
namespace QLTVT
{
    partial class FrmImportInvoice
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
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label labelMaterialID;
            System.Windows.Forms.Label labelInvoiceID;
            System.Windows.Forms.Label labelDay;
            System.Windows.Forms.Label labelOrderID;
            System.Windows.Forms.Label mAVTLabel1;
            System.Windows.Forms.Label labelQuantity;
            System.Windows.Forms.Label labelUnitPrice;
            System.Windows.Forms.Label labelStaffID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportInvoice));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnImportInvoice = new DevExpress.XtraBars.BarButtonItem();
            this.btnImportInvoiceDetail = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.btnThemChiTietDonDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet = new QLTVT.DataSet();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.gcPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDDH = new DevExpress.XtraEditors.GroupControl();
            this.gcChiTietPhieuNhap = new DevExpress.XtraGrid.GridControl();
            this.bdsChiTietPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBoxPhieuNhap = new System.Windows.Forms.GroupBox();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnEnterOrderDetail = new System.Windows.Forms.Button();
            this.txtMaterialID = new DevExpress.XtraEditors.TextEdit();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.txtDonGiaChiTietPhieuNhap = new DevExpress.XtraEditors.SpinEdit();
            this.txtQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaterialIDInvoice = new DevExpress.XtraEditors.TextEdit();
            this.btnEnterOrder = new System.Windows.Forms.Button();
            this.txtMaDonDatHang = new System.Windows.Forms.TextBox();
            this.dteDay = new DevExpress.XtraEditors.DateEdit();
            this.txtIImvoiceID = new DevExpress.XtraEditors.TextEdit();
            this.txtDonGia = new DevExpress.XtraEditors.SpinEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.SpinEdit();
            this.btnChonVatTu = new System.Windows.Forms.Button();
            this.txtMaVatTu = new DevExpress.XtraEditors.TextEdit();
            this.chiTietPhieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.CTPNTableAdapter();
            dONGIALabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            labelMaterialID = new System.Windows.Forms.Label();
            labelInvoiceID = new System.Windows.Forms.Label();
            labelDay = new System.Windows.Forms.Label();
            labelOrderID = new System.Windows.Forms.Label();
            mAVTLabel1 = new System.Windows.Forms.Label();
            labelQuantity = new System.Windows.Forms.Label();
            labelUnitPrice = new System.Windows.Forms.Label();
            labelStaffID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            this.gcDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuNhap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            this.groupBoxPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaChiTietPhieuNhap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialIDInvoice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIImvoiceID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(62, 665);
            dONGIALabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(52, 16);
            dONGIALabel.TabIndex = 16;
            dONGIALabel.Text = "Đơn Giá";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(61, 588);
            sOLUONGLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(61, 16);
            sOLUONGLabel.TabIndex = 14;
            sOLUONGLabel.Text = "Số Lượng";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(61, 512);
            mAVTLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(67, 16);
            mAVTLabel.TabIndex = 11;
            mAVTLabel.Text = "Mã Vật Tư";
            // 
            // labelMaterialID
            // 
            labelMaterialID.AutoSize = true;
            labelMaterialID.Location = new System.Drawing.Point(13, 125);
            labelMaterialID.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            labelMaterialID.Name = "labelMaterialID";
            labelMaterialID.Size = new System.Drawing.Size(78, 16);
            labelMaterialID.TabIndex = 8;
            labelMaterialID.Text = "Material ID :";
            // 
            // labelInvoiceID
            // 
            labelInvoiceID.AutoSize = true;
            labelInvoiceID.Location = new System.Drawing.Point(12, 39);
            labelInvoiceID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelInvoiceID.Name = "labelInvoiceID";
            labelInvoiceID.Size = new System.Drawing.Size(114, 16);
            labelInvoiceID.TabIndex = 18;
            labelInvoiceID.Text = "Import Invoice ID :";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Location = new System.Drawing.Point(350, 34);
            labelDay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelDay.Name = "labelDay";
            labelDay.Size = new System.Drawing.Size(37, 16);
            labelDay.TabIndex = 19;
            labelDay.Text = "Day :";
            labelDay.Click += new System.EventHandler(this.labelDay_Click);
            // 
            // labelOrderID
            // 
            labelOrderID.AutoSize = true;
            labelOrderID.Location = new System.Drawing.Point(14, 192);
            labelOrderID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelOrderID.Name = "labelOrderID";
            labelOrderID.Size = new System.Drawing.Size(65, 16);
            labelOrderID.TabIndex = 20;
            labelOrderID.Text = "Order ID :";
            // 
            // mAVTLabel1
            // 
            mAVTLabel1.AutoSize = true;
            mAVTLabel1.Location = new System.Drawing.Point(13, 240);
            mAVTLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAVTLabel1.Name = "mAVTLabel1";
            mAVTLabel1.Size = new System.Drawing.Size(78, 16);
            mAVTLabel1.TabIndex = 22;
            mAVTLabel1.Text = "Material ID :";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new System.Drawing.Point(10, 283);
            labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new System.Drawing.Size(63, 16);
            labelQuantity.TabIndex = 23;
            labelQuantity.Text = "Quantity :";
            // 
            // labelUnitPrice
            // 
            labelUnitPrice.AutoSize = true;
            labelUnitPrice.Location = new System.Drawing.Point(13, 324);
            labelUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelUnitPrice.Name = "labelUnitPrice";
            labelUnitPrice.Size = new System.Drawing.Size(70, 16);
            labelUnitPrice.TabIndex = 24;
            labelUnitPrice.Text = "Unit Price :";
            labelUnitPrice.Click += new System.EventHandler(this.dONGIALabel1_Click);
            // 
            // labelStaffID
            // 
            labelStaffID.AutoSize = true;
            labelStaffID.Location = new System.Drawing.Point(12, 83);
            labelStaffID.Name = "labelStaffID";
            labelStaffID.Size = new System.Drawing.Size(59, 16);
            labelStaffID.TabIndex = 25;
            labelStaffID.Text = "Staff ID :";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnUndo,
            this.btnRefresh,
            this.btnCHUYENCHINHANH,
            this.btnExit,
            this.btnThemChiTietDonDatHang,
            this.btnMENU,
            this.btnImportInvoice,
            this.btnImportInvoiceDetail});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnMENU, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Add";
            this.btnAdd.Enabled = false;
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAdd.ImageOptions.SvgImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 40);
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Delete";
            this.btnDelete.Enabled = false;
            this.btnDelete.Id = 1;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 0);
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Save";
            this.btnSave.Enabled = false;
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 0);
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGHI_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 3;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(100, 0);
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Caption = "Refresh";
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 0);
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnMENU
            // 
            this.btnMENU.Caption = "Options";
            this.btnMENU.Id = 8;
            this.btnMENU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMENU.ImageOptions.SvgImage")));
            this.btnMENU.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImportInvoice),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnImportInvoiceDetail)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnImportInvoice
            // 
            this.btnImportInvoice.Caption = "Import Invoice";
            this.btnImportInvoice.Id = 9;
            this.btnImportInvoice.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportInvoice.ImageOptions.SvgImage")));
            this.btnImportInvoice.Name = "btnImportInvoice";
            this.btnImportInvoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImportInvoice_ItemClick);
            // 
            // btnImportInvoiceDetail
            // 
            this.btnImportInvoiceDetail.Caption = "Import Invoice Detail";
            this.btnImportInvoiceDetail.Id = 10;
            this.btnImportInvoiceDetail.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnImportInvoiceDetail.ImageOptions.SvgImage")));
            this.btnImportInvoiceDetail.Name = "btnImportInvoiceDetail";
            this.btnImportInvoiceDetail.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnImportInvoiceDetail_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 6;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 0);
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlTop.Size = new System.Drawing.Size(1082, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 752);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1082, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 702);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1082, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 702);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 5;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // btnThemChiTietDonDatHang
            // 
            this.btnThemChiTietDonDatHang.Caption = "Thêm Chi Tiết Đơn Đặt Hàng";
            this.btnThemChiTietDonDatHang.Id = 7;
            this.btnThemChiTietDonDatHang.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThemChiTietDonDatHang.ImageOptions.SvgImage")));
            this.btnThemChiTietDonDatHang.Name = "btnThemChiTietDonDatHang";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbBranch);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1082, 69);
            this.panelControl1.TabIndex = 6;
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.Enabled = false;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(166, 20);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(8);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(362, 24);
            this.cmbBranch.TabIndex = 1;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Branch";
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "PhieuNhap";
            this.bdsPhieuNhap.DataSource = this.dataSet;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcPhieuNhap
            // 
            this.gcPhieuNhap.DataSource = this.bdsPhieuNhap;
            this.gcPhieuNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcPhieuNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcPhieuNhap.Enabled = false;
            this.gcPhieuNhap.Location = new System.Drawing.Point(0, 119);
            this.gcPhieuNhap.MainView = this.gridView1;
            this.gcPhieuNhap.Margin = new System.Windows.Forms.Padding(6);
            this.gcPhieuNhap.MenuManager = this.barManager1;
            this.gcPhieuNhap.Name = "gcPhieuNhap";
            this.gcPhieuNhap.Size = new System.Drawing.Size(1082, 210);
            this.gcPhieuNhap.TabIndex = 7;
            this.gcPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY,
            this.colMasoDDH,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.DetailHeight = 682;
            this.gridView1.GridControl = this.gcPhieuNhap;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNGAY, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "Import Invoice ID";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.MinWidth = 31;
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.OptionsColumn.AllowEdit = false;
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            this.colMAPN.Width = 117;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Day";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 31;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 117;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Order ID";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 31;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.AllowEdit = false;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 2;
            this.colMasoDDH.Width = 117;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Staff ID";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 31;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 117;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "Material ID";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 31;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 117;
            // 
            // gcDDH
            // 
            this.gcDDH.Controls.Add(this.gcChiTietPhieuNhap);
            this.gcDDH.Controls.Add(this.groupBoxPhieuNhap);
            this.gcDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDDH.Location = new System.Drawing.Point(0, 329);
            this.gcDDH.Margin = new System.Windows.Forms.Padding(6);
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(1082, 423);
            this.gcDDH.TabIndex = 25;
            this.gcDDH.Text = "Order";
            // 
            // gcChiTietPhieuNhap
            // 
            this.gcChiTietPhieuNhap.DataSource = this.bdsChiTietPhieuNhap;
            this.gcChiTietPhieuNhap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietPhieuNhap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(6);
            this.gcChiTietPhieuNhap.Enabled = false;
            this.gcChiTietPhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.gcChiTietPhieuNhap.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcChiTietPhieuNhap.Location = new System.Drawing.Point(589, 28);
            this.gcChiTietPhieuNhap.MainView = this.gvCTDDH;
            this.gcChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(6);
            this.gcChiTietPhieuNhap.MenuManager = this.barManager1;
            this.gcChiTietPhieuNhap.Name = "gcChiTietPhieuNhap";
            this.gcChiTietPhieuNhap.Size = new System.Drawing.Size(491, 393);
            this.gcChiTietPhieuNhap.TabIndex = 1;
            this.gcChiTietPhieuNhap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            // 
            // bdsChiTietPhieuNhap
            // 
            this.bdsChiTietPhieuNhap.DataMember = "FK_CTPN_PhieuNhap";
            this.bdsChiTietPhieuNhap.DataSource = this.bdsPhieuNhap;
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.DetailHeight = 682;
            this.gvCTDDH.GridControl = this.gcChiTietPhieuNhap;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "Import Invoice ID";
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "Import Invoice Detail";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.MinWidth = 25;
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            this.colMAPN1.Width = 94;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Material ID";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 25;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 94;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Quantity";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 25;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 94;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Unit Price";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 25;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 94;
            // 
            // groupBoxPhieuNhap
            // 
            this.groupBoxPhieuNhap.Controls.Add(this.separatorControl1);
            this.groupBoxPhieuNhap.Controls.Add(this.btnEnterOrderDetail);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaterialID);
            this.groupBoxPhieuNhap.Controls.Add(labelStaffID);
            this.groupBoxPhieuNhap.Controls.Add(this.txtStaffID);
            this.groupBoxPhieuNhap.Controls.Add(labelUnitPrice);
            this.groupBoxPhieuNhap.Controls.Add(this.txtDonGiaChiTietPhieuNhap);
            this.groupBoxPhieuNhap.Controls.Add(labelQuantity);
            this.groupBoxPhieuNhap.Controls.Add(this.txtQuantity);
            this.groupBoxPhieuNhap.Controls.Add(mAVTLabel1);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaterialIDInvoice);
            this.groupBoxPhieuNhap.Controls.Add(this.btnEnterOrder);
            this.groupBoxPhieuNhap.Controls.Add(labelOrderID);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaDonDatHang);
            this.groupBoxPhieuNhap.Controls.Add(labelDay);
            this.groupBoxPhieuNhap.Controls.Add(this.dteDay);
            this.groupBoxPhieuNhap.Controls.Add(labelInvoiceID);
            this.groupBoxPhieuNhap.Controls.Add(this.txtIImvoiceID);
            this.groupBoxPhieuNhap.Controls.Add(dONGIALabel);
            this.groupBoxPhieuNhap.Controls.Add(this.txtDonGia);
            this.groupBoxPhieuNhap.Controls.Add(sOLUONGLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.txtSoLuong);
            this.groupBoxPhieuNhap.Controls.Add(this.btnChonVatTu);
            this.groupBoxPhieuNhap.Controls.Add(mAVTLabel);
            this.groupBoxPhieuNhap.Controls.Add(this.txtMaVatTu);
            this.groupBoxPhieuNhap.Controls.Add(labelMaterialID);
            this.groupBoxPhieuNhap.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxPhieuNhap.Location = new System.Drawing.Point(2, 28);
            this.groupBoxPhieuNhap.Margin = new System.Windows.Forms.Padding(6);
            this.groupBoxPhieuNhap.Name = "groupBoxPhieuNhap";
            this.groupBoxPhieuNhap.Padding = new System.Windows.Forms.Padding(6);
            this.groupBoxPhieuNhap.Size = new System.Drawing.Size(587, 393);
            this.groupBoxPhieuNhap.TabIndex = 0;
            this.groupBoxPhieuNhap.TabStop = false;
            this.groupBoxPhieuNhap.Text = "Information";
            this.groupBoxPhieuNhap.Enter += new System.EventHandler(this.groupBoxDonDatHang_Enter);
            // 
            // separatorControl1
            // 
            this.separatorControl1.Location = new System.Drawing.Point(64, 150);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Size = new System.Drawing.Size(462, 30);
            this.separatorControl1.TabIndex = 29;
            // 
            // btnEnterOrderDetail
            // 
            this.btnEnterOrderDetail.Enabled = false;
            this.btnEnterOrderDetail.Location = new System.Drawing.Point(353, 186);
            this.btnEnterOrderDetail.Name = "btnEnterOrderDetail";
            this.btnEnterOrderDetail.Size = new System.Drawing.Size(211, 48);
            this.btnEnterOrderDetail.TabIndex = 28;
            this.btnEnterOrderDetail.Text = "Enter Order Detail";
            this.btnEnterOrderDetail.UseVisualStyleBackColor = true;
            this.btnEnterOrderDetail.Click += new System.EventHandler(this.btnEnterOrderDetail_Click);
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuNhap, "MAKHO", true));
            this.txtMaterialID.Enabled = false;
            this.txtMaterialID.Location = new System.Drawing.Point(181, 120);
            this.txtMaterialID.MenuManager = this.barManager1;
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.Size = new System.Drawing.Size(131, 22);
            this.txtMaterialID.TabIndex = 27;
            // 
            // txtStaffID
            // 
            this.txtStaffID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MANV", true));
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Location = new System.Drawing.Point(181, 77);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(130, 23);
            this.txtStaffID.TabIndex = 26;
            // 
            // txtDonGiaChiTietPhieuNhap
            // 
            this.txtDonGiaChiTietPhieuNhap.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsChiTietPhieuNhap, "DONGIA", true));
            this.txtDonGiaChiTietPhieuNhap.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDonGiaChiTietPhieuNhap.Enabled = false;
            this.txtDonGiaChiTietPhieuNhap.Location = new System.Drawing.Point(179, 320);
            this.txtDonGiaChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.txtDonGiaChiTietPhieuNhap.MenuManager = this.barManager1;
            this.txtDonGiaChiTietPhieuNhap.Name = "txtDonGiaChiTietPhieuNhap";
            this.txtDonGiaChiTietPhieuNhap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGiaChiTietPhieuNhap.Properties.DisplayFormat.FormatString = "n0";
            this.txtDonGiaChiTietPhieuNhap.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGiaChiTietPhieuNhap.Properties.EditFormat.FormatString = "n0";
            this.txtDonGiaChiTietPhieuNhap.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDonGiaChiTietPhieuNhap.Properties.MaxValue = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.txtDonGiaChiTietPhieuNhap.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDonGiaChiTietPhieuNhap.Size = new System.Drawing.Size(130, 24);
            this.txtDonGiaChiTietPhieuNhap.TabIndex = 25;
            // 
            // txtQuantity
            // 
            this.txtQuantity.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsChiTietPhieuNhap, "SOLUONG", true));
            this.txtQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(179, 276);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5);
            this.txtQuantity.MenuManager = this.barManager1;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtQuantity.Properties.DisplayFormat.FormatString = "n0";
            this.txtQuantity.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantity.Properties.EditFormat.FormatString = "n0";
            this.txtQuantity.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtQuantity.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtQuantity.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Size = new System.Drawing.Size(131, 24);
            this.txtQuantity.TabIndex = 24;
            // 
            // txtMaterialIDInvoice
            // 
            this.txtMaterialIDInvoice.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsChiTietPhieuNhap, "MAVT", true));
            this.txtMaterialIDInvoice.Enabled = false;
            this.txtMaterialIDInvoice.Location = new System.Drawing.Point(180, 237);
            this.txtMaterialIDInvoice.Margin = new System.Windows.Forms.Padding(5);
            this.txtMaterialIDInvoice.MenuManager = this.barManager1;
            this.txtMaterialIDInvoice.Name = "txtMaterialIDInvoice";
            this.txtMaterialIDInvoice.Size = new System.Drawing.Size(130, 22);
            this.txtMaterialIDInvoice.TabIndex = 23;
            // 
            // btnEnterOrder
            // 
            this.btnEnterOrder.Enabled = false;
            this.btnEnterOrder.Location = new System.Drawing.Point(353, 94);
            this.btnEnterOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnterOrder.Name = "btnEnterOrder";
            this.btnEnterOrder.Size = new System.Drawing.Size(211, 48);
            this.btnEnterOrder.TabIndex = 22;
            this.btnEnterOrder.Text = "Enter Order";
            this.btnEnterOrder.UseVisualStyleBackColor = true;
            this.btnEnterOrder.Click += new System.EventHandler(this.btnEnterOrder_Click);
            // 
            // txtMaDonDatHang
            // 
            this.txtMaDonDatHang.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsPhieuNhap, "MasoDDH", true));
            this.txtMaDonDatHang.Enabled = false;
            this.txtMaDonDatHang.Location = new System.Drawing.Point(179, 186);
            this.txtMaDonDatHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDonDatHang.Name = "txtMaDonDatHang";
            this.txtMaDonDatHang.Size = new System.Drawing.Size(130, 23);
            this.txtMaDonDatHang.TabIndex = 21;
            // 
            // dteDay
            // 
            this.dteDay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuNhap, "NGAY", true));
            this.dteDay.EditValue = null;
            this.dteDay.Enabled = false;
            this.dteDay.Location = new System.Drawing.Point(399, 31);
            this.dteDay.Margin = new System.Windows.Forms.Padding(5);
            this.dteDay.MenuManager = this.barManager1;
            this.dteDay.Name = "dteDay";
            this.dteDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDay.Size = new System.Drawing.Size(165, 22);
            this.dteDay.TabIndex = 20;
            this.dteDay.EditValueChanged += new System.EventHandler(this.dteNgay_EditValueChanged);
            // 
            // txtIImvoiceID
            // 
            this.txtIImvoiceID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsPhieuNhap, "MAPN", true));
            this.txtIImvoiceID.Enabled = false;
            this.txtIImvoiceID.Location = new System.Drawing.Point(181, 31);
            this.txtIImvoiceID.Margin = new System.Windows.Forms.Padding(5);
            this.txtIImvoiceID.MenuManager = this.barManager1;
            this.txtIImvoiceID.Name = "txtIImvoiceID";
            this.txtIImvoiceID.Size = new System.Drawing.Size(129, 22);
            this.txtIImvoiceID.TabIndex = 19;
            // 
            // txtDonGia
            // 
            this.txtDonGia.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(360, 652);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(6);
            this.txtDonGia.MenuManager = this.barManager1;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDonGia.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtDonGia.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtDonGia.Size = new System.Drawing.Size(244, 24);
            this.txtDonGia.TabIndex = 17;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Enabled = false;
            this.txtSoLuong.Location = new System.Drawing.Point(360, 580);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(6);
            this.txtSoLuong.MenuManager = this.barManager1;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtSoLuong.Properties.DisplayFormat.FormatString = "n0";
            this.txtSoLuong.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoLuong.Properties.EditFormat.FormatString = "n0";
            this.txtSoLuong.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtSoLuong.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtSoLuong.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtSoLuong.Size = new System.Drawing.Size(244, 24);
            this.txtSoLuong.TabIndex = 15;
            // 
            // btnChonVatTu
            // 
            this.btnChonVatTu.Enabled = false;
            this.btnChonVatTu.Location = new System.Drawing.Point(662, 498);
            this.btnChonVatTu.Margin = new System.Windows.Forms.Padding(6);
            this.btnChonVatTu.Name = "btnChonVatTu";
            this.btnChonVatTu.Size = new System.Drawing.Size(232, 61);
            this.btnChonVatTu.TabIndex = 13;
            this.btnChonVatTu.Text = "Chọn Vật Tư";
            this.btnChonVatTu.UseVisualStyleBackColor = true;
            // 
            // txtMaVatTu
            // 
            this.txtMaVatTu.Enabled = false;
            this.txtMaVatTu.Location = new System.Drawing.Point(360, 506);
            this.txtMaVatTu.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaVatTu.MenuManager = this.barManager1;
            this.txtMaVatTu.Name = "txtMaVatTu";
            this.txtMaVatTu.Size = new System.Drawing.Size(244, 22);
            this.txtMaVatTu.TabIndex = 12;
            // 
            // chiTietPhieuNhapTableAdapter
            // 
            this.chiTietPhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // FrmImportInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 772);
            this.Controls.Add(this.gcDDH);
            this.Controls.Add(this.gcPhieuNhap);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmImportInvoice";
            this.Text = "Import Invoice";
            this.Load += new System.EventHandler(this.FrmImportInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            this.gcDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietPhieuNhap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            this.groupBoxPhieuNhap.ResumeLayout(false);
            this.groupBoxPhieuNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGiaChiTietPhieuNhap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialIDInvoice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIImvoiceID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaVatTu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRefresh;
        public DevExpress.XtraBars.BarSubItem btnMENU;
        private DevExpress.XtraBars.BarButtonItem btnImportInvoice;
        private DevExpress.XtraBars.BarButtonItem btnImportInvoiceDetail;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnThemChiTietDonDatHang;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DataSet dataSet;
        private DataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl gcDDH;
        private DevExpress.XtraGrid.GridControl gcChiTietPhieuNhap;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private System.Windows.Forms.GroupBox groupBoxPhieuNhap;
        private DevExpress.XtraEditors.SpinEdit txtDonGia;
        private DevExpress.XtraEditors.SpinEdit txtSoLuong;
        private System.Windows.Forms.Button btnChonVatTu;
        private DevExpress.XtraEditors.TextEdit txtMaVatTu;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private System.Windows.Forms.BindingSource bdsChiTietPhieuNhap;
        private DataSetTableAdapters.CTPNTableAdapter chiTietPhieuNhapTableAdapter;
        private System.Windows.Forms.Button btnEnterOrder;
        private System.Windows.Forms.TextBox txtMaDonDatHang;
        private DevExpress.XtraEditors.DateEdit dteDay;
        private DevExpress.XtraEditors.TextEdit txtIImvoiceID;
        private DevExpress.XtraEditors.SpinEdit txtDonGiaChiTietPhieuNhap;
        private DevExpress.XtraEditors.SpinEdit txtQuantity;
        private DevExpress.XtraEditors.TextEdit txtMaterialIDInvoice;
        private System.Windows.Forms.TextBox txtStaffID;
        private DevExpress.XtraEditors.TextEdit txtMaterialID;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.Button btnEnterOrderDetail;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
    }
}