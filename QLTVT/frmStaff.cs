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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{
    public partial class FrmStaff : Form
    {
        int viTri = 0;
        bool dangThemMoi = false;
        String maChiNhanh = "";
        Stack undoList = new Stack();

        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        public FrmStaff()
        {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet);

        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            dataSet.EnforceConstraints = false;

            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
            
            this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.datHangTableAdapter.Fill(this.dataSet.DatHang);
            
            this.phieuNhapTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);
           
            this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
            this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);

            maChiNhanh = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();

            cmbBranch.DataSource = Program.bindingSource;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.SelectedIndex = Program.brand;
            
            if( Program.role == "CONGTY")
            {
                cmbBranch.Enabled = true;

                this.btnAdd.Enabled = false;
                this.btnDelete.Enabled = false;
                this.btnSave.Enabled = false;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnBranchTransfer.Enabled = false;
                this.btnExit.Enabled = true;

                this.panelNhapLieu.Enabled = false;
            }

            if( Program.role == "CHINHANH" || Program.role == "USER")
            {
                cmbBranch.Enabled = false;

                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnBranchTransfer.Enabled = true;
                this.btnExit.Enabled = true;

                this.panelNhapLieu.Enabled = true;
                this.txtIDStaff.Enabled = false;
            }

        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTri = bdsNhanVien.Position;
            this.panelNhapLieu.Enabled = true;
            dangThemMoi = true;

            bdsNhanVien.AddNew();
            txtIDBranch.Text = maChiNhanh;
            dteBirth.EditValue = "2002-09-12";
            txtSalary.Value = 8000000;

            this.txtIDStaff.Enabled = true;
            this.btnAdd.Enabled = false;
            this.btnDelete.Enabled = false;
            this.btnSave.Enabled = true;

            this.btnUndo.Enabled = true;
            this.btnRefresh.Enabled = false;
            this.btnBranchTransfer.Enabled = false;
            this.btnExit.Enabled = false;
            this.cbDStatus.Checked = false;

            this.gcNhanVien.Enabled = false;
            this.panelNhapLieu.Enabled = true;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if ( dangThemMoi == true && this.btnAdd.Enabled == false)
            {
                dangThemMoi = false;

                this.txtIDStaff.Enabled = false;
                this.btnAdd.Enabled = true;
                this.btnDelete.Enabled = true;
                this.btnSave.Enabled = true;

                this.btnUndo.Enabled = false;
                this.btnRefresh.Enabled = true;
                this.btnBranchTransfer.Enabled = true;
                this.btnExit.Enabled = true;
                this.cbDStatus.Checked = false;

                this.gcNhanVien.Enabled = true;
                this.panelNhapLieu.Enabled = true;

                bdsNhanVien.CancelEdit();
                bdsNhanVien.RemoveCurrent();
                bdsNhanVien.Position = viTri;
                return;
            }

            if ( undoList.Count == 0)
            {
                MessageBox.Show("Không còn thao tác nào để khôi phục" , "Thông báo", MessageBoxButtons.OK);
                btnUndo.Enabled = false;
                return;
            }

            bdsNhanVien.CancelEdit();
            String cauTruyVanHoanTac = undoList.Pop().ToString();

            if ( cauTruyVanHoanTac.Contains("sp_ChuyenChiNhanh") )
            {
                try
                {
                    String chiNhanhHienTai = Program.serverName;
                    String chiNhanhChuyenToi = Program.serverNameLeft;

                    Program.serverName = chiNhanhChuyenToi;
                    Program.loginName = Program.remoteLogin;
                    Program.loginPassword = Program.remotePassword;

                    if (Program.KetNoi() == 0)
                    {
                        return;
                    }


                    int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);

                    MessageBox.Show("Chuyển nhân viên trở lại thành công", "Thông báo", MessageBoxButtons.OK);
                    Program.serverName = chiNhanhHienTai;
                    Program.loginName = Program.currentLogin;
                    Program.loginPassword = Program.currentPassword;
                }
                catch( Exception ex)
                {
                    MessageBox.Show("Chuyển nhân viên thất bại \n"+ex.Message, "Thông báo", MessageBoxButtons.OK);
                    return;
                }
                
            } else {
                if (Program.KetNoi() == 0)
                {
                    return;
                }
                int n = Program.ExecSqlNonQuery(cauTruyVanHoanTac);
                
            }
            this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
        }

        private void btnRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           try
           {
                this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
                this.gcNhanVien.Enabled = true;
           }
           catch(Exception ex)
           {
                MessageBox.Show("Lỗi Làm mới" + ex.Message,"Thông báo", MessageBoxButtons.OK);
                return;
           }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String tenNV = ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString();

            if(tenNV == Program.userName)
            {
                MessageBox.Show("Không thể xóa chính tài khoản đang đăng nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if ( bdsNhanVien.Count == 0)
            {
                btnDelete.Enabled = false;
            }

            if( bdsDatHang.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập đơn đặt hàng", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuNhap.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu nhập", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            if (bdsPhieuXuat.Count > 0)
            {
                MessageBox.Show("Không thể xóa nhân viên này vì đã lập phiếu xuất", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int trangThai = (cbDStatus.Checked == true) ? 1 : 0;

            DateTime NGAYSINH = (DateTime)((DataRowView)bdsNhanVien[bdsNhanVien.Position])["NGAYSINH"];


            string cauTruyVanHoanTac =
                string.Format("INSERT INTO DBO.NHANVIEN( MANV,HO,TEN,DIACHI,NGAYSINH,LUONG,MACN)" +
            "VALUES({0},'{1}','{2}','{3}',CAST({4} AS DATETIME), {5},'{6}')", txtIDStaff.Text, txtFname.Text, txtLname.Text, txtAddress.Text, NGAYSINH.ToString("yyyy-MM-dd"), txtSalary.Value, txtIDBranch.Text.Trim());

            Console.WriteLine(cauTruyVanHoanTac);
            undoList.Push(cauTruyVanHoanTac);

            if ( MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không ?","Thông báo",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    viTri = bdsNhanVien.Position;
                    bdsNhanVien.RemoveCurrent();

                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.dataSet.NhanVien);

                    MessageBox.Show("Xóa thành công ", "Thông báo", MessageBoxButtons.OK);
                    this.btnUndo.Enabled = true;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Hãy thử lại\n" + ex.Message, "Thông báo", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);
                    bdsNhanVien.Position = viTri;
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

            if( cmbBranch.SelectedIndex != Program.brand )
            {
                Program.loginName = Program.remoteLogin;
                Program.loginPassword = Program.remotePassword;
            }
            else
            {
                Program.loginName = Program.currentLogin;
                Program.loginPassword = Program.currentPassword;
            }

            if( Program.KetNoi() == 0)
            {
                MessageBox.Show("Xảy ra lỗi kết nối với chi nhánh hiện tại","Thông báo",MessageBoxButtons.OK);
            }
            else
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.dataSet.NhanVien);

                this.datHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.datHangTableAdapter.Fill(this.dataSet.DatHang);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuNhapTableAdapter.Fill(this.dataSet.PhieuNhap);

                this.phieuXuatTableAdapter.Connection.ConnectionString = Program.connstr;
                this.phieuXuatTableAdapter.Fill(this.dataSet.PhieuXuat);
            }
        }

        private void bdsPhieuNhap_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dteNGAYSINH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void trangThaiXoaCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private bool kiemTraDuLieuDauVao()
        {
            if (txtIDStaff.Text == "")
            {
                MessageBox.Show("Không bỏ trống mã nhân viên", "Thông báo", MessageBoxButtons.OK);
                txtIDStaff.Focus();
                return false;
            }

            if (Regex.IsMatch(txtIDStaff.Text, @"^[a-zA-Z0-9]+$") == false)
            {
                MessageBox.Show("Mã nhân viên chỉ chấp nhận số", "Thông báo", MessageBoxButtons.OK);
                txtIDStaff.Focus();
                return false;
            }
            if (txtFname.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtFname.Focus();
                return false;
            }
            if ( Regex.IsMatch(txtFname.Text, @"^[A-Za-z ]+$") == false)
            {
                MessageBox.Show("Họ của người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtFname.Focus();
                return false;
            }
            if (txtFname.Text.Length > 40)
            {
                MessageBox.Show("Họ không thể lớn hơn 40 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtFname.Focus();
                return false;
            }
            if (txtLname.Text == "")
            {
                MessageBox.Show("Không bỏ trống họ và tên", "Thông báo", MessageBoxButtons.OK);
                txtLname.Focus();
                return false;
            }

            if (Regex.IsMatch(txtLname.Text, @"^[a-zA-Z ]+$") == false)
            {
                MessageBox.Show("Tên người chỉ có chữ cái và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtLname.Focus();
                return false;
            }

            if (txtLname.Text.Length > 10)
            {
                MessageBox.Show("Tên không thể lớn hơn 10 kí tự", "Thông báo", MessageBoxButtons.OK);
                txtLname.Focus();
                return false;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtAddress.Focus();
                return false;
            }

            if (Regex.IsMatch(txtAddress.Text, @"^[a-zA-Z0-9, ]+$") == false)
            {
                MessageBox.Show("Địa chỉ chỉ chấp nhận chữ cái, số và khoảng trắng", "Thông báo", MessageBoxButtons.OK);
                txtAddress.Focus();
                return false;
            }

            if (txtAddress.Text.Length > 100)
            {
                MessageBox.Show("Không bỏ trống địa chỉ", "Thông báo", MessageBoxButtons.OK);
                txtAddress.Focus();
                return false;
            }
            if (CalculateAge(dteBirth.DateTime) < 18)
            {
                MessageBox.Show("Nhân viên chưa đủ 18 tuổi", "Thông báo", MessageBoxButtons.OK);
                dteBirth.Focus();
                return false;
            }

            if (txtSalary.Value < 4000000 || txtSalary.Value == 0)
            {
                MessageBox.Show("Mức lương không thể bỏ trống & tối thiểu 4.000.000 đồng", "Thông báo", MessageBoxButtons.OK);
                txtSalary.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false)
                return;

            String maNhanVien = txtIDStaff.Text.Trim();
            DataRowView drv = ((DataRowView)bdsNhanVien[bdsNhanVien.Position]);
            String ho = drv["HO"].ToString();
            String ten = drv["TEN"].ToString();

            String diaChi = drv["DIACHI"].ToString();

            DateTime ngaySinh = ((DateTime)drv["NGAYSINH"]);
            Console.WriteLine(ngaySinh);

            int luong = int.Parse(drv["LUONG"].ToString());
            String maChiNhanh = drv["MACN"].ToString();
            int trangThai = (cbDStatus.Checked == true) ? 1 : 0;

            String cauTruyVan =
                    "DECLARE	@result int " +
                    "EXEC @result = [dbo].[sp_TraCuu_KiemTraMaNhanVien] '" +
                    maNhanVien + "' " +
                    "SELECT 'Value' = @result"; ;
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

            int viTriConTro = bdsNhanVien.Position;
            int viTriMaNhanVien = bdsNhanVien.Find("MANV", txtIDStaff.Text);
            
            if ( result == 1 && viTriConTro != viTriMaNhanVien)
            {
                MessageBox.Show("Mã nhân viên này đã được sử dụng !", "Thông báo", MessageBoxButtons.OK);
                return; 
            }
            else
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn ghi dữ liệu vào cơ sở dữ liệu ?", "Thông báo",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if ( dr == DialogResult.OK)
                {
                    try
                    {
                        btnAdd.Enabled = true;
                        btnDelete.Enabled = true;
                        btnSave.Enabled = true;
                        btnUndo.Enabled = true;

                        btnRefresh.Enabled = true;
                        btnBranchTransfer.Enabled = true;
                        btnExit.Enabled = true;

                        this.txtIDStaff.Enabled = false;
                        this.bdsNhanVien.EndEdit();
                        this.nhanVienTableAdapter.Update(this.dataSet.NhanVien);
                        this.gcNhanVien.Enabled = true;

                        String cauTruyVanHoanTac = "";
                        if( dangThemMoi == true)
                        {
                            cauTruyVanHoanTac = "" +
                                "DELETE DBO.NHANVIEN " +
                                "WHERE MANV = " + txtIDStaff.Text.Trim();
                        }
                        else
                        {
                            cauTruyVanHoanTac = 
                                "UPDATE DBO.NhanVien "+
                                "SET " +
                                "HO = '" + ho + "'," +
                                "TEN = '" + ten + "'," +
                                "DIACHI = '" + diaChi + "'," +
                                "NGAYSINH = CAST('" + ngaySinh.ToString("yyyy-MM-dd") + "' AS DATETIME)," +
                                "LUONG = '" + luong + "',"+
                                "TrangThaiXoa = " + trangThai + " " +
                                "WHERE MANV = '" + maNhanVien + "'";
                        }
                        Console.WriteLine(cauTruyVanHoanTac);

                        undoList.Push(cauTruyVanHoanTac);
                        dangThemMoi = false;
                        MessageBox.Show("Ghi thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    catch(Exception ex)
                    {

                        bdsNhanVien.RemoveCurrent();
                        MessageBox.Show("Thất bại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            
        }
        private void dteNGAYSINH_Validating(object sender, CancelEventArgs e)
        {
            
        }
        
        public void chuyenChiNhanh(String chiNhanh, Form form )
        {
            if ( Program.serverName == chiNhanh)
            {
                MessageBox.Show("Hãy chọn chi nhánh khác chi nhánh bạn đang đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String maChiNhanhHienTai = "";
            String maChiNhanhMoi = "";
            int viTriHienTai = bdsNhanVien.Position;
            String maNhanVien = ((DataRowView)bdsNhanVien[viTriHienTai])["MANV"].ToString();

            if (chiNhanh.Contains("1"))
            {
                maChiNhanhHienTai = "CN2";
                maChiNhanhMoi = "CN1";
            }
            else if( chiNhanh.Contains("2"))
            {
                maChiNhanhHienTai = "CN1";
                maChiNhanhMoi = "CN2";
            }
            else
            {
                MessageBox.Show("Mã chi nhánh không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            Console.WriteLine("Ma chi nhanh hien tai : " + maChiNhanhHienTai);
            Console.WriteLine("Ma chi nhanh Moi : " + maChiNhanhMoi);

            String cauTruyVanHoanTac = "EXEC sp_ChuyenChiNhanh "+maNhanVien+",'"+maChiNhanhHienTai+"'";
            undoList.Push(cauTruyVanHoanTac);
            
            Program.serverNameLeft = chiNhanh;
            Console.WriteLine("Ten server con lai" + Program.serverNameLeft);

            String cauTruyVan = "EXEC sp_ChuyenChiNhanh " + maNhanVien + ",'" + maChiNhanhMoi + "'";
            Console.WriteLine("Cau Truy Van: " + cauTruyVan);
            Console.WriteLine("Cau Truy Van Hoan Tac: " + cauTruyVanHoanTac);

            SqlCommand sqlcommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                MessageBox.Show("Chuyển chi nhánh thành công", "thông báo", MessageBoxButtons.OK);
                
                form.Dispose();
                if (Program.myReader == null)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("thực thi database thất bại!\n\n" + ex.Message, "thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            this.nhanVienTableAdapter.Update(this.dataSet.NhanVien);


        }
        private void btnBranchTransfer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {


            int viTriHienTai = bdsNhanVien.Position;
            int trangThaiXoa = int.Parse( ( (DataRowView) (bdsNhanVien[viTriHienTai]) )["TrangThaiXoa"].ToString());
            string maNhanVien = ((DataRowView)(bdsNhanVien[viTriHienTai]))["MANV"].ToString();

            if( maNhanVien == Program.userName)
            {
                MessageBox.Show("Không thể chuyển chính người đang đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }    

            if ( trangThaiXoa == 1 )
            {
                MessageBox.Show("Nhân viên này không có ở chi nhánh này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Form f = this.CheckExists(typeof(FrmBranchTransfer));
            if (f != null)
            {
                f.Activate();
            }
            FrmBranchTransfer form = new FrmBranchTransfer();
            form.Show();

            form.branchTransfer = new FrmBranchTransfer.MyDelegate(chuyenChiNhanh);
            
            this.btnUndo.Enabled = true;
        }

        private void gcNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
