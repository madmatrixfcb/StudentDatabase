using DevExpress.XtraEditors;
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
        private string GetSHA1HashData(string data)
        {
            var shaSHA1 = System.Security.Cryptography.SHA1.Create();
            var inputEncodingBytes = Encoding.ASCII.GetBytes(data);
            var hashString = shaSHA1.ComputeHash(inputEncodingBytes);

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
                LoginInfo.pass = GetSHA1HashData(Convert.ToString(passBox.Text));
                LoginInfo.userType = Convert.ToString(uzytkownikTableAdapter.SelectLogin(LoginInfo.login, LoginInfo.pass));
                LoginInfo.userID = Convert.ToSByte(uzytkownikTableAdapter.SelectUserID(LoginInfo.login, LoginInfo.pass));

                if (LoginInfo.userType == "Admin")
                {
                    try
                    {
                        AdminMenu adminMenu = new AdminMenu();
                        this.Hide();
                        adminMenu.ShowDialog();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (LoginInfo.userType == "Lekarz")
                {
                    try
                    {
                        AdminMenu adminMenu = new AdminMenu();
                        this.Hide();
                        adminMenu.ShowDialog();
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
                string newPass = GetSHA1HashData(Convert.ToString(newPassBox.Text));
                LoginInfo.login = Convert.ToString(loginBox.Text);
                LoginInfo.pass = GetSHA1HashData(Convert.ToString(passBox.Text));
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
                currentPassLabel.Text = "Stare hasło:";
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
                currentPassLabel.Text = "Hasło:";
                newPassBox.Visible = false;
                newPassLabel.Visible = false;
                LoginInfo.changePassword = false;
                loginBox.EditValue = "";
                passBox.EditValue = "";
            }
        }
    }
}