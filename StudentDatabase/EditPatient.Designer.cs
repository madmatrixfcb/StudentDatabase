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
            this.uBEZPIECZENIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.pLECBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pACJENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dxValidationProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.pLECTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.PLECTableAdapter();
            this.uBEZPIECZENIETableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter();
            this.kRAJBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kRAJTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.KRAJTableAdapter();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.closeButton = new DevExpress.XtraEditors.SimpleButton();
            this.ubezpieczenieSelect = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Ubezpieczenie = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRodzaj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plecSelect = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.krajSelect = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID_Kraj = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IDTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.editPatient2 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl13 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.miastoTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.kodTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.mieszkanieTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
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
            this.kartapolakaTB = new DevExpress.XtraEditors.TextEdit();
            this.peselTB = new DevExpress.XtraEditors.TextEdit();
            this.paszportCB = new DevExpress.XtraEditors.CheckEdit();
            this.dowodosobistyCB = new DevExpress.XtraEditors.CheckEdit();
            this.kartapolakaCB = new DevExpress.XtraEditors.CheckEdit();
            this.peselCB = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nazwiskoTB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataur = new DevExpress.XtraEditors.DateEdit();
            this.imieTB = new DevExpress.XtraEditors.TextEdit();
            this.gridEditPatient = new DevExpress.XtraGrid.GridControl();
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
            this.pacjentTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.PACJENTTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uBEZPIECZENIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLECBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRAJBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plecSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajSelect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.miastoTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mieszkanieTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budynekTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulicaTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paszportTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartapolakaTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paszportCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodosobistyCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartapolakaCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazwiskoTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataur.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imieTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditPatient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
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
            // pACJENTBindingSource
            // 
            this.pACJENTBindingSource.DataMember = "PACJENT";
            this.pACJENTBindingSource.DataSource = this.poradniaDataSet;
            // 
            // dxValidationProvider1
            // 
            this.dxValidationProvider1.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
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
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.closeButton);
            this.splitContainerControl1.Panel1.Controls.Add(this.ubezpieczenieSelect);
            this.splitContainerControl1.Panel1.Controls.Add(this.plecSelect);
            this.splitContainerControl1.Panel1.Controls.Add(this.krajSelect);
            this.splitContainerControl1.Panel1.Controls.Add(this.IDTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl15);
            this.splitContainerControl1.Panel1.Controls.Add(this.editPatient2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl14);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl13);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl11);
            this.splitContainerControl1.Panel1.Controls.Add(this.miastoTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl12);
            this.splitContainerControl1.Panel1.Controls.Add(this.kodTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl10);
            this.splitContainerControl1.Panel1.Controls.Add(this.mieszkanieTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl9);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel1.Controls.Add(this.budynekTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainerControl1.Panel1.Controls.Add(this.ulicaTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.telefonTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.paszportTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.dowodTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.kartapolakaTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.peselTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.paszportCB);
            this.splitContainerControl1.Panel1.Controls.Add(this.dowodosobistyCB);
            this.splitContainerControl1.Panel1.Controls.Add(this.kartapolakaCB);
            this.splitContainerControl1.Panel1.Controls.Add(this.peselCB);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.nazwiskoTB);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.dataur);
            this.splitContainerControl1.Panel1.Controls.Add(this.imieTB);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridEditPatient);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1311, 593);
            this.splitContainerControl1.SplitterPosition = 326;
            this.splitContainerControl1.TabIndex = 112;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(126, 567);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(99, 23);
            this.closeButton.TabIndex = 155;
            this.closeButton.Text = "Zamknij";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ubezpieczenieSelect
            // 
            this.ubezpieczenieSelect.EditValue = "";
            this.ubezpieczenieSelect.Location = new System.Drawing.Point(145, 463);
            this.ubezpieczenieSelect.Name = "ubezpieczenieSelect";
            this.ubezpieczenieSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ubezpieczenieSelect.Properties.DataSource = this.uBEZPIECZENIEBindingSource;
            this.ubezpieczenieSelect.Properties.DisplayMember = "Rodzaj";
            this.ubezpieczenieSelect.Properties.ValueMember = "ID_Ubezpieczenie";
            this.ubezpieczenieSelect.Properties.View = this.gridView4;
            this.ubezpieczenieSelect.Size = new System.Drawing.Size(180, 20);
            this.ubezpieczenieSelect.TabIndex = 154;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Ubezpieczenie,
            this.colRodzaj});
            this.gridView4.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsCustomization.AllowFilter = false;
            this.gridView4.OptionsFind.AllowFindPanel = false;
            this.gridView4.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView4.OptionsView.ShowGroupPanel = false;
            this.gridView4.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colID_Ubezpieczenie, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colID_Ubezpieczenie
            // 
            this.colID_Ubezpieczenie.FieldName = "ID_Ubezpieczenie";
            this.colID_Ubezpieczenie.Name = "colID_Ubezpieczenie";
            // 
            // colRodzaj
            // 
            this.colRodzaj.FieldName = "Rodzaj";
            this.colRodzaj.Name = "colRodzaj";
            this.colRodzaj.Visible = true;
            this.colRodzaj.VisibleIndex = 0;
            // 
            // plecSelect
            // 
            this.plecSelect.EditValue = "";
            this.plecSelect.Location = new System.Drawing.Point(126, 205);
            this.plecSelect.Name = "plecSelect";
            this.plecSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.plecSelect.Properties.DataSource = this.pLECBindingSource;
            this.plecSelect.Properties.DisplayMember = "Plec";
            this.plecSelect.Properties.ValueMember = "ID_Plec";
            this.plecSelect.Properties.View = this.gridView3;
            this.plecSelect.Size = new System.Drawing.Size(199, 20);
            this.plecSelect.TabIndex = 152;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsFind.AllowFindPanel = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // krajSelect
            // 
            this.krajSelect.EditValue = "";
            this.krajSelect.Location = new System.Drawing.Point(126, 153);
            this.krajSelect.Name = "krajSelect";
            this.krajSelect.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.krajSelect.Properties.DataSource = this.kRAJBindingSource;
            this.krajSelect.Properties.DisplayMember = "Kraj";
            this.krajSelect.Properties.ValueMember = "ID_Kraj";
            this.krajSelect.Properties.View = this.gridView2;
            this.krajSelect.Size = new System.Drawing.Size(199, 20);
            this.krajSelect.TabIndex = 147;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID_Kraj,
            this.gridColumn1});
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
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Kraj";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 76;
            // 
            // IDTB
            // 
            this.IDTB.Enabled = false;
            this.IDTB.Location = new System.Drawing.Point(126, 49);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(199, 20);
            this.IDTB.TabIndex = 146;
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(33, 52);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(15, 13);
            this.labelControl15.TabIndex = 145;
            this.labelControl15.Text = "ID:";
            // 
            // editPatient2
            // 
            this.editPatient2.Location = new System.Drawing.Point(126, 524);
            this.editPatient2.Name = "editPatient2";
            this.editPatient2.Size = new System.Drawing.Size(99, 23);
            this.editPatient2.TabIndex = 144;
            this.editPatient2.Text = "Edytuj pacjenta";
            this.editPatient2.Click += new System.EventHandler(this.EditPatient2_Click);
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(33, 470);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(72, 13);
            this.labelControl14.TabIndex = 143;
            this.labelControl14.Text = "Ubezpieczenie:";
            // 
            // labelControl13
            // 
            this.labelControl13.Location = new System.Drawing.Point(33, 208);
            this.labelControl13.Name = "labelControl13";
            this.labelControl13.Size = new System.Drawing.Size(24, 13);
            this.labelControl13.TabIndex = 142;
            this.labelControl13.Text = "Płeć:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(187, 313);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(35, 13);
            this.labelControl11.TabIndex = 141;
            this.labelControl11.Text = "Miasto:";
            // 
            // miastoTB
            // 
            this.miastoTB.Location = new System.Drawing.Point(242, 310);
            this.miastoTB.Name = "miastoTB";
            this.miastoTB.Size = new System.Drawing.Size(83, 20);
            this.miastoTB.TabIndex = 120;
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(27, 313);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(71, 13);
            this.labelControl12.TabIndex = 140;
            this.labelControl12.Text = "Kod pocztowy:";
            // 
            // kodTB
            // 
            this.kodTB.Location = new System.Drawing.Point(120, 310);
            this.kodTB.Name = "kodTB";
            this.kodTB.Properties.Mask.EditMask = "00-000";
            this.kodTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.kodTB.Properties.ValidateOnEnterKey = true;
            this.kodTB.Size = new System.Drawing.Size(61, 20);
            this.kodTB.TabIndex = 119;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(187, 285);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(89, 13);
            this.labelControl10.TabIndex = 139;
            this.labelControl10.Text = "Numer mieszkania:";
            // 
            // mieszkanieTB
            // 
            this.mieszkanieTB.Location = new System.Drawing.Point(280, 282);
            this.mieszkanieTB.Name = "mieszkanieTB";
            this.mieszkanieTB.Size = new System.Drawing.Size(45, 20);
            this.mieszkanieTB.TabIndex = 118;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(159, 231);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(41, 19);
            this.labelControl9.TabIndex = 138;
            this.labelControl9.Text = "Adres";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(126, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(152, 19);
            this.labelControl8.TabIndex = 137;
            this.labelControl8.Text = "Edytuj dane osobowe";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(27, 285);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 13);
            this.labelControl6.TabIndex = 136;
            this.labelControl6.Text = "Numer budynku:";
            // 
            // budynekTB
            // 
            this.budynekTB.Location = new System.Drawing.Point(120, 282);
            this.budynekTB.Name = "budynekTB";
            this.budynekTB.Size = new System.Drawing.Size(45, 20);
            this.budynekTB.TabIndex = 117;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(27, 259);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(26, 13);
            this.labelControl7.TabIndex = 135;
            this.labelControl7.Text = "Ulica:";
            // 
            // ulicaTB
            // 
            this.ulicaTB.Location = new System.Drawing.Point(120, 256);
            this.ulicaTB.Name = "ulicaTB";
            this.ulicaTB.Size = new System.Drawing.Size(205, 20);
            this.ulicaTB.TabIndex = 116;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 182);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 134;
            this.labelControl4.Text = "Telefon:";
            // 
            // telefonTB
            // 
            this.telefonTB.EditValue = "+48";
            this.telefonTB.Location = new System.Drawing.Point(126, 179);
            this.telefonTB.Name = "telefonTB";
            this.telefonTB.Properties.Mask.EditMask = "+48-000-000-000";
            this.telefonTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.telefonTB.Size = new System.Drawing.Size(199, 20);
            this.telefonTB.TabIndex = 114;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(33, 156);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(86, 13);
            this.labelControl5.TabIndex = 133;
            this.labelControl5.Text = "Kraj pochodzenia:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 130);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(77, 13);
            this.labelControl3.TabIndex = 132;
            this.labelControl3.Text = "Data urodzenia:";
            // 
            // paszportTB
            // 
            this.paszportTB.Enabled = false;
            this.paszportTB.Location = new System.Drawing.Point(145, 436);
            this.paszportTB.Name = "paszportTB";
            this.paszportTB.Size = new System.Drawing.Size(180, 20);
            this.paszportTB.TabIndex = 124;
            this.paszportTB.EditValueChanged += new System.EventHandler(this.paszportTB_EditValueChanged);
            // 
            // dowodTB
            // 
            this.dowodTB.Enabled = false;
            this.dowodTB.Location = new System.Drawing.Point(145, 410);
            this.dowodTB.Name = "dowodTB";
            this.dowodTB.Size = new System.Drawing.Size(180, 20);
            this.dowodTB.TabIndex = 123;
            this.dowodTB.EditValueChanged += new System.EventHandler(this.dowodTB_EditValueChanged);
            // 
            // kartapolakaTB
            // 
            this.kartapolakaTB.Enabled = false;
            this.kartapolakaTB.Location = new System.Drawing.Point(145, 384);
            this.kartapolakaTB.Name = "kartapolakaTB";
            this.kartapolakaTB.Size = new System.Drawing.Size(180, 20);
            this.kartapolakaTB.TabIndex = 122;
            this.kartapolakaTB.EditValueChanged += new System.EventHandler(this.kartapolakaTB_EditValueChanged);
            // 
            // peselTB
            // 
            this.peselTB.Enabled = false;
            this.peselTB.Location = new System.Drawing.Point(145, 358);
            this.peselTB.Name = "peselTB";
            this.peselTB.Properties.Mask.EditMask = "\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?\\d?";
            this.peselTB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Regular;
            this.peselTB.Size = new System.Drawing.Size(180, 20);
            this.peselTB.TabIndex = 121;
            this.peselTB.EditValueChanged += new System.EventHandler(this.peselTB_EditValueChanged);
            // 
            // paszportCB
            // 
            this.paszportCB.Location = new System.Drawing.Point(33, 436);
            this.paszportCB.Name = "paszportCB";
            this.paszportCB.Properties.Caption = "Numer paszportu:";
            this.paszportCB.Size = new System.Drawing.Size(106, 19);
            this.paszportCB.TabIndex = 131;
            this.paszportCB.CheckedChanged += new System.EventHandler(this.paszportCB_CheckedChanged);
            // 
            // dowodosobistyCB
            // 
            this.dowodosobistyCB.Location = new System.Drawing.Point(33, 411);
            this.dowodosobistyCB.Name = "dowodosobistyCB";
            this.dowodosobistyCB.Properties.Caption = "Dowód osobisty:";
            this.dowodosobistyCB.Size = new System.Drawing.Size(106, 19);
            this.dowodosobistyCB.TabIndex = 130;
            this.dowodosobistyCB.CheckedChanged += new System.EventHandler(this.dowodosobistyCB_CheckedChanged);
            // 
            // kartapolakaCB
            // 
            this.kartapolakaCB.Location = new System.Drawing.Point(33, 386);
            this.kartapolakaCB.Name = "kartapolakaCB";
            this.kartapolakaCB.Properties.Caption = "Karta polaka:";
            this.kartapolakaCB.Size = new System.Drawing.Size(86, 19);
            this.kartapolakaCB.TabIndex = 129;
            this.kartapolakaCB.CheckedChanged += new System.EventHandler(this.kartapolakaCB_CheckedChanged);
            // 
            // peselCB
            // 
            this.peselCB.Location = new System.Drawing.Point(33, 361);
            this.peselCB.Name = "peselCB";
            this.peselCB.Properties.Caption = "PESEL:";
            this.peselCB.Size = new System.Drawing.Size(75, 19);
            this.peselCB.TabIndex = 128;
            this.peselCB.CheckedChanged += new System.EventHandler(this.peselCB_CheckedChanged);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 104);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 13);
            this.labelControl2.TabIndex = 127;
            this.labelControl2.Text = "Nazwisko:";
            // 
            // nazwiskoTB
            // 
            this.nazwiskoTB.Location = new System.Drawing.Point(126, 101);
            this.nazwiskoTB.Name = "nazwiskoTB";
            this.nazwiskoTB.Size = new System.Drawing.Size(199, 20);
            this.nazwiskoTB.TabIndex = 112;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 13);
            this.labelControl1.TabIndex = 126;
            this.labelControl1.Text = "Imię:";
            // 
            // dataur
            // 
            this.dataur.EditValue = null;
            this.dataur.Location = new System.Drawing.Point(126, 127);
            this.dataur.Name = "dataur";
            this.dataur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataur.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dataur.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dataur.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dataur.Size = new System.Drawing.Size(199, 20);
            this.dataur.TabIndex = 113;
            // 
            // imieTB
            // 
            this.imieTB.Location = new System.Drawing.Point(126, 75);
            this.imieTB.Name = "imieTB";
            this.imieTB.Size = new System.Drawing.Size(199, 20);
            this.imieTB.TabIndex = 111;
            // 
            // gridEditPatient
            // 
            this.gridEditPatient.DataSource = this.pACJENTBindingSource;
            this.gridEditPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEditPatient.Location = new System.Drawing.Point(0, 0);
            this.gridEditPatient.MainView = this.gridView1;
            this.gridEditPatient.Name = "gridEditPatient";
            this.gridEditPatient.Size = new System.Drawing.Size(973, 593);
            this.gridEditPatient.TabIndex = 0;
            this.gridEditPatient.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
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
            this.gridView1.GridControl = this.gridEditPatient;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
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
            // pacjentTableAdapter
            // 
            this.pacjentTableAdapter.ClearBeforeFill = true;
            // 
            // EditPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 593);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "EditPatient";
            this.Text = "EditPatient";
            this.Load += new System.EventHandler(this.EditPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uBEZPIECZENIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pLECBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kRAJBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ubezpieczenieSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plecSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.krajSelect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IDTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.miastoTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mieszkanieTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budynekTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ulicaTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paszportTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartapolakaTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paszportCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodosobistyCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kartapolakaCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nazwiskoTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataur.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imieTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridEditPatient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PoradniaDataSet poradniaDataSet;
        private System.Windows.Forms.BindingSource pACJENTBindingSource;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider1;
        private System.Windows.Forms.BindingSource pLECBindingSource;
        private PoradniaDataSetTableAdapters.PLECTableAdapter pLECTableAdapter;
        private System.Windows.Forms.BindingSource uBEZPIECZENIEBindingSource;
        private PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter uBEZPIECZENIETableAdapter;
        private System.Windows.Forms.BindingSource kRAJBindingSource;
        private PoradniaDataSetTableAdapters.KRAJTableAdapter kRAJTableAdapter;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SearchLookUpEdit krajSelect;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Kraj;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit IDTB;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.SimpleButton editPatient2;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl13;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit miastoTB;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.TextEdit kodTB;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit mieszkanieTB;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
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
        private DevExpress.XtraEditors.TextEdit kartapolakaTB;
        private DevExpress.XtraEditors.TextEdit peselTB;
        private DevExpress.XtraEditors.CheckEdit paszportCB;
        private DevExpress.XtraEditors.CheckEdit dowodosobistyCB;
        private DevExpress.XtraEditors.CheckEdit kartapolakaCB;
        private DevExpress.XtraEditors.CheckEdit peselCB;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit nazwiskoTB;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dataur;
        private DevExpress.XtraEditors.TextEdit imieTB;
        private DevExpress.XtraGrid.GridControl gridEditPatient;
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
        private PoradniaDataSetTableAdapters.PACJENTTableAdapter pacjentTableAdapter;
        private DevExpress.XtraEditors.SearchLookUpEdit plecSelect;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SearchLookUpEdit ubezpieczenieSelect;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SimpleButton closeButton;
        private DevExpress.XtraGrid.Columns.GridColumn colID_Ubezpieczenie;
        private DevExpress.XtraGrid.Columns.GridColumn colRodzaj;
    }
}