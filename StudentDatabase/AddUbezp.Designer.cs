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
            this.addUbezpButton = new System.Windows.Forms.Button();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.kodTB = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.kodTB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // addUbezpButton
            // 
            this.addUbezpButton.Location = new System.Drawing.Point(107, 91);
            this.addUbezpButton.Name = "addUbezpButton";
            this.addUbezpButton.Size = new System.Drawing.Size(97, 35);
            this.addUbezpButton.TabIndex = 73;
            this.addUbezpButton.Text = "Dodaj ubezpieczenie";
            this.addUbezpButton.UseVisualStyleBackColor = true;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(19, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 71;
            this.labelControl2.Text = "Nazwa:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(19, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(105, 13);
            this.labelControl1.TabIndex = 70;
            this.labelControl1.Text = "Numer ubezpieczenia:";
            // 
            // kodTB
            // 
            this.kodTB.Location = new System.Drawing.Point(130, 39);
            this.kodTB.Name = "kodTB";
            this.kodTB.Size = new System.Drawing.Size(158, 20);
            this.kodTB.TabIndex = 68;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(130, 65);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(158, 20);
            this.textEdit1.TabIndex = 74;
            // 
            // AddUbezp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 134);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.addUbezpButton);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.kodTB);
            this.Name = "AddUbezp";
            this.Text = "AddUbezp";
            ((System.ComponentModel.ISupportInitialize)(this.kodTB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addUbezpButton;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit kodTB;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}