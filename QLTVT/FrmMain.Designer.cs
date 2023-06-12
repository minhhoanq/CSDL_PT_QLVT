
namespace QLTVT
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnStaff = new DevExpress.XtraBars.BarButtonItem();
            this.btnVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnKho = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnDanhSachVatTu = new DevExpress.XtraBars.BarButtonItem();
            this.btnChiTietNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnDonHangKhongPhieuNhap = new DevExpress.XtraBars.BarButtonItem();
            this.btnHoatDongNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnTongHopNhapXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoaTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnOrderOption = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.btnExportInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnLapTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.btnRegister = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.pageMenu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.pageDetails = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANHANVIEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnStaff,
            this.btnVatTu,
            this.btnKho,
            this.btnDonHang,
            this.btnDanhSachNhanVien,
            this.btnDanhSachVatTu,
            this.btnChiTietNhapXuat,
            this.btnDonHangKhongPhieuNhap,
            this.btnHoatDongNhanVien,
            this.btnTongHopNhapXuat,
            this.btn,
            this.barButtonItem12,
            this.barButtonItem1,
            this.btnTaoTaiKhoan,
            this.btnXoaTaiKhoan,
            this.btnMENU,
            this.barButtonItem2,
            this.btnOrderOption,
            this.btnImportInvoice,
            this.btnExportInvoice,
            this.btnLapTaiKhoan,
            this.btnRegister,
            this.btnLogout});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(6);
            this.ribbon.MaxItemId = 32;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.pageMenu,
            this.pageDetails});
            this.ribbon.Size = new System.Drawing.Size(1598, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnStaff
            // 
            this.btnStaff.Caption = "STAFF";
            this.btnStaff.Id = 1;
            this.btnStaff.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStaff.ImageOptions.SvgImage")));
            this.btnStaff.LargeWidth = 100;
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaff_ItemClick);
            // 
            // btnVatTu
            // 
            this.btnVatTu.Caption = "MATERIAL";
            this.btnVatTu.Id = 2;
            this.btnVatTu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVatTu.ImageOptions.SvgImage")));
            this.btnVatTu.LargeWidth = 100;
            this.btnVatTu.Name = "btnVatTu";
            this.btnVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnVatTu_ItemClick);
            // 
            // btnKho
            // 
            this.btnKho.Caption = "WAREHOUSE";
            this.btnKho.Id = 3;
            this.btnKho.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnKho.ImageOptions.SvgImage")));
            this.btnKho.LargeWidth = 100;
            this.btnKho.Name = "btnKho";
            this.btnKho.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKho_ItemClick);
            // 
            // btnDonHang
            // 
            this.btnDonHang.Id = 21;
            this.btnDonHang.Name = "btnDonHang";
            // 
            // btnDanhSachNhanVien
            // 
            this.btnDanhSachNhanVien.Caption = "STAFF LIST";
            this.btnDanhSachNhanVien.Id = 5;
            this.btnDanhSachNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanhSachNhanVien.ImageOptions.SvgImage")));
            this.btnDanhSachNhanVien.LargeWidth = 100;
            this.btnDanhSachNhanVien.Name = "btnDanhSachNhanVien";
            this.btnDanhSachNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachNhanVien_ItemClick);
            // 
            // btnDanhSachVatTu
            // 
            this.btnDanhSachVatTu.Caption = "MATERIAL LIST";
            this.btnDanhSachVatTu.Id = 6;
            this.btnDanhSachVatTu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDanhSachVatTu.ImageOptions.SvgImage")));
            this.btnDanhSachVatTu.LargeWidth = 100;
            this.btnDanhSachVatTu.Name = "btnDanhSachVatTu";
            this.btnDanhSachVatTu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDanhSachVatTu_ItemClick);
            // 
            // btnChiTietNhapXuat
            // 
            this.btnChiTietNhapXuat.Caption = "IMPORT EXPORT";
            this.btnChiTietNhapXuat.Id = 7;
            this.btnChiTietNhapXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnChiTietNhapXuat.ImageOptions.SvgImage")));
            this.btnChiTietNhapXuat.LargeWidth = 100;
            this.btnChiTietNhapXuat.Name = "btnChiTietNhapXuat";
            this.btnChiTietNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChiTietNhapXuat_ItemClick);
            // 
            // btnDonHangKhongPhieuNhap
            // 
            this.btnDonHangKhongPhieuNhap.Caption = "NON-IMPORT INVOICE";
            this.btnDonHangKhongPhieuNhap.Id = 8;
            this.btnDonHangKhongPhieuNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDonHangKhongPhieuNhap.ImageOptions.SvgImage")));
            this.btnDonHangKhongPhieuNhap.LargeWidth = 100;
            this.btnDonHangKhongPhieuNhap.Name = "btnDonHangKhongPhieuNhap";
            this.btnDonHangKhongPhieuNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDonHangKhongPhieuNhap_ItemClick);
            // 
            // btnHoatDongNhanVien
            // 
            this.btnHoatDongNhanVien.Caption = "STAFF ACTIVITY";
            this.btnHoatDongNhanVien.Id = 9;
            this.btnHoatDongNhanVien.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnHoatDongNhanVien.ImageOptions.SvgImage")));
            this.btnHoatDongNhanVien.LargeWidth = 100;
            this.btnHoatDongNhanVien.Name = "btnHoatDongNhanVien";
            this.btnHoatDongNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnHoatDongNhanVien_ItemClick);
            // 
            // btnTongHopNhapXuat
            // 
            this.btnTongHopNhapXuat.Caption = "TOTAL IM/EXPORT";
            this.btnTongHopNhapXuat.Id = 10;
            this.btnTongHopNhapXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTongHopNhapXuat.ImageOptions.SvgImage")));
            this.btnTongHopNhapXuat.LargeWidth = 100;
            this.btnTongHopNhapXuat.Name = "btnTongHopNhapXuat";
            this.btnTongHopNhapXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTongHopNhapXuat_ItemClick);
            // 
            // btn
            // 
            this.btn.Caption = "12";
            this.btn.Id = 11;
            this.btn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn.ImageOptions.SvgImage")));
            this.btn.LargeWidth = 100;
            this.btn.Name = "btn";
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Id = 30;
            this.barButtonItem12.Name = "barButtonItem12";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 16;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // btnTaoTaiKhoan
            // 
            this.btnTaoTaiKhoan.Caption = "TẠO MỚI";
            this.btnTaoTaiKhoan.Id = 17;
            this.btnTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaoTaiKhoan.ImageOptions.SvgImage")));
            this.btnTaoTaiKhoan.LargeWidth = 100;
            this.btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Caption = "XÓA";
            this.btnXoaTaiKhoan.Id = 18;
            this.btnXoaTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoaTaiKhoan.ImageOptions.SvgImage")));
            this.btnXoaTaiKhoan.LargeWidth = 100;
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            // 
            // btnMENU
            // 
            this.btnMENU.Caption = "CREATE INVOICE";
            this.btnMENU.Id = 22;
            this.btnMENU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMENU.ImageOptions.SvgImage")));
            this.btnMENU.LargeWidth = 100;
            this.btnMENU.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOrderOption),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImportInvoice),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExportInvoice)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnOrderOption
            // 
            this.btnOrderOption.Caption = "Order Option";
            this.btnOrderOption.Id = 24;
            this.btnOrderOption.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOrderOption.ImageOptions.SvgImage")));
            this.btnOrderOption.Name = "btnOrderOption";
            this.btnOrderOption.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOrderOption_ItemClick);
            // 
            // btnImportInvoice
            // 
            this.btnImportInvoice.Caption = "Import Invoice";
            this.btnImportInvoice.Id = 25;
            this.btnImportInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportInvoice.ImageOptions.SvgImage")));
            this.btnImportInvoice.Name = "btnImportInvoice";
            this.btnImportInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImportInvoice_ItemClick);
            // 
            // btnExportInvoice
            // 
            this.btnExportInvoice.Caption = "Export Invoice";
            this.btnExportInvoice.Id = 26;
            this.btnExportInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExportInvoice.ImageOptions.SvgImage")));
            this.btnExportInvoice.Name = "btnExportInvoice";
            this.btnExportInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExportInvoice_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 23;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnLapTaiKhoan
            // 
            this.btnLapTaiKhoan.Caption = "TẠO TÀI KHOẢN";
            this.btnLapTaiKhoan.Enabled = false;
            this.btnLapTaiKhoan.Id = 27;
            this.btnLapTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLapTaiKhoan.ImageOptions.SvgImage")));
            this.btnLapTaiKhoan.LargeWidth = 100;
            this.btnLapTaiKhoan.Name = "btnLapTaiKhoan";
            this.btnLapTaiKhoan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLapTaiKhoan_ItemClick);
            // 
            // btnRegister
            // 
            this.btnRegister.Caption = "REGISTER";
            this.btnRegister.Id = 28;
            this.btnRegister.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRegister.ImageOptions.SvgImage")));
            this.btnRegister.LargeWidth = 100;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRegister_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "LOG OUT";
            this.btnLogout.Id = 29;
            this.btnLogout.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLogout.ImageOptions.SvgImage")));
            this.btnLogout.LargeWidth = 100;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // pageMenu
            // 
            this.pageMenu.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pageMenu.Appearance.Options.UseBackColor = true;
            this.pageMenu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.pageMenu.Name = "pageMenu";
            this.pageMenu.Text = "MENU";
            this.pageMenu.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnStaff);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnVatTu);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKho);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMENU);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "MATERIAL MANAGEMENT";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnRegister);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ACCOUNT";
            // 
            // pageDetails
            // 
            this.pageDetails.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.pageDetails.Name = "pageDetails";
            this.pageDetails.Text = "DETAILS";
            this.pageDetails.Visible = false;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanhSachNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDanhSachVatTu);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnChiTietNhapXuat);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnDonHangKhongPhieuNhap);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnHoatDongNhanVien);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnTongHopNhapXuat);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "DETAIL MANAGEMENT";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 856);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(6);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1598, 28);
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANHANVIEN,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 830);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1598, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANHANVIEN
            // 
            this.MANHANVIEN.Name = "MANHANVIEN";
            this.MANHANVIEN.Size = new System.Drawing.Size(31, 20);
            this.MANHANVIEN.Text = "ID :";
            this.MANHANVIEN.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // HOTEN
            // 
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(80, 20);
            this.HOTEN.Text = "Full name :";
            // 
            // NHOM
            // 
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(46, 20);
            this.NHOM.Text = "Role :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 884);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MATERIAL MANAGEMENT";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnStaff;
        private DevExpress.XtraBars.BarButtonItem btnVatTu;
        private DevExpress.XtraBars.BarButtonItem btnKho;
        private DevExpress.XtraBars.BarButtonItem btnDonHang;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnDanhSachVatTu;
        private DevExpress.XtraBars.BarButtonItem btnChiTietNhapXuat;
        private DevExpress.XtraBars.BarButtonItem btnDonHangKhongPhieuNhap;
        private DevExpress.XtraBars.BarButtonItem btnHoatDongNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnTongHopNhapXuat;
        private DevExpress.XtraBars.BarButtonItem btn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.Ribbon.RibbonPage pageDetails;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        //private DevExpress.XtraBars.BarButtonItem btnDangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnXoaTaiKhoan;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANHANVIEN;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
        private DevExpress.XtraBars.BarSubItem btnMENU;
        private DevExpress.XtraBars.BarButtonItem btnOrderOption;
        private DevExpress.XtraBars.BarButtonItem btnImportInvoice;
        private DevExpress.XtraBars.BarButtonItem btnExportInvoice;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnLapTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem btnRegister;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
    }
}