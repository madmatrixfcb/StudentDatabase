using System;
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
            this.AcceptButton = addPatientButton;
        }

        //-----------------------CHECK BOXES----------------------------------/

        private void PeselCB_CheckedChanged(object sender, EventArgs e)
        {
            if (peselCB.Checked == true)
            {
                peselTB.Enabled = true;
            }
            else
            {
                peselTB.Enabled = false;
            }
        }

        private void DowodosobistyCB_CheckedChanged(object sender, EventArgs e)
        {
            if (dowodosobistyCB.Checked == true)
            {
                dowodTB.Enabled = true;
            }
            else
            {
                dowodTB.Enabled = false;
            }
        }

        private void PaszportCB_CheckedChanged(object sender, EventArgs e)
        {
            if (paszportCB.Checked == true)
            {
                paszportTB.Enabled = true;
            }
            else
            {
                paszportTB.Enabled = false;
            }
        }

        private void ubezpieczenieSelect_EditValueChanged(object sender, EventArgs e)
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
                string kp = Convert.ToString(kpSelect.Text);
                string dowod_osobisty = Convert.ToString(dowodTB.Text);
                string nr_paszportu = Convert.ToString(paszportTB.Text);
                string plec = Convert.ToString(plecSelect.EditValue);
                string ubezpieczenie = Convert.ToString(ubezpieczenieSelect.EditValue);
                string nr_ekuz = Convert.ToString(ekuzTB.Text);

                if (nr_pesel == "" || peselCB.Checked == false)
                {
                    nr_pesel = "Brak";
                }

                if (dowod_osobisty == "" || dowodosobistyCB.Checked == false)
                {
                    dowod_osobisty = "Brak";
                }

                if (nr_paszportu == "" || paszportCB.Checked == false)
                {
                    nr_paszportu = "Brak";
                }

                if (nr_ekuz == "" || ekuzTB.Enabled == false)
                {
                    nr_ekuz = "Brak";
                }
                if (nr_ekuz != "Brak" && ekuzTB.Enabled == true || nr_pesel != "Brak" && peselTB.Enabled == true || nr_paszportu != "Brak" && paszportTB.Enabled == true || dowod_osobisty != "Brak" && dowodosobistyCB.Enabled == true)
                {
                    if (FunctionsPatient.CheckBirthDate(data_ur) == true)
                    {
                        int pacjentDuplicateCount = Convert.ToInt16(pACJENTTableAdapter.PatientCount(nr_pesel, dowod_osobisty, nr_paszportu, nr_ekuz));
                        if (pacjentDuplicateCount == 0)
                        {
                            try
                            {
                                pACJENTTableAdapter.InsertQuery(imie, nazwisko, data_ur, kraj, telefon, plec, ulica, nr_budynku, nr_mieszkania, kod_pocztowy, miasto, nr_pesel, kp, dowod_osobisty, nr_paszportu, ubezpieczenie, nr_ekuz);

                                MessageBox.Show("Pacjent " + imie + " " + nazwisko + " został dodany do bazy pacjentów", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("W jednym z pól: PESEL, Dowód osobisty, Paszport lub Numer EKUZ, jest wpisana wartość, która występuje już w bazie pacjentów", "Duplikat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Podana data urodzenia jest błęda", "Zła data urodzenia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Jeżeli zaznaczony jest przycisk PESEL, należy podać numer PESEL" + Environment.NewLine + "Jeżeli zaznaczony jest przycisk Dowód osobisty, należy podać numer dowodu osobistego" + Environment.NewLine + "Jeżeli zaznaczony jest przycisk Paszport, należy podać numer paszportu" + Environment.NewLine + "Jeżeli wybranym ubezpieczeniem jest EKUZ, należy podać numer karty EKUZ", "Błąd wypełniania formularza", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (FunctionsPatient.ValidatePesel(peselTB.Text) == true)
            {
                checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
                dataur.Text = FunctionsPatient.InfoPESEL.szDate;
                plecSelect.EditValue = FunctionsPatient.InfoPESEL.plec;
            }
            else
            {
                checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png");
            }
        }

        private void peselTB_EditValueChanged(object sender, EventArgs e)
        {
            if (FunctionsPatient.ValidatePesel(peselTB.Text) == true)
            {
                checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
                checkPESEL.Text = "Pesel OK";
                dataur.Text = FunctionsPatient.InfoPESEL.szDate;
                plecSelect.EditValue = FunctionsPatient.InfoPESEL.plec;
            }
            else
            {
                checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png");
                checkPESEL.Text = "Pesel ZŁY";
            }
        }

        private void phoneCheckEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (phoneCheckEdit.Checked == false)
            {
                telefonTB.Properties.Mask.EditMask = "(\\+48-)[0-9]{0,3}(-)[0-9]{0,3}(-)[0-9]{0,3}";
                telefonTB.Text = "";
            }

            if (phoneCheckEdit.Checked == true)
            {
                telefonTB.Properties.Mask.EditMask = "[0-9]{0,3}(-)[0-9]{0,3}(-)[0-9]{0,3}(-)[0-9]{0,3}";
                telefonTB.Text = "";
            }
        }

        private void txtMessage_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddPatient2_Click(sender, e);
            }
        }
    }
}