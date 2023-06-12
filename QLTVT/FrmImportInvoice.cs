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
    public partial class FrmImportInvoice : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        public string makho = "";
        string maChiNhanh = "";
        public static String MAPN_temp = "";
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
        public FrmImportInvoice()
        {
            InitializeComponent();
        }

        private void phieuNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuNhap.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FrmImportInvoice_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.chiTietPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietPhieuNhapTableAdapter.Fill(this.dataSet.CTPN);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

            cmbBranch.DataSource = Program.bindingSource;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.SelectedIndex = Program.brand;
        }

        private void groupBoxDonDatHang_Enter(object sender, EventArgs e)
        {

        }

        private void mAVTTextEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void dteNgay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged_1(object sender, EventArgs e)
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
                this.chiTietPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietPhieuNhapTableAdapter.Fill(this.dataSet.CTPN);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
            }
        }

        private void btnImportInvoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMENU.Links[0].Caption = "Import Invoice";

            bds = bdsPhieuNhap;
            gc = gcPhieuNhap;

            txtIImvoiceID.Enabled = false;
            dteDay.Enabled = false;

            txtMaDonDatHang.Enabled = false;
            btnEnterOrder.Enabled = false;

            txtStaffID.Enabled = false;
            txtMaterialID.Enabled = false;

            btnEnterOrderDetail.Enabled = false;

            txtMaterialIDInvoice.Enabled = false;
            txtQuantity.Enabled = false;
            txtDonGiaChiTietPhieuNhap.Enabled = false;

            gcPhieuNhap.Enabled = true;
            gcChiTietPhieuNhap.Enabled = true;

            if (Program.role == "CONGTY")
            {
       
                cmbBranch.Enabled = true;

                this.btnAdd.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;

                this.groupBoxPhieuNhap.Enabled = false;


            }

            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbBranch.Enabled = false;

                this.btnAdd.Enabled = true;
                bool turnOn = (bdsPhieuNhap.Count > 0) ? true : false;
                this.btnDelete.Enabled = turnOn;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;
            }
        }

        private void btnImportInvoiceDetail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMENU.Links[0].Caption = "Import Invoice Detail";

            bds = bdsChiTietPhieuNhap;
            gc = gcPhieuNhap;

            txtIImvoiceID.Enabled = false;
            dteDay.Enabled = false;

            txtMaDonDatHang.Enabled = false;
            btnEnterOrder.Enabled = false;

            txtStaffID.Enabled = false;
            txtMaterialID.Enabled = false;

            txtMaVatTu.Enabled = false;
            txtQuantity.Enabled = false;
            txtDonGiaChiTietPhieuNhap.Enabled = false;

            btnEnterOrderDetail.Enabled = false;

            gcPhieuNhap.Enabled = true;
            gcChiTietPhieuNhap.Enabled = true;

            if (Program.role == "CONGTY")
            {
                cmbBranch.Enabled = true;

                this.btnAdd.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;
            }

            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbBranch.Enabled = false;

                this.btnAdd.Enabled = true;
                
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;
            }
        }

        private void btnEnterOrder_Click(object sender, EventArgs e)
        {
            FrmSelectOrder form = new FrmSelectOrder();
            form.ShowDialog();

            this.txtMaDonDatHang.Text = Program.maDonDatHangDuocChon;
            this.txtMaterialID.Text = Program.maKhoDuocChon;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bds.Position;
            dangThemMoi = true;
            MAPN_temp = txtIImvoiceID.Text.Trim();

            bds.AddNew();
            if (btnMENU.Links[0].Caption == "Import Invoice")
            { 
                this.txtIImvoiceID.Enabled = true;

                this.dteDay.EditValue = DateTime.Now;
                this.dteDay.Enabled = false;

                this.txtMaDonDatHang.Enabled = false;
                this.btnEnterOrder.Enabled = true;

                this.txtStaffID.Text = Program.userName;
                this.txtMaterialID.Text = Program.maKhoDuocChon;
         
                ((DataRowView)(bdsPhieuNhap.Current))["NGAY"] = DateTime.Now;
                ((DataRowView)(bdsPhieuNhap.Current))["MasoDDH"] = Program.maDonDatHangDuocChon;
                ((DataRowView)(bdsPhieuNhap.Current))["MANV"] = Program.userName;
                ((DataRowView)(bdsPhieuNhap.Current))["MAKHO"] =
                Program.maKhoDuocChon;

            }

            if (btnMENU.Links[0].Caption == "Import Invoice Detail")
            {
                DataRowView drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không thêm chi tiết phiếu nhập trên phiếu không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    bdsChiTietPhieuNhap.RemoveCurrent();
                    return;
                }

                ((DataRowView)(bdsChiTietPhieuNhap.Current))["MAPN"] = ((DataRowView)(bdsPhieuNhap.Current))["MAPN"];
                ((DataRowView)(bdsChiTietPhieuNhap.Current))["MAVT"] =
                    Program.maVatTuDuocChon;
                ((DataRowView)(bdsChiTietPhieuNhap.Current))["SOLUONG"] =
                    Program.soLuongVatTu;
                ((DataRowView)(bdsChiTietPhieuNhap.Current))["DONGIA"] =
                    Program.donGia;

                this.txtMaVatTu.Enabled = false;
                this.btnEnterOrderDetail.Enabled = true;

                this.txtSoLuong.Enabled = true;
                this.txtSoLuong.EditValue = 1;

                this.txtDonGia.Enabled = true;
                this.txtDonGia.EditValue = 1;

                this.txtQuantity.Enabled = true;
                this.txtDonGiaChiTietPhieuNhap.Enabled = true;
            }

            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;

            this.btnUndo.Enabled = true;
            this.btnRefresh.Enabled = false;
            this.btnMENU.Enabled = false;
            this.btnExit.Enabled = false;

            gcPhieuNhap.Enabled = false;
            gcChiTietPhieuNhap.Enabled = false;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
                this.chiTietPhieuNhapTableAdapter.Fill(this.dataSet.CTPN);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi làm mời dữ liệu\n\n" + ex.Message,"Thông Báo",MessageBoxButtons.OK);
                Console.WriteLine(ex.Message);
                return;
            }
        }

        private void btnEnterOrderDetail_Click(object sender, EventArgs e)
        {
            Program.maDonDatHangDuocChon = ((DataRowView)(bdsPhieuNhap.Current))["MasoDDH"].ToString().Trim();

            FrmSelectOrderDetail form = new FrmSelectOrderDetail();
            form.ShowDialog();

            

            this.txtMaterialIDInvoice.Text = Program.maVatTuDuocChon;
            this.txtQuantity.Value = Program.soLuongVatTu;
            this.txtDonGiaChiTietPhieuNhap.Value = Program.donGia;
        }
        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnAdd.Enabled == false)
            {
                dangThemMoi = false;

                if (btnMENU.Links[0].Caption == "Import Invoice")
                {
                    this.txtMaDonDatHang.Enabled = false;
                    dteDay.Enabled = false;

                    txtMaDonDatHang.Enabled = false;
                    txtMaterialID.Enabled = false;

                    btnEnterOrder.Enabled = false;
                    txtMaDonDatHang.Enabled = false;
                }

                if (btnMENU.Links[0].Caption == "Import Invoice Detail")
                {
                    this.txtMaDonDatHang.Enabled = false;
                    this.btnEnterOrderDetail.Enabled = false;

                    this.txtMaterialIDInvoice.Enabled = false;
                    this.txtQuantity.Enabled = false;
                    this.txtDonGiaChiTietPhieuNhap.Enabled = false;

                    this.btnDelete.Enabled = false;
                }

                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSave.Enabled = true;

                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;

                this.gcPhieuNhap.Enabled = true;
                this.gcChiTietPhieuNhap.Enabled = true;

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

            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
            this.chiTietPhieuNhapTableAdapter.Fill(this.dataSet.CTPN);

            bdsPhieuNhap.Position = viTri;
        }



        private void capNhatSoLuongVatTu(string maVatTu, int soLuong)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu 'IMPORT','" + maVatTu + "', " + soLuong;


            int n = Program.ExecSqlNonQuery(cauTruyVan);
            Console.WriteLine(cauTruyVan);
        }
        private String taoCauTruyVanHoanTac(String cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;

            if(cheDo == "Import Invoice" && dangThemMoi == false)
            {
            }

            if(cheDo == "Import Invoice" && dangThemMoi == true)
            {
            }

            if (cheDo == "Import Invoice Detail" && dangThemMoi == true)
            {
            }

            if (cheDo == "Import Invoice Detail" && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsChiTietPhieuNhap.Current));
                int soLuong = int.Parse(drv["SOLUONG"].ToString().Trim());
                float donGia = float.Parse(drv["DONGIA"].ToString().Trim());
                String maPhieuNhap = drv["MAPN"].ToString().Trim();
                String maVatTu = drv["MAVT"].ToString().Trim();

                cauTruyVan = "UPDATE DBO.CTPN " +
                    "SET " +
                    "SOLUONG = " + soLuong + ", " +
                    "DONGIA = " + donGia + " " +
                    "WHERE MAPN = '"+ maPhieuNhap + "' " +
                    "AND MAVT = '" + maVatTu + "' ";
            }

            return cauTruyVan;
        }
        private bool kiemTraDuLieuDauVao(String cheDo)
        {
            if( cheDo == "Import Invoice")
            {
                if( txtIImvoiceID.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !","Thông báo",MessageBoxButtons.OK);
                    txtIImvoiceID.Focus();
                    return false;
                }


                if (txtStaffID.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã nhân viên !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtMaterialID.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtMaDonDatHang.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã đơn đặt hàng !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }
            }

            if (cheDo == "Import Invoice Detail")
            {

                if (txtMaterialIDInvoice.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã vật tư !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtQuantity.Value < 0 || 
                    txtQuantity.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Số lượng vật tư không thể lớn hơn số lượng vật tư trong chi tiết đơn hàng !", "Thông báo", MessageBoxButtons.OK);
                    txtQuantity.Focus();
                    return false;
                }

                if (txtDonGiaChiTietPhieuNhap.Value < 1 )
                {
                    MessageBox.Show("Đơn giá không thể nhỏ hơn 1 VND", "Thông báo", MessageBoxButtons.OK);
                    txtDonGiaChiTietPhieuNhap.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnGHI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cheDo = (btnMENU.Links[0].Caption == "Import Invoice") ? "Import Invoice" : "Import Invoice Detail";

            bool ketQua = kiemTraDuLieuDauVao(cheDo);
            if (ketQua == false) return;

            string cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);

            String maPhieuNhap = txtIImvoiceID.Text.Trim();
            
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaPhieuNhap '" +
                    maPhieuNhap + "' " +
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

            int viTriConTro = bdsPhieuNhap.Position;
            int viTriMaPhieuNhap = bdsPhieuNhap.Find("MAPN", maPhieuNhap);

            if( result == 1 && cheDo == "Import Invoice" && viTriMaPhieuNhap != viTriConTro)
            {
                MessageBox.Show("Mã phiếu nhập đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtIImvoiceID.Focus();
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
                        if (cheDo == "Import Invoice" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.PHIEUNHAP " +
                                "WHERE MAPN = '" + maPhieuNhap + "'";
                        }

                        if (cheDo == "Import Invoice Detail" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.CTPN " +
                                "WHERE MAPN = '" + maPhieuNhap + "' " +
                                "AND MAVT = '" + Program.maVatTuDuocChon + "'";

                            string maVatTu = txtMaterialIDInvoice.Text.Trim();
                            int soLuong = (int)txtQuantity.Value;
                     
                            capNhatSoLuongVatTu(maVatTu, soLuong);
                        }

                        undoList.Push(cauTruyVanHoanTac);
                        Console.WriteLine("cau truy van hoan tac");
                        Console.WriteLine(cauTruyVanHoanTac);

                        this.bdsPhieuNhap.EndEdit();
                        this.bdsChiTietPhieuNhap.EndEdit();
                        this.phieuNhapTableAdapter.Update(this.dataSet.PhieuNhap);
                        this.chiTietPhieuNhapTableAdapter.Update(this.dataSet.CTPN);

                        this.btnAdd.Enabled = true;
                        this.btnDelete.Enabled = true;
                        this.btnSave.Enabled = true;

                        this.btnUndo.Enabled = true;
                        this.btnRefresh.Enabled = true;
                        this.btnMENU.Enabled = true;
                        this.btnExit.Enabled = true;

                        this.gcPhieuNhap.Enabled = true;
                        this.gcChiTietPhieuNhap.Enabled = true;

                        this.txtQuantity.Enabled = false;
                        this.txtDonGiaChiTietPhieuNhap.Enabled = false;
                        
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
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

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            string cauTruyVanHoanTac = "";
            string cheDo = (btnMENU.Links[0].Caption == "Import Invoice") ? "Import Invoice" : "Import Invoice Detail";
            


            if (cheDo == "Import Invoice")
            {
                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Không xóa chi tiết phiếu xuất không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsChiTietPhieuNhap.Count > 0)
                {
                    MessageBox.Show("Không thể xóa phiếu nhập vì có chi tiết phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                DateTime ngay = ((DateTime)drv["NGAY"]);

                cauTruyVanHoanTac = "INSERT INTO DBO.PHIEUNHAP(MAPN, NGAY, MasoDDH, MANV, MAKHO) " +
                    "VALUES( '" + drv["MAPN"].ToString().Trim() + "', '"+
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["MasoDDH"].ToString() + "', '" +
                    drv["MANV"].ToString() + "', '" +
                    drv["MAKHO"].ToString() + "')";
                    
            }

            if(cheDo == "Import Invoice Detail")
            {
                drv = ((DataRowView)bdsPhieuNhap[bdsPhieuNhap.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa chi tiết phiếu nhập không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                drv = ((DataRowView)bdsChiTietPhieuNhap[bdsChiTietPhieuNhap.Position]);
                cauTruyVanHoanTac = "INSERT INTO DBO.CTPN(MAPN, MAVT, SOLUONG, DONGIA) " +
                    "VALUES('" + drv["MAPN"].ToString().Trim() + "', '" +
                    drv["MAVT"].ToString().Trim() + "', " +
                    drv["SOLUONG"].ToString().Trim() + ", " +
                    drv["DONGIA"].ToString().Trim() + ")";
            }

            undoList.Push(cauTruyVanHoanTac);
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bds.Position;
                    if (cheDo == "Import Invoice")
                    {
                        bdsPhieuNhap.RemoveCurrent();
                    }
                    if (cheDo == "Import Invoice Detail")
                    {
                        bdsChiTietPhieuNhap.RemoveCurrent();
                    }


                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.dataSet.PhieuNhap);

                    this.chiTietPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietPhieuNhapTableAdapter.Update(this.dataSet.CTPN);

                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuNhapTableAdapter.Update(this.dataSet.PhieuNhap);

                    this.chiTietPhieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietPhieuNhapTableAdapter.Update(this.dataSet.CTPN);
                    bds.Position = viTri;
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void labelDay_Click(object sender, EventArgs e)
        {

        }

        private void dONGIALabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
