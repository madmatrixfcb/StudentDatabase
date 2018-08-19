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
    public partial class AddUbezp : DevExpress.XtraEditors.XtraForm
    {
        public AddUbezp()
        {
            InitializeComponent();
        }

        private void ubezpAdd_button_Click(object sender, EventArgs e)
        {
            string nazwa_ubezpieczenia = Convert.ToString(nameUbezpTB.Text);

            try
            {
                ubezpieczenieTableAdapter.InsertQuery(nazwa_ubezpieczenia);
                MessageBox.Show("Ubezpieczenie dodane", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();

                this.ubezpieczenieTableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}