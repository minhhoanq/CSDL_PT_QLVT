using DevExpress.XtraBars;
using QLTVT.ReportForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVT
{

    public partial class FrmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //public System.Windows.Forms.ToolStripStatusLabel MANHANVIEN { get; set; }
        //public System.Windows.Forms.ToolStripStatusLabel HOTEN { get; set; }
        //public System.Windows.Forms.ToolStripStatusLabel NHOM { get; set; }
        public FrmMain()
        {
            InitializeComponent();
        }
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



        /************************************************************
         *enableButtons: kích hoạt các tab chức năng và nút đăng xuất
         ************************************************************/
        public void enableButtons()
        {
            btnLogout.Enabled = true;

            pageMenu.Visible = true;
            pageDetails.Visible = true;
            btnLapTaiKhoan.Enabled = true;

            if( Program.role == "USER")
            {
                btnLapTaiKhoan.Enabled = false;
            }    
            
            //pageTaiKhoan.Visible = true;


        }



        /************************************************************
         * Dispose: giải phóng các form khỏi bộ nhớ. Ví dụ form nhân viên,...
         * Close: đóng hoàn toàn chương trình lại
         ************************************************************/
        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }



        /************************************************************
         * Step 1: giải phóng các form khỏi bộ nhớ
         * Step 2: vô hiệu hóa các tab
         * Step 3: gọi lại form đăng nhập
         ************************************************************/
        private void btnLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            logout();

            //btnDangNhap.Enabled = true;
            btnLogout.Enabled = false;

            pageMenu.Visible = false;
            pageDetails.Visible = false;
            //pageTaiKhoan.Visible = false;

            Form f = this.CheckExists(typeof(FrmLogin));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FrmLogin form = new FrmLogin();
                //form.MdiParent = this;
                form.Show();
            }
            this.Close();
        }




        /************************************************************
         * Kiểm tra xem form đăng nhập đã có trong hệ thống chưa?
         * Step 1: Nếu có thì chạy form đăng nhập
         * Step 2: Nếu không thì khởi tạo một form đăng nhập mới rồi 
         * ném vào đưa vào xtraTabbedMdiManager
         * 
         * f.MdiParent = this; cái form này có form cha là this - tức form chính
         ************************************************************/
        //private void btnDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        //{
        //    Form f = this.CheckExists(typeof(frmLogin));
        //    if (f != null)
        //    {
        //        f.Activate();
        //    }
        //    else
        //    {
        //        frmLogin form = new frmLogin();
        //        //form.MdiParent = this;
        //        form.Show();
        //    }
        //}

        private void FormMain_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            Program.frmMain.MANHANVIEN.Text = "ID : " + Program.userName;
            Program.frmMain.HOTEN.Text = "Full name : " + Program.staff;
            Program.frmMain.NHOM.Text = "Role : " + Program.role;
            
        }


        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MANV_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStaff_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FrmStaff));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FrmStaff form = new FrmStaff();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FrmMaterial));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FrmMaterial form = new FrmMaterial();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnKho_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FrmWareHouse));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FrmWareHouse form = new FrmWareHouse();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnOrderOption_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FrmTheOrder));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FrmTheOrder form = new FrmTheOrder();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnImportInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FrmImportInvoice));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FrmImportInvoice form = new FrmImportInvoice();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnExportInvoice_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FrmExportInvoice));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FrmExportInvoice form = new FrmExportInvoice();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDanhSachNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDanhSachNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDanhSachNhanVien form = new FormDanhSachNhanVien();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDanhSachVatTu_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDanhSachVatTu));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDanhSachVatTu form = new FormDanhSachVatTu();
                form.MdiParent = this;
                form.Show();
            }
        }

        private void btnDonHangKhongPhieuNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormDonHangKhongPhieuNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormDonHangKhongPhieuNhap form = new FormDonHangKhongPhieuNhap();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void btnChiTietNhapXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormChiTietSoLuongTriGiaHangHoaNhapXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormChiTietSoLuongTriGiaHangHoaNhapXuat form = new FormChiTietSoLuongTriGiaHangHoaNhapXuat();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void btnHoatDongNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormHoatDongNhanVien));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormHoatDongNhanVien form = new FormHoatDongNhanVien();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void btnTongHopNhapXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FormTongHopNhapXuat));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FormTongHopNhapXuat form = new FormTongHopNhapXuat();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void btnLapTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FrmSignUp));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FrmSignUp form = new FrmSignUp();
                //form.MdiParent = this;
                form.Show();
            }
        }

        private void NHOM_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_ItemClick_1(object sender, ItemClickEventArgs e)
        {

        }

        private void btnRegister_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(FrmSignUp));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                FrmSignUp form = new FrmSignUp();
                //form.MdiParent = this;
                form.Show();
            }
        }
    }
}