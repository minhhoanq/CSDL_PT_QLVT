using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FrmMaterial : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        String maChiNhanh = "";
        Stack undoList = new Stack();

        public FrmMaterial()
        {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Dispose();
        }

        private void vattuBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
        

        }

        private void FrmMaterial_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.ctddhTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctddhTableAdapter.Fill(this.dataSet.CTDDH);

            this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpnTableAdapter.Fill(this.dataSet.CTPN);

            this.ctpxTableAdapter.Connection.ConnectionString = Program.connstr;
            this.ctpxTableAdapter.Fill(this.dataSet.CTPX);

            this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
            this.vattuTableAdapter.Fill(this.dataSet.Vattu);

            cmbBranch.DataSource = Program.bindingSource;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.SelectedIndex = Program.brand;

            if (Program.role == "CONGTY")
            {
                cmbBranch.Enabled = true;

                this.btnAdd.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnExit.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }

            if (Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbBranch.Enabled = false;

                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnExit.Enabled = true;

                this.panelNhapLieu.Enabled = true;
                this.txtMaterialID.Enabled = false;
            }
        }

        private void vattuBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsVatTu.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

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
                this.ctddhTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctddhTableAdapter.Fill(this.dataSet.CTDDH);

                this.ctpnTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctpnTableAdapter.Fill(this.dataSet.CTPN);

                this.ctpxTableAdapter.Connection.ConnectionString = Program.connstr;
                this.ctpxTableAdapter.Fill(this.dataSet.CTPX);

                this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                this.vattuTableAdapter.Fill(this.dataSet.Vattu);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsVatTu.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;

            bdsVatTu.AddNew();
            txtRemainQuantity.Value = 1;

            this.txtMaterialID.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;

            this.btnUndo.Enabled = true;
            this.btnRefresh.Enabled = false;
            this.btnExit.Enabled = false;


            this.gcVATTU.Enabled = false;
            this.panelNhapLieu.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /* Step 0 */
            if (dangThemMoi == true && this.btnAdd.Enabled == false)
            {
                dangThemMoi = false;

                this.txtMaterialID.Enabled = false;
                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnExit.Enabled = true;


                this.gcVATTU.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsVatTu.CancelEdit();
                bdsVatTu.RemoveCurrent();
                bdsVatTu.Position = viTri;
                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                return;
            }

            bdsVatTu.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            this.vattuTableAdapter.Fill(this.dataSet.Vattu);
        }

        private void panelNhapLieu_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool kiemTraDuLieuDauVao()
        {
            if (txtMaterialID.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã vật tư", "Thông báo", MessageBoxButtons.OK);
                txtMaterialID.Focus();
                return false;
            }

            if (Regex.IsMatch(txtMaterialID.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã vật tư chỉ có chữ cái và số", "Thông báo", MessageBoxButtons.OK);
                txtMaterialID.Focus();
                return false;
            }

            if (txtMaterialID.Text.Length > 4)
            {
                MessageBox.Show("Mã vật tư không quá 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaterialID.Focus();
                return false;
            }
            if (txtMaterialName.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên vật tư", "Thông báo", MessageBoxButtons.OK);
                txtMaterialName.Focus();
                return false;
            }
            
            if (Regex.IsMatch(txtMaterialName.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Tên vật tư chỉ chấp nhận chữ, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtMaterialName.Focus();
                return false;
            }
            
            if (txtMaterialName.Text.Length > 30)
            {
                MessageBox.Show("Tên vật tư không quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtMaterialName.Focus();
                return false;
            }
            if (txtUnit.Text == "")
            {
                MessageBox.Show("Không bỏ trống đơn vị tính", "Thông báo", MessageBoxButtons.OK);
                txtUnit.Focus();
                return false;
            }

            if (Regex.IsMatch(txtUnit.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Đơn vị vật tư chỉ có chữ cái", "Thông báo", MessageBoxButtons.OK);
                txtUnit.Focus();
                return false;
            }

            if (txtUnit.Text.Length > 15)
            {
                MessageBox.Show("Đơn vị vật tự không quá 15 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtUnit.Focus();
                return false;
            }
            if (txtRemainQuantity.Value < 0)
            {
                MessageBox.Show("Sô lượng tồn phải ít nhất bằng 0", "Thông báo", MessageBoxButtons.OK);
                txtRemainQuantity.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            String maVatTu = txtMaterialID.Text.Trim();
            DataRowView drv = ((DataRowView)bdsVatTu[bdsVatTu.Position]);
            String tenVatTu = drv["TENVT"].ToString();
            String donViTinh = drv["DVT"].ToString();
            String soLuongTon = (drv["SOLUONGTON"].ToString());

            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaVatTu '" +
                    maVatTu + "' " +
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

            int viTriConTro = bdsVatTu.Position;
            int viTriMaVatTu = bdsVatTu.Find("MAVT", txtMaterialID.Text);
           
            if (result == 1 && viTriConTro != viTriMaVatTu)
            {
                MessageBox.Show("Mã vật tư này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
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
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnSave.Enabled = true;
                        btnUndo.Enabled = true;

                        btnRefresh.Enabled = true;
                        btnCHUYENCHINHANH.Enabled = true;
                        btnExit.Enabled = true;

                        this.txtMaterialID.Enabled = false;
                        this.gcVATTU.Enabled = true;

                        String cauTruyVanHoanTac = "";
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.VATTU " +
                                "WHERE MAVT = '" + txtMaterialID.Text.Trim()+"'";
                        }
                        else
                        {
                            cauTruyVanHoanTac =
                                "UPDATE DBO.VATTU " +
                                "SET " +
                                "TENVT = '" + tenVatTu + "'," +
                                "DVT = '" + donViTinh + "'," +
                                "SOLUONGTON = " + soLuongTon + " " +
                                "WHERE MAVT = '" + maVatTu + "'";
                        }
                        undoList.Push(cauTruyVanHoanTac);

                        this.bdsVatTu.EndEdit();
                        this.vattuTableAdapter.Update(this.dataSet.Vattu);
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bdsVatTu.RemoveCurrent();
                        MessageBox.Show("Tên vật tư có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                
            }
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.vattuTableAdapter.Fill(this.dataSet.Vattu);
                this.gcVATTU.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private int kiemTraVatTuCoSuDungTaiChiNhanhKhac(String maVatTu)
        {
            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_KiemTraMaVatTuChiNhanhConLai '" +
                    maVatTu + "' " +
                    "SELECT 'Value' = @result";
            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                if (Program.myReader == null)
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return 1;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            int ketQua = (result == 1) ? 1 : 0;

            return ketQua;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsVatTu.Count == 0)
            {
                btnDelete.Enabled = false;
            }

            if (bdsCTDDH.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTPN.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsCTPX.Count > 0)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            String maVatTu = txtMaterialID.Text.Trim();
            int ketQua = kiemTraVatTuCoSuDungTaiChiNhanhKhac(maVatTu);

            if( ketQua == 1)
            {
                MessageBox.Show("Không thể xóa vật tư này vì đang được sử dụng ở chi nhánh khác", "Thông báo", MessageBoxButtons.OK);
                return;
            }    

            string cauTruyVanHoanTac =
            "INSERT INTO DBO.VATTU( MAVT,TENVT,DVT,SOLUONGTON) " +
            " VALUES( '" + txtMaterialID.Text + "','" +
                        txtMaterialName.Text + "','" +
                        txtUnit.Text + "', " +
                        txtRemainQuantity.Value + " ) ";

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdsVatTu.Position;
                    bdsVatTu.RemoveCurrent();

                    this.vattuTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.vattuTableAdapter.Update(this.dataSet.Vattu);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.vattuTableAdapter.Fill(this.dataSet.Vattu);
                    bdsVatTu.Position = viTri;
                    return;
                }
            }
            else
            {
                undoList.Pop();
            }
        }
    }
}
