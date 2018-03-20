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
            this.bpodTB = new System.Windows.Forms.RichTextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
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
            this.pacjentCB = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.pACJENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
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
            this.ICDCB1 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.iCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ICDCB2 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ICDCB3 = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dateEdit = new DevExpress.XtraEditors.DateEdit();
            this.timeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.iCDTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.ICDTableAdapter();
            this.pacjentTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.PACJENTTableAdapter();
            this.wizytaTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.WIZYTATableAdapter();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pacjentCB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICDCB1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICDCB2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICDCB3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // bpodTB
            // 
            this.bpodTB.Location = new System.Drawing.Point(413, 159);
            this.bpodTB.Name = "bpodTB";
            this.bpodTB.Size = new System.Drawing.Size(158, 67);
            this.bpodTB.TabIndex = 6;
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
            this.bprzedTB.TabIndex = 5;
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
            this.objawyTB.TabIndex = 4;
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
            // pacjentCB
            // 
            this.pacjentCB.EditValue = "";
            this.pacjentCB.Location = new System.Drawing.Point(102, 22);
            this.pacjentCB.Name = "pacjentCB";
            this.pacjentCB.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.pacjentCB.Properties.DataSource = this.pACJENTBindingSource;
            this.pacjentCB.Properties.DisplayMember = "Nazwisko";
            this.pacjentCB.Properties.NullText = "";
            this.pacjentCB.Properties.ValueMember = "ID_Pacjent";
            this.pacjentCB.Properties.View = this.searchLookUpEdit1View;
            this.pacjentCB.Size = new System.Drawing.Size(126, 20);
            this.pacjentCB.TabIndex = 1;
            // 
            // pACJENTBindingSource
            // 
            this.pACJENTBindingSource.DataMember = "PACJENT";
            this.pACJENTBindingSource.DataSource = this.poradniaDataSet;
            // 
            // poradniaDataSet
            // 
            this.poradniaDataSet.DataSetName = "PoradniaDataSet";
            this.poradniaDataSet.Locale = new System.Globalization.CultureInfo("pl");
            this.poradniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
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
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.searchLookUpEdit1View.OptionsFind.ShowClearButton = false;
            this.searchLookUpEdit1View.OptionsFind.ShowFindButton = false;
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // colID_Pacjent
            // 
            this.colID_Pacjent.FieldName = "ID_Pacjent";
            this.colID_Pacjent.Name = "colID_Pacjent";
            this.colID_Pacjent.Visible = true;
            this.colID_Pacjent.VisibleIndex = 0;
            this.colID_Pacjent.Width = 76;
            // 
            // colImie
            // 
            this.colImie.FieldName = "Imie";
            this.colImie.Name = "colImie";
            this.colImie.Visible = true;
            this.colImie.VisibleIndex = 1;
            this.colImie.Width = 76;
            // 
            // colNazwisko
            // 
            this.colNazwisko.FieldName = "Nazwisko";
            this.colNazwisko.Name = "colNazwisko";
            this.colNazwisko.Visible = true;
            this.colNazwisko.VisibleIndex = 2;
            this.colNazwisko.Width = 76;
            // 
            // colData_urodzenia
            // 
            this.colData_urodzenia.FieldName = "Data_urodzenia";
            this.colData_urodzenia.Name = "colData_urodzenia";
            this.colData_urodzenia.Visible = true;
            this.colData_urodzenia.VisibleIndex = 3;
            this.colData_urodzenia.Width = 96;
            // 
            // colKraj
            // 
            this.colKraj.FieldName = "Kraj";
            this.colKraj.Name = "colKraj";
            this.colKraj.Visible = true;
            this.colKraj.VisibleIndex = 4;
            this.colKraj.Width = 76;
            // 
            // colTelefon
            // 
            this.colTelefon.FieldName = "Telefon";
            this.colTelefon.Name = "colTelefon";
            this.colTelefon.Visible = true;
            this.colTelefon.VisibleIndex = 5;
            this.colTelefon.Width = 76;
            // 
            // colPlec
            // 
            this.colPlec.FieldName = "Plec";
            this.colPlec.Name = "colPlec";
            this.colPlec.Visible = true;
            this.colPlec.VisibleIndex = 6;
            this.colPlec.Width = 76;
            // 
            // colUlica
            // 
            this.colUlica.FieldName = "Ulica";
            this.colUlica.Name = "colUlica";
            // 
            // colNr_budynku
            // 
            this.colNr_budynku.FieldName = "Nr_budynku";
            this.colNr_budynku.Name = "colNr_budynku";
            // 
            // colNr_mieszkania
            // 
            this.colNr_mieszkania.FieldName = "Nr_mieszkania";
            this.colNr_mieszkania.Name = "colNr_mieszkania";
            // 
            // colKod_pocztowy
            // 
            this.colKod_pocztowy.FieldName = "Kod_pocztowy";
            this.colKod_pocztowy.Name = "colKod_pocztowy";
            // 
            // colMiasto
            // 
            this.colMiasto.FieldName = "Miasto";
            this.colMiasto.Name = "colMiasto";
            // 
            // colPESEL
            // 
            this.colPESEL.FieldName = "PESEL";
            this.colPESEL.Name = "colPESEL";
            // 
            // colKarta_polaka
            // 
            this.colKarta_polaka.FieldName = "Karta_polaka";
            this.colKarta_polaka.Name = "colKarta_polaka";
            // 
            // colDowod_osobisty
            // 
            this.colDowod_osobisty.FieldName = "Dowod_osobisty";
            this.colDowod_osobisty.Name = "colDowod_osobisty";
            // 
            // colPaszport
            // 
            this.colPaszport.FieldName = "Paszport";
            this.colPaszport.Name = "colPaszport";
            // 
            // colUbezpieczenie
            // 
            this.colUbezpieczenie.FieldName = "Ubezpieczenie";
            this.colUbezpieczenie.Name = "colUbezpieczenie";
            this.colUbezpieczenie.Visible = true;
            this.colUbezpieczenie.VisibleIndex = 7;
            this.colUbezpieczenie.Width = 88;
            // 
            // ICDCB1
            // 
            this.ICDCB1.EditValue = "";
            this.ICDCB1.Location = new System.Drawing.Point(102, 251);
            this.ICDCB1.Name = "ICDCB1";
            this.ICDCB1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ICDCB1.Properties.DataSource = this.iCDBindingSource;
            this.ICDCB1.Properties.DisplayMember = "Kod_ICD";
            this.ICDCB1.Properties.ValueMember = "ID_ICD";
            this.ICDCB1.Properties.View = this.gridView1;
            this.ICDCB1.Size = new System.Drawing.Size(158, 20);
            this.ICDCB1.TabIndex = 7;
            // 
            // iCDBindingSource
            // 
            this.iCDBindingSource.DataMember = "ICD";
            this.iCDBindingSource.DataSource = this.poradniaDataSet;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridView1.OptionsFind.ShowClearButton = false;
            this.gridView1.OptionsFind.ShowFindButton = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ICDCB2
            // 
            this.ICDCB2.EditValue = "";
            this.ICDCB2.Location = new System.Drawing.Point(266, 251);
            this.ICDCB2.Name = "ICDCB2";
            this.ICDCB2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ICDCB2.Properties.DataSource = this.iCDBindingSource;
            this.ICDCB2.Properties.DisplayMember = "Kod_ICD";
            this.ICDCB2.Properties.ValueMember = "ID_ICD";
            this.ICDCB2.Properties.View = this.gridView2;
            this.ICDCB2.Size = new System.Drawing.Size(158, 20);
            this.ICDCB2.TabIndex = 8;
            // 
            // gridView2
            // 
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridView2.OptionsFind.ShowClearButton = false;
            this.gridView2.OptionsFind.ShowFindButton = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ICDCB3
            // 
            this.ICDCB3.EditValue = "";
            this.ICDCB3.Location = new System.Drawing.Point(430, 251);
            this.ICDCB3.Name = "ICDCB3";
            this.ICDCB3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ICDCB3.Properties.DataSource = this.iCDBindingSource;
            this.ICDCB3.Properties.DisplayMember = "Kod_ICD";
            this.ICDCB3.Properties.ValueMember = "ID_ICD";
            this.ICDCB3.Properties.View = this.gridView3;
            this.ICDCB3.Size = new System.Drawing.Size(158, 20);
            this.ICDCB3.TabIndex = 9;
            // 
            // gridView3
            // 
            this.gridView3.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsFind.FindNullPrompt = "Wpisz co chcesz wyszukać...";
            this.gridView3.OptionsFind.ShowClearButton = false;
            this.gridView3.OptionsFind.ShowFindButton = false;
            this.gridView3.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // dateEdit
            // 
            this.dateEdit.EditValue = null;
            this.dateEdit.Location = new System.Drawing.Point(102, 57);
            this.dateEdit.Name = "dateEdit";
            this.dateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit.Size = new System.Drawing.Size(126, 20);
            this.dateEdit.TabIndex = 2;
            // 
            // timeEdit
            // 
            this.timeEdit.EditValue = new System.DateTime(2018, 3, 5, 0, 0, 0, 0);
            this.timeEdit.Location = new System.Drawing.Point(260, 58);
            this.timeEdit.Name = "timeEdit";
            this.timeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.timeEdit.Properties.Mask.EditMask = "t";
            this.timeEdit.Properties.TouchUIMinuteIncrement = 5;
            this.timeEdit.Size = new System.Drawing.Size(100, 20);
            this.timeEdit.TabIndex = 3;
            this.timeEdit.Spin += new DevExpress.XtraEditors.Controls.SpinEventHandler(this.timeEdit_Spin);
            // 
            // iCDTableAdapter
            // 
            this.iCDTableAdapter.ClearBeforeFill = true;
            // 
            // pacjentTableAdapter
            // 
            this.pacjentTableAdapter.ClearBeforeFill = true;
            // 
            // wizytaTableAdapter
            // 
            this.wizytaTableAdapter.ClearBeforeFill = true;
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // AddVisit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 442);
            this.Controls.Add(this.timeEdit);
            this.Controls.Add(this.dateEdit);
            this.Controls.Add(this.ICDCB3);
            this.Controls.Add(this.ICDCB2);
            this.Controls.Add(this.ICDCB1);
            this.Controls.Add(this.pacjentCB);
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
            this.Controls.Add(this.bpodTB);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "AddVisit";
            this.Text = "AddVisit";
            this.Load += new System.EventHandler(this.AddVisit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pacjentCB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pACJENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICDCB1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICDCB2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICDCB3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PoradniaDataSet poradniaDataSet;
        private System.Windows.Forms.BindingSource iCDBindingSource;
        private PoradniaDataSetTableAdapters.ICDTableAdapter iCDTableAdapter;
        private System.Windows.Forms.RichTextBox bpodTB;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.BindingSource pACJENTBindingSource;
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
        private PoradniaDataSetTableAdapters.PACJENTTableAdapter pacjentTableAdapter;
        private DevExpress.XtraEditors.SearchLookUpEdit pacjentCB;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.SearchLookUpEdit ICDCB1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit ICDCB2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.SearchLookUpEdit ICDCB3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.DateEdit dateEdit;
        private DevExpress.XtraEditors.TimeEdit timeEdit;
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
        private PoradniaDataSetTableAdapters.WIZYTATableAdapter wizytaTableAdapter;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
    }
}