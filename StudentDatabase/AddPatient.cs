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
            this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
            this.pLECTableAdapter.Fill(this.poradniaDataSet.PLEC);
            this.krajTableAdapter.Fill(this.poradniaDataSet.KRAJ);
        }

        //-----------------------CHECK BOXES----------------------------------/

        private void PeselCB_CheckedChanged(object sender, EventArgs e)
        {
            peselTB.Enabled = (peselCB.Checked == true);
        }

        private void DowodosobistyCB_CheckedChanged(object sender, EventArgs e)
        {
            dowodTB.Enabled = (dowodosobistyCB.Checked == true);
        }

        private void PaszportCB_CheckedChanged(object sender, EventArgs e)
        {
            paszportTB.Enabled = (paszportCB.Checked == true);
        }

        private void ubezpieczenieSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ubezpieczenieSelect.Text == "EKUZ")
            {
                ekuzTB.Enabled = true;
            }
            else
            {
                ekuzTB.Enabled = false;
            }
        }
        //-----------------------BUTTONS----------------------------------/
        private void AddPatient2_Click(object sender, EventArgs e)
        {
            bool isValid = dxValidationProvider.Validate();

            if (isValid == true)
            {
                string imie = Convert.ToString(imieTB.Text);
                string nazwisko = Convert.ToString(nazwiskoTB.Text);
                DateTime data_ur = Convert.ToDateTime(dataur.Text);
                string kraj = Convert.ToString(krajSelect.EditValue);
                string telefon = Convert.ToString(telefonTB.Text);
                string ulica = Convert.ToString(ulicaTB.Text);
                string nr_budynku = Convert.ToString(budynekTB.Text);
                string nr_mieszkania = Convert.ToString(mieszkanieTB.Text);
                string kod_pocztowy = Convert.ToString(kodTB.Text);
                string miasto = Convert.ToString(miastoTB.Text);
                string nr_pesel = Convert.ToString(peselTB.Text);
                string nr_ekuz = Convert.ToString(ekuzTB.Text);
                string dowod_osobisty = Convert.ToString(dowodTB.Text);
                string nr_paszportu = Convert.ToString(paszportTB.Text);
                string plec = Convert.ToString(plecSelect.SelectedValue);
                string ubezpieczenie = Convert.ToString(ubezpieczenieSelect.SelectedValue);

                if (Functions.CheckBirthDate(data_ur) == true)
                {
                    try
                    {
                        pACJENTTableAdapter.InsertQuery(imie, nazwisko, data_ur, kraj, telefon, plec, ulica, nr_budynku, nr_mieszkania, kod_pocztowy, miasto, nr_pesel, nr_ekuz, dowod_osobisty, nr_paszportu, ubezpieczenie);

                        MessageBox.Show("Pacjent " + imieTB.Text + " " + nazwiskoTB.Text + " został dodany do bazy pacjentów", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Podana data urodzenia jest błęda", "Zła data urodzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Wypełnij wszystkie pola by dodać pacjenta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz wyjść bez dodawania pacjenta", "Potwierdzenie wyjścia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        private void checkPESEL_Click(object sender, EventArgs e)
        {
            if (Functions.ValidatePesel(peselTB.Text) == true)
            {
                checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
                //MessageBox.Show("OK", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataur.Text = Functions.InfoPESEL.szDate;
                plecSelect.SelectedIndex = Functions.InfoPESEL.plec;
            }
            else
            {
                //MessageBox.Show("Źle", "Źle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png");
            }
            
        }
    }
}