﻿namespace StudentDatabase
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
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.kodTB = new DevExpress.XtraEditors.TextEdit();
            this.addICDButton = new System.Windows.Forms.Button();
            this.rozpoznanieTB = new System.Windows.Forms.RichTextBox();
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.iCDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iCDTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.ICDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.kodTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iCDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12.25F);
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(126, 12);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(104, 19);
            this.labelControl8.TabIndex = 61;
            this.labelControl8.Text = "Dane osobowe";
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
            // addICDButton
            // 
            this.addICDButton.Location = new System.Drawing.Point(117, 143);
            this.addICDButton.Name = "addICDButton";
            this.addICDButton.Size = new System.Drawing.Size(97, 23);
            this.addICDButton.TabIndex = 67;
            this.addICDButton.Text = "Dodaj kod ICD";
            this.addICDButton.UseVisualStyleBackColor = true;
            this.addICDButton.Click += new System.EventHandler(this.addICDButton_Click);
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
            this.poradniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iCDBindingSource
            // 
            this.iCDBindingSource.DataMember = "ICD";
            this.iCDBindingSource.DataSource = this.poradniaDataSet;
            // 
            // iCDTableAdapter
            // 
            this.iCDTableAdapter.ClearBeforeFill = true;
            // 
            // AddICD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 178);
            this.Controls.Add(this.rozpoznanieTB);
            this.Controls.Add(this.addICDButton);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.kodTB);
            this.Name = "AddICD";
            this.Text = "AddICD";
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
        private System.Windows.Forms.Button addICDButton;
        private System.Windows.Forms.RichTextBox rozpoznanieTB;
        private PoradniaDataSet poradniaDataSet;
        private System.Windows.Forms.BindingSource iCDBindingSource;
        private PoradniaDataSetTableAdapters.ICDTableAdapter iCDTableAdapter;
    }
}