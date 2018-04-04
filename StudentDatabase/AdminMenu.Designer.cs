namespace StudentDatabase
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addPatient = new DevExpress.XtraBars.BarButtonItem();
            this.refreshButton = new DevExpress.XtraBars.BarButtonItem();
            this.saveChanges = new DevExpress.XtraBars.BarButtonItem();
            this.deleteButtonP = new DevExpress.XtraBars.BarButtonItem();
            this.refreshUbezp = new DevExpress.XtraBars.BarButtonItem();
            this.addICD = new DevExpress.XtraBars.BarButtonItem();
            this.refreshICD = new DevExpress.XtraBars.BarButtonItem();
            this.saveChangesICD = new DevExpress.XtraBars.BarButtonItem();
            this.addVisit = new DevExpress.XtraBars.BarButtonItem();
            this.refreshVisit = new DevExpress.XtraBars.BarButtonItem();
            this.deleteButtonU = new DevExpress.XtraBars.BarButtonItem();
            this.deleteButtonI = new DevExpress.XtraBars.BarButtonItem();
            this.deleteButtonW = new DevExpress.XtraBars.BarButtonItem();
            this.dodajUbezp = new DevExpress.XtraBars.BarButtonItem();
            this.editPatient = new DevExpress.XtraBars.BarButtonItem();
            this.timeItem = new DevExpress.XtraBars.BarStaticItem();
            this.deleteModeBar = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.deleteBarWizyta = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.barStaticItem2 = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonAdmin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PacjenciGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.WizytaGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UbezpieczenieGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ICDGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemToggleSwitch1 = new DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.PacjenciPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridPacjenci = new DevExpress.XtraGrid.GridControl();
            this.adminviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Pacjent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNazwisko = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData_urodzenia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKraj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUlica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNr_budynku = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNr_mieszkania = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKod_pocztowy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiasto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPESEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKarta_polaka = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDowod_osobisty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaszport = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUbezpieczenie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UbezpieczeniePage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridUbezpieczenie = new DevExpress.XtraGrid.GridControl();
            this.uBEZPIECZENIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Ubezpieczenie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRodzaj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ICDPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridICD = new DevExpress.XtraGrid.GridControl();
            this.iCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidICD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKod_ICD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRozpoznanie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WizytaPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridWizyta = new DevExpress.XtraGrid.GridControl();
            this.visitviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Wizyta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colD_Pacjent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGodzina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjawy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBPrzedmiotowe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBPodmiotowe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ICD_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ICD_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ICD_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZalecenia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pACJENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uBEZPIECZENIETableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter();
            this.iCDTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.ICDTableAdapter();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.pACJENTTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.PACJENTTableAdapter();
            this.admin_viewTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.admin_viewTableAdapter();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.wizytaTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.WIZYTATableAdapter();
            this.visit_viewTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.visit_viewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.PacjenciPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacjenci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.UbezpieczeniePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUbezpieczenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBEZPIECZENIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.ICDPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridICD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.WizytaPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWizyta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.addPatient,
            this.refreshButton,
            this.saveChanges,
            this.deleteButtonP,
            this.refreshUbezp,
            this.addICD,
            this.refreshICD,
            this.saveChangesICD,
            this.addVisit,
            this.refreshVisit,
            this.deleteButtonU,
            this.deleteButtonI,
            this.deleteButtonW,
            this.dodajUbezp,
            this.editPatient,
            this.timeItem,
            this.deleteModeBar,
            this.barStaticItem1,
            this.deleteBarWizyta,
            this.barStaticItem2});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonAdmin});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemToggleSwitch1,
            this.repositoryItemCheckEdit1});
            this.ribbon.Size = new System.Drawing.Size(1284, 147);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // addPatient
            // 
            this.addPatient.Caption = "Dodaj pacjenta";
            this.addPatient.Id = 1;
            this.addPatient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addPatient.ImageOptions.Image")));
            this.addPatient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addPatient.ImageOptions.LargeImage")));
            this.addPatient.Name = "addPatient";
            this.addPatient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddPatient_ItemClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Caption = "Odśwież";
            this.refreshButton.Id = 2;
            this.refreshButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.ImageOptions.Image")));
            this.refreshButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.ImageOptions.LargeImage")));
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshButton_ItemClick);
            // 
            // saveChanges
            // 
            this.saveChanges.Caption = "Zapisz zmiany";
            this.saveChanges.Id = 5;
            this.saveChanges.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveChanges.ImageOptions.Image")));
            this.saveChanges.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveChanges.ImageOptions.LargeImage")));
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveChanges_ItemClick);
            // 
            // deleteButtonP
            // 
            this.deleteButtonP.Caption = "Usuń";
            this.deleteButtonP.Id = 6;
            this.deleteButtonP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteButtonP.ImageOptions.Image")));
            this.deleteButtonP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteButtonP.ImageOptions.LargeImage")));
            this.deleteButtonP.Name = "deleteButtonP";
            this.deleteButtonP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteButtonP_ItemClick);
            // 
            // refreshUbezp
            // 
            this.refreshUbezp.Caption = "Odśwież";
            this.refreshUbezp.Id = 7;
            this.refreshUbezp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshUbezp.ImageOptions.Image")));
            this.refreshUbezp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshUbezp.ImageOptions.LargeImage")));
            this.refreshUbezp.Name = "refreshUbezp";
            this.refreshUbezp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshUbezp_ItemClick);
            // 
            // addICD
            // 
            this.addICD.Caption = "Dodaj kod ICD";
            this.addICD.Id = 8;
            this.addICD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addICD.ImageOptions.Image")));
            this.addICD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addICD.ImageOptions.LargeImage")));
            this.addICD.Name = "addICD";
            this.addICD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddICD_ItemClick);
            // 
            // refreshICD
            // 
            this.refreshICD.Caption = "Odśwież";
            this.refreshICD.Id = 9;
            this.refreshICD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshICD.ImageOptions.Image")));
            this.refreshICD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshICD.ImageOptions.LargeImage")));
            this.refreshICD.Name = "refreshICD";
            this.refreshICD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshICD_ItemClick);
            // 
            // saveChangesICD
            // 
            this.saveChangesICD.Caption = "Zapisz";
            this.saveChangesICD.Id = 10;
            this.saveChangesICD.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveChangesICD.ImageOptions.Image")));
            this.saveChangesICD.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveChangesICD.ImageOptions.LargeImage")));
            this.saveChangesICD.Name = "saveChangesICD";
            this.saveChangesICD.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveChangesICD_ItemClick);
            // 
            // addVisit
            // 
            this.addVisit.Caption = "Dodaj wiztye";
            this.addVisit.Id = 11;
            this.addVisit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addVisit.ImageOptions.Image")));
            this.addVisit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addVisit.ImageOptions.LargeImage")));
            this.addVisit.Name = "addVisit";
            this.addVisit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddVisit_ItemClick);
            // 
            // refreshVisit
            // 
            this.refreshVisit.Caption = "Odśwież";
            this.refreshVisit.Id = 13;
            this.refreshVisit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshVisit.ImageOptions.Image")));
            this.refreshVisit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshVisit.ImageOptions.LargeImage")));
            this.refreshVisit.Name = "refreshVisit";
            this.refreshVisit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.RefreshVisit_ItemClick);
            // 
            // deleteButtonU
            // 
            this.deleteButtonU.Caption = "Usuń";
            this.deleteButtonU.Id = 14;
            this.deleteButtonU.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteButtonU.ImageOptions.Image")));
            this.deleteButtonU.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteButtonU.ImageOptions.LargeImage")));
            this.deleteButtonU.Name = "deleteButtonU";
            this.deleteButtonU.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteButtonU_ItemClick);
            // 
            // deleteButtonI
            // 
            this.deleteButtonI.Caption = "Usuń";
            this.deleteButtonI.Id = 15;
            this.deleteButtonI.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteButtonI.ImageOptions.Image")));
            this.deleteButtonI.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteButtonI.ImageOptions.LargeImage")));
            this.deleteButtonI.Name = "deleteButtonI";
            this.deleteButtonI.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteButtonI_ItemClick);
            // 
            // deleteButtonW
            // 
            this.deleteButtonW.Caption = "Usuń";
            this.deleteButtonW.Id = 16;
            this.deleteButtonW.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteButtonW.ImageOptions.Image")));
            this.deleteButtonW.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteButtonW.ImageOptions.LargeImage")));
            this.deleteButtonW.Name = "deleteButtonW";
            this.deleteButtonW.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteButtonW_ItemClick);
            // 
            // dodajUbezp
            // 
            this.dodajUbezp.Caption = "Dodaj ubezpieczenie";
            this.dodajUbezp.Id = 17;
            this.dodajUbezp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dodajUbezp.ImageOptions.Image")));
            this.dodajUbezp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("dodajUbezp.ImageOptions.LargeImage")));
            this.dodajUbezp.Name = "dodajUbezp";
            this.dodajUbezp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DodajUbezp_ItemClick);
            // 
            // editPatient
            // 
            this.editPatient.Caption = "Edytuj pacjenta";
            this.editPatient.Id = 18;
            this.editPatient.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editPatient.ImageOptions.Image")));
            this.editPatient.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editPatient.ImageOptions.LargeImage")));
            this.editPatient.Name = "editPatient";
            this.editPatient.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.EditPatient_ItemClick);
            // 
            // timeItem
            // 
            this.timeItem.Id = 1;
            this.timeItem.Name = "timeItem";
            // 
            // deleteModeBar
            // 
            this.deleteModeBar.Id = 9;
            this.deleteModeBar.Name = "deleteModeBar";
            this.deleteModeBar.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteModeBar_CheckedChanged);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Caption = "Tryb usuwania";
            this.barStaticItem1.Id = 10;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // deleteBarWizyta
            // 
            this.deleteBarWizyta.Id = 13;
            this.deleteBarWizyta.Name = "deleteBarWizyta";
            this.deleteBarWizyta.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarWizyta_CheckedChanged);
            // 
            // barStaticItem2
            // 
            this.barStaticItem2.Caption = "Tryb usuwania";
            this.barStaticItem2.Id = 14;
            this.barStaticItem2.Name = "barStaticItem2";
            // 
            // ribbonAdmin
            // 
            this.ribbonAdmin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PacjenciGroup,
            this.WizytaGroup,
            this.UbezpieczenieGroup,
            this.ICDGroup});
            this.ribbonAdmin.Name = "ribbonAdmin";
            this.ribbonAdmin.Text = "Admin";
            // 
            // PacjenciGroup
            // 
            this.PacjenciGroup.Enabled = false;
            this.PacjenciGroup.ItemLinks.Add(this.addPatient);
            this.PacjenciGroup.ItemLinks.Add(this.editPatient);
            this.PacjenciGroup.ItemLinks.Add(this.refreshButton);
            this.PacjenciGroup.ItemLinks.Add(this.saveChanges);
            this.PacjenciGroup.ItemLinks.Add(this.deleteButtonP);
            this.PacjenciGroup.ItemLinks.Add(this.deleteModeBar);
            this.PacjenciGroup.ItemLinks.Add(this.barStaticItem1);
            this.PacjenciGroup.Name = "PacjenciGroup";
            this.PacjenciGroup.Text = "Pacjenci";
            // 
            // WizytaGroup
            // 
            this.WizytaGroup.Enabled = false;
            this.WizytaGroup.ItemLinks.Add(this.addVisit);
            this.WizytaGroup.ItemLinks.Add(this.refreshVisit);
            this.WizytaGroup.ItemLinks.Add(this.deleteButtonW);
            this.WizytaGroup.ItemLinks.Add(this.deleteBarWizyta);
            this.WizytaGroup.ItemLinks.Add(this.barStaticItem2);
            this.WizytaGroup.Name = "WizytaGroup";
            this.WizytaGroup.Text = "Wizyta";
            // 
            // UbezpieczenieGroup
            // 
            this.UbezpieczenieGroup.Enabled = false;
            this.UbezpieczenieGroup.ItemLinks.Add(this.dodajUbezp);
            this.UbezpieczenieGroup.ItemLinks.Add(this.refreshUbezp);
            this.UbezpieczenieGroup.ItemLinks.Add(this.deleteButtonU);
            this.UbezpieczenieGroup.Name = "UbezpieczenieGroup";
            this.UbezpieczenieGroup.Text = "Ubezpieczenie";
            // 
            // ICDGroup
            // 
            this.ICDGroup.Enabled = false;
            this.ICDGroup.ItemLinks.Add(this.addICD);
            this.ICDGroup.ItemLinks.Add(this.refreshICD);
            this.ICDGroup.ItemLinks.Add(this.saveChangesICD);
            this.ICDGroup.ItemLinks.Add(this.deleteButtonI);
            this.ICDGroup.Name = "ICDGroup";
            this.ICDGroup.Text = "ICD";
            // 
            // repositoryItemToggleSwitch1
            // 
            this.repositoryItemToggleSwitch1.AutoHeight = false;
            this.repositoryItemToggleSwitch1.Name = "repositoryItemToggleSwitch1";
            this.repositoryItemToggleSwitch1.OffText = "Wyłączony";
            this.repositoryItemToggleSwitch1.OnText = "Włączony";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "";
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.UserDefined;
            this.repositoryItemCheckEdit1.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.repositoryItemCheckEdit1.PictureChecked = ((System.Drawing.Image)(resources.GetObject("repositoryItemCheckEdit1.PictureChecked")));
            this.repositoryItemCheckEdit1.PictureUnchecked = ((System.Drawing.Image)(resources.GetObject("repositoryItemCheckEdit1.PictureUnchecked")));
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.timeItem);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 548);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1284, 23);
            // 
            // poradniaDataSet
            // 
            this.poradniaDataSet.DataSetName = "PoradniaDataSet";
            this.poradniaDataSet.Locale = new System.Globalization.CultureInfo("pl");
            this.poradniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPane1
            // 
            this.tabPane1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.Appearance.Options.UseTextOptions = true;
            this.tabPane1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tabPane1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tabPane1.Controls.Add(this.PacjenciPage);
            this.tabPane1.Controls.Add(this.UbezpieczeniePage);
            this.tabPane1.Controls.Add(this.ICDPage);
            this.tabPane1.Controls.Add(this.WizytaPage);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPane1.Location = new System.Drawing.Point(0, 147);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.PacjenciPage,
            this.WizytaPage,
            this.UbezpieczeniePage,
            this.ICDPage});
            this.tabPane1.RegularSize = new System.Drawing.Size(1284, 401);
            this.tabPane1.SelectedPage = this.WizytaPage;
            this.tabPane1.Size = new System.Drawing.Size(1284, 401);
            this.tabPane1.TabIndex = 6;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.TabPane1_SelectedPageChanged);
            // 
            // PacjenciPage
            // 
            this.PacjenciPage.Caption = "Pacjenci";
            this.PacjenciPage.Controls.Add(this.gridPacjenci);
            this.PacjenciPage.Name = "PacjenciPage";
            this.PacjenciPage.Size = new System.Drawing.Size(1266, 356);
            // 
            // gridPacjenci
            // 
            this.gridPacjenci.DataSource = this.adminviewBindingSource;
            this.gridPacjenci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPacjenci.Location = new System.Drawing.Point(0, 0);
            this.gridPacjenci.MainView = this.gridView1;
            this.gridPacjenci.MenuManager = this.ribbon;
            this.gridPacjenci.Name = "gridPacjenci";
            this.gridPacjenci.Size = new System.Drawing.Size(1266, 356);
            this.gridPacjenci.TabIndex = 0;
            this.gridPacjenci.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // adminviewBindingSource
            // 
            this.adminviewBindingSource.DataMember = "admin_view";
            this.adminviewBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Pacjent,
            this.colImie,
            this.colNazwisko,
            this.colData_urodzenia,
            this.colKraj,
            this.colTelefon,
            this.colPlec,
            this.colUlica,
            this.colNr_budynku,
            this.colNr_mieszkania,
            this.colKod_pocztowy,
            this.colMiasto,
            this.colPESEL,
            this.colKarta_polaka,
            this.colDowod_osobisty,
            this.colPaszport,
            this.colUbezpieczenie});
            this.gridView1.GridControl = this.gridPacjenci;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colID_Pacjent
            // 
            this.colID_Pacjent.FieldName = "ID_Pacjent";
            this.colID_Pacjent.Name = "colID_Pacjent";
            // 
            // colImie
            // 
            this.colImie.FieldName = "Imie";
            this.colImie.Name = "colImie";
            this.colImie.Visible = true;
            this.colImie.VisibleIndex = 0;
            this.colImie.Width = 77;
            // 
            // colNazwisko
            // 
            this.colNazwisko.FieldName = "Nazwisko";
            this.colNazwisko.Name = "colNazwisko";
            this.colNazwisko.Visible = true;
            this.colNazwisko.VisibleIndex = 1;
            this.colNazwisko.Width = 64;
            // 
            // colData_urodzenia
            // 
            this.colData_urodzenia.FieldName = "Data_urodzenia";
            this.colData_urodzenia.Name = "colData_urodzenia";
            this.colData_urodzenia.Visible = true;
            this.colData_urodzenia.VisibleIndex = 2;
            this.colData_urodzenia.Width = 96;
            // 
            // colKraj
            // 
            this.colKraj.FieldName = "Kraj";
            this.colKraj.Name = "colKraj";
            this.colKraj.Visible = true;
            this.colKraj.VisibleIndex = 3;
            this.colKraj.Width = 58;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 4;
            this.colTelefon.Width = 58;
            // 
            // colPlec
            // 
            this.colPlec.FieldName = "Plec";
            this.colPlec.Name = "colPlec";
            this.colPlec.Visible = true;
            this.colPlec.VisibleIndex = 5;
            this.colPlec.Width = 58;
            // 
            // colUlica
            // 
            this.colUlica.FieldName = "Ulica";
            this.colUlica.Name = "colUlica";
            this.colUlica.Visible = true;
            this.colUlica.VisibleIndex = 6;
            this.colUlica.Width = 58;
            // 
            // colNr_budynku
            // 
            this.colNr_budynku.FieldName = "Nr_budynku";
            this.colNr_budynku.Name = "colNr_budynku";
            this.colNr_budynku.Visible = true;
            this.colNr_budynku.VisibleIndex = 7;
            this.colNr_budynku.Width = 78;
            // 
            // colNr_mieszkania
            // 
            this.colNr_mieszkania.FieldName = "Nr_mieszkania";
            this.colNr_mieszkania.Name = "colNr_mieszkania";
            this.colNr_mieszkania.Visible = true;
            this.colNr_mieszkania.VisibleIndex = 8;
            this.colNr_mieszkania.Width = 88;
            // 
            // colKod_pocztowy
            // 
            this.colKod_pocztowy.FieldName = "Kod_pocztowy";
            this.colKod_pocztowy.Name = "colKod_pocztowy";
            this.colKod_pocztowy.Visible = true;
            this.colKod_pocztowy.VisibleIndex = 9;
            this.colKod_pocztowy.Width = 90;
            // 
            // colMiasto
            // 
            this.colMiasto.FieldName = "Miasto";
            this.colMiasto.Name = "colMiasto";
            this.colMiasto.Visible = true;
            this.colMiasto.VisibleIndex = 10;
            this.colMiasto.Width = 58;
            // 
            // colPESEL
            // 
            this.colPESEL.FieldName = "PESEL";
            this.colPESEL.Name = "colPESEL";
            this.colPESEL.Visible = true;
            this.colPESEL.VisibleIndex = 11;
            this.colPESEL.Width = 58;
            // 
            // colKarta_polaka
            // 
            this.colKarta_polaka.FieldName = "Karta_polaka";
            this.colKarta_polaka.Name = "colKarta_polaka";
            this.colKarta_polaka.Visible = true;
            this.colKarta_polaka.VisibleIndex = 12;
            this.colKarta_polaka.Width = 83;
            // 
            // colDowod_osobisty
            // 
            this.colDowod_osobisty.FieldName = "Dowod_osobisty";
            this.colDowod_osobisty.Name = "colDowod_osobisty";
            this.colDowod_osobisty.Visible = true;
            this.colDowod_osobisty.VisibleIndex = 13;
            this.colDowod_osobisty.Width = 99;
            // 
            // colPaszport
            // 
            this.colPaszport.FieldName = "Paszport";
            this.colPaszport.Name = "colPaszport";
            this.colPaszport.Visible = true;
            this.colPaszport.VisibleIndex = 14;
            this.colPaszport.Width = 62;
            // 
            // colUbezpieczenie
            // 
            this.colUbezpieczenie.FieldName = "Ubezpieczenie";
            this.colUbezpieczenie.Name = "colUbezpieczenie";
            this.colUbezpieczenie.Visible = true;
            this.colUbezpieczenie.VisibleIndex = 15;
            this.colUbezpieczenie.Width = 88;
            // 
            // UbezpieczeniePage
            // 
            this.UbezpieczeniePage.Caption = "Ubezpieczenie";
            this.UbezpieczeniePage.Controls.Add(this.gridUbezpieczenie);
            this.UbezpieczeniePage.Name = "UbezpieczeniePage";
            this.UbezpieczeniePage.Size = new System.Drawing.Size(1266, 356);
            // 
            // gridUbezpieczenie
            // 
            this.gridUbezpieczenie.DataSource = this.uBEZPIECZENIEBindingSource;
            this.gridUbezpieczenie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUbezpieczenie.Location = new System.Drawing.Point(0, 0);
            this.gridUbezpieczenie.MainView = this.gridView2;
            this.gridUbezpieczenie.MenuManager = this.ribbon;
            this.gridUbezpieczenie.Name = "gridUbezpieczenie";
            this.gridUbezpieczenie.Size = new System.Drawing.Size(1266, 356);
            this.gridUbezpieczenie.TabIndex = 0;
            this.gridUbezpieczenie.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // uBEZPIECZENIEBindingSource
            // 
            this.uBEZPIECZENIEBindingSource.DataMember = "UBEZPIECZENIE";
            this.uBEZPIECZENIEBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Ubezpieczenie1,
            this.colRodzaj});
            this.gridView2.GridControl = this.gridUbezpieczenie;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridView2.OptionsFind.ShowClearButton = false;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colID_Ubezpieczenie1
            // 
            this.colID_Ubezpieczenie1.FieldName = "ID_Ubezpieczenie";
            this.colID_Ubezpieczenie1.Name = "colID_Ubezpieczenie1";
            this.colID_Ubezpieczenie1.Visible = true;
            this.colID_Ubezpieczenie1.VisibleIndex = 0;
            // 
            // colRodzaj
            // 
            this.colRodzaj.FieldName = "Rodzaj";
            this.colRodzaj.Name = "colRodzaj";
            this.colRodzaj.Visible = true;
            this.colRodzaj.VisibleIndex = 1;
            // 
            // ICDPage
            // 
            this.ICDPage.Caption = "Kody ICD";
            this.ICDPage.Controls.Add(this.gridICD);
            this.ICDPage.Name = "ICDPage";
            this.ICDPage.Size = new System.Drawing.Size(1266, 356);
            // 
            // gridICD
            // 
            this.gridICD.DataSource = this.iCDBindingSource;
            this.gridICD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridICD.Location = new System.Drawing.Point(0, 0);
            this.gridICD.MainView = this.gridView3;
            this.gridICD.MenuManager = this.ribbon;
            this.gridICD.Name = "gridICD";
            this.gridICD.Size = new System.Drawing.Size(1266, 356);
            this.gridICD.TabIndex = 0;
            this.gridICD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // iCDBindingSource
            // 
            this.iCDBindingSource.DataMember = "ICD";
            this.iCDBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidICD,
            this.colKod_ICD,
            this.colRozpoznanie});
            this.gridView3.GridControl = this.gridICD;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridView3.OptionsFind.ShowClearButton = false;
            this.gridView3.OptionsFind.ShowFindButton = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colidICD
            // 
            this.colidICD.FieldName = "idICD";
            this.colidICD.Name = "colidICD";
            this.colidICD.Visible = true;
            this.colidICD.VisibleIndex = 0;
            this.colidICD.Width = 91;
            // 
            // colKod_ICD
            // 
            this.colKod_ICD.FieldName = "Kod_ICD";
            this.colKod_ICD.Name = "colKod_ICD";
            this.colKod_ICD.Visible = true;
            this.colKod_ICD.VisibleIndex = 1;
            this.colKod_ICD.Width = 108;
            // 
            // colRozpoznanie
            // 
            this.colRozpoznanie.FieldName = "Rozpoznanie";
            this.colRozpoznanie.Name = "colRozpoznanie";
            this.colRozpoznanie.Visible = true;
            this.colRozpoznanie.VisibleIndex = 2;
            this.colRozpoznanie.Width = 888;
            // 
            // WizytaPage
            // 
            this.WizytaPage.Caption = "Wizyta";
            this.WizytaPage.Controls.Add(this.gridWizyta);
            this.WizytaPage.Name = "WizytaPage";
            this.WizytaPage.Size = new System.Drawing.Size(1266, 356);
            // 
            // gridWizyta
            // 
            this.gridWizyta.DataSource = this.visitviewBindingSource;
            this.gridWizyta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWizyta.Location = new System.Drawing.Point(0, 0);
            this.gridWizyta.MainView = this.gridView4;
            this.gridWizyta.MenuManager = this.ribbon;
            this.gridWizyta.Name = "gridWizyta";
            this.gridWizyta.Size = new System.Drawing.Size(1266, 356);
            this.gridWizyta.TabIndex = 0;
            this.gridWizyta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // visitviewBindingSource
            // 
            this.visitviewBindingSource.DataMember = "visit_view";
            this.visitviewBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Wizyta,
            this.colD_Pacjent,
            this.colData,
            this.colGodzina,
            this.colObjawy,
            this.colBPrzedmiotowe,
            this.colBPodmiotowe,
            this.colID_ICD_1,
            this.colID_ICD_2,
            this.colID_ICD_3,
            this.colZalecenia,
            this.colLeki});
            this.gridView4.GridControl = this.gridWizyta;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsBehavior.Editable = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            // 
            // colID_Wizyta
            // 
            this.colID_Wizyta.Caption = "Wizyta";
            this.colID_Wizyta.FieldName = "ID_Wizyta";
            this.colID_Wizyta.Name = "colID_Wizyta";
            this.colID_Wizyta.Visible = true;
            this.colID_Wizyta.VisibleIndex = 0;
            // 
            // colD_Pacjent
            // 
            this.colD_Pacjent.Caption = "Pacjent";
            this.colD_Pacjent.FieldName = "ID_Pacjent";
            this.colD_Pacjent.Name = "colD_Pacjent";
            this.colD_Pacjent.Visible = true;
            this.colD_Pacjent.VisibleIndex = 1;
            // 
            // colData
            // 
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 2;
            // 
            // colGodzina
            // 
            this.colGodzina.FieldName = "Godzina";
            this.colGodzina.Name = "colGodzina";
            this.colGodzina.Visible = true;
            this.colGodzina.VisibleIndex = 3;
            // 
            // colObjawy
            // 
            this.colObjawy.FieldName = "Objawy";
            this.colObjawy.Name = "colObjawy";
            this.colObjawy.Visible = true;
            this.colObjawy.VisibleIndex = 4;
            // 
            // colBPrzedmiotowe
            // 
            this.colBPrzedmiotowe.Caption = "Badanie przedmiotowe";
            this.colBPrzedmiotowe.FieldName = "BPrzedmiotowe";
            this.colBPrzedmiotowe.Name = "colBPrzedmiotowe";
            this.colBPrzedmiotowe.Visible = true;
            this.colBPrzedmiotowe.VisibleIndex = 5;
            // 
            // colBPodmiotowe
            // 
            this.colBPodmiotowe.Caption = "Badanie podmiotowe";
            this.colBPodmiotowe.FieldName = "BPodmiotowe";
            this.colBPodmiotowe.Name = "colBPodmiotowe";
            this.colBPodmiotowe.Visible = true;
            this.colBPodmiotowe.VisibleIndex = 6;
            // 
            // colID_ICD_1
            // 
            this.colID_ICD_1.Caption = "ICD 1";
            this.colID_ICD_1.FieldName = "ID_ICD_1";
            this.colID_ICD_1.Name = "colID_ICD_1";
            this.colID_ICD_1.Visible = true;
            this.colID_ICD_1.VisibleIndex = 7;
            // 
            // colID_ICD_2
            // 
            this.colID_ICD_2.Caption = "ICD 2";
            this.colID_ICD_2.FieldName = "ID_ICD_2";
            this.colID_ICD_2.Name = "colID_ICD_2";
            this.colID_ICD_2.Visible = true;
            this.colID_ICD_2.VisibleIndex = 8;
            // 
            // colID_ICD_3
            // 
            this.colID_ICD_3.Caption = "ICD 3";
            this.colID_ICD_3.FieldName = "ID_ICD_3";
            this.colID_ICD_3.Name = "colID_ICD_3";
            this.colID_ICD_3.Visible = true;
            this.colID_ICD_3.VisibleIndex = 9;
            // 
            // colZalecenia
            // 
            this.colZalecenia.FieldName = "Zalecenia";
            this.colZalecenia.Name = "colZalecenia";
            this.colZalecenia.Visible = true;
            this.colZalecenia.VisibleIndex = 10;
            // 
            // colLeki
            // 
            this.colLeki.FieldName = "Leki";
            this.colLeki.Name = "colLeki";
            this.colLeki.Visible = true;
            this.colLeki.VisibleIndex = 11;
            // 
            // pACJENTBindingSource
            // 
            this.pACJENTBindingSource.DataMember = "PACJENT";
            this.pACJENTBindingSource.DataSource = this.poradniaDataSet;
            // 
            // uBEZPIECZENIETableAdapter
            // 
            this.uBEZPIECZENIETableAdapter.ClearBeforeFill = true;
            // 
            // iCDTableAdapter
            // 
            this.iCDTableAdapter.ClearBeforeFill = true;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Odswiez";
            this.barButtonItem1.Id = 2;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // pACJENTTableAdapter
            // 
            this.pACJENTTableAdapter.ClearBeforeFill = true;
            // 
            // admin_viewTableAdapter
            // 
            this.admin_viewTableAdapter.ClearBeforeFill = true;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // wizytaTableAdapter
            // 
            this.wizytaTableAdapter.ClearBeforeFill = true;
            // 
            // visit_viewTableAdapter
            // 
            this.visit_viewTableAdapter.ClearBeforeFill = true;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 571);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "AdminMenu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemToggleSwitch1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.PacjenciPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacjenci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.UbezpieczeniePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUbezpieczenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBEZPIECZENIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ICDPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridICD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.WizytaPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWizyta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonAdmin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PacjenciGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private PoradniaDataSet poradniaDataSet;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage PacjenciPage;
        private DevExpress.XtraBars.Navigation.TabNavigationPage UbezpieczeniePage;
        private DevExpress.XtraGrid.GridControl gridUbezpieczenie;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource uBEZPIECZENIEBindingSource;
        private PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter uBEZPIECZENIETableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Ubezpieczenie1;
        private DevExpress.XtraGrid.Columns.GridColumn colRodzaj;
        private DevExpress.XtraBars.BarButtonItem addPatient;
        private DevExpress.XtraBars.BarButtonItem refreshButton;
        private DevExpress.XtraBars.BarButtonItem saveChanges;
        private DevExpress.XtraBars.BarButtonItem deleteButtonP;
        private DevExpress.XtraBars.Navigation.TabNavigationPage ICDPage;
        private DevExpress.XtraGrid.GridControl gridICD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.BindingSource iCDBindingSource;
        private PoradniaDataSetTableAdapters.ICDTableAdapter iCDTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colidICD;
        private DevExpress.XtraGrid.Columns.GridColumn colKod_ICD;
        private DevExpress.XtraGrid.Columns.GridColumn colRozpoznanie;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup UbezpieczenieGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ICDGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem refreshUbezp;
        private DevExpress.XtraBars.BarButtonItem addICD;
        private DevExpress.XtraBars.BarButtonItem refreshICD;
        private DevExpress.XtraBars.BarButtonItem saveChangesICD;
        private DevExpress.XtraBars.BarButtonItem addVisit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup WizytaGroup;
        private DevExpress.XtraBars.Navigation.TabNavigationPage WizytaPage;
        private DevExpress.XtraBars.BarButtonItem refreshVisit;
        private DevExpress.XtraBars.BarButtonItem deleteButtonU;
        private DevExpress.XtraBars.BarButtonItem deleteButtonI;
        private DevExpress.XtraBars.BarButtonItem deleteButtonW;
        private DevExpress.XtraBars.BarButtonItem dodajUbezp;
        private DevExpress.XtraBars.BarButtonItem editPatient;
        private System.Windows.Forms.Timer time;
        private DevExpress.XtraBars.BarStaticItem timeItem;
        private DevExpress.XtraGrid.GridControl gridPacjenci;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource pACJENTBindingSource;
        private PoradniaDataSetTableAdapters.PACJENTTableAdapter pACJENTTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Pacjent;
        private DevExpress.XtraGrid.Columns.GridColumn colImie;
        private DevExpress.XtraGrid.Columns.GridColumn colNazwisko;
        private DevExpress.XtraGrid.Columns.GridColumn colData_urodzenia;
        private DevExpress.XtraGrid.Columns.GridColumn colKraj;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefon;
        private DevExpress.XtraGrid.Columns.GridColumn colPlec;
        private DevExpress.XtraGrid.Columns.GridColumn colUlica;
        private DevExpress.XtraGrid.Columns.GridColumn colNr_budynku;
        private DevExpress.XtraGrid.Columns.GridColumn colNr_mieszkania;
        private DevExpress.XtraGrid.Columns.GridColumn colKod_pocztowy;
        private DevExpress.XtraGrid.Columns.GridColumn colMiasto;
        private DevExpress.XtraGrid.Columns.GridColumn colPESEL;
        private DevExpress.XtraGrid.Columns.GridColumn colKarta_polaka;
        private DevExpress.XtraGrid.Columns.GridColumn colDowod_osobisty;
        private DevExpress.XtraGrid.Columns.GridColumn colPaszport;
        private DevExpress.XtraGrid.Columns.GridColumn colUbezpieczenie;
        private System.Windows.Forms.BindingSource adminviewBindingSource;
        private PoradniaDataSetTableAdapters.admin_viewTableAdapter admin_viewTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch repositoryItemToggleSwitch1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarToggleSwitchItem deleteModeBar;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarToggleSwitchItem deleteBarWizyta;
        private DevExpress.XtraBars.BarStaticItem barStaticItem2;
        private PoradniaDataSetTableAdapters.WIZYTATableAdapter wizytaTableAdapter;
        private DevExpress.XtraGrid.GridControl gridWizyta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.BindingSource visitviewBindingSource;
        private PoradniaDataSetTableAdapters.visit_viewTableAdapter visit_viewTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Wizyta;
        private DevExpress.XtraGrid.Columns.GridColumn colD_Pacjent;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colGodzina;
        private DevExpress.XtraGrid.Columns.GridColumn colObjawy;
        private DevExpress.XtraGrid.Columns.GridColumn colBPrzedmiotowe;
        private DevExpress.XtraGrid.Columns.GridColumn colBPodmiotowe;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ICD_1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ICD_2;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ICD_3;
        private DevExpress.XtraGrid.Columns.GridColumn colZalecenia;
        private DevExpress.XtraGrid.Columns.GridColumn colLeki;
    }
}