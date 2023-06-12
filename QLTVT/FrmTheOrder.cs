using DevExpress.XtraGrid;
using QLTVT.SubForm;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{

    public partial class FrmTheOrder : Form
    {
        /* vị trí của con trỏ trên grid view*/
        int viTri = 0;
        public static String MADDH_temp = "";
        /********************************************
         * đang thêm mới -> true -> đang dùng btnTHEM
         *              -> false -> có thể là btnGHI( chỉnh sửa) hoặc btnXOA
         *              
         * Mục đích: dùng biến này để phân biệt giữa btnTHEM - thêm mới hoàn toàn
         * và việc chỉnh sửa nhân viên( do mình ko dùng thêm btnXOA )
         * Trạng thái true or false sẽ được sử dụng 
         * trong btnGHI - việc này để phục vụ cho btnHOANTAC
         ********************************************/
        bool dangThemMoi = false;
        public string makho = "";   
        string maChiNhanh = "";
        /**********************************************************
         * undoList - phục vụ cho btnHOANTAC -  chứa các thông tin của đối tượng bị tác động 
         * 
         * nó là nơi lưu trữ các đối tượng cần thiết để hoàn tác các thao tác
         * 
         * nếu btnGHI sẽ ứng với INSERT
         * nếu btnXOA sẽ ứng với DELETE
         * nếu btnCHUYENCHINHANH sẽ ứng với CHANGEBRAND
         **********************************************************/
        Stack undoList = new Stack();



        /********************************************************
         * chứa những dữ liệu hiện tại đang làm việc
         * gc chứa grid view đang làm việc
         ********************************************************/
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";



        /************************************************************
         * CheckExists:
         * Để tránh việc người dùng ấn vào 1 form đến 2 lần chúng ta 
         * cần sử dụng hàm này để kiểm tra xem cái form hiện tại đã 
         * có trong bộ nhớ chưa
         * Nếu có trả về "f"
         * Nếu không trả về "null"
         ************************************************************/
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FrmTheOrder()
        {
            InitializeComponent();
        }
        private void datHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsDonDatHang.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FrmTheOrder_Load(object sender, EventArgs e)
        {
            
            /*Step 1*/
            dataSet.EnforceConstraints = false;

            this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

            this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatHangTableAdapter.Fill(this.dataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
            /*van con ton tai loi chua sua duoc*/
            //maChiNhanh = ((DataRowView)bdsVatTu[0])["MACN"].ToString();

            /*Step 2*/
            cmbBranch.DataSource = Program.bindingSource;/*sao chep bingding source tu form dang nhap*/
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.SelectedIndex = Program.brand;

            
            bds = bdsDonDatHang;
            gc = gcDonDatHang;
            
        }

        private void sOLUONGSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        /*********************************************************
         * Step 0: Hiện chế độ làm việc
         * Step 1: cập nhật binding source và grid control
         * 
         * tắt các chức năng liên quan tới chi tiết đơn hàng
         *********************************************************/
        private void btnOrderOption_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnMENU.Links[0].Caption = "Order Option";

            /*Step 1*/
            bds = bdsDonDatHang;
            gc = gcDonDatHang;
            //MessageBox.Show("Chế Độ Làm Việc Đơn Đặt Hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Bat chuc nang cua don dat hang*/
            txtTheOrderID.Enabled = false;
            dteDay.Enabled = false;

            txtSupplier.Enabled = true;
            txtStaffID.Enabled = false;

            txtWareHouseID.Enabled = false;
            btnEnterWHouse.Enabled = true;

            /*Tat chuc nang cua chi tiet don hang*/
            txtMaterialID.Enabled = false;
            btnEnterMaterial.Enabled = false;
            txtQuantity.Enabled = false;
            txtUnitPrice.Enabled = false;

            /*Bat cac grid control len*/
            gcDonDatHang.Enabled = true;
            gcChiTietDonDatHang.Enabled = true;


            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {
                cmbBranch.Enabled = true;

                this.btnAdd.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = false;
                this.btnExit.Enabled = true;

                this.groupBoxOrder.Enabled = false;
            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbBranch.Enabled = false;

                this.btnAdd.Enabled = true;
                bool turnOn = (bdsDonDatHang.Count > 0) ? true : false;
                this.btnDelete.Enabled = turnOn;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;

                this.txtTheOrderID.Enabled = false;
            }
        }

        private void btnOrderDetailOption_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 0*/
            btnMENU.Links[0].Caption = "Order Detail Option";

            /*Step 1*/
            bds = bdsChiTietDonDatHang;
            gc = gcChiTietDonDatHang;
            //MessageBox.Show("Chế Độ Làm Việc Chi Tiết Đơn Đặt Hàng", "Thông báo", MessageBoxButtons.OK);

            /*Step 2*/
            /*Tat chuc nang don dat hang*/
            txtTheOrderID.Enabled = false;
            dteDay.Enabled = false;

            txtSupplier.Enabled = false;
            txtStaffID.Enabled = false;

            txtWareHouseID.Enabled = false;
            btnEnterWHouse.Enabled = false;

            /*Bat chuc nang cua chi tiet don hang*/
            txtMaterialID.Enabled = false;
            btnEnterMaterial.Enabled = false;
            txtQuantity.Enabled = true;
            txtUnitPrice.Enabled = true;


            /*Bat cac grid control len*/
            gcDonDatHang.Enabled = true;
            gcChiTietDonDatHang.Enabled = true;

            /*Step 3*/
            /*CONG TY chi xem du lieu*/
            if (Program.role == "CONGTY")
            {
                cmbBranch.Enabled = true;

                this.btnAdd.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = false;
                this.btnExit.Enabled = true;

                this.groupBoxOrder.Enabled = false;


            }

            /* CHI NHANH & USER co the xem - xoa - sua du lieu nhung khong the 
             chuyen sang chi nhanh khac*/
            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbBranch.Enabled = false;

                this.btnAdd.Enabled = true;
                bool turnOn = (bdsChiTietDonDatHang.Count > 0) ? true : false;
                this.btnDelete.Enabled = turnOn;
                this.btnSave.Enabled = false;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;

                this.txtTheOrderID.Enabled = false;

            }
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /*Step 1*/
            /*lấy vị trí hiện tại của con trỏ*/
            viTri = bds.Position;
            dangThemMoi = true;
            MADDH_temp = txtTheOrderID.Text;

            /*Step 2*/
            /*AddNew tự động nhảy xuống cuối thêm 1 dòng mới*/
            bds.AddNew();
            if (btnMENU.Links[0].Caption == "Order Option")
            {
                this.txtTheOrderID.Enabled = true;
                //this.txtMaKho.Text = "";
                this.dteDay.EditValue = DateTime.Now;
                this.dteDay.Enabled = false;
                this.txtSupplier.Enabled = true;
                this.txtStaffID.Text = Program.userName;
                this.btnEnterWHouse.Enabled = true;

                /*Gan tu dong may truong du lieu nay*/
                ((DataRowView)(bdsDonDatHang.Current))["MANV"] = Program.userName;
                ((DataRowView)(bdsDonDatHang.Current))["NGAY"] = DateTime.Now;
            }

            if (btnMENU.Links[0].Caption == "Order Detail Option")
            {
                DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không thêm chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    bdsChiTietDonDatHang.RemoveCurrent();
                    return;
                }

                this.txtMaterialID.Enabled = false;
                this.btnEnterMaterial.Enabled = true;

                this.txtQuantity.Enabled = true;
                this.txtQuantity.EditValue = 1;

                this.txtUnitPrice.Enabled = true;
                this.txtUnitPrice.EditValue = 1;
            }


            /*Step 3*/
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;

            this.btnUndo.Enabled = true;
            this.btnRefresh.Enabled = false;
            this.btnMENU.Enabled = false;
            this.btnExit.Enabled = false;            
        }


        /**************************************************
         * ham nay kiem tra du lieu dau vao
         * true là qua hết
         * false là thiếu một dữ liệu nào đó
         **************************************************/
        private bool kiemTraDuLieuDauVao(String cheDo)
        {
            if (cheDo == "Order Option")
            {
                if( txtTheOrderID.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã đơn hàng","Thông báo",MessageBoxButtons.OK);
                    return false;
                }
                if (txtTheOrderID.Text.Length > 8)
                {
                    MessageBox.Show("Mã đơn đặt hàng không quá 8 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if ( txtStaffID.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if( txtSupplier.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống nhà cung cấp", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if (txtSupplier.Text.Length > 100)
                {
                    MessageBox.Show("Tên nhà cung cấp không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if ( txtWareHouseID.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã kho", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }    
            }

            if (cheDo == "Order Detail Option")
            {
                if( txtMaterialID.Text == "")
                {
                    MessageBox.Show("Không thể bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                if( txtQuantity.Value < 0 || txtUnitPrice.Value < 0)
                {
                    MessageBox.Show("Không thể nhỏ hơn 1", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
                /*
                if( txtSoLuong.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Sô lượng đặt mua lớn hơn số lượng vật tư hiện có", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }*/
            }
            return true;
        }



        /**************************************************
         * tra ve 1 cau truy van de phuc hoi du lieu
         * 
         * ket qua tra ve dua theo che do dang su dung
         **************************************************/
        private String taoCauTruyVanHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;

            /*Dang chinh sua don dat hang*/
            if ( cheDo == "Order Option" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                /*Ngay can duoc xu ly dac biet hon*/
                DateTime ngay = ((DateTime)drv["NGAY"]);

                cauTruyVan = "UPDATE DBO.DATHANG " +
                    "SET " +
                    "NGAY = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "NhaCC = '" + drv["NhaCC"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MasoDDH = '" + drv["MasoDDH"].ToString().Trim() + "'";
            }  
            /*Dang xoa don dat hang*/
            if ( cheDo == "Order Option" && dangThemMoi == true)
            {
                drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                DateTime ngay = ((DateTime)drv["NGAY"]);
                cauTruyVan = "INSERT INTO DBO.DATHANG(MasoDDH, NGAY, NhaCC, MaNV, MaKho) " +
                    "VALUES('" + drv["MasoDDH"] + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["NhaCC"].ToString() + "', '" +
                    drv["MaNV"].ToString() + "', '" +
                    drv["MaKho"].ToString() + "' )";

            }

            /*Dang chinh sua chi tiet don dat hang*/
            if(cheDo == "Order Detail Option" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsChiTietDonDatHang[bdsChiTietDonDatHang.Position]);

                cauTruyVan = "UPDATE DBO.CTDDH " +
                    "SET " +
                    "SOLUONG = " + drv["SOLUONG"].ToString() + " , "+
                    "DONGIA = " + drv["DONGIA"].ToString() + " " +
                    "WHERE MasoDDH = '" + drv["MasoDDH"].ToString().Trim() + "'" + 
                    " AND MAVT = '" + drv["MAVT"].ToString().Trim() +"'";

            }
            return cauTruyVan;
        }

        /**************************************************
         * Step 1: Kiem tra xem day co phai nguoi lap don hang hay không
         * Step 2: lay che do dang lam viec, kiem tra du lieu dau vao. Neu OK thi 
         * tiep tuc tao cau truy van hoan tac neu dangThemMoi = false
         * Step 3: kiem tra xem cai ma don hang nay da ton tai chua ?
         *          Neu co thi ket thuc luon
         *          Neu khong thi cho them moi
         **************************************************/
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDonDatHang.Position;
            /*Step 1*/
            DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
            /*lay maNhanVien & maDonDatHang de phong truong hop them chi tiet don hang thi se co ngay*/
            String maNhanVien = drv["MANV"].ToString();
            String maDonDatHang = drv["MasoDDH"].ToString().Trim();

            if (Program.userName != maNhanVien && dangThemMoi == false)
            {
                MessageBox.Show("Bạn không thể sửa phiếu do người khác lập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            /*Step 2*/
            String cheDo = (btnMENU.Links[0].Caption == "Order Option") ? "Order Option" : "Order Detail Option";

            bool ketQua = kiemTraDuLieuDauVao(cheDo);
            if (ketQua == false) return;

            String cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);
            //Console.WriteLine(cauTruyVanHoanTac);

            /*Step 3*/
            String maDonDatHangMoi = txtTheOrderID.Text;
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaDonDatHang '" +
                    maDonDatHangMoi + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            /*Step 4*/
            //Console.WriteLine(txtMaNhanVien.Text);
            int viTriHienTai = bds.Position;
            int viTriMaDonDatHang = bdsDonDatHang.Find("MasoDDH", txtTheOrderID.Text);
            /******************************************************************
             * truong hop them moi don dat hang moi quan tam xem no ton tai hay
             * chua ?
             ******************************************************************/
            if ( result == 1 && cheDo == "Order Option" && viTriHienTai != viTriMaDonDatHang)
            {
                MessageBox.Show("Mã đơn hàng này đã được sử dụng !\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            /*****************************************************************
             * tat ca cac truong hop khac ko can quan tam !!
             *****************************************************************/
            
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        //Console.WriteLine(txtMaNhanVien.Text);
                        /*TH1: them moi don dat hang*/
                        if (cheDo == "Order Option" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.DATHANG " +
                                "WHERE MasoDDH = '" + maDonDatHang + "'";
                        }

                        /*TH2: them moi chi tiet don hang*/
                        if (cheDo == "Order Detail Option" && dangThemMoi == true)
                        {
                            /*Gan tu dong may truong du lieu nay*/
                            ((DataRowView)(bdsChiTietDonDatHang.Current))["MasoDDH"] = ((DataRowView)(bdsDonDatHang.Current))["MasoDDH"];
                            ((DataRowView)(bdsChiTietDonDatHang.Current))["MAVT"] = Program.maVatTuDuocChon;
                            ((DataRowView)(bdsChiTietDonDatHang.Current))["SOLUONG"] =
                                txtQuantity.Value;
                            ((DataRowView)(bdsChiTietDonDatHang.Current))["DONGIA"] =
                                (int)txtUnitPrice.Value;

                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.CTDDH " +
                                "WHERE MasoDDH = '" + maDonDatHang + "' " +
                                "AND MAVT = '" + txtMaterialID.Text.Trim() + "'";
                        }

                        /*TH3: chinh sua don hang */
                        /*TH4: chinh sua chi tiet don hang - > thi chi can may dong lenh duoi la xong*/
                        undoList.Push(cauTruyVanHoanTac);
                        //Console.WriteLine("cau truy van hoan tac");
                        //Console.WriteLine(cauTruyVanHoanTac);
                        
                        this.bdsDonDatHang.EndEdit();
                        this.bdsChiTietDonDatHang.EndEdit();
                        this.donDatHangTableAdapter.Update(this.dataSet.DatHang);
                        this.chiTietDonDatHangTableAdapter.Update(this.dataSet.CTDDH);

                        this.btnAdd.Enabled = true;
                        this.btnDelete.Enabled = true;
                        this.btnSave.Enabled = true;

                        this.btnUndo.Enabled = true;
                        this.btnRefresh.Enabled = true;
                        this.btnMENU.Enabled = true;
                        this.btnExit.Enabled = true;

                        //this.groupBoxDonDatHang.Enabled = false;

                        /*cập nhật lại trạng thái thêm mới cho chắc*/
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bds.RemoveCurrent();
                        MessageBox.Show("Da xay ra loi !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }    
            
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        /**********************************************************************
         * moi lan nhan btnHOANTAC thi nen nhan them btnLAMMOI de 
         * tranh bi loi khi an btnTHEM lan nua
         * 
         * statement: chua cau y nghia chuc nang ngay truoc khi an btnHOANTAC.
         * Vi du: statement = INSERT | DELETE | CHANGEBRAND
         * 
         * bdsNhanVien.CancelEdit() - phuc hoi lai du lieu neu chua an btnGHI
         * Step 0: trường hợp đã ấn btnTHEM nhưng chưa ấn btnGHI
         * Step 1: kiểm tra undoList có trông hay không ?
         * Step 2: Neu undoList khong trống thì lấy ra khôi phục
         *********************************************************************/
        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnAdd.Enabled == false)
            {
                dangThemMoi = false;

                /*dang o che do Don Dat Hang*/
                if (btnMENU.Links[0].Caption == "Order Option")
                {
                    this.txtTheOrderID.Enabled = false;

                    //this.dteNGAY.EditValue = DateTime.Now;
                    this.dteDay.Enabled = false;
                    this.txtSupplier.Enabled = true;
                    //this.txtMaNhanVien.Text = Program.userName;
                    this.btnEnterWHouse.Enabled = true;
                }
                /*dang o che do Chi Tiet Don Dat Hang*/
                if (btnMENU.Links[0].Caption == "Order Detail Option")
                {
                    this.txtMaterialID.Enabled = false;
                    this.btnEnterMaterial.Enabled = true;

                    this.txtQuantity.Enabled = true;
                    this.txtQuantity.EditValue = 1;

                    this.txtUnitPrice.Enabled = true;
                    this.txtUnitPrice.EditValue = 1;
                }

                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSave.Enabled = true;

                //this.btnHOANTAC.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;


                bds.CancelEdit();
                /*xoa dong hien tai*/
                bds.RemoveCurrent();
                /* trở về lúc đầu con trỏ đang đứng*/
                bds.Position = viTri;
                return;
            }

            /*Step 1*/
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                return;
            }

            /*Step 2*/
            bds.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

            this.donDatHangTableAdapter.Fill(this.dataSet.DatHang);
            this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

            bdsDonDatHang.Position = viTri;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                // do du lieu moi tu dataSet vao gridControl NHANVIEN
                this.donDatHangTableAdapter.Fill(this.dataSet.DatHang);
                this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

                this.gcDonDatHang.Enabled = true;
                this.gcChiTietDonDatHang.Enabled = true;

                bdsDonDatHang.Position = viTri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        /***************************************************************
         * ShowDialog is useful when you want to present info to a user, or let him change it, or get info from him before you do anything else.
         * 
         * Show is useful when you want to show information to the user but it is not important that you wait fro him to be finished.
         ***************************************************************/
        private void btnEnterWHouse_Click(object sender, EventArgs e)
        {
            SubForm.FrmSelectWareHouse form = new SubForm.FrmSelectWareHouse();
            form.ShowDialog(); 
                
            this.txtWareHouseID.Text = Program.maKhoDuocChon;
        }

        private void btnEnterMaterial_Click(object sender, EventArgs e)
        {
            FrmSelectMaterial form = new FrmSelectMaterial();
            form.ShowDialog();
            this.txtMaterialID.Text = Program.maVatTuDuocChon;
        }



        /**
         * Step 1: lấy chế độ đang sử dụng và đặt dangThemMoi = true để phục vụ điều kiện tạo câu truy
         * vấn hoàn tác
         * Step 2: kiểm tra điều kiện theo chế độ đang sử dụng
         * Step 3: nạp câu truy vấn hoàn tác vào undolist
         * Step 4: Thực hiện xóa nếu OK
         */
        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cauTruyVan = "";
            string cheDo = (btnMENU.Links[0].Caption == "Order Option") ? "Order Option" : "Order Detail Option";

            dangThemMoi = true;// bat cai nay len de ung voi dieu kien tao cau truy van

            if (cheDo == "Order Option")
            {
                /*Cái bdsChiTietDonHangHang là đại diện cho binding source riêng biệt của CTDDH
                 *Còn cTDDHBindingSource là lấy ngay từ trong data source DATHANG
                 */
                if(bdsChiTietDonDatHang.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có chi tiết đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa đơn đặt hàng này vì có phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                
            }
            if( cheDo == "Order Detail Option")
            {
                DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa chi tiết đơn hàng trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    //bdsChiTietDonDatHang.RemoveCurrent();
                    return;
                }
            }

            cauTruyVan = taoCauTruyVanHoanTac(cheDo);
            //Console.WriteLine("Line 753");
            //Console.WriteLine(cauTruyVan);
            undoList.Push(cauTruyVan);

            /*Step 2*/
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    /*Step 3*/
                    viTri = bds.Position;
                    if(cheDo == "Order Option" )
                    {
                        bdsDonDatHang.RemoveCurrent();
                    }
                    if(cheDo == "Order Detail Option")
                    {
                        bdsChiTietDonDatHang.RemoveCurrent();
                    }
                    

                    this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.donDatHangTableAdapter.Update(this.dataSet.DatHang);

                    this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietDonDatHangTableAdapter.Update(this.dataSet.CTDDH);

                    /*Cap nhat lai do ben tren can tao cau truy van nen da dat dangThemMoi = true*/
                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    /*Step 4*/
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.donDatHangTableAdapter.Update(this.dataSet.DatHang);

                    this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietDonDatHangTableAdapter.Update(this.dataSet.CTDDH);
                    // tro ve vi tri cua nhan vien dang bi loi
                    bds.Position = viTri;
                    //bdsNhanVien.Position = bdsNhanVien.Find("MANV", manv);
                    return;
                }
            }
            else
            {
                // xoa cau truy van hoan tac di
                undoList.Pop();
            }
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            /*Neu combobox khong co so lieu thi ket thuc luon*/
            if (cmbBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbBranch.SelectedValue.ToString();

            /*Neu chon sang chi nhanh khac voi chi nhanh hien tai*/
            if (cmbBranch.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            /*Neu chon trung voi chi nhanh dang dang nhap o formDangNhap*/
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

                this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.donDatHangTableAdapter.Fill(this.dataSet.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
            }
        }
    }
}
