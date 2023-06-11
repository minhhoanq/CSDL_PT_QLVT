
namespace QLTVT
{
    partial class FrmTheOrder
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
            System.Windows.Forms.Label labelTheOrderID;
            System.Windows.Forms.Label labelDay;
            System.Windows.Forms.Label labelSupplier;
            System.Windows.Forms.Label labelStaffID;
            System.Windows.Forms.Label labelWareHouseID;
            System.Windows.Forms.Label labelMaterialID;
            System.Windows.Forms.Label labelQuantity;
            System.Windows.Forms.Label labelUnitPrice;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTheOrder));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnMENU = new DevExpress.XtraBars.BarSubItem();
            this.btnOrderOption = new DevExpress.XtraBars.BarButtonItem();
            this.btnOrderDetailOption = new DevExpress.XtraBars.BarButtonItem();
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
            this.bdsDonDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.donDatHangTableAdapter = new QLTVT.DataSetTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.chiTietDonDatHangTableAdapter = new QLTVT.DataSetTableAdapters.CTDDHTableAdapter();
            this.gcDonDatHang = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcDDH = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcChiTietDonDatHang = new DevExpress.XtraGrid.GridControl();
            this.bdsChiTietDonDatHang = new System.Windows.Forms.BindingSource(this.components);
            this.gvCTDDH = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.txtStaffID = new DevExpress.XtraEditors.TextEdit();
            this.txtWareHouseID = new System.Windows.Forms.TextBox();
            this.btnEnterWHouse = new System.Windows.Forms.Button();
            this.txtSupplier = new DevExpress.XtraEditors.TextEdit();
            this.dteDay = new DevExpress.XtraEditors.DateEdit();
            this.txtTheOrderID = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaterialID = new DevExpress.XtraEditors.TextEdit();
            this.btnEnterMaterial = new System.Windows.Forms.Button();
            this.txtUnitPrice = new DevExpress.XtraEditors.SpinEdit();
            this.txtQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.bdsPhieuNhap = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter();
            labelTheOrderID = new System.Windows.Forms.Label();
            labelDay = new System.Windows.Forms.Label();
            labelSupplier = new System.Windows.Forms.Label();
            labelStaffID = new System.Windows.Forms.Label();
            labelWareHouseID = new System.Windows.Forms.Label();
            labelMaterialID = new System.Windows.Forms.Label();
            labelQuantity = new System.Windows.Forms.Label();
            labelUnitPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).BeginInit();
            this.gcDDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDonDatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheOrderID.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTheOrderID
            // 
            labelTheOrderID.AutoSize = true;
            labelTheOrderID.Location = new System.Drawing.Point(31, 32);
            labelTheOrderID.Name = "labelTheOrderID";
            labelTheOrderID.Size = new System.Drawing.Size(82, 16);
            labelTheOrderID.TabIndex = 0;
            labelTheOrderID.Text = "The Order ID";
            // 
            // labelDay
            // 
            labelDay.AutoSize = true;
            labelDay.Location = new System.Drawing.Point(31, 58);
            labelDay.Name = "labelDay";
            labelDay.Size = new System.Drawing.Size(28, 16);
            labelDay.TabIndex = 2;
            labelDay.Text = "Day";
            // 
            // labelSupplier
            // 
            labelSupplier.AutoSize = true;
            labelSupplier.Location = new System.Drawing.Point(31, 90);
            labelSupplier.Name = "labelSupplier";
            labelSupplier.Size = new System.Drawing.Size(54, 16);
            labelSupplier.TabIndex = 4;
            labelSupplier.Text = "Supplier";
            // 
            // labelStaffID
            // 
            labelStaffID.AutoSize = true;
            labelStaffID.Location = new System.Drawing.Point(31, 117);
            labelStaffID.Name = "labelStaffID";
            labelStaffID.Size = new System.Drawing.Size(50, 16);
            labelStaffID.TabIndex = 6;
            labelStaffID.Text = "Staff ID";
            // 
            // labelWareHouseID
            // 
            labelWareHouseID.AutoSize = true;
            labelWareHouseID.Location = new System.Drawing.Point(31, 148);
            labelWareHouseID.Name = "labelWareHouseID";
            labelWareHouseID.Size = new System.Drawing.Size(89, 16);
            labelWareHouseID.TabIndex = 8;
            labelWareHouseID.Text = "WareHouse ID";
            // 
            // labelMaterialID
            // 
            labelMaterialID.AutoSize = true;
            labelMaterialID.Location = new System.Drawing.Point(31, 40);
            labelMaterialID.Name = "labelMaterialID";
            labelMaterialID.Size = new System.Drawing.Size(82, 16);
            labelMaterialID.TabIndex = 11;
            labelMaterialID.Text = "Material ID : ";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Location = new System.Drawing.Point(31, 81);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new System.Drawing.Size(67, 16);
            labelQuantity.TabIndex = 14;
            labelQuantity.Text = "Quantity : ";
            // 
            // labelUnitPrice
            // 
            labelUnitPrice.AutoSize = true;
            labelUnitPrice.Location = new System.Drawing.Point(32, 121);
            labelUnitPrice.Name = "labelUnitPrice";
            labelUnitPrice.Size = new System.Drawing.Size(61, 16);
            labelUnitPrice.TabIndex = 16;
            labelUnitPrice.Text = "Unit Price";
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
            this.btnOrderOption,
            this.btnOrderDetailOption});
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
            this.btnAdd.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
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
            this.btnDelete.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
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
            this.btnSave.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnSave.Caption = "Save";
            this.btnSave.Enabled = false;
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 0);
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
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
            this.btnRefresh.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
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
            this.btnMENU.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnMENU.Caption = "Options";
            this.btnMENU.Id = 8;
            this.btnMENU.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMENU.ImageOptions.SvgImage")));
            this.btnMENU.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOrderOption),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnOrderDetailOption)});
            this.btnMENU.Name = "btnMENU";
            // 
            // btnOrderOption
            // 
            this.btnOrderOption.Caption = "Order Option";
            this.btnOrderOption.Id = 9;
            this.btnOrderOption.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOrderOption.ImageOptions.SvgImage")));
            this.btnOrderOption.Name = "btnOrderOption";
            this.btnOrderOption.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOrderOption_ItemClick);
            // 
            // btnOrderDetailOption
            // 
            this.btnOrderDetailOption.Caption = "Order Detail Option";
            this.btnOrderDetailOption.Id = 10;
            this.btnOrderDetailOption.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOrderDetailOption.ImageOptions.SvgImage")));
            this.btnOrderDetailOption.Name = "btnOrderDetailOption";
            this.btnOrderDetailOption.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOrderDetailOption_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnExit.Caption = "Exit";
            this.btnExit.Id = 6;
            this.btnExit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnExit.ImageOptions.SvgImage")));
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 0);
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTHOAT_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(1007, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 719);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1007, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 669);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1007, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 669);
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
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1007, 68);
            this.panelControl1.TabIndex = 5;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.Enabled = false;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(188, 25);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(316, 24);
            this.cmbBranch.TabIndex = 1;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 24);
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
            // bdsDonDatHang
            // 
            this.bdsDonDatHang.DataMember = "DatHang";
            this.bdsDonDatHang.DataSource = this.dataSet;
            // 
            // donDatHangTableAdapter
            // 
            this.donDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.chiTietDonDatHangTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.donDatHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // chiTietDonDatHangTableAdapter
            // 
            this.chiTietDonDatHangTableAdapter.ClearBeforeFill = true;
            // 
            // gcDonDatHang
            // 
            this.gcDonDatHang.DataSource = this.bdsDonDatHang;
            this.gcDonDatHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcDonDatHang.Enabled = false;
            this.gcDonDatHang.Location = new System.Drawing.Point(0, 118);
            this.gcDonDatHang.MainView = this.gridView1;
            this.gcDonDatHang.MenuManager = this.barManager1;
            this.gcDonDatHang.Name = "gcDonDatHang";
            this.gcDonDatHang.Size = new System.Drawing.Size(1007, 197);
            this.gcDonDatHang.TabIndex = 6;
            this.gcDonDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.gcDonDatHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.ViewCaption = "Đơn Đặt Hàng";
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "The Order ID";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.MinWidth = 25;
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.OptionsColumn.AllowEdit = false;
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            this.colMasoDDH.Width = 94;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "Day";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.MinWidth = 25;
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.OptionsColumn.AllowEdit = false;
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            this.colNGAY.Width = 94;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Supplier";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.MinWidth = 25;
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.OptionsColumn.AllowEdit = false;
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            this.colNhaCC.Width = 94;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Staff ID";
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 25;
            this.colMANV.Name = "colMANV";
            this.colMANV.OptionsColumn.AllowEdit = false;
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            this.colMANV.Width = 94;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "WareHouse ID";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 25;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            this.colMAKHO.Width = 94;
            // 
            // gcDDH
            // 
            this.gcDDH.Controls.Add(this.panelControl3);
            this.gcDDH.Controls.Add(this.panelControl2);
            this.gcDDH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDDH.Location = new System.Drawing.Point(0, 315);
            this.gcDDH.Name = "gcDDH";
            this.gcDDH.Size = new System.Drawing.Size(1007, 404);
            this.gcDDH.TabIndex = 24;
            this.gcDDH.Text = "Infomation";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcChiTietDonDatHang);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(490, 28);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(515, 374);
            this.panelControl3.TabIndex = 4;
            // 
            // gcChiTietDonDatHang
            // 
            this.gcChiTietDonDatHang.DataSource = this.bdsChiTietDonDatHang;
            this.gcChiTietDonDatHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcChiTietDonDatHang.Enabled = false;
            this.gcChiTietDonDatHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcChiTietDonDatHang.Location = new System.Drawing.Point(2, 2);
            this.gcChiTietDonDatHang.MainView = this.gvCTDDH;
            this.gcChiTietDonDatHang.MenuManager = this.barManager1;
            this.gcChiTietDonDatHang.Name = "gcChiTietDonDatHang";
            this.gcChiTietDonDatHang.Size = new System.Drawing.Size(511, 370);
            this.gcChiTietDonDatHang.TabIndex = 1;
            this.gcChiTietDonDatHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCTDDH});
            // 
            // bdsChiTietDonDatHang
            // 
            this.bdsChiTietDonDatHang.DataMember = "FK_CTDDH_DatHang";
            this.bdsChiTietDonDatHang.DataSource = this.bdsDonDatHang;
            // 
            // gvCTDDH
            // 
            this.gvCTDDH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gvCTDDH.GridControl = this.gcChiTietDonDatHang;
            this.gvCTDDH.Name = "gvCTDDH";
            this.gvCTDDH.OptionsBehavior.Editable = false;
            this.gvCTDDH.OptionsView.ShowGroupPanel = false;
            this.gvCTDDH.OptionsView.ShowViewCaption = true;
            this.gvCTDDH.ViewCaption = "The Order Detail";
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.Caption = "The Order ID";
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.MinWidth = 23;
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            this.colMasoDDH1.Width = 87;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "Material ID";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.MinWidth = 23;
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            this.colMAVT.Width = 87;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "Quantity";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.MinWidth = 23;
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            this.colSOLUONG.Width = 87;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "Unit Price";
            this.colDONGIA.DisplayFormat.FormatString = "VND {0:n2}";
            this.colDONGIA.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.MinWidth = 23;
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            this.colDONGIA.Width = 87;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupBoxOrder);
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 28);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(488, 374);
            this.panelControl2.TabIndex = 3;
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.txtStaffID);
            this.groupBoxOrder.Controls.Add(this.txtWareHouseID);
            this.groupBoxOrder.Controls.Add(this.btnEnterWHouse);
            this.groupBoxOrder.Controls.Add(labelWareHouseID);
            this.groupBoxOrder.Controls.Add(labelStaffID);
            this.groupBoxOrder.Controls.Add(labelSupplier);
            this.groupBoxOrder.Controls.Add(this.txtSupplier);
            this.groupBoxOrder.Controls.Add(labelDay);
            this.groupBoxOrder.Controls.Add(this.dteDay);
            this.groupBoxOrder.Controls.Add(labelTheOrderID);
            this.groupBoxOrder.Controls.Add(this.txtTheOrderID);
            this.groupBoxOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxOrder.Location = new System.Drawing.Point(2, 2);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(484, 179);
            this.groupBoxOrder.TabIndex = 0;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Order";
            // 
            // txtStaffID
            // 
            this.txtStaffID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "MANV", true));
            this.txtStaffID.Enabled = false;
            this.txtStaffID.Location = new System.Drawing.Point(184, 112);
            this.txtStaffID.MenuManager = this.barManager1;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(125, 22);
            this.txtStaffID.TabIndex = 19;
            // 
            // txtWareHouseID
            // 
            this.txtWareHouseID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsDonDatHang, "MAKHO", true));
            this.txtWareHouseID.Enabled = false;
            this.txtWareHouseID.Location = new System.Drawing.Point(184, 142);
            this.txtWareHouseID.Name = "txtWareHouseID";
            this.txtWareHouseID.Size = new System.Drawing.Size(125, 23);
            this.txtWareHouseID.TabIndex = 18;
            // 
            // btnEnterWHouse
            // 
            this.btnEnterWHouse.Enabled = false;
            this.btnEnterWHouse.Location = new System.Drawing.Point(349, 139);
            this.btnEnterWHouse.Name = "btnEnterWHouse";
            this.btnEnterWHouse.Size = new System.Drawing.Size(150, 29);
            this.btnEnterWHouse.TabIndex = 10;
            this.btnEnterWHouse.Text = "Enter WareHouse";
            this.btnEnterWHouse.UseVisualStyleBackColor = true;
            this.btnEnterWHouse.Click += new System.EventHandler(this.btnEnterWHouse_Click);
            // 
            // txtSupplier
            // 
            this.txtSupplier.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "NhaCC", true));
            this.txtSupplier.Enabled = false;
            this.txtSupplier.Location = new System.Drawing.Point(184, 85);
            this.txtSupplier.MenuManager = this.barManager1;
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(125, 22);
            this.txtSupplier.TabIndex = 5;
            // 
            // dteDay
            // 
            this.dteDay.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "NGAY", true));
            this.dteDay.EditValue = null;
            this.dteDay.Enabled = false;
            this.dteDay.Location = new System.Drawing.Point(184, 55);
            this.dteDay.MenuManager = this.barManager1;
            this.dteDay.Name = "dteDay";
            this.dteDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteDay.Size = new System.Drawing.Size(165, 22);
            this.dteDay.TabIndex = 3;
            // 
            // txtTheOrderID
            // 
            this.txtTheOrderID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsDonDatHang, "MasoDDH", true));
            this.txtTheOrderID.Enabled = false;
            this.txtTheOrderID.Location = new System.Drawing.Point(184, 29);
            this.txtTheOrderID.MenuManager = this.barManager1;
            this.txtTheOrderID.Name = "txtTheOrderID";
            this.txtTheOrderID.Size = new System.Drawing.Size(125, 22);
            this.txtTheOrderID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaterialID);
            this.groupBox1.Controls.Add(labelMaterialID);
            this.groupBox1.Controls.Add(labelUnitPrice);
            this.groupBox1.Controls.Add(this.btnEnterMaterial);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(labelQuantity);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(2, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 222);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Detail";
            // 
            // txtMaterialID
            // 
            this.txtMaterialID.Enabled = false;
            this.txtMaterialID.Location = new System.Drawing.Point(184, 37);
            this.txtMaterialID.MenuManager = this.barManager1;
            this.txtMaterialID.Name = "txtMaterialID";
            this.txtMaterialID.Size = new System.Drawing.Size(125, 22);
            this.txtMaterialID.TabIndex = 12;
            // 
            // btnEnterMaterial
            // 
            this.btnEnterMaterial.Enabled = false;
            this.btnEnterMaterial.Location = new System.Drawing.Point(349, 40);
            this.btnEnterMaterial.Name = "btnEnterMaterial";
            this.btnEnterMaterial.Size = new System.Drawing.Size(119, 31);
            this.btnEnterMaterial.TabIndex = 13;
            this.btnEnterMaterial.Text = "Enter Material";
            this.btnEnterMaterial.UseVisualStyleBackColor = true;
            this.btnEnterMaterial.Click += new System.EventHandler(this.btnEnterMaterial_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(184, 114);
            this.txtUnitPrice.MenuManager = this.barManager1;
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtUnitPrice.Properties.MaxValue = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.txtUnitPrice.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtUnitPrice.Size = new System.Drawing.Size(125, 24);
            this.txtUnitPrice.TabIndex = 17;
            // 
            // txtQuantity
            // 
            this.txtQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(184, 77);
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
            this.txtQuantity.Size = new System.Drawing.Size(125, 24);
            this.txtQuantity.TabIndex = 15;
            this.txtQuantity.EditValueChanged += new System.EventHandler(this.sOLUONGSpinEdit_EditValueChanged);
            // 
            // bdsPhieuNhap
            // 
            this.bdsPhieuNhap.DataMember = "FK_PhieuNhap_DatHang";
            this.bdsPhieuNhap.DataSource = this.bdsDonDatHang;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTheOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 739);
            this.Controls.Add(this.gcDDH);
            this.Controls.Add(this.gcDonDatHang);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmTheOrder";
            this.Text = "The Order";
            this.Load += new System.EventHandler(this.FrmTheOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDDH)).EndInit();
            this.gcDDH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcChiTietDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsChiTietDonDatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCTDDH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSupplier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteDay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTheOrderID.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaterialID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUnitPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPhieuNhap)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnCHUYENCHINHANH;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.BindingSource bdsDonDatHang;
        private DataSet dataSet;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label label1;
        private DataSetTableAdapters.DatHangTableAdapter donDatHangTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.GroupControl gcDDH;
        private DevExpress.XtraGrid.GridControl gcChiTietDonDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCTDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private DevExpress.XtraGrid.GridControl gcDonDatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DataSetTableAdapters.CTDDHTableAdapter chiTietDonDatHangTableAdapter;
        private System.Windows.Forms.Button btnEnterWHouse;
        private DevExpress.XtraEditors.TextEdit txtSupplier;
        private DevExpress.XtraEditors.DateEdit dteDay;
        private DevExpress.XtraEditors.TextEdit txtTheOrderID;
        private DevExpress.XtraBars.BarButtonItem btnThemChiTietDonDatHang;
        private DevExpress.XtraBars.BarButtonItem btnOrderOption;
        private DevExpress.XtraBars.BarButtonItem btnOrderDetailOption;
        private DevExpress.XtraEditors.SpinEdit txtQuantity;
        private System.Windows.Forms.Button btnEnterMaterial;
        private DevExpress.XtraEditors.TextEdit txtMaterialID;
        private DevExpress.XtraEditors.SpinEdit txtUnitPrice;
        public DevExpress.XtraBars.BarSubItem btnMENU;
        public System.Windows.Forms.TextBox txtWareHouseID;
        private DevExpress.XtraEditors.TextEdit txtStaffID;
        private System.Windows.Forms.BindingSource bdsPhieuNhap;
        private DataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsChiTietDonDatHang;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}