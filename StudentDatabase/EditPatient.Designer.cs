namespace StudentDatabase
{
    partial class EditPatient
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::StudentDatabase.FormLoad), true, true);
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPatient));
            this.uBEZPIECZENIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.pLECBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.IDTB = new DevExpress.XtraEditors.TextEdit();
            this.pLECTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.PLECTableAdapter();
            this.uBEZPIECZENIETableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter();
            this.kRAJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRAJTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.KRAJTableAdapter();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.phoneCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.kpSelect = new DevExpress.XtraEditors.ComboBoxEdit();
            this.searchButton = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.checkPESEL = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.paszportCB = new DevExpress.XtraEditors.CheckButton();
            this.dowodosobistyCB = new DevExpress.XtraEditors.CheckButton();
            this.peselCB = new DevExpress.XtraEditors.CheckButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.krajSelect = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Kraj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKraj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plecSelect = new System.Windows.Forms.ComboBox();
            this.ubezpieczenieSelect = new System.Windows.Forms.ComboBox();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.miastoTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.kodTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.mieszkanieTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.budynekTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.ulicaTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.telefonTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.paszportTB = new DevExpress.XtraEditors.TextEdit();
            this.dowodTB = new DevExpress.XtraEditors.TextEdit();
            this.ekuzTB = new DevExpress.XtraEditors.TextEdit();
            this.peselTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nazwiskoTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.dataur = new DevExpress.XtraEditors.DateEdit();
            this.imieTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.editPatient2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.gridEditPacjent = new DevExpress.XtraGrid.GridControl();
            this.pACJENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridViewEditPacjent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Pacjent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNazwisko = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colData_urodzenia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKraj1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.pACJENTTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.PACJENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uBEZPIECZENIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLECBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRAJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miastoTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mieszkanieTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budynekTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulicaTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paszportTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekuzTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazwiskoTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataur.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imieTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditPacjent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEditPacjent)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            splashScreenManager.ClosingDelay = 25;
            // 
            // uBEZPIECZENIEBindingSource
            // 
            this.uBEZPIECZENIEBindingSource.DataMember = "UBEZPIECZENIE";
            this.uBEZPIECZENIEBindingSource.DataSource = this.poradniaDataSet;
            // 
            // poradniaDataSet
            // 
            this.poradniaDataSet.DataSetName = "PoradniaDataSet";
            this.poradniaDataSet.Locale = new System.Globalization.CultureInfo("pl");
            this.poradniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pLECBindingSource
            // 
            this.pLECBindingSource.DataMember = "PLEC";
            this.pLECBindingSource.DataSource = this.poradniaDataSet;
            // 
            // dxValidationProvider
            // 
            this.dxValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // IDTB
            // 
            this.IDTB.Enabled = false;
            this.IDTB.Location = new System.Drawing.Point(121, 42);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(199, 20);
            this.IDTB.TabIndex = 1;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Pole nie może być puste";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.dxValidationProvider.SetValidationRule(this.IDTB, conditionValidationRule1);
            // 
            // pLECTableAdapter
            // 
            this.pLECTableAdapter.ClearBeforeFill = true;
            // 
            // uBEZPIECZENIETableAdapter
            // 
            this.uBEZPIECZENIETableAdapter.ClearBeforeFill = true;
            // 
            // kRAJBindingSource
            // 
            this.kRAJBindingSource.DataMember = "KRAJ";
            this.kRAJBindingSource.DataSource = this.poradniaDataSet;
            // 
            // kRAJTableAdapter
            // 
            this.kRAJTableAdapter.ClearBeforeFill = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.phoneCheckEdit);
            this.splitContainer1.Panel1.Controls.Add(this.kpSelect);
            this.splitContainer1.Panel1.Controls.Add(this.searchButton);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl17);
            this.splitContainer1.Panel1.Controls.Add(this.checkPESEL);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainer1.Panel1.Controls.Add(this.paszportCB);
            this.splitContainer1.Panel1.Controls.Add(this.dowodosobistyCB);
            this.splitContainer1.Panel1.Controls.Add(this.peselCB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl15);
            this.splitContainer1.Panel1.Controls.Add(this.krajSelect);
            this.splitContainer1.Panel1.Controls.Add(this.plecSelect);
            this.splitContainer1.Panel1.Controls.Add(this.ubezpieczenieSelect);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl14);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl13);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl11);
            this.splitContainer1.Panel1.Controls.Add(this.miastoTB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl12);
            this.splitContainer1.Panel1.Controls.Add(this.kodTB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl10);
            this.splitContainer1.Panel1.Controls.Add(this.mieszkanieTB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainer1.Panel1.Controls.Add(this.budynekTB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainer1.Panel1.Controls.Add(this.ulicaTB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainer1.Panel1.Controls.Add(this.telefonTB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainer1.Panel1.Controls.Add(this.paszportTB);
            this.splitContainer1.Panel1.Controls.Add(this.dowodTB);
            this.splitContainer1.Panel1.Controls.Add(this.ekuzTB);
            this.splitContainer1.Panel1.Controls.Add(this.peselTB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainer1.Panel1.Controls.Add(this.nazwiskoTB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl18);
            this.splitContainer1.Panel1.Controls.Add(this.dataur);
            this.splitContainer1.Panel1.Controls.Add(this.imieTB);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl16);
            this.splitContainer1.Panel1.Controls.Add(this.IDTB);
            this.splitContainer1.Panel1.Controls.Add(this.closeButton);
            this.splitContainer1.Panel1.Controls.Add(this.editPatient2);
            this.splitContainer1.Panel1.Controls.Add(this.labelControl8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridEditPacjent);
            this.splitContainer1.Size = new System.Drawing.Size(1904, 961);
            this.splitContainer1.SplitterDistance = 357;
            this.splitContainer1.TabIndex = 0;
            // 
            // phoneCheckEdit
            // 
            this.phoneCheckEdit.Location = new System.Drawing.Point(98, 175);
            this.phoneCheckEdit.Name = "phoneCheckEdit";
            this.phoneCheckEdit.Properties.Caption = "";
            this.phoneCheckEdit.Size = new System.Drawing.Size(16, 19);
            this.phoneCheckEdit.TabIndex = 261;
            this.phoneCheckEdit.CheckedChanged += new System.EventHandler(this.phoneCheckEdit_CheckedChanged);
            // 
            // kpSelect
            // 
            this.kpSelect.EditValue = "Nie";
            this.kpSelect.Location = new System.Drawing.Point(140, 438);
            this.kpSelect.Name = "kpSelect";
            this.kpSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.kpSelect.Properties.DropDownRows = 2;
            this.kpSelect.Properties.Items.AddRange(new object[] {
            "Nie",
            "Tak"});
            this.kpSelect.Size = new System.Drawing.Size(180, 20);
            this.kpSelect.TabIndex = 19;
            // 
            // searchButton
            // 
            this.searchButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.ImageOptions.Image")));
            this.searchButton.Location = new System.Drawing.Point(275, 8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Wyszukaj";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(28, 438);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(64, 13);
            this.labelControl17.TabIndex = 260;
            this.labelControl17.Text = "Karta Polaka:";
            // 
            // checkPESEL
            // 
            this.checkPESEL.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.checkPESEL.Location = new System.Drawing.Point(243, 526);
            this.checkPESEL.Name = "checkPESEL";
            this.checkPESEL.Size = new System.Drawing.Size(81, 52);
            this.checkPESEL.TabIndex = 22;
            this.checkPESEL.Text = "Sprawdź PESEL";
            this.checkPESEL.Click += new System.EventHandler(this.checkPESEL_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(28, 494);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 259;
            this.labelControl1.Text = "Numer EKUZ:";
            // 
            // paszportCB
            // 
            this.paszportCB.Location = new System.Drawing.Point(28, 409);
            this.paszportCB.Name = "paszportCB";
            this.paszportCB.Size = new System.Drawing.Size(102, 23);
            this.paszportCB.TabIndex = 17;
            this.paszportCB.Text = "Paszport:";
            // 
            // dowodosobistyCB
            // 
            this.dowodosobistyCB.Location = new System.Drawing.Point(28, 383);
            this.dowodosobistyCB.Name = "dowodosobistyCB";
            this.dowodosobistyCB.Size = new System.Drawing.Size(102, 23);
            this.dowodosobistyCB.TabIndex = 15;
            this.dowodosobistyCB.Text = "Dowód osobisty:";
            // 
            // peselCB
            // 
            this.peselCB.Location = new System.Drawing.Point(28, 355);
            this.peselCB.Name = "peselCB";
            this.peselCB.Size = new System.Drawing.Size(102, 23);
            this.peselCB.TabIndex = 13;
            this.peselCB.Text = "PESEL:";
            // 
            // labelControl15
            // 
            this.labelControl15.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl15.Appearance.Options.UseFont = true;
            this.labelControl15.Location = new System.Drawing.Point(151, 332);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(66, 19);
            this.labelControl15.TabIndex = 258;
            this.labelControl15.Text = "Pozostałe";
            // 
            // krajSelect
            // 
            this.krajSelect.EditValue = "";
            this.krajSelect.Location = new System.Drawing.Point(121, 148);
            this.krajSelect.Name = "krajSelect";
            this.krajSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.krajSelect.Properties.DataSource = this.kRAJBindingSource;
            this.krajSelect.Properties.DisplayMember = "Kraj";
            this.krajSelect.Properties.ValueMember = "ID_Kraj";
            this.krajSelect.Properties.View = this.gridView2;
            this.krajSelect.Size = new System.Drawing.Size(199, 20);
            this.krajSelect.TabIndex = 5;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Kraj,
            this.colKraj});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            this.gridView2.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_Kraj, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID_Kraj
            // 
            this.colID_Kraj.FieldName = "ID_Kraj";
            this.colID_Kraj.Name = "colID_Kraj";
            // 
            // colKraj
            // 
            this.colKraj.FieldName = "Kraj";
            this.colKraj.Name = "colKraj";
            this.colKraj.Visible = true;
            this.colKraj.VisibleIndex = 0;
            this.colKraj.Width = 76;
            // 
            // plecSelect
            // 
            this.plecSelect.DataSource = this.pLECBindingSource;
            this.plecSelect.DisplayMember = "Plec";
            this.plecSelect.FormattingEnabled = true;
            this.plecSelect.Location = new System.Drawing.Point(121, 200);
            this.plecSelect.Name = "plecSelect";
            this.plecSelect.Size = new System.Drawing.Size(199, 21);
            this.plecSelect.TabIndex = 7;
            this.plecSelect.ValueMember = "ID_Plec";
            // 
            // ubezpieczenieSelect
            // 
            this.ubezpieczenieSelect.DataSource = this.uBEZPIECZENIEBindingSource;
            this.ubezpieczenieSelect.DisplayMember = "Rodzaj";
            this.ubezpieczenieSelect.FormattingEnabled = true;
            this.ubezpieczenieSelect.Location = new System.Drawing.Point(140, 464);
            this.ubezpieczenieSelect.Name = "ubezpieczenieSelect";
            this.ubezpieczenieSelect.Size = new System.Drawing.Size(180, 21);
            this.ubezpieczenieSelect.TabIndex = 20;
            this.ubezpieczenieSelect.ValueMember = "ID_Ubezpieczenie";
            this.ubezpieczenieSelect.SelectedIndexChanged += new System.EventHandler(this.ubezpieczenieSelect_SelectedIndexChanged);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(28, 467);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(72, 13);
            this.labelControl14.TabIndex = 257;
            this.labelControl14.Text = "Ubezpieczenie:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(28, 203);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(24, 13);
            this.labelControl13.TabIndex = 256;
            this.labelControl13.Text = "Płeć:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(194, 309);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(35, 13);
            this.labelControl11.TabIndex = 255;
            this.labelControl11.Text = "Miasto:";
            // 
            // miastoTB
            // 
            this.miastoTB.Location = new System.Drawing.Point(243, 306);
            this.miastoTB.Name = "miastoTB";
            this.miastoTB.Properties.Mask.EditMask = "[a-zA-Z0-9 /]{0,30}";
            this.miastoTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.miastoTB.Properties.Mask.ShowPlaceHolders = false;
            this.miastoTB.Size = new System.Drawing.Size(77, 20);
            this.miastoTB.TabIndex = 12;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(28, 309);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(71, 13);
            this.labelControl12.TabIndex = 254;
            this.labelControl12.Text = "Kod pocztowy:";
            // 
            // kodTB
            // 
            this.kodTB.Location = new System.Drawing.Point(121, 306);
            this.kodTB.Name = "kodTB";
            this.kodTB.Properties.Mask.EditMask = "\\d\\d-\\d\\d\\d";
            this.kodTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.kodTB.Properties.Mask.ShowPlaceHolders = false;
            this.kodTB.Properties.ValidateOnEnterKey = true;
            this.kodTB.Size = new System.Drawing.Size(61, 20);
            this.kodTB.TabIndex = 11;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(172, 281);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(89, 13);
            this.labelControl10.TabIndex = 253;
            this.labelControl10.Text = "Numer mieszkania:";
            // 
            // mieszkanieTB
            // 
            this.mieszkanieTB.Location = new System.Drawing.Point(275, 278);
            this.mieszkanieTB.Name = "mieszkanieTB";
            this.mieszkanieTB.Properties.Mask.EditMask = "[0-9 /,.]{0,5}";
            this.mieszkanieTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.mieszkanieTB.Properties.Mask.ShowPlaceHolders = false;
            this.mieszkanieTB.Size = new System.Drawing.Size(45, 20);
            this.mieszkanieTB.TabIndex = 10;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(160, 227);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 19);
            this.labelControl9.TabIndex = 252;
            this.labelControl9.Text = "Adres";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(28, 281);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 13);
            this.labelControl6.TabIndex = 251;
            this.labelControl6.Text = "Numer budynku:";
            // 
            // budynekTB
            // 
            this.budynekTB.Location = new System.Drawing.Point(121, 278);
            this.budynekTB.Name = "budynekTB";
            this.budynekTB.Properties.Mask.EditMask = "[A-Z0-9 /]{0,5}";
            this.budynekTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.budynekTB.Properties.Mask.ShowPlaceHolders = false;
            this.budynekTB.Size = new System.Drawing.Size(45, 20);
            this.budynekTB.TabIndex = 9;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(28, 255);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(26, 13);
            this.labelControl7.TabIndex = 250;
            this.labelControl7.Text = "Ulica:";
            // 
            // ulicaTB
            // 
            this.ulicaTB.Location = new System.Drawing.Point(121, 252);
            this.ulicaTB.Name = "ulicaTB";
            this.ulicaTB.Properties.Mask.EditMask = "[a-zA-Z0-9 .,/]{0,50}";
            this.ulicaTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.ulicaTB.Properties.Mask.ShowPlaceHolders = false;
            this.ulicaTB.Size = new System.Drawing.Size(199, 20);
            this.ulicaTB.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(28, 177);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 249;
            this.labelControl4.Text = "Telefon:";
            // 
            // telefonTB
            // 
            this.telefonTB.EditValue = "+48";
            this.telefonTB.Location = new System.Drawing.Point(121, 174);
            this.telefonTB.Name = "telefonTB";
            this.telefonTB.Properties.Mask.EditMask = "(\\+48-)[0-9]{0,3}(-)[0-9]{0,3}(-)[0-9]{0,3}";
            this.telefonTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.telefonTB.Properties.Mask.ShowPlaceHolders = false;
            this.telefonTB.Size = new System.Drawing.Size(199, 20);
            this.telefonTB.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(28, 151);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 13);
            this.labelControl5.TabIndex = 248;
            this.labelControl5.Text = "Kraj pochodzenia:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(28, 125);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 247;
            this.labelControl3.Text = "Data urodzenia:";
            // 
            // paszportTB
            // 
            this.paszportTB.Enabled = false;
            this.paszportTB.Location = new System.Drawing.Point(140, 409);
            this.paszportTB.Name = "paszportTB";
            this.paszportTB.Properties.Mask.EditMask = "[A-Z0-9]{0,20}";
            this.paszportTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.paszportTB.Properties.Mask.ShowPlaceHolders = false;
            this.paszportTB.Size = new System.Drawing.Size(180, 20);
            this.paszportTB.TabIndex = 18;
            // 
            // dowodTB
            // 
            this.dowodTB.Enabled = false;
            this.dowodTB.Location = new System.Drawing.Point(140, 383);
            this.dowodTB.Name = "dowodTB";
            this.dowodTB.Properties.Mask.EditMask = "[A-Z0-9]{0,15}";
            this.dowodTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.dowodTB.Properties.Mask.ShowPlaceHolders = false;
            this.dowodTB.Size = new System.Drawing.Size(180, 20);
            this.dowodTB.TabIndex = 16;
            // 
            // ekuzTB
            // 
            this.ekuzTB.Enabled = false;
            this.ekuzTB.Location = new System.Drawing.Point(140, 491);
            this.ekuzTB.Name = "ekuzTB";
            this.ekuzTB.Properties.Mask.EditMask = "[0-9]{0,20}";
            this.ekuzTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.ekuzTB.Properties.Mask.ShowPlaceHolders = false;
            this.ekuzTB.Size = new System.Drawing.Size(180, 20);
            this.ekuzTB.TabIndex = 21;
            // 
            // peselTB
            // 
            this.peselTB.Enabled = false;
            this.peselTB.Location = new System.Drawing.Point(140, 357);
            this.peselTB.Name = "peselTB";
            this.peselTB.Properties.Mask.EditMask = "[0-9]{0,11}";
            this.peselTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.peselTB.Properties.Mask.ShowPlaceHolders = false;
            this.peselTB.Size = new System.Drawing.Size(180, 20);
            this.peselTB.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 99);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 246;
            this.labelControl2.Text = "Nazwisko:";
            // 
            // nazwiskoTB
            // 
            this.nazwiskoTB.Location = new System.Drawing.Point(121, 96);
            this.nazwiskoTB.Name = "nazwiskoTB";
            this.nazwiskoTB.Properties.Mask.EditMask = "[a-zA-Z ,./-]{0,50}";
            this.nazwiskoTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.nazwiskoTB.Properties.Mask.ShowPlaceHolders = false;
            this.nazwiskoTB.Size = new System.Drawing.Size(199, 20);
            this.nazwiskoTB.TabIndex = 3;
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(28, 73);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(24, 13);
            this.labelControl18.TabIndex = 245;
            this.labelControl18.Text = "Imię:";
            // 
            // dataur
            // 
            this.dataur.EditValue = null;
            this.dataur.Location = new System.Drawing.Point(121, 122);
            this.dataur.Name = "dataur";
            this.dataur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataur.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataur.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.Classic;
            this.dataur.Properties.Mask.EditMask = "\\d?\\d?-\\d?\\d?-\\d\\d\\d\\d";
            this.dataur.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.dataur.Properties.Mask.ShowPlaceHolders = false;
            this.dataur.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dataur.Size = new System.Drawing.Size(199, 20);
            this.dataur.TabIndex = 4;
            // 
            // imieTB
            // 
            this.imieTB.Location = new System.Drawing.Point(121, 70);
            this.imieTB.Name = "imieTB";
            this.imieTB.Properties.Mask.EditMask = "[a-zA-Z ,.]{0,50}";
            this.imieTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.imieTB.Properties.Mask.ShowPlaceHolders = false;
            this.imieTB.Size = new System.Drawing.Size(199, 20);
            this.imieTB.TabIndex = 2;
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(28, 45);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(60, 13);
            this.labelControl16.TabIndex = 223;
            this.labelControl16.Text = "ID Pacjenta:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(130, 558);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 23);
            this.closeButton.TabIndex = 24;
            this.closeButton.Text = "Zamknij";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // editPatient2
            // 
            this.editPatient2.Location = new System.Drawing.Point(130, 529);
            this.editPatient2.Name = "editPatient2";
            this.editPatient2.Size = new System.Drawing.Size(99, 23);
            this.editPatient2.TabIndex = 23;
            this.editPatient2.Text = "Edytuj pacjenta";
            this.editPatient2.Click += new System.EventHandler(this.EditPatient2_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(109, 8);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(152, 19);
            this.labelControl8.TabIndex = 179;
            this.labelControl8.Text = "Edytuj dane osobowe";
            // 
            // gridEditPacjent
            // 
            this.gridEditPacjent.DataSource = this.pACJENTBindingSource;
            this.gridEditPacjent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEditPacjent.Location = new System.Drawing.Point(0, 0);
            this.gridEditPacjent.MainView = this.gridViewEditPacjent;
            this.gridEditPacjent.Name = "gridEditPacjent";
            this.gridEditPacjent.Size = new System.Drawing.Size(1543, 961);
            this.gridEditPacjent.TabIndex = 0;
            this.gridEditPacjent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEditPacjent});
            // 
            // pACJENTBindingSource
            // 
            this.pACJENTBindingSource.DataMember = "PACJENT";
            this.pACJENTBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridViewEditPacjent
            // 
            this.gridViewEditPacjent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Pacjent,
            this.colImie,
            this.colNazwisko,
            this.colData_urodzenia,
            this.colKraj1,
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
            this.gridViewEditPacjent.GridControl = this.gridEditPacjent;
            this.gridViewEditPacjent.Name = "gridViewEditPacjent";
            this.gridViewEditPacjent.OptionsBehavior.Editable = false;
            this.gridViewEditPacjent.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridViewEditPacjent.OptionsFind.ShowClearButton = false;
            this.gridViewEditPacjent.OptionsFind.ShowFindButton = false;
            this.gridViewEditPacjent.OptionsView.ShowGroupPanel = false;
            // 
            // colID_Pacjent
            // 
            this.colID_Pacjent.FieldName = "ID_Pacjent";
            this.colID_Pacjent.Name = "colID_Pacjent";
            this.colID_Pacjent.Visible = true;
            this.colID_Pacjent.VisibleIndex = 0;
            // 
            // colImie
            // 
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
            this.colData_urodzenia.FieldName = "Data_urodzenia";
            this.colData_urodzenia.Name = "colData_urodzenia";
            this.colData_urodzenia.Visible = true;
            this.colData_urodzenia.VisibleIndex = 3;
            // 
            // colKraj1
            // 
            this.colKraj1.FieldName = "Kraj";
            this.colKraj1.Name = "colKraj1";
            this.colKraj1.Visible = true;
            this.colKraj1.VisibleIndex = 4;
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
            this.colNr_budynku.FieldName = "Nr_budynku";
            this.colNr_budynku.Name = "colNr_budynku";
            this.colNr_budynku.Visible = true;
            this.colNr_budynku.VisibleIndex = 8;
            // 
            // colNr_mieszkania
            // 
            this.colNr_mieszkania.FieldName = "Nr_mieszkania";
            this.colNr_mieszkania.Name = "colNr_mieszkania";
            this.colNr_mieszkania.Visible = true;
            this.colNr_mieszkania.VisibleIndex = 9;
            // 
            // colKod_pocztowy
            // 
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
            this.colPESEL.FieldName = "PESEL";
            this.colPESEL.Name = "colPESEL";
            this.colPESEL.Visible = true;
            this.colPESEL.VisibleIndex = 12;
            // 
            // colKarta_polaka
            // 
            this.colKarta_polaka.FieldName = "Karta_polaka";
            this.colKarta_polaka.Name = "colKarta_polaka";
            this.colKarta_polaka.Visible = true;
            this.colKarta_polaka.VisibleIndex = 13;
            // 
            // colDowod_osobisty
            // 
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
            this.colNumer_EKUZ.FieldName = "Numer_EKUZ";
            this.colNumer_EKUZ.Name = "colNumer_EKUZ";
            this.colNumer_EKUZ.Visible = true;
            this.colNumer_EKUZ.VisibleIndex = 17;
            // 
            // pACJENTTableAdapter
            // 
            this.pACJENTTableAdapter.ClearBeforeFill = true;
            // 
            // EditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 961);
            this.Controls.Add(this.splitContainer1);
            this.Name = "EditPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edycja pacjenta";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EditPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uBEZPIECZENIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLECBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRAJBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phoneCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kpSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miastoTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mieszkanieTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budynekTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulicaTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paszportTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekuzTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazwiskoTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataur.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imieTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditPacjent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEditPacjent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PoradniaDataSet poradniaDataSet;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private System.Windows.Forms.BindingSource pLECBindingSource;
        private PoradniaDataSetTableAdapters.PLECTableAdapter pLECTableAdapter;
        private System.Windows.Forms.BindingSource uBEZPIECZENIEBindingSource;
        private PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter uBEZPIECZENIETableAdapter;
        private System.Windows.Forms.BindingSource kRAJBindingSource;
        private PoradniaDataSetTableAdapters.KRAJTableAdapter kRAJTableAdapter;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraEditors.SimpleButton editPatient2;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.TextEdit IDTB;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.SimpleButton checkPESEL;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckButton paszportCB;
        private DevExpress.XtraEditors.CheckButton dowodosobistyCB;
        private DevExpress.XtraEditors.CheckButton peselCB;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SearchLookUpEdit krajSelect;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Kraj;
        private DevExpress.XtraGrid.Columns.GridColumn colKraj;
        private System.Windows.Forms.ComboBox plecSelect;
        private System.Windows.Forms.ComboBox ubezpieczenieSelect;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit miastoTB;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit kodTB;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit mieszkanieTB;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit budynekTB;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit ulicaTB;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit telefonTB;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit paszportTB;
        private DevExpress.XtraEditors.TextEdit dowodTB;
        private DevExpress.XtraEditors.TextEdit ekuzTB;
        private DevExpress.XtraEditors.TextEdit peselTB;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit nazwiskoTB;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.DateEdit dataur;
        private DevExpress.XtraEditors.TextEdit imieTB;
        private DevExpress.XtraGrid.GridControl gridEditPacjent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEditPacjent;
        private System.Windows.Forms.BindingSource pACJENTBindingSource;
        private PoradniaDataSetTableAdapters.PACJENTTableAdapter pACJENTTableAdapter;
        private DevExpress.XtraEditors.SimpleButton searchButton;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Pacjent;
        private DevExpress.XtraGrid.Columns.GridColumn colImie;
        private DevExpress.XtraGrid.Columns.GridColumn colNazwisko;
        private DevExpress.XtraGrid.Columns.GridColumn colData_urodzenia;
        private DevExpress.XtraGrid.Columns.GridColumn colKraj1;
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
        private DevExpress.XtraEditors.ComboBoxEdit kpSelect;
        private DevExpress.XtraEditors.CheckEdit phoneCheckEdit;
    }
}