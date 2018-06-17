namespace StudentDatabase
{
    partial class SelectPane
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
            this.patientButton = new DevExpress.XtraEditors.SimpleButton();
            this.visitButton = new DevExpress.XtraEditors.SimpleButton();
            this.statisticsButton = new DevExpress.XtraEditors.SimpleButton();
            this.arrange_visitButton = new DevExpress.XtraEditors.SimpleButton();
            this.insuranceButton = new DevExpress.XtraEditors.SimpleButton();
            this.ICDButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // patientButton
            // 
            this.patientButton.Location = new System.Drawing.Point(12, 26);
            this.patientButton.Name = "patientButton";
            this.patientButton.Size = new System.Drawing.Size(114, 31);
            this.patientButton.TabIndex = 1;
            this.patientButton.Text = "Pacjent";
            this.patientButton.Click += new System.EventHandler(this.patientButton_Click);
            // 
            // visitButton
            // 
            this.visitButton.Location = new System.Drawing.Point(158, 26);
            this.visitButton.Name = "visitButton";
            this.visitButton.Size = new System.Drawing.Size(114, 31);
            this.visitButton.TabIndex = 2;
            this.visitButton.Text = "Wizyta";
            this.visitButton.Click += new System.EventHandler(this.visitButton_Click);
            // 
            // statisticsButton
            // 
            this.statisticsButton.Location = new System.Drawing.Point(158, 73);
            this.statisticsButton.Name = "statisticsButton";
            this.statisticsButton.Size = new System.Drawing.Size(114, 31);
            this.statisticsButton.TabIndex = 4;
            this.statisticsButton.Text = "Statystyka";
            this.statisticsButton.Click += new System.EventHandler(this.statisticsButton_Click);
            // 
            // arrange_visitButton
            // 
            this.arrange_visitButton.Location = new System.Drawing.Point(12, 73);
            this.arrange_visitButton.Name = "arrange_visitButton";
            this.arrange_visitButton.Size = new System.Drawing.Size(114, 31);
            this.arrange_visitButton.TabIndex = 3;
            this.arrange_visitButton.Text = "Umów wizytę";
            this.arrange_visitButton.Click += new System.EventHandler(this.arrange_visitButton_Click);
            // 
            // insuranceButton
            // 
            this.insuranceButton.Location = new System.Drawing.Point(158, 122);
            this.insuranceButton.Name = "insuranceButton";
            this.insuranceButton.Size = new System.Drawing.Size(114, 31);
            this.insuranceButton.TabIndex = 6;
            this.insuranceButton.Text = "Typ ubezpieczenia";
            this.insuranceButton.Click += new System.EventHandler(this.insuranceButton_Click);
            // 
            // ICDButton
            // 
            this.ICDButton.Location = new System.Drawing.Point(12, 122);
            this.ICDButton.Name = "ICDButton";
            this.ICDButton.Size = new System.Drawing.Size(114, 31);
            this.ICDButton.TabIndex = 5;
            this.ICDButton.Text = "Kody ICD";
            this.ICDButton.Click += new System.EventHandler(this.ICDButton_Click);
            // 
            // SelectPane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 187);
            this.Controls.Add(this.insuranceButton);
            this.Controls.Add(this.ICDButton);
            this.Controls.Add(this.statisticsButton);
            this.Controls.Add(this.arrange_visitButton);
            this.Controls.Add(this.visitButton);
            this.Controls.Add(this.patientButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelectPane";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPane";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton patientButton;
        private DevExpress.XtraEditors.SimpleButton visitButton;
        private DevExpress.XtraEditors.SimpleButton statisticsButton;
        private DevExpress.XtraEditors.SimpleButton arrange_visitButton;
        private DevExpress.XtraEditors.SimpleButton insuranceButton;
        private DevExpress.XtraEditors.SimpleButton ICDButton;
    }
}