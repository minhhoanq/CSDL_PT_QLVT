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
        int viTri = 0;
        public static String MADDH_temp = "";
        bool dangThemMoi = false;
        public string makho = "";   
        string maChiNhanh = "";
        Stack undoList = new Stack();
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";

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
            dataSet.EnforceConstraints = false;

            this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietDonDatHangTableAdapter.Fill(this.dataSet.CTDDH);

            this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.donDatHangTableAdapter.Fill(this.dataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
            cmbBranch.DataSource = Program.bindingSource;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.SelectedIndex = Program.brand;

            
            bds = bdsDonDatHang;
            gc = gcDonDatHang;
            
        }

        private void sOLUONGSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }
        private void btnOrderOption_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMENU.Links[0].Caption = "Order Option";

            bds = bdsDonDatHang;
            gc = gcDonDatHang;
            txtTheOrderID.Enabled = false;
            dteDay.Enabled = false;

            txtSupplier.Enabled = true;
            txtStaffID.Enabled = false;

            txtWareHouseID.Enabled = false;
            btnEnterWHouse.Enabled = true;

            txtMaterialID.Enabled = false;
            btnEnterMaterial.Enabled = false;
            txtQuantity.Enabled = false;
            txtUnitPrice.Enabled = false;

            gcDonDatHang.Enabled = true;
            gcChiTietDonDatHang.Enabled = true;

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
            btnMENU.Links[0].Caption = "Order Detail Option";

            bds = bdsChiTietDonDatHang;
            gc = gcChiTietDonDatHang;

            txtTheOrderID.Enabled = false;
            dteDay.Enabled = false;

            txtSupplier.Enabled = false;
            txtStaffID.Enabled = false;

            txtWareHouseID.Enabled = false;
            btnEnterWHouse.Enabled = false;

            txtMaterialID.Enabled = false;
            btnEnterMaterial.Enabled = false;
            txtQuantity.Enabled = true;
            txtUnitPrice.Enabled = true;

            gcDonDatHang.Enabled = true;
            gcChiTietDonDatHang.Enabled = true;

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
            viTri = bds.Position;
            dangThemMoi = true;
            MADDH_temp = txtTheOrderID.Text;

            bds.AddNew();
            if (btnMENU.Links[0].Caption == "Order Option")
            {
                this.txtTheOrderID.Enabled = true;
                this.dteDay.EditValue = DateTime.Now;
                this.dteDay.Enabled = false;
                this.txtSupplier.Enabled = true;
                this.txtStaffID.Text = Program.userName;
                this.btnEnterWHouse.Enabled = true;

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

            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;

            this.btnUndo.Enabled = true;
            this.btnRefresh.Enabled = false;
            this.btnMENU.Enabled = false;
            this.btnExit.Enabled = false;            
        }

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
            }
            return true;
        }

        private String taoCauTruyVanHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;

            if ( cheDo == "Order Option" && dangThemMoi == false)
            {
                drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
                DateTime ngay = ((DateTime)drv["NGAY"]);

                cauTruyVan = "UPDATE DBO.DATHANG " +
                    "SET " +
                    "NGAY = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "NhaCC = '" + drv["NhaCC"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MasoDDH = '" + drv["MasoDDH"].ToString().Trim() + "'";
            }
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

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsDonDatHang.Position;
            DataRowView drv = ((DataRowView)bdsDonDatHang[bdsDonDatHang.Position]);
            String maNhanVien = drv["MANV"].ToString();
            String maDonDatHang = drv["MasoDDH"].ToString().Trim();

            if (Program.userName != maNhanVien && dangThemMoi == false)
            {
                MessageBox.Show("Bạn không thể sửa phiếu do người khác lập", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            String cheDo = (btnMENU.Links[0].Caption == "Order Option") ? "Order Option" : "Order Detail Option";

            bool ketQua = kiemTraDuLieuDauVao(cheDo);
            if (ketQua == false) return;

            String cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);

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
            int viTriHienTai = bds.Position;
            int viTriMaDonDatHang = bdsDonDatHang.Find("MasoDDH", txtTheOrderID.Text);
            if ( result == 1 && cheDo == "Order Option" && viTriHienTai != viTriMaDonDatHang)
            {
                MessageBox.Show("Mã đơn hàng này đã được sử dụng !\n\n", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                         MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        if (cheDo == "Order Option" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.DATHANG " +
                                "WHERE MasoDDH = '" + maDonDatHang + "'";
                        }
                        if (cheDo == "Order Detail Option" && dangThemMoi == true)
                        {
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

                        undoList.Push(cauTruyVanHoanTac);
                        
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

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnAdd.Enabled == false)
            {
                dangThemMoi = false;
                if (btnMENU.Links[0].Caption == "Order Option")
                {
                    this.txtTheOrderID.Enabled = false;
                    this.dteDay.Enabled = false;
                    this.txtSupplier.Enabled = true;
                    this.btnEnterWHouse.Enabled = true;
                }

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

                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;


                bds.CancelEdit();
                bds.RemoveCurrent();
                bds.Position = viTri;
                return;
            }
            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                return;
            }

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

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string cauTruyVan = "";
            string cheDo = (btnMENU.Links[0].Caption == "Order Option") ? "Order Option" : "Order Detail Option";

            dangThemMoi = true;

            if (cheDo == "Order Option")
            {
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
                    return;
                }
            }

            cauTruyVan = taoCauTruyVanHoanTac(cheDo);
            undoList.Push(cauTruyVan);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
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

                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.donDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.donDatHangTableAdapter.Update(this.dataSet.DatHang);

                    this.chiTietDonDatHangTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietDonDatHangTableAdapter.Update(this.dataSet.CTDDH);
                    bds.Position = viTri;
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbBranch.SelectedValue.ToString();
            if (cmbBranch.SelectedIndex != Program.brand)
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
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
