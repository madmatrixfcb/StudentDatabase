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
    public partial class AddPatient : DevExpress.XtraEditors.XtraForm
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void peselCB_CheckedChanged(object sender, EventArgs e)
        {
            peselTB.Enabled = (peselCB.CheckState == CheckState.Checked);
        }

        private void kartapolakaCB_CheckedChanged(object sender, EventArgs e)
        {
            kartapolakaTB.Enabled = (kartapolakaCB.CheckState == CheckState.Checked);
        }

        private void dowodosobistyCB_CheckedChanged(object sender, EventArgs e)
        {
            dowodTB.Enabled = (dowodosobistyCB.CheckState == CheckState.Checked);
        }

        private void paszportCB_CheckedChanged(object sender, EventArgs e)
        {
            paszportTB.Enabled = (paszportCB.CheckState == CheckState.Checked);
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            string imie = Convert.ToString(imieTB.Text);
            string nazwisko = Convert.ToString(nazwiskoTB.Text);
            string data_ur = Convert.ToString(dataur.Text);
            string kraj = Convert.ToString(krajTB.Text);
            string telefon = Convert.ToString(telefonTB.Text);
            string ulica = Convert.ToString(ulicaTB.Text);
            string nr_budynku = Convert.ToString(budynekTB.Text);
            string nr_mieszkania = Convert.ToString(mieszkanieTB.Text);
            string kod_pocztowy = Convert.ToString(kodTB.Text);
            string miasto = Convert.ToString(miastoTB.Text);
            string nr_pesel = Convert.ToString(peselTB.Text);
            string nr_kp = Convert.ToString(kartapolakaTB.Text);
            string dowod_osobisty = Convert.ToString(dowodTB.Text);
            string nr_paszportu = Convert.ToString(paszportTB.Text);
            string plec = Convert.ToString(plecSB);
            string ubezpieczenie = Convert.ToString(ubezpieczenieSB);

            string adres = ulica + " " + nr_budynku + " " + nr_mieszkania + " " + kod_pocztowy + " " + miasto;

            if (String.IsNullOrEmpty(imieTB.Text) || String.IsNullOrEmpty(nazwiskoTB.Text) || String.IsNullOrEmpty(dataur.Text) || String.IsNullOrEmpty(krajTB.Text) || String.IsNullOrEmpty(telefonTB.Text) || String.IsNullOrEmpty(adres))
            {
                MessageBox.Show("Wypełnij wszystkie pola by dodać pacjenta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                try
                {
                    pacjentTableAdapter1.InsertQuery(imie, nazwisko, adres, kraj, data_ur, plec, nr_pesel, nr_kp, dowod_osobisty, nr_paszportu, ubezpieczenie, telefon);
                    MessageBox.Show("Pacjent dodany", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   /* imieTB.ResetText();
                    nazwiskoTB.ResetText();
                    dataur.ResetText();
                    krajTB.ResetText();
                    telefonTB.ResetText();
                    ulicaTB.ResetText();
                    budynekTB.ResetText();
                    mieszkanieTB.ResetText();
                    kodTB.ResetText();
                    miastoTB.ResetText();
                    peselCB.ResetText();
                    kartapolakaTB.ResetText();
                    dowodTB.ResetText();
                    paszportTB.ResetText();
                    plecRD.ResetText();
                    ubezpRD.ResetText();*/

                    foreach(Control c in Controls)
                    {
                        if(c is TextBox)
                        {
                            c.ResetText();
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poradniaDataSet.UBEZPIECZENIE' table. You can move, or remove it, as needed.
            this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
            // TODO: This line of code loads data into the 'poradniaDataSet.PLEC' table. You can move, or remove it, as needed.
            this.pLECTableAdapter.Fill(this.poradniaDataSet.PLEC);

        }
    }
}