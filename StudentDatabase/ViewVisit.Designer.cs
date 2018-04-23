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
            this.wizytaGroup = new DevExpress.XtraEditors.GroupControl();
            this.bprzedmiotoweLabel = new DevExpress.XtraEditors.LabelControl();
            this.bpodmiotowe = new DevExpress.XtraEditors.LabelControl();
            this.labelControl22 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.objawyLabel = new DevExpress.XtraEditors.LabelControl();
            this.ICD1Label = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.rozpoznanieLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl26 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl14 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl20 = new DevExpress.XtraEditors.LabelControl();
            this.visitIDLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
            this.ICD2Label = new DevExpress.XtraEditors.LabelControl();
            this.labelControl21 = new DevExpress.XtraEditors.LabelControl();
            this.ICD3Label = new DevExpress.XtraEditors.LabelControl();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.lekiLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl23 = new DevExpress.XtraEditors.LabelControl();
            this.zaleceniaLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl27 = new DevExpress.XtraEditors.LabelControl();
            this.przyrjmujacyLabel = new DevExpress.XtraEditors.LabelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.phoneLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.peselLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.nameLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.patientIDLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.surnameLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.birthLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.countryLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.sexLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.addressLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.poleCardLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.dowodLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.passportLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.insuranceLabelTB = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.nameLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.patientIDLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.surnameLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.birthLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.countryLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.sexLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.addressLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.insuranceLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.passportLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.dowodLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.poleCardLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.peselLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.phoneLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.patientviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytaGroup)).BeginInit();
            this.wizytaGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleCardLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceLabelTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleCardLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
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
            this.gridControl1.Location = new System.Drawing.Point(1094, 236);
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
            // wizytaGroup
            // 
            this.wizytaGroup.AutoSize = true;
            this.wizytaGroup.Controls.Add(this.przyrjmujacyLabel);
            this.wizytaGroup.Controls.Add(this.labelControl27);
            this.wizytaGroup.Controls.Add(this.zaleceniaLabel);
            this.wizytaGroup.Controls.Add(this.labelControl23);
            this.wizytaGroup.Controls.Add(this.lekiLabel);
            this.wizytaGroup.Controls.Add(this.labelControl15);
            this.wizytaGroup.Controls.Add(this.ICD3Label);
            this.wizytaGroup.Controls.Add(this.labelControl21);
            this.wizytaGroup.Controls.Add(this.ICD2Label);
            this.wizytaGroup.Controls.Add(this.labelControl17);
            this.wizytaGroup.Controls.Add(this.visitIDLabel);
            this.wizytaGroup.Controls.Add(this.labelControl20);
            this.wizytaGroup.Controls.Add(this.labelControl14);
            this.wizytaGroup.Controls.Add(this.labelControl26);
            this.wizytaGroup.Controls.Add(this.rozpoznanieLabel);
            this.wizytaGroup.Controls.Add(this.dateLabel);
            this.wizytaGroup.Controls.Add(this.labelControl16);
            this.wizytaGroup.Controls.Add(this.labelControl24);
            this.wizytaGroup.Controls.Add(this.ICD1Label);
            this.wizytaGroup.Controls.Add(this.objawyLabel);
            this.wizytaGroup.Controls.Add(this.labelControl18);
            this.wizytaGroup.Controls.Add(this.labelControl22);
            this.wizytaGroup.Controls.Add(this.bpodmiotowe);
            this.wizytaGroup.Controls.Add(this.bprzedmiotoweLabel);
            this.wizytaGroup.Location = new System.Drawing.Point(805, 197);
            this.wizytaGroup.Name = "wizytaGroup";
            this.wizytaGroup.Size = new System.Drawing.Size(434, 514);
            this.wizytaGroup.TabIndex = 3;
            this.wizytaGroup.Text = "Dane wizyty";
            this.wizytaGroup.Paint += new System.Windows.Forms.PaintEventHandler(this.wizytaGroup_Paint);
            // 
            // bprzedmiotoweLabel
            // 
            this.bprzedmiotoweLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bprzedmiotoweLabel.Appearance.Options.UseFont = true;
            this.bprzedmiotoweLabel.Location = new System.Drawing.Point(129, 111);
            this.bprzedmiotoweLabel.Name = "bprzedmiotoweLabel";
            this.bprzedmiotoweLabel.Size = new System.Drawing.Size(88, 13);
            this.bprzedmiotoweLabel.TabIndex = 31;
            this.bprzedmiotoweLabel.Text = "bprzedmiotowe";
            // 
            // bpodmiotowe
            // 
            this.bpodmiotowe.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bpodmiotowe.Appearance.Options.UseFont = true;
            this.bpodmiotowe.Location = new System.Drawing.Point(119, 170);
            this.bpodmiotowe.Name = "bpodmiotowe";
            this.bpodmiotowe.Size = new System.Drawing.Size(77, 13);
            this.bpodmiotowe.TabIndex = 33;
            this.bpodmiotowe.Text = "bpodmiotowe";
            // 
            // labelControl22
            // 
            this.labelControl22.Location = new System.Drawing.Point(10, 111);
            this.labelControl22.Name = "labelControl22";
            this.labelControl22.Size = new System.Drawing.Size(112, 13);
            this.labelControl22.TabIndex = 30;
            this.labelControl22.Text = "Badanie przedmiotowe:";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(10, 263);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(52, 13);
            this.labelControl18.TabIndex = 34;
            this.labelControl18.Text = "Kod ICD 1:";
            // 
            // objawyLabel
            // 
            this.objawyLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.objawyLabel.Appearance.Options.UseFont = true;
            this.objawyLabel.Location = new System.Drawing.Point(53, 62);
            this.objawyLabel.Name = "objawyLabel";
            this.objawyLabel.Size = new System.Drawing.Size(41, 13);
            this.objawyLabel.TabIndex = 29;
            this.objawyLabel.Text = "objawy";
            // 
            // ICD1Label
            // 
            this.ICD1Label.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICD1Label.Appearance.Options.UseFont = true;
            this.ICD1Label.Location = new System.Drawing.Point(68, 263);
            this.ICD1Label.Name = "ICD1Label";
            this.ICD1Label.Size = new System.Drawing.Size(27, 13);
            this.ICD1Label.TabIndex = 35;
            this.ICD1Label.Text = "ICD1";
            // 
            // labelControl24
            // 
            this.labelControl24.Location = new System.Drawing.Point(10, 62);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(41, 13);
            this.labelControl24.TabIndex = 28;
            this.labelControl24.Text = "Objawy:";
            // 
            // labelControl16
            // 
            this.labelControl16.Location = new System.Drawing.Point(10, 320);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(65, 13);
            this.labelControl16.TabIndex = 36;
            this.labelControl16.Text = "Rozpoznanie:";
            // 
            // dateLabel
            // 
            this.dateLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateLabel.Appearance.Options.UseFont = true;
            this.dateLabel.Location = new System.Drawing.Point(77, 43);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(26, 13);
            this.dateLabel.TabIndex = 27;
            this.dateLabel.Text = "data";
            // 
            // rozpoznanieLabel
            // 
            this.rozpoznanieLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rozpoznanieLabel.Appearance.Options.UseFont = true;
            this.rozpoznanieLabel.Location = new System.Drawing.Point(81, 320);
            this.rozpoznanieLabel.Name = "rozpoznanieLabel";
            this.rozpoznanieLabel.Size = new System.Drawing.Size(69, 13);
            this.rozpoznanieLabel.TabIndex = 37;
            this.rozpoznanieLabel.Text = "rozpoznanie";
            // 
            // labelControl26
            // 
            this.labelControl26.Location = new System.Drawing.Point(10, 43);
            this.labelControl26.Name = "labelControl26";
            this.labelControl26.Size = new System.Drawing.Size(61, 13);
            this.labelControl26.TabIndex = 26;
            this.labelControl26.Text = "Data wizyty:";
            // 
            // labelControl14
            // 
            this.labelControl14.Location = new System.Drawing.Point(10, 24);
            this.labelControl14.Name = "labelControl14";
            this.labelControl14.Size = new System.Drawing.Size(69, 13);
            this.labelControl14.TabIndex = 38;
            this.labelControl14.Text = "Numer wizyty:";
            // 
            // labelControl20
            // 
            this.labelControl20.Location = new System.Drawing.Point(10, 170);
            this.labelControl20.Name = "labelControl20";
            this.labelControl20.Size = new System.Drawing.Size(103, 13);
            this.labelControl20.TabIndex = 32;
            this.labelControl20.Text = "Badanie podmiotowe:";
            // 
            // visitIDLabel
            // 
            this.visitIDLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.visitIDLabel.Appearance.Options.UseFont = true;
            this.visitIDLabel.Location = new System.Drawing.Point(85, 24);
            this.visitIDLabel.Name = "visitIDLabel";
            this.visitIDLabel.Size = new System.Drawing.Size(54, 13);
            this.visitIDLabel.TabIndex = 39;
            this.visitIDLabel.Text = "id_wizyta";
            // 
            // labelControl17
            // 
            this.labelControl17.Location = new System.Drawing.Point(10, 282);
            this.labelControl17.Name = "labelControl17";
            this.labelControl17.Size = new System.Drawing.Size(52, 13);
            this.labelControl17.TabIndex = 40;
            this.labelControl17.Text = "Kod ICD 2:";
            // 
            // ICD2Label
            // 
            this.ICD2Label.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICD2Label.Appearance.Options.UseFont = true;
            this.ICD2Label.Location = new System.Drawing.Point(68, 282);
            this.ICD2Label.Name = "ICD2Label";
            this.ICD2Label.Size = new System.Drawing.Size(27, 13);
            this.ICD2Label.TabIndex = 41;
            this.ICD2Label.Text = "ICD2";
            // 
            // labelControl21
            // 
            this.labelControl21.Location = new System.Drawing.Point(10, 301);
            this.labelControl21.Name = "labelControl21";
            this.labelControl21.Size = new System.Drawing.Size(52, 13);
            this.labelControl21.TabIndex = 42;
            this.labelControl21.Text = "Kod ICD 3:";
            // 
            // ICD3Label
            // 
            this.ICD3Label.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ICD3Label.Appearance.Options.UseFont = true;
            this.ICD3Label.Location = new System.Drawing.Point(68, 301);
            this.ICD3Label.Name = "ICD3Label";
            this.ICD3Label.Size = new System.Drawing.Size(27, 13);
            this.ICD3Label.TabIndex = 43;
            this.ICD3Label.Text = "ICD3";
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(10, 372);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(22, 13);
            this.labelControl15.TabIndex = 44;
            this.labelControl15.Text = "Leki:";
            // 
            // lekiLabel
            // 
            this.lekiLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lekiLabel.Appearance.Options.UseFont = true;
            this.lekiLabel.Location = new System.Drawing.Point(38, 372);
            this.lekiLabel.Name = "lekiLabel";
            this.lekiLabel.Size = new System.Drawing.Size(20, 13);
            this.lekiLabel.TabIndex = 45;
            this.lekiLabel.Text = "leki";
            // 
            // labelControl23
            // 
            this.labelControl23.Location = new System.Drawing.Point(10, 434);
            this.labelControl23.Name = "labelControl23";
            this.labelControl23.Size = new System.Drawing.Size(49, 13);
            this.labelControl23.TabIndex = 46;
            this.labelControl23.Text = "Zalecenia:";
            // 
            // zaleceniaLabel
            // 
            this.zaleceniaLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaleceniaLabel.Appearance.Options.UseFont = true;
            this.zaleceniaLabel.Location = new System.Drawing.Point(65, 434);
            this.zaleceniaLabel.Name = "zaleceniaLabel";
            this.zaleceniaLabel.Size = new System.Drawing.Size(53, 13);
            this.zaleceniaLabel.TabIndex = 47;
            this.zaleceniaLabel.Text = "zalecenia";
            // 
            // labelControl27
            // 
            this.labelControl27.Location = new System.Drawing.Point(9, 472);
            this.labelControl27.Name = "labelControl27";
            this.labelControl27.Size = new System.Drawing.Size(62, 13);
            this.labelControl27.TabIndex = 48;
            this.labelControl27.Text = "Przyjmujący:";
            // 
            // przyrjmujacyLabel
            // 
            this.przyrjmujacyLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przyrjmujacyLabel.Appearance.Options.UseFont = true;
            this.przyrjmujacyLabel.Location = new System.Drawing.Point(80, 472);
            this.przyrjmujacyLabel.Name = "przyrjmujacyLabel";
            this.przyrjmujacyLabel.Size = new System.Drawing.Size(71, 13);
            this.przyrjmujacyLabel.TabIndex = 49;
            this.przyrjmujacyLabel.Text = "przyjmujący";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.patientIDLabelTB);
            this.layoutControl1.Controls.Add(this.nameLabelTB);
            this.layoutControl1.Controls.Add(this.phoneLabelTB);
            this.layoutControl1.Controls.Add(this.peselLabelTB);
            this.layoutControl1.Controls.Add(this.surnameLabelTB);
            this.layoutControl1.Controls.Add(this.birthLabelTB);
            this.layoutControl1.Controls.Add(this.countryLabelTB);
            this.layoutControl1.Controls.Add(this.sexLabelTB);
            this.layoutControl1.Controls.Add(this.addressLabelTB);
            this.layoutControl1.Controls.Add(this.poleCardLabelTB);
            this.layoutControl1.Controls.Add(this.dowodLabelTB);
            this.layoutControl1.Controls.Add(this.passportLabelTB);
            this.layoutControl1.Controls.Add(this.insuranceLabelTB);
            this.layoutControl1.Location = new System.Drawing.Point(12, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1280, 228, 450, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(683, 235);
            this.layoutControl1.TabIndex = 27;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.nameLabel,
            this.patientIDLabel,
            this.surnameLabel,
            this.birthLabel,
            this.countryLabel,
            this.sexLabel,
            this.addressLabel,
            this.insuranceLabel,
            this.passportLabel,
            this.dowodLabel,
            this.poleCardLabel,
            this.peselLabel,
            this.phoneLabel,
            this.simpleLabelItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(683, 235);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // phoneLabelTB
            // 
            this.phoneLabelTB.Location = new System.Drawing.Point(428, 29);
            this.phoneLabelTB.Name = "phoneLabelTB";
            this.phoneLabelTB.Size = new System.Drawing.Size(243, 20);
            this.phoneLabelTB.StyleController = this.layoutControl1;
            this.phoneLabelTB.TabIndex = 6;
            // 
            // peselLabelTB
            // 
            this.peselLabelTB.Location = new System.Drawing.Point(428, 53);
            this.peselLabelTB.Name = "peselLabelTB";
            this.peselLabelTB.Size = new System.Drawing.Size(243, 20);
            this.peselLabelTB.StyleController = this.layoutControl1;
            this.peselLabelTB.TabIndex = 7;
            // 
            // nameLabelTB
            // 
            this.nameLabelTB.Location = new System.Drawing.Point(96, 53);
            this.nameLabelTB.Name = "nameLabelTB";
            this.nameLabelTB.Size = new System.Drawing.Size(244, 20);
            this.nameLabelTB.StyleController = this.layoutControl1;
            this.nameLabelTB.TabIndex = 5;
            // 
            // patientIDLabelTB
            // 
            this.patientIDLabelTB.Location = new System.Drawing.Point(96, 29);
            this.patientIDLabelTB.Name = "patientIDLabelTB";
            this.patientIDLabelTB.Size = new System.Drawing.Size(244, 20);
            this.patientIDLabelTB.StyleController = this.layoutControl1;
            this.patientIDLabelTB.TabIndex = 4;
            // 
            // surnameLabelTB
            // 
            this.surnameLabelTB.Location = new System.Drawing.Point(96, 77);
            this.surnameLabelTB.Name = "surnameLabelTB";
            this.surnameLabelTB.Size = new System.Drawing.Size(244, 20);
            this.surnameLabelTB.StyleController = this.layoutControl1;
            this.surnameLabelTB.TabIndex = 8;
            // 
            // birthLabelTB
            // 
            this.birthLabelTB.Location = new System.Drawing.Point(96, 101);
            this.birthLabelTB.Name = "birthLabelTB";
            this.birthLabelTB.Size = new System.Drawing.Size(244, 20);
            this.birthLabelTB.StyleController = this.layoutControl1;
            this.birthLabelTB.TabIndex = 9;
            // 
            // countryLabelTB
            // 
            this.countryLabelTB.Location = new System.Drawing.Point(96, 125);
            this.countryLabelTB.Name = "countryLabelTB";
            this.countryLabelTB.Size = new System.Drawing.Size(244, 20);
            this.countryLabelTB.StyleController = this.layoutControl1;
            this.countryLabelTB.TabIndex = 10;
            // 
            // sexLabelTB
            // 
            this.sexLabelTB.Location = new System.Drawing.Point(96, 149);
            this.sexLabelTB.Name = "sexLabelTB";
            this.sexLabelTB.Size = new System.Drawing.Size(244, 20);
            this.sexLabelTB.StyleController = this.layoutControl1;
            this.sexLabelTB.TabIndex = 11;
            // 
            // addressLabelTB
            // 
            this.addressLabelTB.Location = new System.Drawing.Point(96, 173);
            this.addressLabelTB.Name = "addressLabelTB";
            this.addressLabelTB.Size = new System.Drawing.Size(575, 20);
            this.addressLabelTB.StyleController = this.layoutControl1;
            this.addressLabelTB.TabIndex = 12;
            // 
            // poleCardLabelTB
            // 
            this.poleCardLabelTB.Location = new System.Drawing.Point(428, 77);
            this.poleCardLabelTB.Name = "poleCardLabelTB";
            this.poleCardLabelTB.Size = new System.Drawing.Size(243, 20);
            this.poleCardLabelTB.StyleController = this.layoutControl1;
            this.poleCardLabelTB.TabIndex = 13;
            // 
            // dowodLabelTB
            // 
            this.dowodLabelTB.Location = new System.Drawing.Point(428, 101);
            this.dowodLabelTB.Name = "dowodLabelTB";
            this.dowodLabelTB.Size = new System.Drawing.Size(243, 20);
            this.dowodLabelTB.StyleController = this.layoutControl1;
            this.dowodLabelTB.TabIndex = 14;
            // 
            // passportLabelTB
            // 
            this.passportLabelTB.Location = new System.Drawing.Point(428, 125);
            this.passportLabelTB.Name = "passportLabelTB";
            this.passportLabelTB.Size = new System.Drawing.Size(243, 20);
            this.passportLabelTB.StyleController = this.layoutControl1;
            this.passportLabelTB.TabIndex = 15;
            // 
            // insuranceLabelTB
            // 
            this.insuranceLabelTB.Location = new System.Drawing.Point(428, 149);
            this.insuranceLabelTB.Name = "insuranceLabelTB";
            this.insuranceLabelTB.Size = new System.Drawing.Size(243, 20);
            this.insuranceLabelTB.StyleController = this.layoutControl1;
            this.insuranceLabelTB.TabIndex = 16;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(302, 362);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 28;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(646, 67);
            // 
            // nameLabel
            // 
            this.nameLabel.Control = this.nameLabelTB;
            this.nameLabel.CustomizationFormText = "layoutControlItem2";
            this.nameLabel.Location = new System.Drawing.Point(0, 41);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(332, 24);
            this.nameLabel.Text = "Imię:";
            this.nameLabel.TextLocation = DevExpress.Utils.Locations.Left;
            this.nameLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // patientIDLabel
            // 
            this.patientIDLabel.Control = this.patientIDLabelTB;
            this.patientIDLabel.CustomizationFormText = "layoutControlItem1";
            this.patientIDLabel.Location = new System.Drawing.Point(0, 17);
            this.patientIDLabel.Name = "patientIDLabel";
            this.patientIDLabel.Size = new System.Drawing.Size(332, 24);
            this.patientIDLabel.Text = "Numer pacjenta:";
            this.patientIDLabel.TextLocation = DevExpress.Utils.Locations.Left;
            this.patientIDLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // surnameLabel
            // 
            this.surnameLabel.Control = this.surnameLabelTB;
            this.surnameLabel.Location = new System.Drawing.Point(0, 65);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(332, 24);
            this.surnameLabel.Text = "Nazwisko:";
            this.surnameLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // birthLabel
            // 
            this.birthLabel.Control = this.birthLabelTB;
            this.birthLabel.Location = new System.Drawing.Point(0, 89);
            this.birthLabel.Name = "birthLabel";
            this.birthLabel.Size = new System.Drawing.Size(332, 24);
            this.birthLabel.Text = "Data urodzenia:";
            this.birthLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // countryLabel
            // 
            this.countryLabel.Control = this.countryLabelTB;
            this.countryLabel.Location = new System.Drawing.Point(0, 113);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(332, 24);
            this.countryLabel.Text = "Kraj:";
            this.countryLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // sexLabel
            // 
            this.sexLabel.Control = this.sexLabelTB;
            this.sexLabel.Location = new System.Drawing.Point(0, 137);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(332, 24);
            this.sexLabel.Text = "Płeć:";
            this.sexLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // addressLabel
            // 
            this.addressLabel.Control = this.addressLabelTB;
            this.addressLabel.Location = new System.Drawing.Point(0, 161);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(663, 54);
            this.addressLabel.Text = "Adres:";
            this.addressLabel.TextLocation = DevExpress.Utils.Locations.Left;
            this.addressLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // insuranceLabel
            // 
            this.insuranceLabel.Control = this.insuranceLabelTB;
            this.insuranceLabel.Location = new System.Drawing.Point(332, 137);
            this.insuranceLabel.Name = "insuranceLabel";
            this.insuranceLabel.Size = new System.Drawing.Size(331, 24);
            this.insuranceLabel.Text = "Ubezpieczenie:";
            this.insuranceLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // passportLabel
            // 
            this.passportLabel.Control = this.passportLabelTB;
            this.passportLabel.Location = new System.Drawing.Point(332, 113);
            this.passportLabel.Name = "passportLabel";
            this.passportLabel.Size = new System.Drawing.Size(331, 24);
            this.passportLabel.Text = "Paszport:";
            this.passportLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // dowodLabel
            // 
            this.dowodLabel.Control = this.dowodLabelTB;
            this.dowodLabel.Location = new System.Drawing.Point(332, 89);
            this.dowodLabel.Name = "dowodLabel";
            this.dowodLabel.Size = new System.Drawing.Size(331, 24);
            this.dowodLabel.Text = "Dowód osobisty:";
            this.dowodLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // poleCardLabel
            // 
            this.poleCardLabel.Control = this.poleCardLabelTB;
            this.poleCardLabel.Location = new System.Drawing.Point(332, 65);
            this.poleCardLabel.Name = "poleCardLabel";
            this.poleCardLabel.Size = new System.Drawing.Size(331, 24);
            this.poleCardLabel.Text = "Karta Polaka:";
            this.poleCardLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // peselLabel
            // 
            this.peselLabel.Control = this.peselLabelTB;
            this.peselLabel.CustomizationFormText = "layoutControlItem4";
            this.peselLabel.Location = new System.Drawing.Point(332, 41);
            this.peselLabel.Name = "peselLabel";
            this.peselLabel.Size = new System.Drawing.Size(331, 24);
            this.peselLabel.Text = "PESEL:";
            this.peselLabel.TextLocation = DevExpress.Utils.Locations.Left;
            this.peselLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // phoneLabel
            // 
            this.phoneLabel.Control = this.phoneLabelTB;
            this.phoneLabel.CustomizationFormText = "layoutControlItem3";
            this.phoneLabel.Location = new System.Drawing.Point(332, 17);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(331, 24);
            this.phoneLabel.Text = "Telefon:";
            this.phoneLabel.TextLocation = DevExpress.Utils.Locations.Left;
            this.phoneLabel.TextSize = new System.Drawing.Size(80, 13);
            // 
            // simpleLabelItem1
            // 
            this.simpleLabelItem1.AllowHotTrack = false;
            this.simpleLabelItem1.Location = new System.Drawing.Point(0, 0);
            this.simpleLabelItem1.Name = "simpleLabelItem1";
            this.simpleLabelItem1.Size = new System.Drawing.Size(663, 17);
            this.simpleLabelItem1.Text = "Dane Pacjenta";
            this.simpleLabelItem1.TextSize = new System.Drawing.Size(80, 13);
            // 
            // ViewVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 723);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.wizytaGroup);
            this.Controls.Add(this.gridControl1);
            this.Name = "ViewVisit";
            this.Text = "ViewVisit";
            this.Load += new System.EventHandler(this.VisitView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wizytaGroup)).EndInit();
            this.wizytaGroup.ResumeLayout(false);
            this.wizytaGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleCardLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceLabelTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientIDLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surnameLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birthLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countryLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.insuranceLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passportLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dowodLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poleCardLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peselLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.GroupControl wizytaGroup;
        private DevExpress.XtraEditors.LabelControl przyrjmujacyLabel;
        private DevExpress.XtraEditors.LabelControl labelControl27;
        private DevExpress.XtraEditors.LabelControl zaleceniaLabel;
        private DevExpress.XtraEditors.LabelControl labelControl23;
        private DevExpress.XtraEditors.LabelControl lekiLabel;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.LabelControl ICD3Label;
        private DevExpress.XtraEditors.LabelControl labelControl21;
        private DevExpress.XtraEditors.LabelControl ICD2Label;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.LabelControl visitIDLabel;
        private DevExpress.XtraEditors.LabelControl labelControl20;
        private DevExpress.XtraEditors.LabelControl labelControl14;
        private DevExpress.XtraEditors.LabelControl labelControl26;
        private DevExpress.XtraEditors.LabelControl rozpoznanieLabel;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl ICD1Label;
        private DevExpress.XtraEditors.LabelControl objawyLabel;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.LabelControl labelControl22;
        private DevExpress.XtraEditors.LabelControl bpodmiotowe;
        private DevExpress.XtraEditors.LabelControl bprzedmiotoweLabel;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit patientIDLabelTB;
        private DevExpress.XtraEditors.TextEdit nameLabelTB;
        private DevExpress.XtraEditors.TextEdit phoneLabelTB;
        private DevExpress.XtraEditors.TextEdit peselLabelTB;
        private DevExpress.XtraEditors.TextEdit surnameLabelTB;
        private DevExpress.XtraEditors.TextEdit birthLabelTB;
        private DevExpress.XtraEditors.TextEdit countryLabelTB;
        private DevExpress.XtraEditors.TextEdit sexLabelTB;
        private DevExpress.XtraEditors.TextEdit addressLabelTB;
        private DevExpress.XtraEditors.TextEdit poleCardLabelTB;
        private DevExpress.XtraEditors.TextEdit dowodLabelTB;
        private DevExpress.XtraEditors.TextEdit passportLabelTB;
        private DevExpress.XtraEditors.TextEdit insuranceLabelTB;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem nameLabel;
        private DevExpress.XtraLayout.LayoutControlItem patientIDLabel;
        private DevExpress.XtraLayout.LayoutControlItem surnameLabel;
        private DevExpress.XtraLayout.LayoutControlItem birthLabel;
        private DevExpress.XtraLayout.LayoutControlItem countryLabel;
        private DevExpress.XtraLayout.LayoutControlItem sexLabel;
        private DevExpress.XtraLayout.LayoutControlItem addressLabel;
        private DevExpress.XtraLayout.LayoutControlItem insuranceLabel;
        private DevExpress.XtraLayout.LayoutControlItem passportLabel;
        private DevExpress.XtraLayout.LayoutControlItem dowodLabel;
        private DevExpress.XtraLayout.LayoutControlItem poleCardLabel;
        private DevExpress.XtraLayout.LayoutControlItem peselLabel;
        private DevExpress.XtraLayout.LayoutControlItem phoneLabel;
        private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
    }
}