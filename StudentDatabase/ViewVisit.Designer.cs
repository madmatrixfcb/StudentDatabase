namespace StudentDatabase
{
    partial class ViewVisit
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewVisit));
            this.patientviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.pACJENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.visit_viewTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.visit_viewTableAdapter();
            this.patient_viewTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.patient_viewTableAdapter();
            this.pacjentTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.PACJENTTableAdapter();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.visitIDLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.dateLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.objawyLabelTB = new DevExpress.XtraEditors.MemoEdit();
            this.bprzedmiotoweLabelTB = new DevExpress.XtraEditors.MemoEdit();
            this.bpodmiotoweLabelTB = new DevExpress.XtraEditors.MemoEdit();
            this.ICD1LabelTB = new DevExpress.XtraEditors.TextEdit();
            this.ICD2LabelTB = new DevExpress.XtraEditors.TextEdit();
            this.ICD3LabelTB = new DevExpress.XtraEditors.TextEdit();
            this.rozpoznanieLabelTB = new DevExpress.XtraEditors.MemoEdit();
            this.lekiLabelTB = new DevExpress.XtraEditors.MemoEdit();
            this.zaleceniaLabelTB = new DevExpress.XtraEditors.MemoEdit();
            this.przyrjmujacyLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.patientIDLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.nameLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.surnameLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.birthLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.countryLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.sexLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.addressLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.phoneLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.peselLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.poleCardLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.dowodLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.passportLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.insuranceLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.visitIDLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.objawyLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.bprzedmiotoweLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.ICD1Label1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.rozpoznanieLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lekiLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.dateLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.bpodmiotoweLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.zaleceniaLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.przyrjmujacyLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.ICD2Label = new DevExpress.XtraLayout.LayoutControlItem();
            this.ICD3Label = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ICD1Label = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.exportToPDFButton = new DevExpress.XtraEditors.SimpleButton();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.patientviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitIDLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objawyLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bprzedmiotoweLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpodmiotoweLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD1LabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD2LabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD3LabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznanieLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekiLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaleceniaLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przyrjmujacyLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleCardLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitIDLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.objawyLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bprzedmiotoweLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD1Label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznanieLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekiLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpodmiotoweLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaleceniaLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.przyrjmujacyLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD2Label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD3Label)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD1Label)).BeginInit();
            this.SuspendLayout();
            // 
            // patientviewBindingSource
            // 
            this.patientviewBindingSource.DataMember = "patient_view";
            this.patientviewBindingSource.DataSource = this.poradniaDataSet;
            // 
            // poradniaDataSet
            // 
            this.poradniaDataSet.DataSetName = "PoradniaDataSet";
            this.poradniaDataSet.Locale = new System.Globalization.CultureInfo("pl");
            this.poradniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pACJENTBindingSource
            // 
            this.pACJENTBindingSource.DataMember = "PACJENT";
            this.pACJENTBindingSource.DataSource = this.poradniaDataSet;
            // 
            // visit_viewTableAdapter
            // 
            this.visit_viewTableAdapter.ClearBeforeFill = true;
            // 
            // patient_viewTableAdapter
            // 
            this.patient_viewTableAdapter.ClearBeforeFill = true;
            // 
            // pacjentTableAdapter
            // 
            this.pacjentTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.patientviewBindingSource;
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(1224, 143);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(207, 274);
            this.gridControl1.TabIndex = 26;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
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
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.visitIDLabelTB);
            this.layoutControl1.Controls.Add(this.dateLabelTB);
            this.layoutControl1.Controls.Add(this.objawyLabelTB);
            this.layoutControl1.Controls.Add(this.bprzedmiotoweLabelTB);
            this.layoutControl1.Controls.Add(this.bpodmiotoweLabelTB);
            this.layoutControl1.Controls.Add(this.ICD1LabelTB);
            this.layoutControl1.Controls.Add(this.ICD2LabelTB);
            this.layoutControl1.Controls.Add(this.ICD3LabelTB);
            this.layoutControl1.Controls.Add(this.rozpoznanieLabelTB);
            this.layoutControl1.Controls.Add(this.lekiLabelTB);
            this.layoutControl1.Controls.Add(this.zaleceniaLabelTB);
            this.layoutControl1.Controls.Add(this.przyrjmujacyLabelTB);
            this.layoutControl1.Controls.Add(this.patientIDLabelTB);
            this.layoutControl1.Controls.Add(this.nameLabelTB);
            this.layoutControl1.Controls.Add(this.surnameLabelTB);
            this.layoutControl1.Controls.Add(this.birthLabelTB);
            this.layoutControl1.Controls.Add(this.countryLabelTB);
            this.layoutControl1.Controls.Add(this.sexLabelTB);
            this.layoutControl1.Controls.Add(this.addressLabelTB);
            this.layoutControl1.Controls.Add(this.phoneLabelTB);
            this.layoutControl1.Controls.Add(this.peselLabelTB);
            this.layoutControl1.Controls.Add(this.poleCardLabelTB);
            this.layoutControl1.Controls.Add(this.dowodLabelTB);
            this.layoutControl1.Controls.Add(this.passportLabelTB);
            this.layoutControl1.Controls.Add(this.insuranceLabelTB);
            this.layoutControl1.Location = new System.Drawing.Point(6, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(472, 304, 450, 399);
            this.layoutControl1.OptionsItemText.TextAlignMode = DevExpress.XtraLayout.TextAlignMode.AlignInGroups;
            this.layoutControl1.OptionsPrint.AllowFitToPage = false;
            this.layoutControl1.OptionsPrint.TextToControlDistance = 5;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1366, 842);
            this.layoutControl1.TabIndex = 27;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // visitIDLabelTB
            // 
            this.visitIDLabelTB.Location = new System.Drawing.Point(168, 212);
            this.visitIDLabelTB.Name = "visitIDLabelTB";
            this.visitIDLabelTB.Properties.ReadOnly = true;
            this.visitIDLabelTB.Size = new System.Drawing.Size(295, 20);
            this.visitIDLabelTB.StyleController = this.layoutControl1;
            this.visitIDLabelTB.TabIndex = 12;
            // 
            // dateLabelTB
            // 
            this.dateLabelTB.Location = new System.Drawing.Point(603, 212);
            this.dateLabelTB.Name = "dateLabelTB";
            this.dateLabelTB.Properties.ReadOnly = true;
            this.dateLabelTB.Size = new System.Drawing.Size(296, 20);
            this.dateLabelTB.StyleController = this.layoutControl1;
            this.dateLabelTB.TabIndex = 12;
            // 
            // objawyLabelTB
            // 
            this.objawyLabelTB.Location = new System.Drawing.Point(168, 236);
            this.objawyLabelTB.Name = "objawyLabelTB";
            this.objawyLabelTB.Properties.ReadOnly = true;
            this.objawyLabelTB.Size = new System.Drawing.Size(1166, 54);
            this.objawyLabelTB.StyleController = this.layoutControl1;
            this.objawyLabelTB.TabIndex = 16;
            // 
            // bprzedmiotoweLabelTB
            // 
            this.bprzedmiotoweLabelTB.Location = new System.Drawing.Point(32, 312);
            this.bprzedmiotoweLabelTB.Name = "bprzedmiotoweLabelTB";
            this.bprzedmiotoweLabelTB.Properties.ReadOnly = true;
            this.bprzedmiotoweLabelTB.Size = new System.Drawing.Size(649, 169);
            this.bprzedmiotoweLabelTB.StyleController = this.layoutControl1;
            this.bprzedmiotoweLabelTB.TabIndex = 16;
            // 
            // bpodmiotoweLabelTB
            // 
            this.bpodmiotoweLabelTB.Location = new System.Drawing.Point(685, 312);
            this.bpodmiotoweLabelTB.Name = "bpodmiotoweLabelTB";
            this.bpodmiotoweLabelTB.Properties.ReadOnly = true;
            this.bpodmiotoweLabelTB.Size = new System.Drawing.Size(649, 169);
            this.bpodmiotoweLabelTB.StyleController = this.layoutControl1;
            this.bpodmiotoweLabelTB.TabIndex = 16;
            // 
            // ICD1LabelTB
            // 
            this.ICD1LabelTB.Location = new System.Drawing.Point(168, 485);
            this.ICD1LabelTB.Name = "ICD1LabelTB";
            this.ICD1LabelTB.Properties.ReadOnly = true;
            this.ICD1LabelTB.Size = new System.Drawing.Size(1166, 20);
            this.ICD1LabelTB.StyleController = this.layoutControl1;
            this.ICD1LabelTB.TabIndex = 12;
            // 
            // ICD2LabelTB
            // 
            this.ICD2LabelTB.Location = new System.Drawing.Point(168, 509);
            this.ICD2LabelTB.Name = "ICD2LabelTB";
            this.ICD2LabelTB.Properties.ReadOnly = true;
            this.ICD2LabelTB.Size = new System.Drawing.Size(1166, 20);
            this.ICD2LabelTB.StyleController = this.layoutControl1;
            this.ICD2LabelTB.TabIndex = 12;
            // 
            // ICD3LabelTB
            // 
            this.ICD3LabelTB.Location = new System.Drawing.Point(168, 533);
            this.ICD3LabelTB.Name = "ICD3LabelTB";
            this.ICD3LabelTB.Properties.ReadOnly = true;
            this.ICD3LabelTB.Size = new System.Drawing.Size(1166, 20);
            this.ICD3LabelTB.StyleController = this.layoutControl1;
            this.ICD3LabelTB.TabIndex = 12;
            // 
            // rozpoznanieLabelTB
            // 
            this.rozpoznanieLabelTB.Location = new System.Drawing.Point(32, 575);
            this.rozpoznanieLabelTB.Name = "rozpoznanieLabelTB";
            this.rozpoznanieLabelTB.Properties.ReadOnly = true;
            this.rozpoznanieLabelTB.Size = new System.Drawing.Size(1302, 85);
            this.rozpoznanieLabelTB.StyleController = this.layoutControl1;
            this.rozpoznanieLabelTB.TabIndex = 16;
            // 
            // lekiLabelTB
            // 
            this.lekiLabelTB.Location = new System.Drawing.Point(32, 682);
            this.lekiLabelTB.Name = "lekiLabelTB";
            this.lekiLabelTB.Properties.ReadOnly = true;
            this.lekiLabelTB.Size = new System.Drawing.Size(649, 128);
            this.lekiLabelTB.StyleController = this.layoutControl1;
            this.lekiLabelTB.TabIndex = 16;
            // 
            // zaleceniaLabelTB
            // 
            this.zaleceniaLabelTB.Location = new System.Drawing.Point(685, 682);
            this.zaleceniaLabelTB.Name = "zaleceniaLabelTB";
            this.zaleceniaLabelTB.Properties.ReadOnly = true;
            this.zaleceniaLabelTB.Size = new System.Drawing.Size(649, 128);
            this.zaleceniaLabelTB.StyleController = this.layoutControl1;
            this.zaleceniaLabelTB.TabIndex = 16;
            // 
            // przyrjmujacyLabelTB
            // 
            this.przyrjmujacyLabelTB.Location = new System.Drawing.Point(1039, 212);
            this.przyrjmujacyLabelTB.Name = "przyrjmujacyLabelTB";
            this.przyrjmujacyLabelTB.Properties.ReadOnly = true;
            this.przyrjmujacyLabelTB.Size = new System.Drawing.Size(295, 20);
            this.przyrjmujacyLabelTB.StyleController = this.layoutControl1;
            this.przyrjmujacyLabelTB.TabIndex = 12;
            // 
            // patientIDLabelTB
            // 
            this.patientIDLabelTB.Location = new System.Drawing.Point(130, 73);
            this.patientIDLabelTB.Name = "patientIDLabelTB";
            this.patientIDLabelTB.Size = new System.Drawing.Size(257, 20);
            this.patientIDLabelTB.StyleController = this.layoutControl1;
            this.patientIDLabelTB.TabIndex = 17;
            // 
            // nameLabelTB
            // 
            this.nameLabelTB.Location = new System.Drawing.Point(489, 73);
            this.nameLabelTB.Name = "nameLabelTB";
            this.nameLabelTB.Size = new System.Drawing.Size(276, 20);
            this.nameLabelTB.StyleController = this.layoutControl1;
            this.nameLabelTB.TabIndex = 18;
            // 
            // surnameLabelTB
            // 
            this.surnameLabelTB.Location = new System.Drawing.Point(867, 73);
            this.surnameLabelTB.Name = "surnameLabelTB";
            this.surnameLabelTB.Size = new System.Drawing.Size(206, 20);
            this.surnameLabelTB.StyleController = this.layoutControl1;
            this.surnameLabelTB.TabIndex = 19;
            // 
            // birthLabelTB
            // 
            this.birthLabelTB.Location = new System.Drawing.Point(1175, 73);
            this.birthLabelTB.Name = "birthLabelTB";
            this.birthLabelTB.Size = new System.Drawing.Size(159, 20);
            this.birthLabelTB.StyleController = this.layoutControl1;
            this.birthLabelTB.TabIndex = 17;
            // 
            // countryLabelTB
            // 
            this.countryLabelTB.Location = new System.Drawing.Point(130, 97);
            this.countryLabelTB.Name = "countryLabelTB";
            this.countryLabelTB.Size = new System.Drawing.Size(257, 20);
            this.countryLabelTB.StyleController = this.layoutControl1;
            this.countryLabelTB.TabIndex = 18;
            // 
            // sexLabelTB
            // 
            this.sexLabelTB.Location = new System.Drawing.Point(1175, 97);
            this.sexLabelTB.Name = "sexLabelTB";
            this.sexLabelTB.Size = new System.Drawing.Size(159, 20);
            this.sexLabelTB.StyleController = this.layoutControl1;
            this.sexLabelTB.TabIndex = 19;
            // 
            // addressLabelTB
            // 
            this.addressLabelTB.Location = new System.Drawing.Point(130, 145);
            this.addressLabelTB.Name = "addressLabelTB";
            this.addressLabelTB.Size = new System.Drawing.Size(1204, 20);
            this.addressLabelTB.StyleController = this.layoutControl1;
            this.addressLabelTB.TabIndex = 20;
            // 
            // phoneLabelTB
            // 
            this.phoneLabelTB.Location = new System.Drawing.Point(130, 121);
            this.phoneLabelTB.Name = "phoneLabelTB";
            this.phoneLabelTB.Size = new System.Drawing.Size(257, 20);
            this.phoneLabelTB.StyleController = this.layoutControl1;
            this.phoneLabelTB.TabIndex = 21;
            // 
            // peselLabelTB
            // 
            this.peselLabelTB.Location = new System.Drawing.Point(867, 97);
            this.peselLabelTB.Name = "peselLabelTB";
            this.peselLabelTB.Size = new System.Drawing.Size(206, 20);
            this.peselLabelTB.StyleController = this.layoutControl1;
            this.peselLabelTB.TabIndex = 22;
            // 
            // poleCardLabelTB
            // 
            this.poleCardLabelTB.Location = new System.Drawing.Point(1175, 121);
            this.poleCardLabelTB.Name = "poleCardLabelTB";
            this.poleCardLabelTB.Size = new System.Drawing.Size(159, 20);
            this.poleCardLabelTB.StyleController = this.layoutControl1;
            this.poleCardLabelTB.TabIndex = 23;
            // 
            // dowodLabelTB
            // 
            this.dowodLabelTB.Location = new System.Drawing.Point(867, 121);
            this.dowodLabelTB.Name = "dowodLabelTB";
            this.dowodLabelTB.Size = new System.Drawing.Size(206, 20);
            this.dowodLabelTB.StyleController = this.layoutControl1;
            this.dowodLabelTB.TabIndex = 24;
            // 
            // passportLabelTB
            // 
            this.passportLabelTB.Location = new System.Drawing.Point(489, 121);
            this.passportLabelTB.Name = "passportLabelTB";
            this.passportLabelTB.Size = new System.Drawing.Size(276, 20);
            this.passportLabelTB.StyleController = this.layoutControl1;
            this.passportLabelTB.TabIndex = 25;
            // 
            // insuranceLabelTB
            // 
            this.insuranceLabelTB.Location = new System.Drawing.Point(489, 97);
            this.insuranceLabelTB.Name = "insuranceLabelTB";
            this.insuranceLabelTB.Size = new System.Drawing.Size(276, 20);
            this.insuranceLabelTB.StyleController = this.layoutControl1;
            this.insuranceLabelTB.TabIndex = 26;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup5});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1366, 842);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup5
            // 
            this.layoutControlGroup5.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlGroup5.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup4,
            this.layoutControlGroup3});
            this.layoutControlGroup5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup5.Name = "layoutControlGroup5";
            this.layoutControlGroup5.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.layoutControlGroup5.Size = new System.Drawing.Size(1346, 822);
            this.layoutControlGroup5.Text = "Karta wizyty";
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlGroup4.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.visitIDLabel,
            this.objawyLabel,
            this.bprzedmiotoweLabel,
            this.ICD1Label1,
            this.rozpoznanieLabel,
            this.lekiLabel,
            this.dateLabel,
            this.bpodmiotoweLabel,
            this.zaleceniaLabel,
            this.przyrjmujacyLabel,
            this.ICD2Label,
            this.ICD3Label});
            this.layoutControlGroup4.Location = new System.Drawing.Point(0, 139);
            this.layoutControlGroup4.Name = "layoutControlGroup4";
            this.layoutControlGroup4.OptionsTableLayoutItem.RowIndex = 1;
            this.layoutControlGroup4.Size = new System.Drawing.Size(1330, 645);
            this.layoutControlGroup4.Text = "Dane wizyty";
            // 
            // visitIDLabel
            // 
            this.visitIDLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visitIDLabel.AppearanceItemCaption.Options.UseFont = true;
            this.visitIDLabel.Control = this.visitIDLabelTB;
            this.visitIDLabel.CustomizationFormText = "Numer wizyty:";
            this.visitIDLabel.Location = new System.Drawing.Point(0, 0);
            this.visitIDLabel.Name = "visitIDLabel";
            this.visitIDLabel.Size = new System.Drawing.Size(435, 24);
            this.visitIDLabel.Text = "Numer wizyty:";
            this.visitIDLabel.TextLocation = DevExpress.Utils.Locations.Left;
            this.visitIDLabel.TextSize = new System.Drawing.Size(131, 13);
            // 
            // objawyLabel
            // 
            this.objawyLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objawyLabel.AppearanceItemCaption.Options.UseFont = true;
            this.objawyLabel.Control = this.objawyLabelTB;
            this.objawyLabel.CustomizationFormText = "Objawy:";
            this.objawyLabel.Location = new System.Drawing.Point(0, 24);
            this.objawyLabel.Name = "objawyLabel";
            this.objawyLabel.Size = new System.Drawing.Size(1306, 58);
            this.objawyLabel.Text = "Objawy:";
            this.objawyLabel.TextLocation = DevExpress.Utils.Locations.Left;
            this.objawyLabel.TextSize = new System.Drawing.Size(131, 13);
            // 
            // bprzedmiotoweLabel
            // 
            this.bprzedmiotoweLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bprzedmiotoweLabel.AppearanceItemCaption.Options.UseFont = true;
            this.bprzedmiotoweLabel.Control = this.bprzedmiotoweLabelTB;
            this.bprzedmiotoweLabel.CustomizationFormText = "Badanie przedmiotowe:";
            this.bprzedmiotoweLabel.Location = new System.Drawing.Point(0, 82);
            this.bprzedmiotoweLabel.Name = "bprzedmiotoweLabel";
            this.bprzedmiotoweLabel.Size = new System.Drawing.Size(653, 191);
            this.bprzedmiotoweLabel.Text = "Badanie przedmiotowe:";
            this.bprzedmiotoweLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.bprzedmiotoweLabel.TextSize = new System.Drawing.Size(131, 13);
            // 
            // ICD1Label1
            // 
            this.ICD1Label1.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICD1Label1.AppearanceItemCaption.Options.UseFont = true;
            this.ICD1Label1.Control = this.ICD1LabelTB;
            this.ICD1Label1.CustomizationFormText = "Kod ICD 1:";
            this.ICD1Label1.Location = new System.Drawing.Point(0, 273);
            this.ICD1Label1.Name = "ICD1Label1";
            this.ICD1Label1.Size = new System.Drawing.Size(1306, 24);
            this.ICD1Label1.Text = "Kod ICD 1:";
            this.ICD1Label1.TextLocation = DevExpress.Utils.Locations.Left;
            this.ICD1Label1.TextSize = new System.Drawing.Size(131, 13);
            // 
            // rozpoznanieLabel
            // 
            this.rozpoznanieLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rozpoznanieLabel.AppearanceItemCaption.Options.UseFont = true;
            this.rozpoznanieLabel.Control = this.rozpoznanieLabelTB;
            this.rozpoznanieLabel.CustomizationFormText = "Rozpoznanie:";
            this.rozpoznanieLabel.Location = new System.Drawing.Point(0, 345);
            this.rozpoznanieLabel.Name = "rozpoznanieLabel";
            this.rozpoznanieLabel.Size = new System.Drawing.Size(1306, 107);
            this.rozpoznanieLabel.Text = "Rozpoznanie:";
            this.rozpoznanieLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.rozpoznanieLabel.TextSize = new System.Drawing.Size(131, 13);
            // 
            // lekiLabel
            // 
            this.lekiLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lekiLabel.AppearanceItemCaption.Options.UseFont = true;
            this.lekiLabel.Control = this.lekiLabelTB;
            this.lekiLabel.CustomizationFormText = "Leki:";
            this.lekiLabel.Location = new System.Drawing.Point(0, 452);
            this.lekiLabel.Name = "lekiLabel";
            this.lekiLabel.Size = new System.Drawing.Size(653, 150);
            this.lekiLabel.Text = "Leki:";
            this.lekiLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.lekiLabel.TextSize = new System.Drawing.Size(131, 13);
            // 
            // dateLabel
            // 
            this.dateLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.AppearanceItemCaption.Options.UseFont = true;
            this.dateLabel.Control = this.dateLabelTB;
            this.dateLabel.CustomizationFormText = "Data wizyty:";
            this.dateLabel.Location = new System.Drawing.Point(435, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(436, 24);
            this.dateLabel.Text = "Data wizyty:";
            this.dateLabel.TextLocation = DevExpress.Utils.Locations.Left;
            this.dateLabel.TextSize = new System.Drawing.Size(131, 13);
            // 
            // bpodmiotoweLabel
            // 
            this.bpodmiotoweLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bpodmiotoweLabel.AppearanceItemCaption.Options.UseFont = true;
            this.bpodmiotoweLabel.Control = this.bpodmiotoweLabelTB;
            this.bpodmiotoweLabel.CustomizationFormText = "Badanie podmiotowe:";
            this.bpodmiotoweLabel.Location = new System.Drawing.Point(653, 82);
            this.bpodmiotoweLabel.Name = "bpodmiotoweLabel";
            this.bpodmiotoweLabel.Size = new System.Drawing.Size(653, 191);
            this.bpodmiotoweLabel.Text = "Badanie podmiotowe:";
            this.bpodmiotoweLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.bpodmiotoweLabel.TextSize = new System.Drawing.Size(131, 13);
            // 
            // zaleceniaLabel
            // 
            this.zaleceniaLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaleceniaLabel.AppearanceItemCaption.Options.UseFont = true;
            this.zaleceniaLabel.Control = this.zaleceniaLabelTB;
            this.zaleceniaLabel.CustomizationFormText = "Zalecenia:";
            this.zaleceniaLabel.Location = new System.Drawing.Point(653, 452);
            this.zaleceniaLabel.Name = "zaleceniaLabel";
            this.zaleceniaLabel.Size = new System.Drawing.Size(653, 150);
            this.zaleceniaLabel.Text = "Zalecenia:";
            this.zaleceniaLabel.TextLocation = DevExpress.Utils.Locations.Top;
            this.zaleceniaLabel.TextSize = new System.Drawing.Size(131, 13);
            // 
            // przyrjmujacyLabel
            // 
            this.przyrjmujacyLabel.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyrjmujacyLabel.AppearanceItemCaption.Options.UseFont = true;
            this.przyrjmujacyLabel.Control = this.przyrjmujacyLabelTB;
            this.przyrjmujacyLabel.CustomizationFormText = "Przyjmujący:";
            this.przyrjmujacyLabel.Location = new System.Drawing.Point(871, 0);
            this.przyrjmujacyLabel.Name = "przyrjmujacyLabel";
            this.przyrjmujacyLabel.Size = new System.Drawing.Size(435, 24);
            this.przyrjmujacyLabel.Text = "Przyjmujący:";
            this.przyrjmujacyLabel.TextLocation = DevExpress.Utils.Locations.Left;
            this.przyrjmujacyLabel.TextSize = new System.Drawing.Size(131, 13);
            // 
            // ICD2Label
            // 
            this.ICD2Label.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICD2Label.AppearanceItemCaption.Options.UseFont = true;
            this.ICD2Label.Control = this.ICD2LabelTB;
            this.ICD2Label.CustomizationFormText = "Kod ICD 2:";
            this.ICD2Label.Location = new System.Drawing.Point(0, 297);
            this.ICD2Label.Name = "ICD2Label";
            this.ICD2Label.Size = new System.Drawing.Size(1306, 24);
            this.ICD2Label.Text = "Kod ICD 2:";
            this.ICD2Label.TextLocation = DevExpress.Utils.Locations.Left;
            this.ICD2Label.TextSize = new System.Drawing.Size(131, 13);
            // 
            // ICD3Label
            // 
            this.ICD3Label.AppearanceItemCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICD3Label.AppearanceItemCaption.Options.UseFont = true;
            this.ICD3Label.Control = this.ICD3LabelTB;
            this.ICD3Label.CustomizationFormText = "Kod ICD 3:";
            this.ICD3Label.Location = new System.Drawing.Point(0, 321);
            this.ICD3Label.Name = "ICD3Label";
            this.ICD3Label.Size = new System.Drawing.Size(1306, 24);
            this.ICD3Label.Text = "Kod ICD 3:";
            this.ICD3Label.TextLocation = DevExpress.Utils.Locations.Left;
            this.ICD3Label.TextSize = new System.Drawing.Size(131, 13);
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlGroup3.AppearanceGroup.Options.UseFont = true;
            this.layoutControlGroup3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlGroup3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem8,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem13,
            this.layoutControlItem12,
            this.layoutControlItem4,
            this.layoutControlItem14,
            this.layoutControlItem9,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(1330, 139);
            this.layoutControlGroup3.Text = "Dane Pacjenta";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.patientIDLabelTB;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem1.Text = "Numer Pacjenta:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.addressLabelTB;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1306, 24);
            this.layoutControlItem8.Text = "Adres:";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.nameLabelTB;
            this.layoutControlItem2.Location = new System.Drawing.Point(359, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem2.Text = "Imię:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.surnameLabelTB;
            this.layoutControlItem3.Location = new System.Drawing.Point(737, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(308, 24);
            this.layoutControlItem3.Text = "Nazwisko:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.countryLabelTB;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem5.Text = "Kraj:";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.sexLabelTB;
            this.layoutControlItem6.Location = new System.Drawing.Point(1045, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(261, 24);
            this.layoutControlItem6.Text = "Płeć:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem13.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem13.Control = this.passportLabelTB;
            this.layoutControlItem13.Location = new System.Drawing.Point(359, 48);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem13.Text = "Paszport:";
            this.layoutControlItem13.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem12.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem12.Control = this.dowodLabelTB;
            this.layoutControlItem12.Location = new System.Drawing.Point(737, 48);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(308, 24);
            this.layoutControlItem12.Text = "Dowód:";
            this.layoutControlItem12.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem4.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem4.Control = this.birthLabelTB;
            this.layoutControlItem4.Location = new System.Drawing.Point(1045, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(261, 24);
            this.layoutControlItem4.Text = "Data Urodzenia:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem14.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem14.Control = this.insuranceLabelTB;
            this.layoutControlItem14.Location = new System.Drawing.Point(359, 24);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem14.Text = "Ubezpieczenie:";
            this.layoutControlItem14.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.phoneLabelTB;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(359, 24);
            this.layoutControlItem9.Text = "Telefon:";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem10.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem10.Control = this.peselLabelTB;
            this.layoutControlItem10.Location = new System.Drawing.Point(737, 24);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(308, 24);
            this.layoutControlItem10.Text = "PESEL:";
            this.layoutControlItem10.TextSize = new System.Drawing.Size(93, 13);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.layoutControlItem11.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem11.Control = this.poleCardLabelTB;
            this.layoutControlItem11.Location = new System.Drawing.Point(1045, 48);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(261, 24);
            this.layoutControlItem11.Text = "Karta Polaka:";
            this.layoutControlItem11.TextSize = new System.Drawing.Size(93, 13);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(503, 860);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(137, 56);
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "Podgląd wydruku";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(646, 67);
            // 
            // ICD1Label
            // 
            this.ICD1Label.Control = this.bpodmiotoweLabelTB;
            this.ICD1Label.CustomizationFormText = "Ubezpieczenie:";
            this.ICD1Label.Location = new System.Drawing.Point(0, 409);
            this.ICD1Label.Name = "bpodmiotoweLabel";
            this.ICD1Label.Size = new System.Drawing.Size(663, 20);
            this.ICD1Label.Text = "Kod ICD 1:";
            this.ICD1Label.TextSize = new System.Drawing.Size(112, 13);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(656, 860);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(137, 56);
            this.simpleButton2.TabIndex = 29;
            this.simpleButton2.Text = "Drukuj";
            // 
            // exportToPDFButton
            // 
            this.exportToPDFButton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("exportToPDFButton.ImageOptions.Image")));
            this.exportToPDFButton.Location = new System.Drawing.Point(810, 860);
            this.exportToPDFButton.Name = "exportToPDFButton";
            this.exportToPDFButton.Size = new System.Drawing.Size(137, 56);
            this.exportToPDFButton.TabIndex = 30;
            this.exportToPDFButton.Text = "Eksport do PDF";
            this.exportToPDFButton.Click += new System.EventHandler(this.exportToPDFButton_Click);
            // 
            // ViewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 971);
            this.Controls.Add(this.exportToPDFButton);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "ViewVisit";
            this.Text = "ViewVisit";
            this.Load += new System.EventHandler(this.VisitView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.visitIDLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objawyLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bprzedmiotoweLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpodmiotoweLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD1LabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD2LabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD3LabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznanieLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekiLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaleceniaLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przyrjmujacyLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleCardLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visitIDLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.objawyLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bprzedmiotoweLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD1Label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rozpoznanieLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lekiLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpodmiotoweLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zaleceniaLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.przyrjmujacyLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD2Label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD3Label)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICD1Label)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PoradniaDataSetTableAdapters.visit_viewTableAdapter visit_viewTableAdapter;
        private PoradniaDataSetTableAdapters.patient_viewTableAdapter patient_viewTableAdapter;
        private PoradniaDataSetTableAdapters.PACJENTTableAdapter pacjentTableAdapter;
        private System.Windows.Forms.BindingSource patientviewBindingSource;
        private PoradniaDataSet poradniaDataSet;
        private System.Windows.Forms.BindingSource pACJENTBindingSource;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
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
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.TextEdit visitIDLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem visitIDLabel;
        private DevExpress.XtraLayout.LayoutControlItem objawyLabel;
        private DevExpress.XtraEditors.TextEdit dateLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem dateLabel;
        private DevExpress.XtraEditors.MemoEdit objawyLabelTB;
        private DevExpress.XtraEditors.MemoEdit bprzedmiotoweLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem bprzedmiotoweLabel;
        private DevExpress.XtraEditors.MemoEdit bpodmiotoweLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem bpodmiotoweLabel;
        private DevExpress.XtraEditors.TextEdit ICD1LabelTB;
        private DevExpress.XtraEditors.TextEdit ICD2LabelTB;
        private DevExpress.XtraLayout.LayoutControlItem ICD1Label1;
        private DevExpress.XtraLayout.LayoutControlItem ICD2Label;
        private DevExpress.XtraLayout.LayoutControlItem ICD1Label;
        private DevExpress.XtraEditors.TextEdit ICD3LabelTB;
        private DevExpress.XtraLayout.LayoutControlItem ICD3Label;
        private DevExpress.XtraEditors.MemoEdit rozpoznanieLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem rozpoznanieLabel;
        private DevExpress.XtraEditors.MemoEdit lekiLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem lekiLabel;
        private DevExpress.XtraEditors.MemoEdit zaleceniaLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem zaleceniaLabel;
        private DevExpress.XtraEditors.TextEdit przyrjmujacyLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem przyrjmujacyLabel;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton exportToPDFButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
        private DevExpress.XtraEditors.TextEdit patientIDLabelTB;
        private DevExpress.XtraEditors.TextEdit nameLabelTB;
        private DevExpress.XtraEditors.TextEdit surnameLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.TextEdit birthLabelTB;
        private DevExpress.XtraEditors.TextEdit countryLabelTB;
        private DevExpress.XtraEditors.TextEdit sexLabelTB;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraEditors.TextEdit addressLabelTB;
        private DevExpress.XtraEditors.TextEdit phoneLabelTB;
        private DevExpress.XtraEditors.TextEdit peselLabelTB;
        private DevExpress.XtraEditors.TextEdit poleCardLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraEditors.TextEdit dowodLabelTB;
        private DevExpress.XtraEditors.TextEdit passportLabelTB;
        private DevExpress.XtraEditors.TextEdit insuranceLabelTB;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
    }
}