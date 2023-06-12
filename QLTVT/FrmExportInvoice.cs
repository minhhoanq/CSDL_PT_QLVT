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
    public partial class FrmExportInvoice : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        public string makho = "";
        string maChiNhanh = "";
        Stack undoList = new Stack();
        BindingSource bds = null;
        GridControl gc = null;
        string type = "";
        public FrmExportInvoice()
        {
            InitializeComponent();
        }

        private void phieuXuatBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsPhieuXuat.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void FrmExportInvoice_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);

            this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.chiTietPhieuXuatTableAdapter.Fill(this.dataSet.CTPX);

            cmbBranch.DataSource = Program.bindingSource;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.SelectedIndex = Program.brand;
        }

        private void btnTHOAT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void btnExportInvoiceOption_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMENU.Links[0].Caption = "Export Invoice";

            bds = bdsPhieuXuat;
            gc = gcChiTietPhieuXuat;

            txtEInvoiceID.Enabled = false;
            dteDay.Enabled = false;

            txtCustomerName.Enabled = true;
            txtStaffID.Enabled = false;

            btnEnterWareHouse.Enabled = true;
            txtMaterialID.Enabled = false;

            txtMaterialIDEIDetail.Enabled = false;
            btnEnterMaterial.Enabled = false;
            txtQuantityEIDetail.Enabled = false;
            txtUnitPriceEIDetail.Enabled = false;

            gcPhieuXuat.Enabled = true;
            gcChiTietPhieuXuat.Enabled = true;

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
                bool turnOn = (bdsPhieuXuat.Count > 0) ? true : false;
                this.btnDelete.Enabled = turnOn;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;

            }
        }

        private void btnEInvoiceDetailOption_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnMENU.Links[0].Caption = "Export Invoice Detail";

            bds = bdsChiTietPhieuXuat;

            txtEInvoiceID.Enabled = false;
            dteDay.Enabled = false;

            txtCustomerName.Enabled = false;
            txtStaffID.Enabled = false;

            btnEnterWareHouse.Enabled = false;
            txtMaterialID.Enabled = false;

            txtMaterialIDEIDetail.Enabled = false;
            txtQuantityEIDetail.Enabled = false;
            txtUnitPriceEIDetail.Enabled = false;

            gcPhieuXuat.Enabled = true;
            gcChiTietPhieuXuat.Enabled = true;

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
                bool turnOn = (bdsPhieuXuat.Count > 0) ? true : false;
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;
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
                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);

                this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.chiTietPhieuXuatTableAdapter.Fill(this.dataSet.CTPX);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {            
            viTri = bds.Position;
            dangThemMoi = true;

            bds.AddNew();
            if (btnMENU.Links[0].Caption == "Export Invoice")
            {
                this.txtEInvoiceID.Enabled = true;

                this.dteDay.EditValue = DateTime.Now;
                this.dteDay.Enabled = false;

                this.txtCustomerName.Enabled = true;
                this.txtStaffID.Text = Program.userName;

                this.btnEnterWareHouse.Enabled = true;
                this.txtMaterialID.Text = Program.maKhoDuocChon;

                this.txtMaterialIDEIDetail.Enabled = false;
                this.btnEnterMaterial.Enabled = false;
                this.txtQuantityEIDetail.Enabled = false;
                this.txtUnitPriceEIDetail.Enabled = false;
                
                ((DataRowView)(bdsPhieuXuat.Current))["NGAY"] = DateTime.Now;
                ((DataRowView)(bdsPhieuXuat.Current))["MANV"] = Program.userName;
                ((DataRowView)(bdsPhieuXuat.Current))["MAKHO"] =
                Program.maKhoDuocChon;

            }

            if (btnMENU.Links[0].Caption == "Export Invoice Detail")
            {

                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Không thể thêm Export Invoice Detail trên phiếu  không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

               ((DataRowView)(bdsChiTietPhieuXuat.Current))["MAPX"] = ((DataRowView)(bdsPhieuXuat.Current))["MAPX"];
                ((DataRowView)(bdsChiTietPhieuXuat.Current))["MAVT"] =
                    Program.maVatTuDuocChon;




                this.txtMaterialIDEIDetail.Enabled = false;
                this.btnEnterMaterial.Enabled = true;

                this.txtQuantityEIDetail.Enabled = true;
                this.txtQuantityEIDetail.EditValue = 1;

                this.txtUnitPriceEIDetail.Enabled = true;
                this.txtUnitPriceEIDetail.EditValue = 1;
            }

            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;

            this.btnUndo.Enabled = true;
            this.btnRefresh.Enabled = false;
            this.btnMENU.Enabled = false;
            this.btnExit.Enabled = false;

            gcPhieuXuat.Enabled = false;
            gcChiTietPhieuXuat.Enabled = false;
        }

        private void btnEnterWareHouse_Click(object sender, EventArgs e)
        {
            SubForm.FrmSelectWareHouse form = new SubForm.FrmSelectWareHouse();
            form.ShowDialog();

            this.txtMaterialID.Text = Program.maKhoDuocChon;
        }

        private void btnEnterMaterial_Click(object sender, EventArgs e)
        {
            FrmSelectMaterial form = new FrmSelectMaterial();
            form.ShowDialog();
            this.txtMaterialIDEIDetail.Text = Program.maVatTuDuocChon;
        }


        private bool kiemTraDuLieuDauVao(string cheDo)
        {
            if (cheDo == "Export Invoice")
            {
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Không thể sửa phiếu xuất do người khác tạo", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

                if (txtEInvoiceID.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    txtEInvoiceID.Focus();
                    return false;
                }

                if (txtEInvoiceID.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtEInvoiceID.Focus();
                    return false;
                }

                if (txtCustomerName.Text == "")
                {
                    MessageBox.Show("Không bỏ trống tên khách hàng !", "Thông báo", MessageBoxButtons.OK);
                    txtCustomerName.Focus();
                    return false;
                }

                if( txtCustomerName.Text.Length > 100)
                {
                    MessageBox.Show("Tên khách hàng không quá 100 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtCustomerName.Focus();
                    return false;
                }

                if (txtMaterialID.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã kho !", "Thông báo", MessageBoxButtons.OK);
                    return false;
                }

            }

            if(cheDo == "Export Invoice Detail")
            {
                DataRowView drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Không thể thêm Export Invoice Detail với phiếu xuất do người khác tạo !", "Thông báo", MessageBoxButtons.OK);
                    bdsChiTietPhieuXuat.RemoveCurrent();
                    return false;
                }

                if (txtEInvoiceID.Text == "")
                {
                    MessageBox.Show("Không bỏ trống mã phiếu nhập !", "Thông báo", MessageBoxButtons.OK);
                    txtEInvoiceID.Focus();
                    return false;
                }

                if (txtEInvoiceID.Text.Length > 8)
                {
                    MessageBox.Show("Mã phiếu xuất không thể quá 8 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtEInvoiceID.Focus();
                    return false;
                }

                if (txtMaterialIDEIDetail.Text == "")
                {
                    MessageBox.Show("Thiếu mã vật tư !", "Thông báo", MessageBoxButtons.OK);
                    txtMaterialIDEIDetail.Focus();
                    return false;
                }

                if( txtMaterialIDEIDetail.Text.Length > 4)
                {
                    MessageBox.Show("Mã vật tư không quá 4 kí tự !", "Thông báo", MessageBoxButtons.OK);
                    txtMaterialIDEIDetail.Focus();
                    return false;
                }

                if( txtQuantityEIDetail.Value < 0 || txtQuantityEIDetail.Value > Program.soLuongVatTu)
                {
                    MessageBox.Show("Số lượng vật tư không thể bé hơn 0 & lớn hơn số lượng vật tư đang có trong kho hàng !", "Thông báo", MessageBoxButtons.OK);
                    txtQuantityEIDetail.Focus();
                    return false;
                }

                if (txtUnitPriceEIDetail.Value < 0)
                {
                    MessageBox.Show("Đơn giá không thể bé hơn 0 VND !", "Thông báo", MessageBoxButtons.OK);
                    txtUnitPriceEIDetail.Focus();
                    return false;
                }
            }

            return true;
        }

        private string taoCauTruyVanHoanTac(string cheDo)
        {
            String cauTruyVan = "";
            DataRowView drv;
            
            if (cheDo == "Export Invoice" && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsPhieuXuat.Current));
                DateTime ngay = (DateTime) drv["NGAY"];


                cauTruyVan = "UPDATE DBO.PHIEUXUAT " +
                    "SET " +
                    "NGAY = CAST('" + ngay.ToString("yyyy-MM-dd") + "' AS DATETIME), " +
                    "HOTENKH = '" + drv["HOTENKH"].ToString().Trim() + "', " +
                    "MANV = '" + drv["MANV"].ToString().Trim() + "', " +
                    "MAKHO = '" + drv["MAKHO"].ToString().Trim() + "' " +
                    "WHERE MAPX = '" + drv["MAPX"].ToString().Trim() + "' "; 
            }

            if (cheDo == "Export Invoice" && dangThemMoi == true)
            {
            }

            if (cheDo == "Export Invoice Detail" && dangThemMoi == true)
            {
            }

            if (cheDo == "Export Invoice Detail" && dangThemMoi == false)
            {
                drv = ((DataRowView)(bdsChiTietPhieuXuat.Current));
                int soLuong = int.Parse(drv["SOLUONG"].ToString().Trim());
                float donGia = float.Parse(drv["DONGIA"].ToString().Trim());
                String maPhieuXuat = drv["MAPN"].ToString().Trim();
                String maVatTu = drv["MAVT"].ToString().Trim();

                cauTruyVan = "UPDATE DBO.CTPX " +
                    "SET " +
                    "SOLUONG = " + soLuong + " " +
                    "DOGIA = " + donGia + " " +
                    "WHERE MAPX = '" + maPhieuXuat + "' " +
                    "AND MAVT = '" + maVatTu + "' ";
            }

            return cauTruyVan;
        }




        private void capNhatSoLuongVatTu(string maVatTu, string soLuong)
        {
            string cauTruyVan = "EXEC sp_CapNhatSoLuongVatTu 'EXPORT','" + maVatTu + "', " + soLuong;


            int n = Program.ExecSqlNonQuery(cauTruyVan);
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String cheDo = (btnMENU.Links[0].Caption == "Export Invoice") ? "Export Invoice" : "Export Invoice Detail";

            bool ketQua = kiemTraDuLieuDauVao(cheDo);
            if (ketQua == false) return;

            string cauTruyVanHoanTac = taoCauTruyVanHoanTac(cheDo);

            String maPhieuXuat = txtEInvoiceID.Text.Trim();
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaPhieuXuat '" +
                    maPhieuXuat + "' " +
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

            int viTriConTro = bdsPhieuXuat.Position;
            int viTriMaPhieuXuat = bdsPhieuXuat.Find("MAPX", maPhieuXuat);

            if (result == 1 && cheDo == "Export Invoice" && viTriMaPhieuXuat != viTriConTro)
            {
                MessageBox.Show("Mã phiếu xuất đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                txtEInvoiceID.Focus();
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
                        if (cheDo == "Export Invoice" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.PHIEUXUAT " +
                                "WHERE MAPX = '" + maPhieuXuat + "'";
                        }

                        if (cheDo == "Export Invoice Detail" && dangThemMoi == true)
                        {
                            cauTruyVanHoanTac =
                                "DELETE FROM DBO.CTPN " +
                                "WHERE MAPN = '" + maPhieuXuat + "' " +
                                "AND MAVT = '" + Program.maVatTuDuocChon + "'";

                            string maVatTu = txtMaterialIDEIDetail.Text.Trim();
                            string soLuong = txtQuantityEIDetail.Text.Trim();

                            capNhatSoLuongVatTu(maVatTu, soLuong);
                        }

                        undoList.Push(cauTruyVanHoanTac);
                        Console.WriteLine("cau truy van hoan tac");
                        Console.WriteLine(cauTruyVanHoanTac);

                        this.bdsPhieuXuat.EndEdit();
                        this.bdsChiTietPhieuXuat.EndEdit();
                        this.phieuXuatTableAdapter.Update(this.dataSet.PhieuXuat);
                        this.chiTietPhieuXuatTableAdapter.Update(this.dataSet.CTPX);

                        this.txtEInvoiceID.Enabled = false;

                        this.btnAdd.Enabled = true;
                        this.btnDelete.Enabled = true;
                        this.btnSave.Enabled = true;

                        this.btnUndo.Enabled = true;
                        this.btnRefresh.Enabled = true;
                        this.btnMENU.Enabled = true;
                        this.btnExit.Enabled = true;

                        this.gcPhieuXuat.Enabled = true;
                        this.gcChiTietPhieuXuat.Enabled = true;

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

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (dangThemMoi == true && this.btnAdd.Enabled == false)
            {
                dangThemMoi = false;

                if (btnMENU.Links[0].Caption == "Export Invoice")
                {
                    this.txtEInvoiceID.Enabled = false;
                    this.dteDay.Enabled = false;
                    this.txtCustomerName.Enabled = true;

                    this.txtStaffID.Enabled = false;
                    
                    this.txtMaterialID.Enabled = false;
                    this.btnEnterWareHouse.Enabled = true;
                }

                if (btnMENU.Links[0].Caption == "Chi Tiết Phiếu Nhập")
                {
                    this.txtEInvoiceID.Enabled = false;
                    this.txtMaterialIDEIDetail.Enabled = false;
                    this.btnEnterMaterial.Enabled = false;

                    this.txtQuantityEIDetail.Enabled = true;
                    this.txtUnitPriceEIDetail.Enabled = true;
                }

                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSave.Enabled = true;

                this.btnRefresh.Enabled = true;
                this.btnMENU.Enabled = true;
                this.btnExit.Enabled = true;

                this.gcPhieuXuat.Enabled = true;
                this.gcChiTietPhieuXuat.Enabled = true;

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

            this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);
            this.chiTietPhieuXuatTableAdapter.Fill(this.dataSet.CTPX);

            bdsPhieuXuat.Position = viTri;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);
                this.chiTietPhieuXuatTableAdapter.Fill(this.dataSet.CTPX);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi lam moi \n\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataRowView drv;
            string cauTruyVanHoanTac = "";
            string cheDo = (btnMENU.Links[0].Caption == "Export Invoice") ? "Export Invoice" : "Export Invoice Detail";

            if (cheDo == "Export Invoice")
            {
                drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Không xóa Export Invoice Detail không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }

                if (bdsChiTietPhieuXuat.Count > 0)
                {
                    MessageBox.Show("Không thể xóa vì có Export Invoice Detail", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                DateTime ngay = ((DateTime)drv["NGAY"]);

                cauTruyVanHoanTac = "INSERT INTO DBO.PHIEUXUAT(MAPX, NGAY, HOTENKH, MANV, MAKHO) " +
                    "VALUES( '" + drv["MAPX"].ToString().Trim() + "', '" +
                    ngay.ToString("yyyy-MM-dd") + "', '" +
                    drv["HOTENKH"].ToString() + "', '" +
                    drv["MANV"].ToString() + "', '" +
                    drv["MAKHO"].ToString() + "')";
            }

            if (cheDo == "Export Invoice Detail")
            {
                drv = ((DataRowView)bdsPhieuXuat[bdsPhieuXuat.Position]);
                String maNhanVien = drv["MANV"].ToString();
                if (Program.userName != maNhanVien)
                {
                    MessageBox.Show("Bạn không xóa Export Invoice Detail không phải do mình tạo", "Thông báo", MessageBoxButtons.OK);
                    return;
                }


                drv = ((DataRowView)bdsChiTietPhieuXuat[bdsChiTietPhieuXuat.Position]);
                cauTruyVanHoanTac = "INSERT INTO DBO.CTPX(MAPX, MAVT, SOLUONG, DONGIA) " +
                    "VALUES('" + drv["MAPX"].ToString().Trim() + "', '" +
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
                    if (cheDo == "Export Invoice")
                    {
                        bdsPhieuXuat.RemoveCurrent();
                    }
                    if (cheDo == "Chi Tiết Phiếu Nhập")
                    {
                        bdsChiTietPhieuXuat.RemoveCurrent();
                    }


                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.dataSet.PhieuXuat);

                    this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietPhieuXuatTableAdapter.Update(this.dataSet.CTPX);

                    dangThemMoi = false;
                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.phieuXuatTableAdapter.Update(this.dataSet.PhieuXuat);

                    this.chiTietPhieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.chiTietPhieuXuatTableAdapter.Update(this.dataSet.CTPX);
                    bds.Position = viTri;
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }

        private void dteDay_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mAVTLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
