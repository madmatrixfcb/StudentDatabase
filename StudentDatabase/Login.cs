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

namespace StudentDatabase
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public bool isAdmin { get; private set; }

        public Login()
        {
            InitializeComponent();

        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poradniaDataSet.UZYTKOWNIK' table. You can move, or remove it, as needed.
            this.uzytkownikTableAdapter.Fill(this.poradniaDataSet.UZYTKOWNIK);
            this.AcceptButton = loginButton;

        }

        private void txtMessage_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton_Click(sender, e);
            }
        }



        public void loginButton_Click(object sender, EventArgs e)
        {
            String login = Convert.ToString(loginBox.Text);
            String pass = Convert.ToString(passBox.Text);
            String userType = Convert.ToString(uzytkownikTableAdapter.SelectLogin(login, pass));

            if (userType == "Admin")
            {
                AdminMenu adminMenu = new AdminMenu();
                this.Hide();
                adminMenu.ShowDialog();
                this.Close();
            }

            else if (userType == "Lekarz")
            {
                AdminMenu adminMenu = new AdminMenu();
                this.Hide();
                adminMenu.ShowDialog();
                this.Close();
            }

            else
            {
                MessageBox.Show("Wprowadzono nieprawidłowe dane", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void passBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}