﻿using DevExpress.XtraEditors;
using System;
using System.Text;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.AcceptButton = loginButton;
        }

        private void txtMessage_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }

        public static class LoginInfo
        {
            public static string login;
            public static string pass;
            public static string userType;
            public static sbyte userID;
            public static bool changePassword = false;
        }

        //-------------------SHA-----------------------/
        private static string GetSHA256HashData(string data)
        {
            var shaSHA256 = System.Security.Cryptography.SHA256.Create();
            var inputEncodingBytes = Encoding.ASCII.GetBytes(data);
            var hashString = shaSHA256.ComputeHash(inputEncodingBytes);

            var stringBuilder = new StringBuilder();
            for (var x = 0; x < hashString.Length; x++)
            {
                stringBuilder.Append(hashString[x].ToString("X2"));
            }
            return stringBuilder.ToString();
        }

        public void loginButton_Click(object sender, EventArgs e)
        {
            bool isValid = dxValidationProvider.Validate();
            bool changePassValid = dxValidationUpdatePassword.Validate();

            if (isValid == true && LoginInfo.changePassword == false)
            {
                LoginInfo.login = Convert.ToString(loginBox.Text);
                LoginInfo.pass = GetSHA256HashData(Convert.ToString(passBox.Text));
                LoginInfo.userType = Convert.ToString(uzytkownikTableAdapter.SelectLogin(LoginInfo.login, LoginInfo.pass));
                LoginInfo.userID = Convert.ToSByte(uzytkownikTableAdapter.SelectUserID(LoginInfo.login, LoginInfo.pass));

                if (LoginInfo.userType == "Admin" || LoginInfo.userType == "Lekarz")
                {
                    try
                    {
                        Menu menu = new Menu();
                        this.Hide();
                        menu.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Wprowadzono nieprawidłowe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginBox.ResetText();
                    passBox.ResetText();
                }
            }
            else if (changePassValid == true && LoginInfo.changePassword == true)
            {
                string newPass = GetSHA256HashData(Convert.ToString(newPassBox.Text));
                LoginInfo.login = Convert.ToString(loginBox.Text);
                LoginInfo.pass = GetSHA256HashData(Convert.ToString(passBox.Text));
                LoginInfo.userID = Convert.ToSByte(uzytkownikTableAdapter.SelectUserID(LoginInfo.login, LoginInfo.pass));
                if (LoginInfo.userID > 0)
                {
                    try
                    {

                        uzytkownikTableAdapter.UpdatePassword(newPass, LoginInfo.userID);
                        XtraMessageBox.Show("Hasło dla użytkownika " + LoginInfo.login + " zostało zmienione", "Hasło zmienione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        changePasswordControl_Click(sender, e);
                    }
                    catch
                    {
                        XtraMessageBox.Show("Wystąpił błąd podczas zmiany hasła dla użytkownika " + LoginInfo.login, "Hasło nie zostało zmienione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    XtraMessageBox.Show("Użytkownik " + LoginInfo.login + " nie istnieje lub stare hasło jest niepoprawne", "Hasło nie zostało zmienione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                XtraMessageBox.Show("Wprowadzono nieprawidłowe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changePasswordControl_Click(object sender, EventArgs e)
        {
            if (LoginInfo.changePassword == false)
            {
                loginButton.Text = "Zmień hasło";
                changePasswordControl.Text = "Wróć";
                int X1 = 130;
                changePasswordControl.Location.X.Equals(X1);
                currentPassLabel.Text = "Stare hasło:";
                int X2 = 111;
                currentPassLabel.Location.X.Equals(X2);
                newPassBox.Visible = true;
                newPassLabel.Visible = true;
                LoginInfo.changePassword = true;
                loginBox.EditValue = "";
                passBox.EditValue = "";
                newPassBox.EditValue = "";
            }

            else
            {
                loginButton.Text = "Zaloguj się";
                changePasswordControl.Text = "Zmień hasło";
                int X1 = 116;
                changePasswordControl.Location.X.Equals(X1);
                currentPassLabel.Text = "Hasło:";
                int X2 = 125;
                currentPassLabel.Location.X.Equals(X2);
                newPassBox.Visible = false;
                newPassLabel.Visible = false;
                LoginInfo.changePassword = false;
                loginBox.EditValue = "";
                passBox.EditValue = "";
            }
        }
    }
}