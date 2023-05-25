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

namespace QLTVT.SubForm
{
    public partial class FormChuyenChiNhanh : DevExpress.XtraEditors.XtraForm
    {
        
        public FormChuyenChiNhanh()
        {
            InitializeComponent();
        }
       

        private void FormChuyenChiNhanh_Load(object sender, EventArgs e)
        { 
            /*Lấy dữ liệu từ form đăng nhập đổ vào nhưng chỉ lấn đúng danh sách
             phân mảnh mà thôi*/
            cmbBranch.DataSource  = Program.bindingSource.DataSource;
            /*sao chep bingding source tu form dang nhap*/
            cmbBranch.DisplayMember = "tencn";
            cmbBranch.ValueMember = "tenserver";
            cmbBranch.SelectedIndex = Program.brand;

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }



        /************************************************************
         * tạo delegate - một cái biến mà khi được gọi, nó sẽ thực hiện 1 hàm(function) khác
         * Ví dụ: ở class frmStaff, ta có hàm chuyển chi nhánh, hàm này cần 1 tham số, chính
         * là tên server được chọn ở formChuyenChiNhanh này. Để gọi được hàm chuyển chi nhánh ở frmStaff
         * Chúng ta khai báo 1 delete là branchTransfer để gọi hàm chuyển chi nhánh về form này
         *************************************************************/
        public delegate void MyDelegate(string chiNhanh, Form form);
        public MyDelegate branchTransfer;
        private void btnComfirm_Click(object sender, EventArgs e)
        {
            if (cmbBranch.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng chọn chi nhánh", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            /*Step 2*/
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn chuyển nhân viên này đi ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if( dialogResult == DialogResult.OK)
            {
                branchTransfer(cmbBranch.SelectedValue.ToString(), this);
            } else
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cCHINHANH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {

        }
    }
}