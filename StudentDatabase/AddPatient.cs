﻿using System;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class AddPatient : DevExpress.XtraEditors.XtraForm
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poradniaDataSet.UBEZPIECZENIE' table. You can move, or remove it, as needed.
            this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
            // TODO: This line of code loads data into the 'poradniaDataSet.PLEC' table. You can move, or remove it, as needed.
            this.pLECTableAdapter.Fill(this.poradniaDataSet.PLEC);
        }

        //-----------------------FUNCTIONS----------------------------------/

        void ClearAllControls(Control container)
        {
            foreach (var control in container.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = string.Empty;
                }
                if (control is Label)
                {
                    ((Label)control).Text = string.Empty;
                }
            }
        }

        //-----------------------CHECK BOXES----------------------------------/

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

        //-----------------------BUTTONS----------------------------------/
        private void checkButton_Click(object sender, EventArgs e)
        {
            string imie = Convert.ToString(imieTB.Text);
            string nazwisko = Convert.ToString(nazwiskoTB.Text);
            string data_ur = Convert.ToString(dataur.Text);
            string kraj = Convert.ToString(krajSelect.Text);
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
            string plec = Convert.ToString(plecSelect.Text);
            string ubezpieczenie = Convert.ToString(ubezpieczenieSelect.Text);

            bool isValid = dxValidationProvider1.Validate();

            if (isValid == true)
            {
                addPatient2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola by dodać pacjenta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addPatient2_Click(object sender, EventArgs e)
        {
            string imie = Convert.ToString(imieTB.Text);
            string nazwisko = Convert.ToString(nazwiskoTB.Text);
            string data_ur = Convert.ToString(dataur.Text);
            string kraj = Convert.ToString(krajSelect.Text);
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
            string plec = Convert.ToString(plecSelect.Text);
            string ubezpieczenie = Convert.ToString(ubezpieczenieSelect.Text);

            /*  if (String.IsNullOrEmpty(imieTB.Text) || String.IsNullOrEmpty(nazwiskoTB.Text) || String.IsNullOrEmpty(dataur.Text) || String.IsNullOrEmpty(krajTB.Text) || String.IsNullOrEmpty(telefonTB.Text) || String.Equals(telefonTB.Text,wrong_phone)  ||  String.IsNullOrEmpty(adres))
              else
              {*/
            try
                {
                    pACJENTTableAdapter.InsertQuery(imie, nazwisko, data_ur, kraj, plec, ulica, nr_budynku, nr_mieszkania, kod_pocztowy, miasto, nr_pesel, nr_kp, dowod_osobisty, nr_paszportu, ubezpieczenie, telefon);

                    MessageBox.Show("Pacjent dodany", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

  
    }