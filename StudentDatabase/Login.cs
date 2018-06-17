using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Security.Cryptography;

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
            // TODO: This line of code loads data into the 'poradniaDataSet.UZYTKOWNIK' table. You can move, or remove it, as needed.
            //this.uzytkownikTableAdapter.Fill(this.poradniaDataSet.UZYTKOWNIK);
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


            bool isValid = dxValidationProvider1.Validate();

            if (isValid == true)
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
                        MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                else
                {
                    MessageBox.Show("Wprowadzono nieprawidłowe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginBox.ResetText();
                    passBox.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Wprowadzono nieprawidłowe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}