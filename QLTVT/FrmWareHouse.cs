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
    public partial class FrmWareHouse : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        String maChiNhanh = "";
        Stack undoList = new Stack();

        public FrmWareHouse()
        {
            InitializeComponent();
        }

        private void khoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKho.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);
        }
        private void FormKho_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dataSet.DatHang);

            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);

            this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khoTableAdapter.Fill(this.dataSet.Kho);

            maChiNhanh = ((DataRowView)bdsKho[0])["MACN"].ToString();
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
                this.btnCHUYENCHINHANH.Enabled = true;
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
                this.txtWareHouseID.Enabled = false;
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
                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dataSet.DatHang);

                this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);

                this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khoTableAdapter.Fill(this.dataSet.Kho);
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsKho.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;
            bdsKho.AddNew();
            txtBranchID.Text = maChiNhanh;

            this.txtWareHouseID.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;

            this.btnUndo.Enabled = true;
            this.btnRefresh.Enabled = false;
            this.btnExit.Enabled = false;


            this.gcKHO.Enabled = false;
            this.panelNhapLieu.Enabled = true;
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khoTableAdapter.Fill(this.dataSet.Kho);
                this.gcKHO.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Làm mới" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private bool kiemTraDuLieuDauVao()
        {
            if (txtWareHouseID.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtWareHouseID.Focus();
                return false;
            }

            if (Regex.IsMatch(txtWareHouseID.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ và số", "Thông báo", MessageBoxButtons.OK);
                txtWareHouseID.Focus();
                return false;
            }

            if (txtWareHouseID.Text.Length > 4)
            {
                MessageBox.Show("Mã kho không thể lớn hơn 4 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtWareHouseID.Focus();
                return false;
            }
            if (txtWareHouseName.Text == "")
            {
                MessageBox.Show("Không bỏ trống tên kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtWareHouseName.Focus();
                return false;
            }

            if (Regex.IsMatch(txtWareHouseName.Text, @"^[a-zA-Z0-9 ]+$") == false)
            {
                MessageBox.Show("Mã kho chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtWareHouseName.Focus();
                return false;
            }

            if ( txtWareHouseName.Text.Length > 30)
            {
                MessageBox.Show("Tên kho không thể quá 30 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtWareHouseName.Focus();
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ kho hàng", "Thông báo", MessageBoxButtons.OK);
                txtAddress.Focus();
                return false;
            }

            if (Regex.IsMatch(txtAddress.Text, @"^[a-zA-Z0-9, ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ gồm chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtAddress.Focus();
                return false;
            }

            if (txtAddress.Text.Length > 100)
            {
                MessageBox.Show("Địa chỉ không quá 100 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtAddress.Focus();
                return false;
            }

            return true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            String maKhoHang = txtWareHouseID.Text.Trim();
            DataRowView drv = ((DataRowView)bdsKho[bdsKho.Position]);
            String tenKhoHang = drv["TENKHO"].ToString();
            String diaChi = drv["DIACHI"].ToString();

            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = sp_TraCuu_KiemTraMaKho '" +
                    maKhoHang + "' " +
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
                MessageBox.Show("Thực thi Stored Procedure thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            Program.myReader.Read();
            int result = int.Parse(Program.myReader.GetValue(0).ToString());
            Program.myReader.Close();

            int viTriConTro = bdsKho.Position;
            int viTriMaKhoHang = bdsKho.Find("MAKHO", txtWareHouseID.Text);

            if (result == 1 && viTriConTro != viTriMaKhoHang)
            {
                MessageBox.Show("Mã kho hàng này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
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

                        this.txtWareHouseID.Enabled = false;
                        this.gcKHO.Enabled = true;

                        String cauTruyVanHoanTac = "";
                        if (dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.KHO " +
                                "WHERE MAKHO = '" + txtWareHouseID.Text.Trim() + "'";
                        }
                        else
                        {
                            cauTruyVanHoanTac =
                                "UPDATE DBO.KHO " +
                                "SET " +
                                "TENKHO = '" + tenKhoHang + "'," +
                                "DIACHI = '" + diaChi + "'" +
                                "WHERE MAKHO = '" + maKhoHang + "'";
                        }

                        undoList.Push(cauTruyVanHoanTac);

                        this.bdsKho.EndEdit();
                        this.khoTableAdapter.Update(this.dataSet.Kho);
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        bdsKho.RemoveCurrent();
                        MessageBox.Show("Tên vật tư có thể đã được dùng !\n\n" + ex.Message, "Lỗi",
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

                this.txtWareHouseID.Enabled = false;
                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnExit.Enabled = true;


                this.gcKHO.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsKho.CancelEdit();
                bdsKho.RemoveCurrent();
                bdsKho.Position = viTri;
                return;
            }

            if (undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục", "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                return;
            }

            bdsKho.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();
            Console.WriteLine(cauTruyVanHoanTac);
            int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
            bdsKho.Position = viTri;
            this.khoTableAdapter.Fill(this.dataSet.Kho);
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsKho.Count == 0)
            {
                btnDelete.Enabled = false;
            }

            if (bdsDATHANG.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPHIEUNHAP.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPHIEUXUAT.Count > 0)
            {
                MessageBox.Show("Không thể xóa kho hàng này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            string cauTruyVanHoanTac =
            "INSERT INTO DBO.KHO( MAKHO,TENKHO,DIACHI,MACN) " +
            " VALUES( '" + txtWareHouseID.Text + "','" +
                        txtAddress.Text + "','" +
                        txtAddress.Text + "', '" +
                        txtBranchID.Text.Trim() + "' ) ";

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdsKho.Position;
                    bdsKho.RemoveCurrent();

                    this.khoTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khoTableAdapter.Update(this.dataSet.Kho);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.khoTableAdapter.Fill(this.dataSet.Kho);
                    bdsKho.Position = viTri;
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
