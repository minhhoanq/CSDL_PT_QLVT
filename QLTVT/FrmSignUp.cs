using DevExpress.XtraEditors;
using QLTVT.SubForm;
using System;
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
    public partial class FrmSignUp : DevExpress.XtraEditors.XtraForm
    {
        private string taiKhoan = "";
        private string matKhau = "";
        private string maNhanVien = "";
        private string vaiTro = "";
        public FrmSignUp()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            FrmSelectStaff form = new FrmSelectStaff();
            form.ShowDialog();

            txtStaffID.Text = Program.maNhanVienDuocChon;
        }

        private bool kiemTraDuLieuDauVao()
        {
            if( txtStaffID.Text == "")
            {
                MessageBox.Show("Thiếu mã nhân viên","Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if( txtPassword.Text == "" )
            {
                MessageBox.Show("Thiếu mật khẩu", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if (txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Thiếu mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }

            if( txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu không khớp với mật khẩu xác nhận", "Thông báo", MessageBoxButtons.OK);
                return false;
            }    

            return true;
        } 

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            bool ketQua = kiemTraDuLieuDauVao();
            if (ketQua == false) return;

             taiKhoan = Program.hoTen;
             matKhau = txtPassword.Text;
             maNhanVien = Program.maNhanVienDuocChon;
             vaiTro = (rdBranch.Checked == true) ? "CHINHANH" : "USER";

            Console.WriteLine(taiKhoan);
            Console.WriteLine(matKhau);
            Console.WriteLine(maNhanVien);
            Console.WriteLine(vaiTro);

            /*declare @returnedResult int
             exec @returnedResult = sp_TraCuu_KiemTraMaNhanVien '20'
             select @returnedResult*/
            String cauTruyVan =
                    "EXEC sp_TaoTaiKhoan '" + taiKhoan + "' , '" + matKhau + "', '"
                    + maNhanVien + "', '" + vaiTro + "'";

            SqlCommand sqlCommand = new SqlCommand(cauTruyVan, Program.conn);
            try
            {
                

                Program.myReader = Program.ExecSqlDataReader(cauTruyVan);
                /*khong co ket qua tra ve thi ket thuc luon*/
                if (Program.myReader == null)
                {
                    return;
                }

                MessageBox.Show("Đăng kí tài khoản thành công\n\nTài khoản: "+taiKhoan+"\nMật khẩu: " + matKhau + "\n Mã Nhân Viên: " + maNhanVien + "\n Vai Trò: " + vaiTro,"Thông Báo",MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thực thi database thất bại!\n\n" + ex.Message, "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.Message);
                return;
            }
            
        }

        private void cmbCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {
            if( Program.role == "CONGTY")
            {
                vaiTro = "CONGTY";
                rdBranch.Enabled = false;
                rdUser.Enabled = false;
            }
            rdBranch.Enabled = true;
            rdUser.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void rdChiNhanh_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtXacNhanMatKhau_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtMaNhanVien_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdUser_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}