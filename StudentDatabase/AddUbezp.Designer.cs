namespace StudentDatabase
{
    partial class AddUbezp
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.nameUbezpTB = new DevExpress.XtraEditors.TextEdit();
            this.ubezpAdd_button = new DevExpress.XtraEditors.SimpleButton();
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.ubezpieczenieTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.nameUbezpTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(106, 13);
            this.labelControl2.TabIndex = 71;
            this.labelControl2.Text = "Nazwa ubezpieczenia:";
            // 
            // nameUbezpTB
            // 
            this.nameUbezpTB.Location = new System.Drawing.Point(125, 53);
            this.nameUbezpTB.Name = "nameUbezpTB";
            this.nameUbezpTB.Size = new System.Drawing.Size(158, 20);
            this.nameUbezpTB.TabIndex = 1;
            // 
            // ubezpAdd_button
            // 
            this.ubezpAdd_button.Location = new System.Drawing.Point(89, 91);
            this.ubezpAdd_button.Name = "ubezpAdd_button";
            this.ubezpAdd_button.Size = new System.Drawing.Size(114, 31);
            this.ubezpAdd_button.TabIndex = 72;
            this.ubezpAdd_button.Text = "Dodaj ubezpieczenie";
            this.ubezpAdd_button.Click += new System.EventHandler(this.ubezpAdd_button_Click);
            // 
            // poradniaDataSet
            // 
            this.poradniaDataSet.DataSetName = "PoradniaDataSet";
            this.poradniaDataSet.Locale = new System.Globalization.CultureInfo("pl");
            this.poradniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ubezpieczenieTableAdapter
            // 
            this.ubezpieczenieTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(99, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(144, 19);
            this.labelControl8.TabIndex = 73;
            this.labelControl8.Text = "Dodaj ubezpieczenie";
            // 
            // AddUbezp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 134);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.ubezpAdd_button);
            this.Controls.Add(this.nameUbezpTB);
            this.Controls.Add(this.labelControl2);
            this.Name = "AddUbezp";
            this.Text = "Dodaj ubezpieczenie";
            ((System.ComponentModel.ISupportInitialize)(this.nameUbezpTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit nameUbezpTB;
        private DevExpress.XtraEditors.SimpleButton ubezpAdd_button;
        private PoradniaDataSet poradniaDataSet;
        private PoradniaDataSetTableAdapters.UBEZPIECZENIETableAdapter ubezpieczenieTableAdapter;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}