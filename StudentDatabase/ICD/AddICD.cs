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
    public partial class AddICD : DevExpress.XtraEditors.XtraForm
    {
        public AddICD()
        {
            InitializeComponent();
        }

        private void addICD_button_Click(object sender, EventArgs e)
        {
            string kodICD = Convert.ToString(kodTB.Text);
            string rozpoznanie = Convert.ToString(rozpoznanieTB.Text);

            try
            {
                iCDTableAdapter.InsertQuery(kodICD, rozpoznanie);
                MessageBox.Show("Kod ICD dodany", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
                this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}