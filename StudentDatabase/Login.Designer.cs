namespace StudentDatabase
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule3 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule4 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule5 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.newPassLabel = new DevExpress.XtraEditors.LabelControl();
            this.currentPassLabel = new DevExpress.XtraEditors.LabelControl();
            this.loginLabel = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.newPassBox = new DevExpress.XtraEditors.TextEdit();
            this.passBox = new DevExpress.XtraEditors.TextEdit();
            this.loginBox = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.loginButton = new DevExpress.XtraEditors.SimpleButton();
            this.changePasswordControl = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.dxValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxValidationUpdatePassword = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.poradniaDataSet = new StudentDatabase.PoradniaDataSet();
            this.uzytkownikTableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.UZYTKOWNIKTableAdapter();
            this.tyP_KONTATableAdapter = new StudentDatabase.PoradniaDataSetTableAdapters.TYP_KONTATableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBox.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationUpdatePassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.newPassLabel);
            this.panel2.Controls.Add(this.currentPassLabel);
            this.panel2.Controls.Add(this.loginLabel);
            this.panel2.Controls.Add(this.pictureEdit1);
            this.panel2.Controls.Add(this.newPassBox);
            this.panel2.Controls.Add(this.passBox);
            this.panel2.Controls.Add(this.loginBox);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 298);
            this.panel2.TabIndex = 1;
            // 
            // newPassLabel
            // 
            this.newPassLabel.Location = new System.Drawing.Point(116, 252);
            this.newPassLabel.Name = "newPassLabel";
            this.newPassLabel.Size = new System.Drawing.Size(60, 13);
            this.newPassLabel.TabIndex = 12;
            this.newPassLabel.Text = "Nowe hasło:";
            this.newPassLabel.Visible = false;
            // 
            // currentPassLabel
            // 
            this.currentPassLabel.Location = new System.Drawing.Point(128, 213);
            this.currentPassLabel.Name = "currentPassLabel";
            this.currentPassLabel.Size = new System.Drawing.Size(31, 13);
            this.currentPassLabel.TabIndex = 11;
            this.currentPassLabel.Text = "Hasło:";
            // 
            // loginLabel
            // 
            this.loginLabel.Location = new System.Drawing.Point(128, 168);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(29, 13);
            this.loginLabel.TabIndex = 10;
            this.loginLabel.Text = "Login:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(97, 12);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Properties.ZoomAccelerationFactor = 1D;
            this.pictureEdit1.Size = new System.Drawing.Size(92, 150);
            this.pictureEdit1.TabIndex = 9;
            // 
            // newPassBox
            // 
            this.newPassBox.Location = new System.Drawing.Point(42, 265);
            this.newPassBox.Name = "newPassBox";
            this.newPassBox.Properties.PasswordChar = '*';
            this.newPassBox.Properties.UseSystemPasswordChar = true;
            this.newPassBox.Size = new System.Drawing.Size(200, 20);
            this.newPassBox.TabIndex = 6;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Pole nowe hasło nie może być puste";
            this.dxValidationUpdatePassword.SetValidationRule(this.newPassBox, conditionValidationRule1);
            this.newPassBox.Visible = false;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(42, 226);
            this.passBox.Name = "passBox";
            this.passBox.Properties.PasswordChar = '*';
            this.passBox.Properties.UseSystemPasswordChar = true;
            this.passBox.Size = new System.Drawing.Size(200, 20);
            this.passBox.TabIndex = 2;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule2.ErrorText = "Pole hasło nie może być puste";
            this.dxValidationProvider.SetValidationRule(this.passBox, conditionValidationRule2);
            conditionValidationRule3.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule3.ErrorText = "Pole stare hasło nie może być puste";
            this.dxValidationUpdatePassword.SetValidationRule(this.passBox, conditionValidationRule3);
            // 
            // loginBox
            // 
            this.loginBox.Location = new System.Drawing.Point(42, 187);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(200, 20);
            this.loginBox.TabIndex = 1;
            conditionValidationRule4.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule4.ErrorText = "Pole login nie może być puste!";
            this.dxValidationProvider.SetValidationRule(this.loginBox, conditionValidationRule4);
            conditionValidationRule5.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule5.ErrorText = "Pole login nie może być puste";
            this.dxValidationUpdatePassword.SetValidationRule(this.loginBox, conditionValidationRule5);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.changePasswordControl);
            this.panel1.Location = new System.Drawing.Point(0, 304);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 55);
            this.panel1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(42, 5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 23);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Zaloguj się";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // changePasswordControl
            // 
            this.changePasswordControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changePasswordControl.Location = new System.Drawing.Point(116, 34);
            this.changePasswordControl.Name = "changePasswordControl";
            this.changePasswordControl.Size = new System.Drawing.Size(57, 13);
            this.changePasswordControl.TabIndex = 4;
            this.changePasswordControl.Text = "Zmień hasło";
            this.changePasswordControl.Click += new System.EventHandler(this.changePasswordControl_Click);
            // 
            // poradniaDataSet
            // 
            this.poradniaDataSet.DataSetName = "PoradniaDataSet";
            this.poradniaDataSet.Locale = new System.Globalization.CultureInfo("pl");
            this.poradniaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uzytkownikTableAdapter
            // 
            this.uzytkownikTableAdapter.ClearBeforeFill = true;
            // 
            // tyP_KONTATableAdapter
            // 
            this.tyP_KONTATableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 358);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newPassBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginBox.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxValidationUpdatePassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.poradniaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PoradniaDataSet poradniaDataSet;
        private PoradniaDataSetTableAdapters.UZYTKOWNIKTableAdapter uzytkownikTableAdapter;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private PoradniaDataSetTableAdapters.TYP_KONTATableAdapter tyP_KONTATableAdapter;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationProvider;
        private DevExpress.XtraEditors.TextEdit passBox;
        private DevExpress.XtraEditors.TextEdit loginBox;
        private DevExpress.XtraEditors.TextEdit newPassBox;
        private DevExpress.XtraEditors.HyperlinkLabelControl changePasswordControl;
        private DevExpress.XtraEditors.SimpleButton loginButton;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxValidationUpdatePassword;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl newPassLabel;
        private DevExpress.XtraEditors.LabelControl currentPassLabel;
        private DevExpress.XtraEditors.LabelControl loginLabel;
    }
}