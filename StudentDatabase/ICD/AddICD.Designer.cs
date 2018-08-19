namespace StudentDatabase
{
    partial class AddICD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddICD));
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.kodTB = new DevExpress.XtraEditors.TextEdit();
            this.rozpoznanieTB = new System.Windows.Forms.RichTextBox();
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.iCDTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.ICDTableAdapter();
            this.addICD_button = new DevExpress.XtraEditors.SimpleButton();
            this.iCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kodTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager
            // 
            splashScreenManager.ClosingDelay = 25;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(126, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(105, 19);
            this.labelControl8.TabIndex = 61;
            this.labelControl8.Text = "Dodaj kod ICD";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 70);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 60;
            this.labelControl2.Text = "Rozpoznanie:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(24, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 59;
            this.labelControl1.Text = "Kod ICD:";
            // 
            // kodTB
            // 
            this.kodTB.Location = new System.Drawing.Point(117, 41);
            this.kodTB.Name = "kodTB";
            this.kodTB.Size = new System.Drawing.Size(158, 20);
            this.kodTB.TabIndex = 1;
            // 
            // rozpoznanieTB
            // 
            this.rozpoznanieTB.Location = new System.Drawing.Point(117, 70);
            this.rozpoznanieTB.Name = "rozpoznanieTB";
            this.rozpoznanieTB.Size = new System.Drawing.Size(158, 67);
            this.rozpoznanieTB.TabIndex = 2;
            this.rozpoznanieTB.Text = "";
            // 
            // poradniaDataSet
            // 
            this.poradniaDataSet.DataSetName = "PoradniaDataSet";
            this.poradniaDataSet.Locale = new System.Globalization.CultureInfo("pl");
            this.poradniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iCDTableAdapter
            // 
            this.iCDTableAdapter.ClearBeforeFill = true;
            // 
            // addICD_button
            // 
            this.addICD_button.Location = new System.Drawing.Point(117, 143);
            this.addICD_button.Name = "addICD_button";
            this.addICD_button.Size = new System.Drawing.Size(75, 23);
            this.addICD_button.TabIndex = 3;
            this.addICD_button.Text = "Dodaj kod ICD";
            this.addICD_button.Click += new System.EventHandler(this.addICD_button_Click);
            // 
            // iCDBindingSource
            // 
            this.iCDBindingSource.DataMember = "ICD";
            this.iCDBindingSource.DataSource = this.poradniaDataSet;
            // 
            // AddICD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 178);
            this.Controls.Add(this.addICD_button);
            this.Controls.Add(this.rozpoznanieTB);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.kodTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddICD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj kod ICD";
            ((System.ComponentModel.ISupportInitialize)(this.kodTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit kodTB;
        private System.Windows.Forms.RichTextBox rozpoznanieTB;
        private PoradniaDataSet poradniaDataSet;
        private System.Windows.Forms.BindingSource iCDBindingSource;
        private PoradniaDataSetTableAdapters.ICDTableAdapter iCDTableAdapter;
        private DevExpress.XtraEditors.SimpleButton addICD_button;
    }
}