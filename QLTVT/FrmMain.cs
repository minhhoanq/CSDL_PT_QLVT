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
        public FrmMain()
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
        }

        private void logout()
        {
            foreach (Form f in this.MdiChildren)
                f.Dispose();
        }

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

        private void FormMain_Load(object sender, EventArgs e)
        {
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