﻿namespace StudentDatabase
{
    partial class Menu
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::StudentDatabase.MenuLoad), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.addPatient = new DevExpress.XtraBars.BarButtonItem();
            this.savePatientXLSButton = new DevExpress.XtraBars.BarButtonItem();
            this.deleteButtonP = new DevExpress.XtraBars.BarButtonItem();
            this.addICD = new DevExpress.XtraBars.BarButtonItem();
            this.saveChangesICD = new DevExpress.XtraBars.BarButtonItem();
            this.addVisit = new DevExpress.XtraBars.BarButtonItem();
            this.saveVisitXLSButton = new DevExpress.XtraBars.BarButtonItem();
            this.deleteButtonU = new DevExpress.XtraBars.BarButtonItem();
            this.deleteButtonI = new DevExpress.XtraBars.BarButtonItem();
            this.deleteButtonW = new DevExpress.XtraBars.BarButtonItem();
            this.dodajUbezp = new DevExpress.XtraBars.BarButtonItem();
            this.editPatient = new DevExpress.XtraBars.BarButtonItem();
            this.timeItem = new DevExpress.XtraBars.BarStaticItem();
            this.deleteModeBar = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.deleteModeLabelPatient = new DevExpress.XtraBars.BarStaticItem();
            this.deleteBarWizyta = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.deleteModeLabelVisit = new DevExpress.XtraBars.BarStaticItem();
            this.viewVisit = new DevExpress.XtraBars.BarButtonItem();
            this.editVisit = new DevExpress.XtraBars.BarButtonItem();
            this.loggedAsText = new DevExpress.XtraBars.BarStaticItem();
            this.findPatientButton = new DevExpress.XtraBars.BarButtonItem();
            this.findVisitButton = new DevExpress.XtraBars.BarButtonItem();
            this.findICDButton = new DevExpress.XtraBars.BarButtonItem();
            this.arrangeVisitButton = new DevExpress.XtraBars.BarButtonItem();
            this.deleteArrangedVisitButton = new DevExpress.XtraBars.BarButtonItem();
            this.startArrangedVisitButton = new DevExpress.XtraBars.BarButtonItem();
            this.filterStdButton = new DevExpress.XtraBars.BarCheckItem();
            this.filterAdvButton = new DevExpress.XtraBars.BarCheckItem();
            this.statisticsExportToXLSButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearFiltersStatictisButton = new DevExpress.XtraBars.BarButtonItem();
            this.refreshButton = new DevExpress.XtraBars.BarButtonItem();
            this.closeButton = new DevExpress.XtraBars.BarButtonItem();
            this.saveArrangedVisitXLSButton = new DevExpress.XtraBars.BarButtonItem();
            this.addUserButton = new DevExpress.XtraBars.BarButtonItem();
            this.clearFilter = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonMenu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PacjenciGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.WizytaGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UmowWizyteGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.StatystykiGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.UbezpieczenieGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ICDGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.userGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.otherGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.PacjenciPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridPacjent = new DevExpress.XtraGrid.GridControl();
            this.patientviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewPacjent = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.colNumer_EKUZ = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UbezpieczeniePage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridUbezpieczenie = new DevExpress.XtraGrid.GridControl();
            this.uBEZPIECZENIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewUbezpieczenie = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Ubezpieczenie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRodzaj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ICDPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridICD = new DevExpress.XtraGrid.GridControl();
            this.iCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewICD = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colidICD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKod_ICD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRozpoznanie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WizytaPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridWizyta = new DevExpress.XtraGrid.GridControl();
            this.visitviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewWizyta = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Wizyta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Pacjent1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPacjent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGodzina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colObjawy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBPrzedmiotowe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBPodmiotowe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ICD_1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ICD_2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ICD_3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRozpoznanie1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLeki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colZalecenia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Lekarz = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UmowWizytePage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.gridUmowWizyte = new DevExpress.XtraGrid.GridControl();
            this.arrangevisitviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewUmowWizyte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Umow_Wizyte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Pacjent3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPacjent2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGodzina2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StatystykiPage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.recordNumberTB = new DevExpress.XtraEditors.LabelControl();
            this.gridStatistics = new DevExpress.XtraGrid.GridControl();
            this.statisticsviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewStatistics = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Wizyta1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Pacjent2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPacjent1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPlec1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRodzaj1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKraj1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGodzina1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ICD_11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ICD_21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_ICD_31 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colID_Lekarz1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.WelcomePage = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ICDButton = new DevExpress.XtraEditors.SimpleButton();
            this.insuranceButton = new DevExpress.XtraEditors.SimpleButton();
            this.statisticsButton = new DevExpress.XtraEditors.SimpleButton();
            this.arrangeVisitButtonOnTab = new DevExpress.XtraEditors.SimpleButton();
            this.visitButton = new DevExpress.XtraEditors.SimpleButton();
            this.info2Label = new DevExpress.XtraEditors.LabelControl();
            this.patientButton = new DevExpress.XtraEditors.SimpleButton();
            this.greetingsLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.uMOWWIZTEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uBEZPIECZENIETableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter();
            this.time = new System.Windows.Forms.Timer(this.components);
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.iCDTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.ICDTableAdapter();
            this.uzytkownikTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.UZYTKOWNIKTableAdapter();
            this.visit_viewTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.visit_viewTableAdapter();
            this.wIZYTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wIZYTATableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.WIZYTATableAdapter();
            this.uMOW_WIZTETableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.UMOW_WIZTETableAdapter();
            this.arrange_visit_viewTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.arrange_visit_viewTableAdapter();
            this.statistics_viewTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.statistics_viewTableAdapter();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.patient_viewTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.patient_viewTableAdapter();
            this.pACJENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pACJENTTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.PACJENTTableAdapter();
            this.infoLabel = new DevExpress.XtraEditors.LabelControl();
            this.welcomeLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.PacjenciPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPacjent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPacjent)).BeginInit();
            this.UbezpieczeniePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUbezpieczenie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBEZPIECZENIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUbezpieczenie)).BeginInit();
            this.ICDPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridICD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewICD)).BeginInit();
            this.WizytaPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridWizyta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWizyta)).BeginInit();
            this.UmowWizytePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUmowWizyte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrangevisitviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUmowWizyte)).BeginInit();
            this.StatystykiPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStatistics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStatistics)).BeginInit();
            this.WelcomePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMOWWIZTEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            splashScreenManager.ClosingDelay = 25;
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.addPatient,
            this.savePatientXLSButton,
            this.deleteButtonP,
            this.addICD,
            this.saveChangesICD,
            this.addVisit,
            this.saveVisitXLSButton,
            this.deleteButtonU,
            this.deleteButtonI,
            this.deleteButtonW,
            this.dodajUbezp,
            this.editPatient,
            this.timeItem,
            this.deleteModeBar,
            this.deleteModeLabelPatient,
            this.deleteBarWizyta,
            this.deleteModeLabelVisit,
            this.viewVisit,
            this.editVisit,
            this.loggedAsText,
            this.findPatientButton,
            this.findVisitButton,
            this.findICDButton,
            this.arrangeVisitButton,
            this.deleteArrangedVisitButton,
            this.startArrangedVisitButton,
            this.filterStdButton,
            this.filterAdvButton,
            this.statisticsExportToXLSButton,
            this.clearFiltersStatictisButton,
            this.refreshButton,
            this.closeButton,
            this.saveArrangedVisitXLSButton,
            this.addUserButton,
            this.clearFilter});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 56;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.loggedAsText);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonMenu});
            this.ribbon.Size = new System.Drawing.Size(1918, 147);
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
            // savePatientXLSButton
            // 
            this.savePatientXLSButton.Caption = "Eksportuj do XLS";
            this.savePatientXLSButton.Id = 2;
            this.savePatientXLSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("savePatientXLSButton.ImageOptions.Image")));
            this.savePatientXLSButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("savePatientXLSButton.ImageOptions.LargeImage")));
            this.savePatientXLSButton.Name = "savePatientXLSButton";
            this.savePatientXLSButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.savePatientXLSButton_ItemClick);
            // 
            // deleteButtonP
            // 
            this.deleteButtonP.Caption = "Usuń pacjenta";
            this.deleteButtonP.Enabled = false;
            this.deleteButtonP.Id = 6;
            this.deleteButtonP.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteButtonP.ImageOptions.Image")));
            this.deleteButtonP.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteButtonP.ImageOptions.LargeImage")));
            this.deleteButtonP.Name = "deleteButtonP";
            this.deleteButtonP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteButtonP_ItemClick);
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
            // saveChangesICD
            // 
            this.saveChangesICD.Id = 15;
            this.saveChangesICD.Name = "saveChangesICD";
            // 
            // addVisit
            // 
            this.addVisit.Caption = "Dodaj wiztyę";
            this.addVisit.Id = 11;
            this.addVisit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addVisit.ImageOptions.Image")));
            this.addVisit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addVisit.ImageOptions.LargeImage")));
            this.addVisit.Name = "addVisit";
            this.addVisit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.AddVisit_ItemClick);
            // 
            // saveVisitXLSButton
            // 
            this.saveVisitXLSButton.Caption = "Eksportuj do XLS";
            this.saveVisitXLSButton.Id = 13;
            this.saveVisitXLSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveVisitXLSButton.ImageOptions.Image")));
            this.saveVisitXLSButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveVisitXLSButton.ImageOptions.LargeImage")));
            this.saveVisitXLSButton.Name = "saveVisitXLSButton";
            this.saveVisitXLSButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveVisitXLSButton_ItemClick);
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
            this.deleteButtonW.Caption = "Usuń wizytę";
            this.deleteButtonW.Enabled = false;
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
            // deleteModeLabelPatient
            // 
            this.deleteModeLabelPatient.Caption = "Tryb usuwania";
            this.deleteModeLabelPatient.Id = 10;
            this.deleteModeLabelPatient.Name = "deleteModeLabelPatient";
            // 
            // deleteBarWizyta
            // 
            this.deleteBarWizyta.Id = 13;
            this.deleteBarWizyta.Name = "deleteBarWizyta";
            this.deleteBarWizyta.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteBarWizyta_CheckedChanged);
            // 
            // deleteModeLabelVisit
            // 
            this.deleteModeLabelVisit.Caption = "Tryb usuwania";
            this.deleteModeLabelVisit.Id = 14;
            this.deleteModeLabelVisit.Name = "deleteModeLabelVisit";
            // 
            // viewVisit
            // 
            this.viewVisit.Caption = "Podgląd wizyty";
            this.viewVisit.Id = 17;
            this.viewVisit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("viewVisit.ImageOptions.Image")));
            this.viewVisit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("viewVisit.ImageOptions.LargeImage")));
            this.viewVisit.Name = "viewVisit";
            this.viewVisit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.viewVisit_ItemClick);
            // 
            // editVisit
            // 
            this.editVisit.Caption = "Edytuj wizytę";
            this.editVisit.Id = 18;
            this.editVisit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("editVisit.ImageOptions.Image")));
            this.editVisit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("editVisit.ImageOptions.LargeImage")));
            this.editVisit.Name = "editVisit";
            this.editVisit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editVisit_ItemClick);
            // 
            // loggedAsText
            // 
            this.loggedAsText.Id = 20;
            this.loggedAsText.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("loggedAsText.ImageOptions.Image")));
            this.loggedAsText.Name = "loggedAsText";
            // 
            // findPatientButton
            // 
            this.findPatientButton.Caption = "Wyszukaj pacjenta";
            this.findPatientButton.Id = 21;
            this.findPatientButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("findPatientButton.ImageOptions.Image")));
            this.findPatientButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("findPatientButton.ImageOptions.LargeImage")));
            this.findPatientButton.Name = "findPatientButton";
            this.findPatientButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.findPatientButton_ItemClick);
            // 
            // findVisitButton
            // 
            this.findVisitButton.Caption = "Wyszukaj wizytę";
            this.findVisitButton.Id = 22;
            this.findVisitButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("findVisitButton.ImageOptions.Image")));
            this.findVisitButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("findVisitButton.ImageOptions.LargeImage")));
            this.findVisitButton.Name = "findVisitButton";
            this.findVisitButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.findVisitButton_ItemClick);
            // 
            // findICDButton
            // 
            this.findICDButton.Caption = "Wyszukaj Kod ICD";
            this.findICDButton.Id = 23;
            this.findICDButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("findICDButton.ImageOptions.Image")));
            this.findICDButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("findICDButton.ImageOptions.LargeImage")));
            this.findICDButton.Name = "findICDButton";
            this.findICDButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.findICDButton_ItemClick);
            // 
            // arrangeVisitButton
            // 
            this.arrangeVisitButton.Caption = "Umów wizytę";
            this.arrangeVisitButton.Id = 36;
            this.arrangeVisitButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("arrangeVisitButton.ImageOptions.Image")));
            this.arrangeVisitButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("arrangeVisitButton.ImageOptions.LargeImage")));
            this.arrangeVisitButton.Name = "arrangeVisitButton";
            this.arrangeVisitButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.arrangeVisitButton_ItemClick);
            // 
            // deleteArrangedVisitButton
            // 
            this.deleteArrangedVisitButton.Caption = "Usun umówioną wizytę";
            this.deleteArrangedVisitButton.Id = 37;
            this.deleteArrangedVisitButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("deleteArrangedVisitButton.ImageOptions.Image")));
            this.deleteArrangedVisitButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("deleteArrangedVisitButton.ImageOptions.LargeImage")));
            this.deleteArrangedVisitButton.Name = "deleteArrangedVisitButton";
            this.deleteArrangedVisitButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.deleteArrangedVisitButton_ItemClick);
            // 
            // startArrangedVisitButton
            // 
            this.startArrangedVisitButton.Caption = "Rozpocznij umówiona wizytę";
            this.startArrangedVisitButton.Id = 38;
            this.startArrangedVisitButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("startArrangedVisitButton.ImageOptions.Image")));
            this.startArrangedVisitButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("startArrangedVisitButton.ImageOptions.LargeImage")));
            this.startArrangedVisitButton.Name = "startArrangedVisitButton";
            this.startArrangedVisitButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.startArrangedVisitButton_ItemClick);
            // 
            // filterStdButton
            // 
            this.filterStdButton.Id = 42;
            this.filterStdButton.Name = "filterStdButton";
            // 
            // filterAdvButton
            // 
            this.filterAdvButton.Id = 43;
            this.filterAdvButton.Name = "filterAdvButton";
            // 
            // statisticsExportToXLSButton
            // 
            this.statisticsExportToXLSButton.Caption = "Eksportuj do XLS";
            this.statisticsExportToXLSButton.Id = 44;
            this.statisticsExportToXLSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("statisticsExportToXLSButton.ImageOptions.Image")));
            this.statisticsExportToXLSButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("statisticsExportToXLSButton.ImageOptions.LargeImage")));
            this.statisticsExportToXLSButton.Name = "statisticsExportToXLSButton";
            this.statisticsExportToXLSButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.statisticsExportToXLSButton_ItemClick);
            // 
            // clearFiltersStatictisButton
            // 
            this.clearFiltersStatictisButton.Caption = "Wyczyść filtry";
            this.clearFiltersStatictisButton.Id = 46;
            this.clearFiltersStatictisButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearFiltersStatictisButton.ImageOptions.Image")));
            this.clearFiltersStatictisButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("clearFiltersStatictisButton.ImageOptions.LargeImage")));
            this.clearFiltersStatictisButton.Name = "clearFiltersStatictisButton";
            this.clearFiltersStatictisButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearFiltersStatictisButton_ItemClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Caption = "Odśwież";
            this.refreshButton.Id = 50;
            this.refreshButton.ImageOptions.DisabledLargeImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.ImageOptions.DisabledLargeImage")));
            this.refreshButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.ImageOptions.Image")));
            this.refreshButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("refreshButton.ImageOptions.LargeImage")));
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.refreshButton_ItemClick);
            // 
            // closeButton
            // 
            this.closeButton.Caption = "Zamknij";
            this.closeButton.Id = 51;
            this.closeButton.ImageOptions.DisabledLargeImage = ((System.Drawing.Image)(resources.GetObject("closeButton.ImageOptions.DisabledLargeImage")));
            this.closeButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.ImageOptions.Image")));
            this.closeButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("closeButton.ImageOptions.LargeImage")));
            this.closeButton.Name = "closeButton";
            this.closeButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.closeButton_ItemClick);
            // 
            // saveArrangedVisitXLSButton
            // 
            this.saveArrangedVisitXLSButton.Caption = "Eksportuj do XLS";
            this.saveArrangedVisitXLSButton.Id = 52;
            this.saveArrangedVisitXLSButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("saveArrangedVisitXLSButton.ImageOptions.Image")));
            this.saveArrangedVisitXLSButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("saveArrangedVisitXLSButton.ImageOptions.LargeImage")));
            this.saveArrangedVisitXLSButton.Name = "saveArrangedVisitXLSButton";
            this.saveArrangedVisitXLSButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.saveArrangedVisitXLSButton_ItemClick);
            // 
            // addUserButton
            // 
            this.addUserButton.Caption = "Dodaj użytkownika";
            this.addUserButton.Id = 54;
            this.addUserButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addUserButton.ImageOptions.Image")));
            this.addUserButton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("addUserButton.ImageOptions.LargeImage")));
            this.addUserButton.Name = "addUserButton";
            // 
            // clearFilter
            // 
            this.clearFilter.Caption = "Wyczyść filtry";
            this.clearFilter.Id = 55;
            this.clearFilter.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("clearFilter.ImageOptions.Image")));
            this.clearFilter.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("clearFilter.ImageOptions.LargeImage")));
            this.clearFilter.Name = "clearFilter";
            this.clearFilter.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.clearFilter_ItemClick);
            // 
            // ribbonMenu
            // 
            this.ribbonMenu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.PacjenciGroup,
            this.WizytaGroup,
            this.UmowWizyteGroup,
            this.StatystykiGroup,
            this.UbezpieczenieGroup,
            this.ICDGroup,
            this.userGroup,
            this.otherGroup});
            this.ribbonMenu.Name = "ribbonMenu";
            this.ribbonMenu.Text = "Menu";
            // 
            // PacjenciGroup
            // 
            this.PacjenciGroup.Enabled = false;
            this.PacjenciGroup.ItemLinks.Add(this.addPatient);
            this.PacjenciGroup.ItemLinks.Add(this.editPatient);
            this.PacjenciGroup.ItemLinks.Add(this.findPatientButton);
            this.PacjenciGroup.ItemLinks.Add(this.savePatientXLSButton);
            this.PacjenciGroup.ItemLinks.Add(this.deleteButtonP);
            this.PacjenciGroup.ItemLinks.Add(this.deleteModeBar);
            this.PacjenciGroup.ItemLinks.Add(this.deleteModeLabelPatient);
            this.PacjenciGroup.Name = "PacjenciGroup";
            this.PacjenciGroup.Text = "Pacjenci";
            // 
            // WizytaGroup
            // 
            this.WizytaGroup.Enabled = false;
            this.WizytaGroup.ItemLinks.Add(this.addVisit);
            this.WizytaGroup.ItemLinks.Add(this.editVisit);
            this.WizytaGroup.ItemLinks.Add(this.viewVisit);
            this.WizytaGroup.ItemLinks.Add(this.findVisitButton);
            this.WizytaGroup.ItemLinks.Add(this.saveVisitXLSButton);
            this.WizytaGroup.ItemLinks.Add(this.deleteButtonW);
            this.WizytaGroup.ItemLinks.Add(this.deleteBarWizyta);
            this.WizytaGroup.ItemLinks.Add(this.deleteModeLabelVisit);
            this.WizytaGroup.Name = "WizytaGroup";
            this.WizytaGroup.Text = "Wizyta";
            // 
            // UmowWizyteGroup
            // 
            this.UmowWizyteGroup.Enabled = false;
            this.UmowWizyteGroup.ItemLinks.Add(this.arrangeVisitButton);
            this.UmowWizyteGroup.ItemLinks.Add(this.deleteArrangedVisitButton);
            this.UmowWizyteGroup.ItemLinks.Add(this.startArrangedVisitButton);
            this.UmowWizyteGroup.ItemLinks.Add(this.saveArrangedVisitXLSButton);
            this.UmowWizyteGroup.Name = "UmowWizyteGroup";
            this.UmowWizyteGroup.Text = "Umów wizytę";
            // 
            // StatystykiGroup
            // 
            this.StatystykiGroup.Enabled = false;
            this.StatystykiGroup.ItemLinks.Add(this.statisticsExportToXLSButton);
            this.StatystykiGroup.ItemLinks.Add(this.clearFiltersStatictisButton);
            this.StatystykiGroup.Name = "StatystykiGroup";
            this.StatystykiGroup.Text = "Statystyki";
            // 
            // UbezpieczenieGroup
            // 
            this.UbezpieczenieGroup.Enabled = false;
            this.UbezpieczenieGroup.ItemLinks.Add(this.dodajUbezp);
            this.UbezpieczenieGroup.ItemLinks.Add(this.deleteButtonU);
            this.UbezpieczenieGroup.Name = "UbezpieczenieGroup";
            this.UbezpieczenieGroup.Text = "Ubezpieczenie";
            // 
            // ICDGroup
            // 
            this.ICDGroup.Enabled = false;
            this.ICDGroup.ItemLinks.Add(this.addICD);
            this.ICDGroup.ItemLinks.Add(this.findICDButton);
            this.ICDGroup.ItemLinks.Add(this.deleteButtonI);
            this.ICDGroup.Name = "ICDGroup";
            this.ICDGroup.Text = "ICD";
            // 
            // userGroup
            // 
            this.userGroup.ItemLinks.Add(this.addUserButton);
            this.userGroup.Name = "userGroup";
            this.userGroup.Text = "Użytkownik";
            this.userGroup.Visible = false;
            // 
            // otherGroup
            // 
            this.otherGroup.ItemLinks.Add(this.refreshButton);
            this.otherGroup.ItemLinks.Add(this.clearFilter);
            this.otherGroup.ItemLinks.Add(this.closeButton);
            this.otherGroup.Name = "otherGroup";
            this.otherGroup.Text = "Ogólne";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.timeItem);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 696);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1918, 23);
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
            this.tabPane1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPane1.Appearance.Options.UseBackColor = true;
            this.tabPane1.Appearance.Options.UseFont = true;
            this.tabPane1.Appearance.Options.UseTextOptions = true;
            this.tabPane1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tabPane1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tabPane1.AppearanceButton.Hovered.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPane1.AppearanceButton.Hovered.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Hovered.Options.UseTextOptions = true;
            this.tabPane1.AppearanceButton.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tabPane1.AppearanceButton.Hovered.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tabPane1.AppearanceButton.Normal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPane1.AppearanceButton.Normal.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Normal.Options.UseTextOptions = true;
            this.tabPane1.AppearanceButton.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tabPane1.AppearanceButton.Normal.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tabPane1.AppearanceButton.Pressed.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPane1.AppearanceButton.Pressed.Options.UseFont = true;
            this.tabPane1.AppearanceButton.Pressed.Options.UseTextOptions = true;
            this.tabPane1.AppearanceButton.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tabPane1.AppearanceButton.Pressed.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.tabPane1.Controls.Add(this.PacjenciPage);
            this.tabPane1.Controls.Add(this.UbezpieczeniePage);
            this.tabPane1.Controls.Add(this.ICDPage);
            this.tabPane1.Controls.Add(this.WizytaPage);
            this.tabPane1.Controls.Add(this.UmowWizytePage);
            this.tabPane1.Controls.Add(this.StatystykiPage);
            this.tabPane1.Controls.Add(this.WelcomePage);
            this.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPane1.Location = new System.Drawing.Point(0, 147);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.WelcomePage,
            this.PacjenciPage,
            this.WizytaPage,
            this.UmowWizytePage,
            this.StatystykiPage,
            this.UbezpieczeniePage,
            this.ICDPage});
            this.tabPane1.RegularSize = new System.Drawing.Size(1918, 549);
            this.tabPane1.SelectedPage = this.WelcomePage;
            this.tabPane1.Size = new System.Drawing.Size(1918, 549);
            this.tabPane1.TabAlignment = DevExpress.XtraEditors.Alignment.Center;
            this.tabPane1.TabIndex = 6;
            this.tabPane1.Text = "tabPane1";
            this.tabPane1.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.TabPane1_SelectedPageChanged);
            // 
            // PacjenciPage
            // 
            this.PacjenciPage.Caption = "Pacjenci";
            this.PacjenciPage.Controls.Add(this.gridPacjent);
            this.PacjenciPage.Image = ((System.Drawing.Image)(resources.GetObject("PacjenciPage.Image")));
            this.PacjenciPage.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.PacjenciPage.Name = "PacjenciPage";
            this.PacjenciPage.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.PacjenciPage.Size = new System.Drawing.Size(1918, 549);
            // 
            // gridPacjent
            // 
            this.gridPacjent.DataSource = this.patientviewBindingSource;
            this.gridPacjent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPacjent.Location = new System.Drawing.Point(0, 0);
            this.gridPacjent.MainView = this.gridViewPacjent;
            this.gridPacjent.MenuManager = this.ribbon;
            this.gridPacjent.Name = "gridPacjent";
            this.gridPacjent.Size = new System.Drawing.Size(1918, 549);
            this.gridPacjent.TabIndex = 0;
            this.gridPacjent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPacjent});
            // 
            // patientviewBindingSource
            // 
            this.patientviewBindingSource.DataMember = "patient_view";
            this.patientviewBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridViewPacjent
            // 
            this.gridViewPacjent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.colUbezpieczenie,
            this.colNumer_EKUZ});
            this.gridViewPacjent.GridControl = this.gridPacjent;
            this.gridViewPacjent.Name = "gridViewPacjent";
            this.gridViewPacjent.OptionsBehavior.Editable = false;
            this.gridViewPacjent.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridViewPacjent.OptionsFind.ShowClearButton = false;
            this.gridViewPacjent.OptionsFind.ShowFindButton = false;
            this.gridViewPacjent.OptionsView.ShowGroupPanel = false;
            this.gridViewPacjent.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewPacjent_FocusedRowChanged);
            // 
            // colID_Pacjent
            // 
            this.colID_Pacjent.Caption = "Numer pacjenta";
            this.colID_Pacjent.FieldName = "ID_Pacjent";
            this.colID_Pacjent.Name = "colID_Pacjent";
            this.colID_Pacjent.Visible = true;
            this.colID_Pacjent.VisibleIndex = 0;
            // 
            // colImie
            // 
            this.colImie.CustomizationCaption = "Imię";
            this.colImie.FieldName = "Imie";
            this.colImie.Name = "colImie";
            this.colImie.Visible = true;
            this.colImie.VisibleIndex = 1;
            // 
            // colNazwisko
            // 
            this.colNazwisko.FieldName = "Nazwisko";
            this.colNazwisko.Name = "colNazwisko";
            this.colNazwisko.Visible = true;
            this.colNazwisko.VisibleIndex = 2;
            // 
            // colData_urodzenia
            // 
            this.colData_urodzenia.Caption = "Data urodzenia";
            this.colData_urodzenia.FieldName = "Data_urodzenia";
            this.colData_urodzenia.Name = "colData_urodzenia";
            this.colData_urodzenia.Visible = true;
            this.colData_urodzenia.VisibleIndex = 3;
            // 
            // colKraj
            // 
            this.colKraj.FieldName = "Kraj";
            this.colKraj.Name = "colKraj";
            this.colKraj.Visible = true;
            this.colKraj.VisibleIndex = 4;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 5;
            // 
            // colPlec
            // 
            this.colPlec.Caption = "Płeć";
            this.colPlec.FieldName = "Plec";
            this.colPlec.Name = "colPlec";
            this.colPlec.Visible = true;
            this.colPlec.VisibleIndex = 6;
            // 
            // colUlica
            // 
            this.colUlica.FieldName = "Ulica";
            this.colUlica.Name = "colUlica";
            this.colUlica.Visible = true;
            this.colUlica.VisibleIndex = 7;
            // 
            // colNr_budynku
            // 
            this.colNr_budynku.Caption = "Numer budynku";
            this.colNr_budynku.FieldName = "Nr_budynku";
            this.colNr_budynku.Name = "colNr_budynku";
            this.colNr_budynku.Visible = true;
            this.colNr_budynku.VisibleIndex = 8;
            // 
            // colNr_mieszkania
            // 
            this.colNr_mieszkania.Caption = "Numer mieszkania";
            this.colNr_mieszkania.FieldName = "Nr_mieszkania";
            this.colNr_mieszkania.Name = "colNr_mieszkania";
            this.colNr_mieszkania.Visible = true;
            this.colNr_mieszkania.VisibleIndex = 9;
            // 
            // colKod_pocztowy
            // 
            this.colKod_pocztowy.Caption = "Kod pocztowy";
            this.colKod_pocztowy.FieldName = "Kod_pocztowy";
            this.colKod_pocztowy.Name = "colKod_pocztowy";
            this.colKod_pocztowy.Visible = true;
            this.colKod_pocztowy.VisibleIndex = 10;
            // 
            // colMiasto
            // 
            this.colMiasto.FieldName = "Miasto";
            this.colMiasto.Name = "colMiasto";
            this.colMiasto.Visible = true;
            this.colMiasto.VisibleIndex = 11;
            // 
            // colPESEL
            // 
            this.colPESEL.Caption = "Numer PESEL";
            this.colPESEL.FieldName = "PESEL";
            this.colPESEL.Name = "colPESEL";
            this.colPESEL.Visible = true;
            this.colPESEL.VisibleIndex = 12;
            // 
            // colKarta_polaka
            // 
            this.colKarta_polaka.Caption = "Karta Polaka";
            this.colKarta_polaka.FieldName = "Karta_polaka";
            this.colKarta_polaka.Name = "colKarta_polaka";
            this.colKarta_polaka.Visible = true;
            this.colKarta_polaka.VisibleIndex = 13;
            // 
            // colDowod_osobisty
            // 
            this.colDowod_osobisty.Caption = "Dowód osobisty";
            this.colDowod_osobisty.FieldName = "Dowod_osobisty";
            this.colDowod_osobisty.Name = "colDowod_osobisty";
            this.colDowod_osobisty.Visible = true;
            this.colDowod_osobisty.VisibleIndex = 14;
            // 
            // colPaszport
            // 
            this.colPaszport.FieldName = "Paszport";
            this.colPaszport.Name = "colPaszport";
            this.colPaszport.Visible = true;
            this.colPaszport.VisibleIndex = 15;
            // 
            // colUbezpieczenie
            // 
            this.colUbezpieczenie.FieldName = "Ubezpieczenie";
            this.colUbezpieczenie.Name = "colUbezpieczenie";
            this.colUbezpieczenie.Visible = true;
            this.colUbezpieczenie.VisibleIndex = 16;
            // 
            // colNumer_EKUZ
            // 
            this.colNumer_EKUZ.Caption = "Numer EKUZ";
            this.colNumer_EKUZ.FieldName = "Numer_EKUZ";
            this.colNumer_EKUZ.Name = "colNumer_EKUZ";
            this.colNumer_EKUZ.Visible = true;
            this.colNumer_EKUZ.VisibleIndex = 17;
            // 
            // UbezpieczeniePage
            // 
            this.UbezpieczeniePage.Caption = "Ubezpieczenie";
            this.UbezpieczeniePage.Controls.Add(this.gridUbezpieczenie);
            this.UbezpieczeniePage.Image = ((System.Drawing.Image)(resources.GetObject("UbezpieczeniePage.Image")));
            this.UbezpieczeniePage.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.UbezpieczeniePage.Name = "UbezpieczeniePage";
            this.UbezpieczeniePage.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.UbezpieczeniePage.Size = new System.Drawing.Size(1918, 549);
            // 
            // gridUbezpieczenie
            // 
            this.gridUbezpieczenie.DataSource = this.uBEZPIECZENIEBindingSource;
            this.gridUbezpieczenie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUbezpieczenie.Location = new System.Drawing.Point(0, 0);
            this.gridUbezpieczenie.MainView = this.gridViewUbezpieczenie;
            this.gridUbezpieczenie.MenuManager = this.ribbon;
            this.gridUbezpieczenie.Name = "gridUbezpieczenie";
            this.gridUbezpieczenie.Size = new System.Drawing.Size(1918, 549);
            this.gridUbezpieczenie.TabIndex = 0;
            this.gridUbezpieczenie.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUbezpieczenie});
            // 
            // uBEZPIECZENIEBindingSource
            // 
            this.uBEZPIECZENIEBindingSource.DataMember = "UBEZPIECZENIE";
            this.uBEZPIECZENIEBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridViewUbezpieczenie
            // 
            this.gridViewUbezpieczenie.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Ubezpieczenie1,
            this.colRodzaj});
            this.gridViewUbezpieczenie.GridControl = this.gridUbezpieczenie;
            this.gridViewUbezpieczenie.Name = "gridViewUbezpieczenie";
            this.gridViewUbezpieczenie.OptionsBehavior.Editable = false;
            this.gridViewUbezpieczenie.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridViewUbezpieczenie.OptionsFind.ShowClearButton = false;
            this.gridViewUbezpieczenie.OptionsFind.ShowFindButton = false;
            this.gridViewUbezpieczenie.OptionsView.ShowGroupPanel = false;
            // 
            // colID_Ubezpieczenie1
            // 
            this.colID_Ubezpieczenie1.FieldName = "ID_Ubezpieczenie";
            this.colID_Ubezpieczenie1.Name = "colID_Ubezpieczenie1";
            // 
            // colRodzaj
            // 
            this.colRodzaj.Caption = "Rodzaj ubezpieczenia";
            this.colRodzaj.FieldName = "Rodzaj";
            this.colRodzaj.Name = "colRodzaj";
            this.colRodzaj.Visible = true;
            this.colRodzaj.VisibleIndex = 0;
            // 
            // ICDPage
            // 
            this.ICDPage.Caption = "Kody ICD";
            this.ICDPage.Controls.Add(this.gridICD);
            this.ICDPage.Image = ((System.Drawing.Image)(resources.GetObject("ICDPage.Image")));
            this.ICDPage.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.ICDPage.Name = "ICDPage";
            this.ICDPage.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.ICDPage.Size = new System.Drawing.Size(1918, 549);
            // 
            // gridICD
            // 
            this.gridICD.DataSource = this.iCDBindingSource;
            this.gridICD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridICD.Location = new System.Drawing.Point(0, 0);
            this.gridICD.MainView = this.gridViewICD;
            this.gridICD.MenuManager = this.ribbon;
            this.gridICD.Name = "gridICD";
            this.gridICD.Size = new System.Drawing.Size(1918, 549);
            this.gridICD.TabIndex = 0;
            this.gridICD.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewICD});
            // 
            // iCDBindingSource
            // 
            this.iCDBindingSource.DataMember = "ICD";
            this.iCDBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridViewICD
            // 
            this.gridViewICD.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colidICD,
            this.colKod_ICD,
            this.colRozpoznanie});
            this.gridViewICD.GridControl = this.gridICD;
            this.gridViewICD.Name = "gridViewICD";
            this.gridViewICD.OptionsBehavior.Editable = false;
            this.gridViewICD.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridViewICD.OptionsFind.ShowClearButton = false;
            this.gridViewICD.OptionsFind.ShowFindButton = false;
            this.gridViewICD.OptionsView.ShowGroupPanel = false;
            // 
            // colidICD
            // 
            this.colidICD.FieldName = "idICD";
            this.colidICD.Name = "colidICD";
            this.colidICD.Width = 91;
            // 
            // colKod_ICD
            // 
            this.colKod_ICD.Caption = "Kod ICD";
            this.colKod_ICD.FieldName = "Kod_ICD";
            this.colKod_ICD.Name = "colKod_ICD";
            this.colKod_ICD.Visible = true;
            this.colKod_ICD.VisibleIndex = 0;
            this.colKod_ICD.Width = 108;
            // 
            // colRozpoznanie
            // 
            this.colRozpoznanie.FieldName = "Rozpoznanie";
            this.colRozpoznanie.Name = "colRozpoznanie";
            this.colRozpoznanie.Visible = true;
            this.colRozpoznanie.VisibleIndex = 1;
            this.colRozpoznanie.Width = 888;
            // 
            // WizytaPage
            // 
            this.WizytaPage.Caption = "Wizyta";
            this.WizytaPage.Controls.Add(this.gridWizyta);
            this.WizytaPage.Image = ((System.Drawing.Image)(resources.GetObject("WizytaPage.Image")));
            this.WizytaPage.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.WizytaPage.Name = "WizytaPage";
            this.WizytaPage.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.WizytaPage.Size = new System.Drawing.Size(1900, 485);
            // 
            // gridWizyta
            // 
            this.gridWizyta.DataSource = this.visitviewBindingSource;
            this.gridWizyta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWizyta.Location = new System.Drawing.Point(0, 0);
            this.gridWizyta.MainView = this.gridViewWizyta;
            this.gridWizyta.MenuManager = this.ribbon;
            this.gridWizyta.Name = "gridWizyta";
            this.gridWizyta.Size = new System.Drawing.Size(1900, 485);
            this.gridWizyta.TabIndex = 0;
            this.gridWizyta.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWizyta});
            // 
            // visitviewBindingSource
            // 
            this.visitviewBindingSource.DataMember = "visit_view";
            this.visitviewBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridViewWizyta
            // 
            this.gridViewWizyta.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Wizyta,
            this.colID_Pacjent1,
            this.colPacjent,
            this.colData,
            this.colGodzina,
            this.colObjawy,
            this.colBPrzedmiotowe,
            this.colBPodmiotowe,
            this.colID_ICD_1,
            this.colID_ICD_2,
            this.colID_ICD_3,
            this.colRozpoznanie1,
            this.colLeki,
            this.colZalecenia,
            this.colID_Lekarz});
            this.gridViewWizyta.GridControl = this.gridWizyta;
            this.gridViewWizyta.Name = "gridViewWizyta";
            this.gridViewWizyta.OptionsBehavior.Editable = false;
            this.gridViewWizyta.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridViewWizyta.OptionsFind.ShowClearButton = false;
            this.gridViewWizyta.OptionsFind.ShowFindButton = false;
            this.gridViewWizyta.OptionsView.ShowGroupPanel = false;
            this.gridViewWizyta.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewWizyta_FocusedRowChanged);
            // 
            // colID_Wizyta
            // 
            this.colID_Wizyta.Caption = "Numer wizyty";
            this.colID_Wizyta.FieldName = "ID_Wizyta";
            this.colID_Wizyta.Name = "colID_Wizyta";
            this.colID_Wizyta.Visible = true;
            this.colID_Wizyta.VisibleIndex = 0;
            // 
            // colID_Pacjent1
            // 
            this.colID_Pacjent1.Caption = "Numer pacjenta";
            this.colID_Pacjent1.FieldName = "ID_Pacjent";
            this.colID_Pacjent1.Name = "colID_Pacjent1";
            this.colID_Pacjent1.Visible = true;
            this.colID_Pacjent1.VisibleIndex = 1;
            // 
            // colPacjent
            // 
            this.colPacjent.Caption = "Imię i nazwisko pacjenta";
            this.colPacjent.FieldName = "Pacjent";
            this.colPacjent.Name = "colPacjent";
            this.colPacjent.Visible = true;
            this.colPacjent.VisibleIndex = 2;
            // 
            // colData
            // 
            this.colData.FieldName = "Data";
            this.colData.Name = "colData";
            this.colData.Visible = true;
            this.colData.VisibleIndex = 3;
            // 
            // colGodzina
            // 
            this.colGodzina.FieldName = "Godzina";
            this.colGodzina.Name = "colGodzina";
            this.colGodzina.Visible = true;
            this.colGodzina.VisibleIndex = 4;
            // 
            // colObjawy
            // 
            this.colObjawy.FieldName = "Objawy";
            this.colObjawy.Name = "colObjawy";
            this.colObjawy.Visible = true;
            this.colObjawy.VisibleIndex = 5;
            // 
            // colBPrzedmiotowe
            // 
            this.colBPrzedmiotowe.Caption = "Badanie przedmiotowe";
            this.colBPrzedmiotowe.FieldName = "BPrzedmiotowe";
            this.colBPrzedmiotowe.Name = "colBPrzedmiotowe";
            this.colBPrzedmiotowe.Visible = true;
            this.colBPrzedmiotowe.VisibleIndex = 6;
            // 
            // colBPodmiotowe
            // 
            this.colBPodmiotowe.Caption = "Badanie podmiotowe";
            this.colBPodmiotowe.FieldName = "BPodmiotowe";
            this.colBPodmiotowe.Name = "colBPodmiotowe";
            this.colBPodmiotowe.Visible = true;
            this.colBPodmiotowe.VisibleIndex = 7;
            // 
            // colID_ICD_1
            // 
            this.colID_ICD_1.Caption = "Kod ICD 1";
            this.colID_ICD_1.FieldName = "ID_ICD_1";
            this.colID_ICD_1.Name = "colID_ICD_1";
            this.colID_ICD_1.Visible = true;
            this.colID_ICD_1.VisibleIndex = 8;
            // 
            // colID_ICD_2
            // 
            this.colID_ICD_2.Caption = "Kod ICD 2";
            this.colID_ICD_2.FieldName = "ID_ICD_2";
            this.colID_ICD_2.Name = "colID_ICD_2";
            this.colID_ICD_2.Visible = true;
            this.colID_ICD_2.VisibleIndex = 9;
            // 
            // colID_ICD_3
            // 
            this.colID_ICD_3.Caption = "Kod ICD 3";
            this.colID_ICD_3.FieldName = "ID_ICD_3";
            this.colID_ICD_3.Name = "colID_ICD_3";
            this.colID_ICD_3.Visible = true;
            this.colID_ICD_3.VisibleIndex = 10;
            // 
            // colRozpoznanie1
            // 
            this.colRozpoznanie1.FieldName = "Rozpoznanie";
            this.colRozpoznanie1.Name = "colRozpoznanie1";
            this.colRozpoznanie1.Visible = true;
            this.colRozpoznanie1.VisibleIndex = 11;
            // 
            // colLeki
            // 
            this.colLeki.FieldName = "Leki";
            this.colLeki.Name = "colLeki";
            this.colLeki.Visible = true;
            this.colLeki.VisibleIndex = 12;
            // 
            // colZalecenia
            // 
            this.colZalecenia.FieldName = "Zalecenia";
            this.colZalecenia.Name = "colZalecenia";
            this.colZalecenia.Visible = true;
            this.colZalecenia.VisibleIndex = 13;
            // 
            // colID_Lekarz
            // 
            this.colID_Lekarz.Caption = "Lekarz przyjmujący";
            this.colID_Lekarz.FieldName = "ID_Lekarz";
            this.colID_Lekarz.Name = "colID_Lekarz";
            this.colID_Lekarz.Visible = true;
            this.colID_Lekarz.VisibleIndex = 14;
            // 
            // UmowWizytePage
            // 
            this.UmowWizytePage.Caption = "Umów wizytę";
            this.UmowWizytePage.Controls.Add(this.gridUmowWizyte);
            this.UmowWizytePage.Image = ((System.Drawing.Image)(resources.GetObject("UmowWizytePage.Image")));
            this.UmowWizytePage.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.UmowWizytePage.Name = "UmowWizytePage";
            this.UmowWizytePage.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.UmowWizytePage.Size = new System.Drawing.Size(1918, 549);
            // 
            // gridUmowWizyte
            // 
            this.gridUmowWizyte.DataSource = this.arrangevisitviewBindingSource;
            this.gridUmowWizyte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUmowWizyte.Location = new System.Drawing.Point(0, 0);
            this.gridUmowWizyte.MainView = this.gridViewUmowWizyte;
            this.gridUmowWizyte.MenuManager = this.ribbon;
            this.gridUmowWizyte.Name = "gridUmowWizyte";
            this.gridUmowWizyte.Size = new System.Drawing.Size(1918, 549);
            this.gridUmowWizyte.TabIndex = 0;
            this.gridUmowWizyte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUmowWizyte});
            // 
            // arrangevisitviewBindingSource
            // 
            this.arrangevisitviewBindingSource.DataMember = "arrange_visit_view";
            this.arrangevisitviewBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridViewUmowWizyte
            // 
            this.gridViewUmowWizyte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Umow_Wizyte,
            this.colID_Pacjent3,
            this.colPacjent2,
            this.colData2,
            this.colGodzina2});
            this.gridViewUmowWizyte.GridControl = this.gridUmowWizyte;
            this.gridViewUmowWizyte.Name = "gridViewUmowWizyte";
            this.gridViewUmowWizyte.OptionsBehavior.Editable = false;
            this.gridViewUmowWizyte.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridViewUmowWizyte.OptionsFind.ShowClearButton = false;
            this.gridViewUmowWizyte.OptionsFind.ShowFindButton = false;
            this.gridViewUmowWizyte.OptionsView.ShowFooter = true;
            this.gridViewUmowWizyte.OptionsView.ShowGroupPanel = false;
            this.gridViewUmowWizyte.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewUmowWizyte_FocusedRowChanged);
            // 
            // colID_Umow_Wizyte
            // 
            this.colID_Umow_Wizyte.Caption = "Numer umówionej wizyty";
            this.colID_Umow_Wizyte.FieldName = "ID_Umow_Wizyte";
            this.colID_Umow_Wizyte.Name = "colID_Umow_Wizyte";
            this.colID_Umow_Wizyte.Visible = true;
            this.colID_Umow_Wizyte.VisibleIndex = 0;
            // 
            // colID_Pacjent3
            // 
            this.colID_Pacjent3.Caption = "Numer pacjenta";
            this.colID_Pacjent3.FieldName = "ID_Pacjent";
            this.colID_Pacjent3.Name = "colID_Pacjent3";
            this.colID_Pacjent3.Visible = true;
            this.colID_Pacjent3.VisibleIndex = 1;
            // 
            // colPacjent2
            // 
            this.colPacjent2.Caption = "Imię i nazwisko pacjenta";
            this.colPacjent2.FieldName = "Pacjent";
            this.colPacjent2.Name = "colPacjent2";
            this.colPacjent2.Visible = true;
            this.colPacjent2.VisibleIndex = 2;
            // 
            // colData2
            // 
            this.colData2.FieldName = "Data";
            this.colData2.Name = "colData2";
            this.colData2.Visible = true;
            this.colData2.VisibleIndex = 3;
            // 
            // colGodzina2
            // 
            this.colGodzina2.FieldName = "Godzina";
            this.colGodzina2.Name = "colGodzina2";
            this.colGodzina2.Visible = true;
            this.colGodzina2.VisibleIndex = 4;
            // 
            // StatystykiPage
            // 
            this.StatystykiPage.Caption = "Statystyki";
            this.StatystykiPage.Controls.Add(this.splitContainerControl1);
            this.StatystykiPage.Image = ((System.Drawing.Image)(resources.GetObject("StatystykiPage.Image")));
            this.StatystykiPage.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.StatystykiPage.Name = "StatystykiPage";
            this.StatystykiPage.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.StatystykiPage.Size = new System.Drawing.Size(1918, 549);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.recordNumberTB);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridStatistics);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1918, 549);
            this.splitContainerControl1.SplitterPosition = 38;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // recordNumberTB
            // 
            this.recordNumberTB.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.recordNumberTB.Appearance.Options.UseFont = true;
            this.recordNumberTB.Location = new System.Drawing.Point(23, 12);
            this.recordNumberTB.Name = "recordNumberTB";
            this.recordNumberTB.Size = new System.Drawing.Size(142, 23);
            this.recordNumberTB.TabIndex = 0;
            this.recordNumberTB.Text = "Liczba rekordów:";
            // 
            // gridStatistics
            // 
            this.gridStatistics.DataSource = this.statisticsviewBindingSource;
            this.gridStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStatistics.Location = new System.Drawing.Point(0, 0);
            this.gridStatistics.MainView = this.gridViewStatistics;
            this.gridStatistics.MenuManager = this.ribbon;
            this.gridStatistics.Name = "gridStatistics";
            this.gridStatistics.Size = new System.Drawing.Size(1918, 499);
            this.gridStatistics.TabIndex = 1;
            this.gridStatistics.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStatistics});
            // 
            // statisticsviewBindingSource
            // 
            this.statisticsviewBindingSource.DataMember = "statistics_view";
            this.statisticsviewBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridViewStatistics
            // 
            this.gridViewStatistics.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Wizyta1,
            this.colID_Pacjent2,
            this.colPacjent1,
            this.colPlec1,
            this.colRodzaj1,
            this.colKraj1,
            this.colData1,
            this.colGodzina1,
            this.colID_ICD_11,
            this.colID_ICD_21,
            this.colID_ICD_31,
            this.colID_Lekarz1});
            this.gridViewStatistics.GridControl = this.gridStatistics;
            this.gridViewStatistics.Name = "gridViewStatistics";
            this.gridViewStatistics.OptionsBehavior.Editable = false;
            this.gridViewStatistics.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridViewStatistics.OptionsFind.ShowClearButton = false;
            this.gridViewStatistics.OptionsFind.ShowFindButton = false;
            this.gridViewStatistics.OptionsView.ShowGroupPanel = false;
            this.gridViewStatistics.RowCountChanged += new System.EventHandler(this.gridViewStatistics_RowCountChanged);
            // 
            // colID_Wizyta1
            // 
            this.colID_Wizyta1.Caption = "Numer wizyty";
            this.colID_Wizyta1.FieldName = "ID_Wizyta";
            this.colID_Wizyta1.Name = "colID_Wizyta1";
            this.colID_Wizyta1.Visible = true;
            this.colID_Wizyta1.VisibleIndex = 0;
            // 
            // colID_Pacjent2
            // 
            this.colID_Pacjent2.Caption = "Numer pacjenta";
            this.colID_Pacjent2.FieldName = "ID_Pacjent";
            this.colID_Pacjent2.Name = "colID_Pacjent2";
            this.colID_Pacjent2.Visible = true;
            this.colID_Pacjent2.VisibleIndex = 1;
            // 
            // colPacjent1
            // 
            this.colPacjent1.Caption = "Imię i nazwisko pacjenta";
            this.colPacjent1.FieldName = "Pacjent";
            this.colPacjent1.Name = "colPacjent1";
            this.colPacjent1.Visible = true;
            this.colPacjent1.VisibleIndex = 2;
            // 
            // colPlec1
            // 
            this.colPlec1.Caption = "Płeć";
            this.colPlec1.FieldName = "Plec";
            this.colPlec1.Name = "colPlec1";
            this.colPlec1.Visible = true;
            this.colPlec1.VisibleIndex = 3;
            // 
            // colRodzaj1
            // 
            this.colRodzaj1.Caption = "Ubezpieczenie";
            this.colRodzaj1.FieldName = "Rodzaj";
            this.colRodzaj1.Name = "colRodzaj1";
            this.colRodzaj1.Visible = true;
            this.colRodzaj1.VisibleIndex = 4;
            // 
            // colKraj1
            // 
            this.colKraj1.FieldName = "Kraj";
            this.colKraj1.Name = "colKraj1";
            this.colKraj1.Visible = true;
            this.colKraj1.VisibleIndex = 5;
            // 
            // colData1
            // 
            this.colData1.FieldName = "Data";
            this.colData1.Name = "colData1";
            this.colData1.Visible = true;
            this.colData1.VisibleIndex = 6;
            // 
            // colGodzina1
            // 
            this.colGodzina1.FieldName = "Godzina";
            this.colGodzina1.Name = "colGodzina1";
            this.colGodzina1.Visible = true;
            this.colGodzina1.VisibleIndex = 7;
            // 
            // colID_ICD_11
            // 
            this.colID_ICD_11.Caption = "Kod ICD 1";
            this.colID_ICD_11.FieldName = "ID_ICD_1";
            this.colID_ICD_11.Name = "colID_ICD_11";
            this.colID_ICD_11.Visible = true;
            this.colID_ICD_11.VisibleIndex = 8;
            // 
            // colID_ICD_21
            // 
            this.colID_ICD_21.Caption = "Kod ICD 2";
            this.colID_ICD_21.FieldName = "ID_ICD_2";
            this.colID_ICD_21.Name = "colID_ICD_21";
            this.colID_ICD_21.Visible = true;
            this.colID_ICD_21.VisibleIndex = 9;
            // 
            // colID_ICD_31
            // 
            this.colID_ICD_31.Caption = "Kod ICD 3";
            this.colID_ICD_31.FieldName = "ID_ICD_3";
            this.colID_ICD_31.Name = "colID_ICD_31";
            this.colID_ICD_31.Visible = true;
            this.colID_ICD_31.VisibleIndex = 10;
            // 
            // colID_Lekarz1
            // 
            this.colID_Lekarz1.Caption = "Lekarz przyjmujący";
            this.colID_Lekarz1.FieldName = "ID_Lekarz";
            this.colID_Lekarz1.Name = "colID_Lekarz1";
            this.colID_Lekarz1.Visible = true;
            this.colID_Lekarz1.VisibleIndex = 11;
            // 
            // WelcomePage
            // 
            this.WelcomePage.Caption = "Start";
            this.WelcomePage.Controls.Add(this.panelControl1);
            this.WelcomePage.Image = ((System.Drawing.Image)(resources.GetObject("WelcomePage.Image")));
            this.WelcomePage.ItemShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.WelcomePage.Name = "WelcomePage";
            this.WelcomePage.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.WelcomePage.Size = new System.Drawing.Size(1900, 485);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ICDButton);
            this.panelControl1.Controls.Add(this.insuranceButton);
            this.panelControl1.Controls.Add(this.statisticsButton);
            this.panelControl1.Controls.Add(this.arrangeVisitButtonOnTab);
            this.panelControl1.Controls.Add(this.visitButton);
            this.panelControl1.Controls.Add(this.info2Label);
            this.panelControl1.Controls.Add(this.patientButton);
            this.panelControl1.Controls.Add(this.greetingsLabel);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1900, 485);
            this.panelControl1.TabIndex = 0;
            // 
            // ICDButton
            // 
            this.ICDButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICDButton.Appearance.Options.UseFont = true;
            this.ICDButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ICDButton.ImageOptions.Image")));
            this.ICDButton.Location = new System.Drawing.Point(1261, 115);
            this.ICDButton.Name = "ICDButton";
            this.ICDButton.Size = new System.Drawing.Size(115, 51);
            this.ICDButton.TabIndex = 23;
            this.ICDButton.Text = "Kody ICD";
            this.ICDButton.Click += new System.EventHandler(this.ICDButton_Click);
            // 
            // insuranceButton
            // 
            this.insuranceButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.insuranceButton.Appearance.Options.UseFont = true;
            this.insuranceButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("insuranceButton.ImageOptions.Image")));
            this.insuranceButton.Location = new System.Drawing.Point(1099, 115);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.Size = new System.Drawing.Size(146, 51);
            this.insuranceButton.TabIndex = 22;
            this.insuranceButton.Text = "Ubezpieczenie";
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.statisticsButton.Appearance.Options.UseFont = true;
            this.statisticsButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("statisticsButton.ImageOptions.Image")));
            this.statisticsButton.Location = new System.Drawing.Point(968, 115);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(116, 51);
            this.statisticsButton.TabIndex = 21;
            this.statisticsButton.Text = "Statystyki";
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // arrangeVisitButtonOnTab
            // 
            this.arrangeVisitButtonOnTab.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.arrangeVisitButtonOnTab.Appearance.Options.UseFont = true;
            this.arrangeVisitButtonOnTab.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("arrangeVisitButtonOnTab.ImageOptions.Image")));
            this.arrangeVisitButtonOnTab.Location = new System.Drawing.Point(807, 115);
            this.arrangeVisitButtonOnTab.Name = "arrangeVisitButtonOnTab";
            this.arrangeVisitButtonOnTab.Size = new System.Drawing.Size(146, 51);
            this.arrangeVisitButtonOnTab.TabIndex = 20;
            this.arrangeVisitButtonOnTab.Text = "Umów wizytę";
            this.arrangeVisitButtonOnTab.Click += new System.EventHandler(this.arrangeVisitButtonOnTab_Click);
            // 
            // visitButton
            // 
            this.visitButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visitButton.Appearance.Options.UseFont = true;
            this.visitButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("visitButton.ImageOptions.Image")));
            this.visitButton.Location = new System.Drawing.Point(698, 115);
            this.visitButton.Name = "visitButton";
            this.visitButton.Size = new System.Drawing.Size(94, 51);
            this.visitButton.TabIndex = 19;
            this.visitButton.Text = "Wizyta";
            this.visitButton.Click += new System.EventHandler(this.visitButton_Click);
            // 
            // info2Label
            // 
            this.info2Label.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.info2Label.Appearance.Options.UseFont = true;
            this.info2Label.Location = new System.Drawing.Point(677, 75);
            this.info2Label.Name = "info2Label";
            this.info2Label.Size = new System.Drawing.Size(591, 19);
            this.info2Label.TabIndex = 18;
            this.info2Label.Text = "Lub naciśnij jeden z poniższych przycisków, aby przenieść się do wybranej zakładk" +
    "i.";
            // 
            // patientButton
            // 
            this.patientButton.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.patientButton.Appearance.Options.UseFont = true;
            this.patientButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("patientButton.ImageOptions.Image")));
            this.patientButton.Location = new System.Drawing.Point(570, 115);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(113, 51);
            this.patientButton.TabIndex = 17;
            this.patientButton.Text = "Pacjenci";
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // greetingsLabel
            // 
            this.greetingsLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.greetingsLabel.Appearance.Options.UseFont = true;
            this.greetingsLabel.Location = new System.Drawing.Point(890, 208);
            this.greetingsLabel.Name = "greetingsLabel";
            this.greetingsLabel.Size = new System.Drawing.Size(126, 19);
            this.greetingsLabel.TabIndex = 16;
            this.greetingsLabel.Text = "Życzę miłej pracy!";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(633, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(651, 19);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "Jeżeli chcesz rozpocząć pracę z aplikacją wybierz jedną z zakładek znajdujących s" +
    "ię powyżej.";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(858, 5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(185, 25);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Witaj w aplikacji!";
            // 
            // uMOWWIZTEBindingSource
            // 
            this.uMOWWIZTEBindingSource.DataMember = "UMOW_WIZTE";
            this.uMOWWIZTEBindingSource.DataSource = this.poradniaDataSet;
            // 
            // uBEZPIECZENIETableAdapter
            // 
            this.uBEZPIECZENIETableAdapter.ClearBeforeFill = true;
            // 
            // time
            // 
            this.time.Tick += new System.EventHandler(this.Time_Tick);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // iCDTableAdapter
            // 
            this.iCDTableAdapter.ClearBeforeFill = true;
            // 
            // uzytkownikTableAdapter
            // 
            this.uzytkownikTableAdapter.ClearBeforeFill = true;
            // 
            // visit_viewTableAdapter
            // 
            this.visit_viewTableAdapter.ClearBeforeFill = true;
            // 
            // wIZYTABindingSource
            // 
            this.wIZYTABindingSource.DataMember = "WIZYTA";
            this.wIZYTABindingSource.DataSource = this.poradniaDataSet;
            // 
            // wIZYTATableAdapter
            // 
            this.wIZYTATableAdapter.ClearBeforeFill = true;
            // 
            // uMOW_WIZTETableAdapter
            // 
            this.uMOW_WIZTETableAdapter.ClearBeforeFill = true;
            // 
            // arrange_visit_viewTableAdapter
            // 
            this.arrange_visit_viewTableAdapter.ClearBeforeFill = true;
            // 
            // statistics_viewTableAdapter
            // 
            this.statistics_viewTableAdapter.ClearBeforeFill = true;
            // 
            // patient_viewTableAdapter
            // 
            this.patient_viewTableAdapter.ClearBeforeFill = true;
            // 
            // pACJENTBindingSource
            // 
            this.pACJENTBindingSource.DataMember = "PACJENT";
            this.pACJENTBindingSource.DataSource = this.poradniaDataSet;
            // 
            // pACJENTTableAdapter
            // 
            this.pACJENTTableAdapter.ClearBeforeFill = true;
            // 
            // infoLabel
            // 
            this.infoLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Appearance.Options.UseFont = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 454);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(651, 19);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Jeżeli chcesz rozpocząć pracę z aplikacją wybierz jedną z zakładek znajdujących s" +
    "ię powyżej.";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.welcomeLabel.Appearance.Options.UseFont = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 448);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(185, 25);
            this.welcomeLabel.TabIndex = 14;
            this.welcomeLabel.Text = "Witaj w aplikacji!";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 719);
            this.Controls.Add(this.tabPane1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "AdminMenu";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.PacjenciPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPacjent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPacjent)).EndInit();
            this.UbezpieczeniePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUbezpieczenie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uBEZPIECZENIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUbezpieczenie)).EndInit();
            this.ICDPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridICD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewICD)).EndInit();
            this.WizytaPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridWizyta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWizyta)).EndInit();
            this.UmowWizytePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUmowWizyte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrangevisitviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUmowWizyte)).EndInit();
            this.StatystykiPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStatistics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statisticsviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStatistics)).EndInit();
            this.WelcomePage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uMOWWIZTEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonMenu;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup PacjenciGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private PoradniaDataSet poradniaDataSet;
        private DevExpress.XtraBars.Navigation.TabNavigationPage PacjenciPage;
        private DevExpress.XtraBars.Navigation.TabNavigationPage UbezpieczeniePage;
        private DevExpress.XtraGrid.GridControl gridUbezpieczenie;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUbezpieczenie;
        private System.Windows.Forms.BindingSource uBEZPIECZENIEBindingSource;
        private PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter uBEZPIECZENIETableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Ubezpieczenie1;
        private DevExpress.XtraGrid.Columns.GridColumn colRodzaj;
        private DevExpress.XtraBars.BarButtonItem addPatient;
        private DevExpress.XtraBars.BarButtonItem savePatientXLSButton;
        private DevExpress.XtraBars.BarButtonItem deleteButtonP;
        private DevExpress.XtraBars.Navigation.TabNavigationPage ICDPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup UbezpieczenieGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ICDGroup;
        private DevExpress.XtraBars.BarButtonItem addICD;
        private DevExpress.XtraBars.BarButtonItem saveChangesICD;
        private DevExpress.XtraBars.BarButtonItem addVisit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup WizytaGroup;
        private DevExpress.XtraBars.Navigation.TabNavigationPage WizytaPage;
        private DevExpress.XtraBars.BarButtonItem saveVisitXLSButton;
        private DevExpress.XtraBars.BarButtonItem deleteButtonU;
        private DevExpress.XtraBars.BarButtonItem deleteButtonI;
        private DevExpress.XtraBars.BarButtonItem deleteButtonW;
        private DevExpress.XtraBars.BarButtonItem dodajUbezp;
        private DevExpress.XtraBars.BarButtonItem editPatient;
        private System.Windows.Forms.Timer time;
        private DevExpress.XtraBars.BarStaticItem timeItem;
        private DevExpress.XtraBars.BarToggleSwitchItem deleteModeBar;
        private DevExpress.XtraBars.BarStaticItem deleteModeLabelPatient;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarToggleSwitchItem deleteBarWizyta;
        private DevExpress.XtraBars.BarStaticItem deleteModeLabelVisit;
        private DevExpress.XtraGrid.GridControl gridICD;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewICD;
        private DevExpress.XtraGrid.Columns.GridColumn colidICD;
        private DevExpress.XtraGrid.Columns.GridColumn colKod_ICD;
        private DevExpress.XtraGrid.Columns.GridColumn colRozpoznanie;
        private System.Windows.Forms.BindingSource iCDBindingSource;
        private PoradniaDataSetTableAdapters.ICDTableAdapter iCDTableAdapter;
        private DevExpress.XtraBars.BarButtonItem viewVisit;
        private DevExpress.XtraBars.BarButtonItem editVisit;
        private System.Windows.Forms.BindingSource adminviewBindingSource;
        private DevExpress.XtraBars.BarStaticItem loggedAsText;
        private PoradniaDataSetTableAdapters.UZYTKOWNIKTableAdapter uzytkownikTableAdapter;
        private DevExpress.XtraBars.BarButtonItem findPatientButton;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private System.Windows.Forms.BindingSource visitviewBindingSource;
        private PoradniaDataSetTableAdapters.visit_viewTableAdapter visit_viewTableAdapter;
        private System.Windows.Forms.BindingSource wIZYTABindingSource;
        private PoradniaDataSetTableAdapters.WIZYTATableAdapter wIZYTATableAdapter;
        private DevExpress.XtraBars.BarButtonItem findVisitButton;
        private DevExpress.XtraBars.BarButtonItem findICDButton;
        private DevExpress.XtraBars.Navigation.TabNavigationPage UmowWizytePage;
        private DevExpress.XtraBars.Navigation.TabNavigationPage StatystykiPage;
        private System.Windows.Forms.BindingSource uMOWWIZTEBindingSource;
        private PoradniaDataSetTableAdapters.UMOW_WIZTETableAdapter uMOW_WIZTETableAdapter;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup UmowWizyteGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup StatystykiGroup;
        private DevExpress.XtraBars.BarButtonItem arrangeVisitButton;
        private DevExpress.XtraBars.BarButtonItem deleteArrangedVisitButton;
        private DevExpress.XtraBars.BarButtonItem startArrangedVisitButton;
        private DevExpress.XtraBars.BarCheckItem filterStdButton;
        private DevExpress.XtraBars.BarCheckItem filterAdvButton;
        private System.Windows.Forms.BindingSource arrangevisitviewBindingSource;
        private PoradniaDataSetTableAdapters.arrange_visit_viewTableAdapter arrange_visit_viewTableAdapter;
        private System.Windows.Forms.BindingSource statisticsviewBindingSource;
        private PoradniaDataSetTableAdapters.statistics_viewTableAdapter statistics_viewTableAdapter;
        private DevExpress.XtraGrid.GridControl gridUmowWizyte;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUmowWizyte;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Umow_Wizyte;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Pacjent3;
        private DevExpress.XtraGrid.Columns.GridColumn colPacjent2;
        private DevExpress.XtraGrid.Columns.GridColumn colData2;
        private DevExpress.XtraGrid.Columns.GridColumn colGodzina2;
        private DevExpress.XtraBars.BarButtonItem statisticsExportToXLSButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DevExpress.XtraGrid.GridControl gridWizyta;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWizyta;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Wizyta;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Pacjent1;
        private DevExpress.XtraGrid.Columns.GridColumn colPacjent;
        private DevExpress.XtraGrid.Columns.GridColumn colData;
        private DevExpress.XtraGrid.Columns.GridColumn colGodzina;
        private DevExpress.XtraGrid.Columns.GridColumn colObjawy;
        private DevExpress.XtraGrid.Columns.GridColumn colBPrzedmiotowe;
        private DevExpress.XtraGrid.Columns.GridColumn colBPodmiotowe;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ICD_1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ICD_2;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ICD_3;
        private DevExpress.XtraGrid.Columns.GridColumn colRozpoznanie1;
        private DevExpress.XtraGrid.Columns.GridColumn colLeki;
        private DevExpress.XtraGrid.Columns.GridColumn colZalecenia;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Lekarz;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.LabelControl recordNumberTB;
        private DevExpress.XtraGrid.GridControl gridStatistics;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStatistics;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Wizyta1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Pacjent2;
        private DevExpress.XtraGrid.Columns.GridColumn colPacjent1;
        private DevExpress.XtraGrid.Columns.GridColumn colPlec1;
        private DevExpress.XtraGrid.Columns.GridColumn colRodzaj1;
        private DevExpress.XtraGrid.Columns.GridColumn colKraj1;
        private DevExpress.XtraGrid.Columns.GridColumn colData1;
        private DevExpress.XtraGrid.Columns.GridColumn colGodzina1;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ICD_11;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ICD_21;
        private DevExpress.XtraGrid.Columns.GridColumn colID_ICD_31;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Lekarz1;
        private DevExpress.XtraBars.BarButtonItem clearFiltersStatictisButton;
        private System.Windows.Forms.BindingSource patientviewBindingSource;
        private PoradniaDataSetTableAdapters.patient_viewTableAdapter patient_viewTableAdapter;
        private System.Windows.Forms.BindingSource pACJENTBindingSource;
        private PoradniaDataSetTableAdapters.PACJENTTableAdapter pACJENTTableAdapter;
        private DevExpress.XtraGrid.GridControl gridPacjent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPacjent;
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
        private DevExpress.XtraGrid.Columns.GridColumn colNumer_EKUZ;
        private DevExpress.XtraBars.Navigation.TabNavigationPage WelcomePage;
        private DevExpress.XtraBars.BarButtonItem refreshButton;
        private DevExpress.XtraBars.BarButtonItem closeButton;
        private DevExpress.XtraBars.BarButtonItem saveArrangedVisitXLSButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup otherGroup;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton ICDButton;
        private DevExpress.XtraEditors.SimpleButton insuranceButton;
        private DevExpress.XtraEditors.SimpleButton statisticsButton;
        private DevExpress.XtraEditors.SimpleButton arrangeVisitButtonOnTab;
        private DevExpress.XtraEditors.SimpleButton visitButton;
        private DevExpress.XtraEditors.LabelControl info2Label;
        private DevExpress.XtraEditors.SimpleButton patientButton;
        private DevExpress.XtraEditors.LabelControl greetingsLabel;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl infoLabel;
        private DevExpress.XtraEditors.LabelControl welcomeLabel;
        private DevExpress.XtraBars.BarButtonItem addUserButton;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup userGroup;
        private DevExpress.XtraBars.BarButtonItem clearFilter;
    }
}