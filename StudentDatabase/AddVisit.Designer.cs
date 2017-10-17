namespace StudentDatabase
{
    partial class AddVisit
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
            this.icdFilter1 = new DevExpress.XtraEditors.LookUpEdit();
            this.iCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.bpodTB = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.patientFilter = new DevExpress.XtraEditors.LookUpEdit();
            this.pACJENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.icdFilter2 = new DevExpress.XtraEditors.LookUpEdit();
            this.icdFilter3 = new DevExpress.XtraEditors.LookUpEdit();
            this.addVisitButton = new System.Windows.Forms.Button();
            this.nameSurnameLabel = new DevExpress.XtraEditors.LabelControl();
            this.dateLabel = new DevExpress.XtraEditors.LabelControl();
            this.bprzedTB = new System.Windows.Forms.RichTextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.rozpoznanieTB = new System.Windows.Forms.RichTextBox();
            this.lekiTB = new System.Windows.Forms.RichTextBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.objawyTB = new System.Windows.Forms.RichTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.filteringUIContext1 = new DevExpress.Utils.Filtering.FilteringUIContext(this.components);
            this.iCDTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.ICDTableAdapter();
            this.pACJENTTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.PACJENTTableAdapter();
            this.wIZYTATableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.WIZYTATableAdapter();
            this.wIZYTABindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icdFilter1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icdFilter2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icdFilter3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // icdFilter1
            // 
            this.icdFilter1.EditValue = "";
            this.icdFilter1.Location = new System.Drawing.Point(102, 250);
            this.icdFilter1.Name = "icdFilter1";
            this.icdFilter1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icdFilter1.Properties.DataSource = this.iCDBindingSource;
            this.icdFilter1.Properties.DisplayMember = "Rozpoznanie";
            this.icdFilter1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.icdFilter1.Properties.ValueMember = "idICD";
            this.icdFilter1.Size = new System.Drawing.Size(166, 20);
            this.icdFilter1.TabIndex = 6;
            // 
            // iCDBindingSource
            // 
            this.iCDBindingSource.DataMember = "ICD";
            this.iCDBindingSource.DataSource = this.poradniaDataSet;
            // 
            // poradniaDataSet
            // 
            this.poradniaDataSet.DataSetName = "PoradniaDataSet";
            this.poradniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bpodTB
            // 
            this.bpodTB.Location = new System.Drawing.Point(413, 159);
            this.bpodTB.Name = "bpodTB";
            this.bpodTB.Size = new System.Drawing.Size(158, 67);
            this.bpodTB.TabIndex = 5;
            this.bpodTB.Text = "";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(304, 189);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(103, 13);
            this.labelControl2.TabIndex = 71;
            this.labelControl2.Text = "Badanie podmiotowe:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 189);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 13);
            this.labelControl1.TabIndex = 70;
            this.labelControl1.Text = "Badanie przedmiotowe:";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = new System.DateTime(2017, 8, 29, 22, 35, 50, 0);
            this.dateEdit1.Location = new System.Drawing.Point(102, 57);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.CalendarTimeProperties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.TouchUI;
            this.dateEdit1.Properties.DisplayFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.dateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Properties.EditFormat.FormatString = "dd/MM/yyyy hh:mm";
            this.dateEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.dateEdit1.Properties.Mask.EditMask = "g";
            this.dateEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateEdit1.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.dateEdit1.Size = new System.Drawing.Size(126, 20);
            this.dateEdit1.TabIndex = 2;
            // 
            // patientFilter
            // 
            this.patientFilter.Location = new System.Drawing.Point(102, 22);
            this.patientFilter.Name = "patientFilter";
            this.patientFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.patientFilter.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Pacjent", "ID_Pacjent", 76, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Imie", "Imie", 30, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nazwisko", "Nazwisko", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Adres", "Adres", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Kraj", "Kraj", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Data_urodzenia", "Data_urodzenia", 86, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Plec", "Plec", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PESEL", "PESEL", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Karta_polaka", "Karta_polaka", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Dowod_osobisty", "Dowod_osobisty", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Paszport", "Paszport", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID_Ubezpieczenie", "ID_Ubezpieczenie", 20, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Telefon", "Telefon", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near)});
            this.patientFilter.Properties.DataSource = this.pACJENTBindingSource;
            this.patientFilter.Properties.DisplayMember = "Nazwisko";
            this.patientFilter.Properties.KeyMember = "Adres;Kraj;Plec;PESEL;Karta_polaka;Dowod_osobisty;Paszport;ID_Ubezpieczenie;Telef" +
    "on";
            this.patientFilter.Properties.NullText = "";
            this.patientFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.patientFilter.Properties.ValueMember = "ID_Pacjent";
            this.patientFilter.Size = new System.Drawing.Size(126, 20);
            this.patientFilter.TabIndex = 1;
            // 
            // pACJENTBindingSource
            // 
            this.pACJENTBindingSource.DataMember = "PACJENT";
            this.pACJENTBindingSource.DataSource = this.poradniaDataSet;
            // 
            // icdFilter2
            // 
            this.icdFilter2.EditValue = "";
            this.icdFilter2.Location = new System.Drawing.Point(274, 250);
            this.icdFilter2.Name = "icdFilter2";
            this.icdFilter2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icdFilter2.Properties.DataSource = this.iCDBindingSource;
            this.icdFilter2.Properties.DisplayMember = "Rozpoznanie";
            this.icdFilter2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.icdFilter2.Properties.ValueMember = "idICD";
            this.icdFilter2.Size = new System.Drawing.Size(166, 20);
            this.icdFilter2.TabIndex = 7;
            // 
            // icdFilter3
            // 
            this.icdFilter3.EditValue = "";
            this.icdFilter3.Location = new System.Drawing.Point(446, 250);
            this.icdFilter3.Name = "icdFilter3";
            this.icdFilter3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icdFilter3.Properties.DataSource = this.iCDBindingSource;
            this.icdFilter3.Properties.DisplayMember = "Rozpoznanie";
            this.icdFilter3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.icdFilter3.Properties.ValueMember = "idICD";
            this.icdFilter3.Size = new System.Drawing.Size(166, 20);
            this.icdFilter3.TabIndex = 9;
            // 
            // addVisitButton
            // 
            this.addVisitButton.Location = new System.Drawing.Point(274, 410);
            this.addVisitButton.Name = "addVisitButton";
            this.addVisitButton.Size = new System.Drawing.Size(75, 23);
            this.addVisitButton.TabIndex = 12;
            this.addVisitButton.Text = "Dodaj pacjenta";
            this.addVisitButton.UseVisualStyleBackColor = true;
            this.addVisitButton.Click += new System.EventHandler(this.addVisitButton_Click);
            // 
            // nameSurnameLabel
            // 
            this.nameSurnameLabel.Location = new System.Drawing.Point(12, 25);
            this.nameSurnameLabel.Name = "nameSurnameLabel";
            this.nameSurnameLabel.Size = new System.Drawing.Size(75, 13);
            this.nameSurnameLabel.TabIndex = 78;
            this.nameSurnameLabel.Text = "Imie i nazwisko:";
            // 
            // dateLabel
            // 
            this.dateLabel.Location = new System.Drawing.Point(9, 60);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(27, 13);
            this.dateLabel.TabIndex = 79;
            this.dateLabel.Text = "Data:";
            // 
            // bprzedTB
            // 
            this.bprzedTB.Location = new System.Drawing.Point(140, 159);
            this.bprzedTB.Name = "bprzedTB";
            this.bprzedTB.Size = new System.Drawing.Size(158, 67);
            this.bprzedTB.TabIndex = 4;
            this.bprzedTB.Text = "";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(9, 253);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 81;
            this.labelControl5.Text = "ICD:";
            // 
            // rozpoznanieTB
            // 
            this.rozpoznanieTB.Location = new System.Drawing.Point(102, 299);
            this.rozpoznanieTB.Name = "rozpoznanieTB";
            this.rozpoznanieTB.Size = new System.Drawing.Size(158, 67);
            this.rozpoznanieTB.TabIndex = 10;
            this.rozpoznanieTB.Text = "";
            // 
            // lekiTB
            // 
            this.lekiTB.Location = new System.Drawing.Point(396, 299);
            this.lekiTB.Name = "lekiTB";
            this.lekiTB.Size = new System.Drawing.Size(158, 67);
            this.lekiTB.TabIndex = 11;
            this.lekiTB.Text = "";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(340, 333);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 13);
            this.labelControl8.TabIndex = 85;
            this.labelControl8.Text = "Leki:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(9, 333);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 13);
            this.labelControl9.TabIndex = 84;
            this.labelControl9.Text = "Rozpoznanie:";
            // 
            // objawyTB
            // 
            this.objawyTB.Location = new System.Drawing.Point(140, 83);
            this.objawyTB.Name = "objawyTB";
            this.objawyTB.Size = new System.Drawing.Size(158, 67);
            this.objawyTB.TabIndex = 3;
            this.objawyTB.Text = "";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 113);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 88;
            this.labelControl3.Text = "Objawy:";
            // 
            // filteringUIContext1
            // 
            this.filteringUIContext1.ModelType = typeof(StudentDatabase.PoradniaDataSet);
            // 
            // iCDTableAdapter
            // 
            this.iCDTableAdapter.ClearBeforeFill = true;
            // 
            // pACJENTTableAdapter
            // 
            this.pACJENTTableAdapter.ClearBeforeFill = true;
            // 
            // wIZYTATableAdapter
            // 
            this.wIZYTATableAdapter.ClearBeforeFill = true;
            // 
            // wIZYTABindingSource
            // 
            this.wIZYTABindingSource.DataMember = "WIZYTA";
            this.wIZYTABindingSource.DataSource = this.poradniaDataSet;
            // 
            // AddVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 442);
            this.Controls.Add(this.objawyTB);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.rozpoznanieTB);
            this.Controls.Add(this.lekiTB);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.bprzedTB);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.nameSurnameLabel);
            this.Controls.Add(this.addVisitButton);
            this.Controls.Add(this.icdFilter3);
            this.Controls.Add(this.icdFilter2);
            this.Controls.Add(this.patientFilter);
            this.Controls.Add(this.dateEdit1);
            this.Controls.Add(this.bpodTB);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.icdFilter1);
            this.Name = "AddVisit";
            this.Text = "AddVisit";
            this.Load += new System.EventHandler(this.AddVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icdFilter1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icdFilter2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icdFilter3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filteringUIContext1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wIZYTABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Filtering.FilteringUIContext filteringUIContext1;
        private PoradniaDataSet poradniaDataSet;
        private System.Windows.Forms.BindingSource iCDBindingSource;
        private PoradniaDataSetTableAdapters.ICDTableAdapter iCDTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit icdFilter1;
        private System.Windows.Forms.RichTextBox bpodTB;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LookUpEdit patientFilter;
        private System.Windows.Forms.BindingSource pACJENTBindingSource;
        private PoradniaDataSetTableAdapters.PACJENTTableAdapter pACJENTTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit icdFilter2;
        private DevExpress.XtraEditors.LookUpEdit icdFilter3;
        private System.Windows.Forms.Button addVisitButton;
        private DevExpress.XtraEditors.LabelControl nameSurnameLabel;
        private DevExpress.XtraEditors.LabelControl dateLabel;
        private System.Windows.Forms.RichTextBox bprzedTB;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox rozpoznanieTB;
        private System.Windows.Forms.RichTextBox lekiTB;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.RichTextBox objawyTB;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private PoradniaDataSetTableAdapters.WIZYTATableAdapter wIZYTATableAdapter;
        private System.Windows.Forms.BindingSource wIZYTABindingSource;
    }
}