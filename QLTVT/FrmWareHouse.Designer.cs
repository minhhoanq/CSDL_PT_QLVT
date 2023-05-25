
namespace QLTVT
{
    partial class FrmWareHouse
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
            System.Windows.Forms.Label labelWareHouseID;
            System.Windows.Forms.Label labelWareHouseName;
            System.Windows.Forms.Label labelAddress;
            System.Windows.Forms.Label labelBranchID;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWareHouse));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnCHUYENCHINHANH = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.dataSet = new QLTVT.DataSet();
            this.bdsKho = new System.Windows.Forms.BindingSource(this.components);
            this.khoTableAdapter = new QLTVT.DataSetTableAdapters.KhoTableAdapter();
            this.tableAdapterManager = new QLTVT.DataSetTableAdapters.TableAdapterManager();
            this.gcKHO = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelNhapLieu = new DevExpress.XtraEditors.GroupControl();
            this.txtBranchID = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.txtWareHouseName = new DevExpress.XtraEditors.TextEdit();
            this.txtWareHouseID = new DevExpress.XtraEditors.TextEdit();
            this.bdsPHIEUXUAT = new System.Windows.Forms.BindingSource(this.components);
            this.phieuXuatTableAdapter = new QLTVT.DataSetTableAdapters.PhieuXuatTableAdapter();
            this.bdsPHIEUNHAP = new System.Windows.Forms.BindingSource(this.components);
            this.phieuNhapTableAdapter = new QLTVT.DataSetTableAdapters.PhieuNhapTableAdapter();
            this.bdsDATHANG = new System.Windows.Forms.BindingSource(this.components);
            this.datHangTableAdapter = new QLTVT.DataSetTableAdapters.DatHangTableAdapter();
            labelWareHouseID = new System.Windows.Forms.Label();
            labelWareHouseName = new System.Windows.Forms.Label();
            labelAddress = new System.Windows.Forms.Label();
            labelBranchID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).BeginInit();
            this.panelNhapLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUXUAT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUNHAP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDATHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWareHouseID
            // 
            labelWareHouseID.AutoSize = true;
            labelWareHouseID.Location = new System.Drawing.Point(115, 83);
            labelWareHouseID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            labelWareHouseID.Name = "labelWareHouseID";
            labelWareHouseID.Size = new System.Drawing.Size(98, 16);
            labelWareHouseID.TabIndex = 0;
            labelWareHouseID.Text = "WareHouse ID :";
            // 
            // labelWareHouseName
            // 
            labelWareHouseName.AutoSize = true;
            labelWareHouseName.Location = new System.Drawing.Point(545, 83);
            labelWareHouseName.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            labelWareHouseName.Name = "labelWareHouseName";
            labelWareHouseName.Size = new System.Drawing.Size(119, 16);
            labelWareHouseName.TabIndex = 2;
            labelWareHouseName.Text = "WareHouse Name :";
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new System.Drawing.Point(116, 142);
            labelAddress.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new System.Drawing.Size(62, 16);
            labelAddress.TabIndex = 4;
            labelAddress.Text = "Address :";
            // 
            // labelBranchID
            // 
            labelBranchID.AutoSize = true;
            labelBranchID.Location = new System.Drawing.Point(545, 142);
            labelBranchID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            labelBranchID.Name = "labelBranchID";
            labelBranchID.Size = new System.Drawing.Size(71, 16);
            labelBranchID.TabIndex = 6;
            labelBranchID.Text = "Branch ID :";
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
            this.btnExit});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.btnAdd.Caption = "Add";
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
            this.btnRefresh.Id = 4;
            this.btnRefresh.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRefresh.ImageOptions.SvgImage")));
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 0);
            this.btnRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRefresh_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Border = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
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
            this.barDockControlTop.Size = new System.Drawing.Size(1019, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 603);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlBottom.Size = new System.Drawing.Size(1019, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 553);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1019, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 553);
            // 
            // btnCHUYENCHINHANH
            // 
            this.btnCHUYENCHINHANH.Caption = "Chuyển Chi Nhánh";
            this.btnCHUYENCHINHANH.Id = 5;
            this.btnCHUYENCHINHANH.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnCHUYENCHINHANH.ImageOptions.SvgImage")));
            this.btnCHUYENCHINHANH.Name = "btnCHUYENCHINHANH";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.cmbBranch);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(8);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1019, 105);
            this.panelControl1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Branch";
            // 
            // cmbBranch
            // 
            this.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranch.Enabled = false;
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(152, 39);
            this.cmbBranch.Margin = new System.Windows.Forms.Padding(8);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(432, 24);
            this.cmbBranch.TabIndex = 1;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKho
            // 
            this.bdsKho.DataMember = "Kho";
            this.bdsKho.DataSource = this.dataSet;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = null;
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = null;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLTVT.DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // gcKHO
            // 
            this.gcKHO.DataSource = this.bdsKho;
            this.gcKHO.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKHO.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(8);
            this.gcKHO.Location = new System.Drawing.Point(0, 155);
            this.gcKHO.MainView = this.gridView1;
            this.gcKHO.Margin = new System.Windows.Forms.Padding(8);
            this.gcKHO.MenuManager = this.barManager1;
            this.gcKHO.Name = "gcKHO";
            this.gcKHO.Size = new System.Drawing.Size(1019, 235);
            this.gcKHO.TabIndex = 6;
            this.gcKHO.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAKHO,
            this.colTENKHO,
            this.colDIACHI,
            this.colMACN});
            this.gridView1.DetailHeight = 852;
            this.gridView1.GridControl = this.gcKHO;
            this.gridView1.Name = "gridView1";
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "WareHouse ID";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.MinWidth = 61;
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.OptionsColumn.AllowEdit = false;
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 0;
            this.colMAKHO.Width = 227;
            // 
            // colTENKHO
            // 
            this.colTENKHO.Caption = "WareHouse Name";
            this.colTENKHO.FieldName = "TENKHO";
            this.colTENKHO.MinWidth = 61;
            this.colTENKHO.Name = "colTENKHO";
            this.colTENKHO.OptionsColumn.AllowEdit = false;
            this.colTENKHO.Visible = true;
            this.colTENKHO.VisibleIndex = 1;
            this.colTENKHO.Width = 227;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Address";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 61;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.OptionsColumn.AllowEdit = false;
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 2;
            this.colDIACHI.Width = 227;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Branch ID";
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 61;
            this.colMACN.Name = "colMACN";
            this.colMACN.OptionsColumn.AllowEdit = false;
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            this.colMACN.Width = 227;
            // 
            // panelNhapLieu
            // 
            this.panelNhapLieu.Controls.Add(labelBranchID);
            this.panelNhapLieu.Controls.Add(this.txtBranchID);
            this.panelNhapLieu.Controls.Add(labelAddress);
            this.panelNhapLieu.Controls.Add(this.txtAddress);
            this.panelNhapLieu.Controls.Add(labelWareHouseName);
            this.panelNhapLieu.Controls.Add(this.txtWareHouseName);
            this.panelNhapLieu.Controls.Add(labelWareHouseID);
            this.panelNhapLieu.Controls.Add(this.txtWareHouseID);
            this.panelNhapLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhapLieu.Location = new System.Drawing.Point(0, 390);
            this.panelNhapLieu.Margin = new System.Windows.Forms.Padding(8);
            this.panelNhapLieu.Name = "panelNhapLieu";
            this.panelNhapLieu.Size = new System.Drawing.Size(1019, 213);
            this.panelNhapLieu.TabIndex = 11;
            this.panelNhapLieu.Text = "INFOMATION";
            // 
            // txtBranchID
            // 
            this.txtBranchID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "MACN", true));
            this.txtBranchID.Enabled = false;
            this.txtBranchID.Location = new System.Drawing.Point(692, 139);
            this.txtBranchID.Margin = new System.Windows.Forms.Padding(8);
            this.txtBranchID.MenuManager = this.barManager1;
            this.txtBranchID.Name = "txtBranchID";
            this.txtBranchID.Size = new System.Drawing.Size(157, 22);
            this.txtBranchID.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "DIACHI", true));
            this.txtAddress.Location = new System.Drawing.Point(245, 139);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(8);
            this.txtAddress.MenuManager = this.barManager1;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(214, 22);
            this.txtAddress.TabIndex = 5;
            // 
            // txtWareHouseName
            // 
            this.txtWareHouseName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "TENKHO", true));
            this.txtWareHouseName.Location = new System.Drawing.Point(692, 82);
            this.txtWareHouseName.Margin = new System.Windows.Forms.Padding(8);
            this.txtWareHouseName.MenuManager = this.barManager1;
            this.txtWareHouseName.Name = "txtWareHouseName";
            this.txtWareHouseName.Size = new System.Drawing.Size(157, 22);
            this.txtWareHouseName.TabIndex = 3;
            // 
            // txtWareHouseID
            // 
            this.txtWareHouseID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKho, "MAKHO", true));
            this.txtWareHouseID.Location = new System.Drawing.Point(245, 80);
            this.txtWareHouseID.Margin = new System.Windows.Forms.Padding(8);
            this.txtWareHouseID.MenuManager = this.barManager1;
            this.txtWareHouseID.Name = "txtWareHouseID";
            this.txtWareHouseID.Size = new System.Drawing.Size(112, 22);
            this.txtWareHouseID.TabIndex = 1;
            // 
            // bdsPHIEUXUAT
            // 
            this.bdsPHIEUXUAT.DataMember = "FK_PhieuXuat_Kho";
            this.bdsPHIEUXUAT.DataSource = this.bdsKho;
            // 
            // phieuXuatTableAdapter
            // 
            this.phieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // bdsPHIEUNHAP
            // 
            this.bdsPHIEUNHAP.DataMember = "FK_PhieuNhap_Kho";
            this.bdsPHIEUNHAP.DataSource = this.bdsKho;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDATHANG
            // 
            this.bdsDATHANG.DataMember = "FK_DatHang_Kho";
            this.bdsDATHANG.DataSource = this.bdsKho;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // FrmWareHouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 623);
            this.Controls.Add(this.panelNhapLieu);
            this.Controls.Add(this.gcKHO);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FrmWareHouse";
            this.Text = "WareHouse";
            this.Load += new System.EventHandler(this.FormKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelNhapLieu)).EndInit();
            this.panelNhapLieu.ResumeLayout(false);
            this.panelNhapLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWareHouseID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUXUAT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsPHIEUNHAP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDATHANG)).EndInit();
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
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.BindingSource bdsKho;
        private DataSet dataSet;
        private DataSetTableAdapters.KhoTableAdapter khoTableAdapter;
        private DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcKHO;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTENKHO;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraEditors.GroupControl panelNhapLieu;
        private DevExpress.XtraEditors.TextEdit txtBranchID;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtWareHouseName;
        private DevExpress.XtraEditors.TextEdit txtWareHouseID;
        private System.Windows.Forms.BindingSource bdsPHIEUXUAT;
        private DataSetTableAdapters.PhieuXuatTableAdapter phieuXuatTableAdapter;
        private System.Windows.Forms.BindingSource bdsPHIEUNHAP;
        private DataSetTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource bdsDATHANG;
        private DataSetTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private System.Windows.Forms.Label label2;
    }
}