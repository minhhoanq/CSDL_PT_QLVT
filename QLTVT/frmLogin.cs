using DevExpress.XtraEditors;
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
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        private SqlConnection connPublisher = new SqlConnection();

        private void layDanhSachPhanManh(String cmd)
        {
            if( connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd, connPublisher);
            da.Fill(dt);


            connPublisher.Close();
            Program.bindingSource.DataSource = dt;


            cmbBranch.DataSource = Program.bindingSource;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
        }
        public FrmLogin()
        {
            InitializeComponent();
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private int KetNoiDatabaseGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.connstrPublisher;
                connPublisher.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {
            txtAccount.Text = "LT";
            txtPassword.Text = "123";
            if ( KetNoiDatabaseGoc() == 0 )
                return;
            layDanhSachPhanManh("SELECT TOP 2 * FROM view_DanhSachPhanManh");
            cmbBranch.SelectedIndex = 1;
            cmbBranch.SelectedIndex = 0;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản & mật khẩu không thể bỏ trống", "Thông Báo", MessageBoxButtons.OK);
                return;
            }
            Program.loginName = txtAccount.Text.Trim();
            Program.loginPassword = txtPassword.Text.Trim();
            if (Program.KetNoi() == 0)
                return;
            Program.brand = cmbBranch.SelectedIndex;
            Program.currentLogin = Program.loginName;
            Program.currentPassword = Program.loginPassword;
            String statement = "EXEC sp_DangNhap '"+Program.loginName + "'";
            Program.myReader = Program.ExecSqlDataReader(statement);
            if (Program.myReader == null)
                return;
            Program.myReader.Read();

            Program.userName = Program.myReader.GetString(0);
            if( Convert.IsDBNull(Program.userName) )
            {
                MessageBox.Show("Tài khoản này không có quyền truy cập \n Hãy thử tài khoản khác","Thông Báo",MessageBoxButtons.OK);
            }

            Program.staff = Program.myReader.GetString(1);
            Program.role = Program.myReader.GetString(2);

            Program.myReader.Close();
            Program.conn.Close();

            //Program.formChinh.MANHANVIEN.Text = "MÃ NHÂN VIÊN: " + Program.userName;
            //Program.formChinh.HOTEN.Text = "HỌ TÊN: " + Program.staff;
            //Program.formChinh.NHOM.Text = "VAI TRÒ: " + Program.role;

            Program.frmMain = new FrmMain();
            Program.frmMain.Activate();
            Program.frmMain.Show();

            this.Visible = false;
            Program.frmMain.enableButtons();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Program.serverName = cmbBranch.SelectedValue.ToString();
            }
            catch( Exception )
            {
                
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}