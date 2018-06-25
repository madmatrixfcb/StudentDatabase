using System;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class EditPatient : DevExpress.XtraEditors.XtraForm
    {
        public EditPatient()
        {
            InitializeComponent();
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poradniaDataSet.PACJENT' table. You can move, or remove it, as needed.
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            // TODO: This line of code loads data into the 'poradniaDataSet.PACJENT' table. You can move, or remove it, as needed.
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            // TODO: This line of code loads data into the 'poradniaDataSet.KRAJ' table. You can move, or remove it, as needed.
            this.kRAJTableAdapter.Fill(this.poradniaDataSet.KRAJ);
            // TODO: This line of code loads data into the 'poradniaDataSet.PACJENT' table. You can move, or remove it, as needed.
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            // TODO: This line of code loads data into the 'poradniaDataSet.UBEZPIECZENIE' table. You can move, or remove it, as needed.
            this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
            // TODO: This line of code loads data into the 'poradniaDataSet.PLEC' table. You can move, or remove it, as needed.
            this.pLECTableAdapter.Fill(this.poradniaDataSet.PLEC);
        }

        //-----------------------OTHER----------------------------------/

        public void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            IDTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "ID_Pacjent");
            imieTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Imie");
            nazwiskoTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Nazwisko");
            dataur.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Data_urodzenia");
            krajSelect.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Kraj");
            telefonTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Telefon");
            ulicaTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Ulica");
            budynekTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Nr_budynku");
            mieszkanieTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Nr_mieszkania");
            kodTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Kod_pocztowy");
            miastoTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Miasto");
            peselTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "PESEL");
            kpSelect.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Karta_polaka");
            dowodTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Dowod_osobisty");
            paszportTB.EditValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Paszport");
            ubezpieczenieSelect.SelectedValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Ubezpieczenie");
            plecSelect.SelectedValue = gridViewEditPacjent.GetRowCellValue(e.FocusedRowHandle, "Plec");
        }

        //-----------------------BUTTONS----------------------------------/

        private void EditPatient2_Click(object sender, EventArgs e)
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
                string kp = Convert.ToString(kpSelect.SelectedText);
                string dowod_osobisty = Convert.ToString(dowodTB.Text);
                string nr_paszportu = Convert.ToString(paszportTB.Text);
                string plec = Convert.ToString(plecSelect.SelectedValue);
                string ubezpieczenie = Convert.ToString(ubezpieczenieSelect.SelectedValue);
                string nr_ekuz = Convert.ToString(ekuzTB.Text);

                if (nr_pesel == "")
                {
                    nr_pesel = "Brak";
                }

                if (dowod_osobisty == "")
                {
                    dowod_osobisty = "Brak";
                }

                if (nr_paszportu == "")
                {
                    nr_paszportu = "Brak";
                }

                if (nr_ekuz == "")
                {
                    nr_ekuz = "Brak";
                }

                if (FunctionsPatient.CheckBirthDate(data_ur) == true)
                {
                    int pacjentDuplicateCount = Convert.ToInt16(pACJENTTableAdapter.PatientCount(nr_pesel, dowod_osobisty, nr_paszportu, nr_ekuz));
                    if (pacjentDuplicateCount == 0)
                    {
                        try
                        {
                            pACJENTTableAdapter.UpdateQuery(imie, nazwisko, data_ur, kraj, telefon, plec, ulica, nr_budynku, nr_mieszkania, kod_pocztowy, miasto, nr_pesel, kp, dowod_osobisty, nr_paszportu, ubezpieczenie, nr_ekuz, Convert.ToInt16(IDTB.EditValue));

                            MessageBox.Show("Pacjent zaktualizowany", "Zaktualizowano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
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
                MessageBox.Show("Wypełnij wszystkie pola by dodać pacjenta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkPESEL_Click(object sender, EventArgs e)
        {
            if (FunctionsPatient.ValidatePesel(peselTB.Text) == true)
            {
                checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
                checkPESEL.Text = "Pesel OK";
                dataur.Text = FunctionsPatient.InfoPESEL.szDate;
                plecSelect.SelectedIndex = FunctionsPatient.InfoPESEL.plec;
            }
            else
            {
                checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png");
                checkPESEL.Text = "Pesel ZŁY";
            }
        }

        //-----------------------TEXT BOXES----------------------------------/

        private void paszportTB_EditValueChanged(object sender, EventArgs e)
        {
            if (paszportTB.Text != "")
            {
                paszportTB.Enabled = true;
                paszportCB.Checked = true;
            }
            else
            {
                paszportTB.Enabled = false;
                paszportCB.Checked = false;
            }
        }

        private void dowodTB_EditValueChanged(object sender, EventArgs e)
        {
            if (dowodTB.Text != "")
            {
                dowodTB.Enabled = true;
                dowodosobistyCB.Checked = true;
            }
            else
            {
                dowodTB.Enabled = false;
                dowodosobistyCB.Checked = false;
            }
        }

        private void peselTB_EditValueChanged(object sender, EventArgs e)
        {
            if (peselTB.Text != "")
            {
                peselTB.Enabled = true;
                peselCB.Checked = true;

                if (FunctionsPatient.ValidatePesel(peselTB.Text) == true)
                {
                    checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/apply_32x32.png");
                    checkPESEL.Text = "Pesel OK";
                    dataur.Text = FunctionsPatient.InfoPESEL.szDate;
                    plecSelect.SelectedIndex = FunctionsPatient.InfoPESEL.plec;
                }
                else
                {
                    checkPESEL.ImageOptions.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png");
                    checkPESEL.Text = "Pesel ZŁY";
                }
            }
            else
            {
                peselTB.Enabled = false;
                peselCB.Checked = false;
            }
        }

        //-----------------------CHECK BOXES----------------------------------/

        private void peselCB_CheckedChanged(object sender, EventArgs e)
        {
            peselTB.Enabled = (peselCB.Checked == true);
        }

        private void dowodosobistyCB_CheckedChanged(object sender, EventArgs e)
        {
            dowodTB.Enabled = (dowodosobistyCB.Checked == true);
        }

        private void paszportCB_CheckedChanged(object sender, EventArgs e)
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

        //-----------------------OTHER----------------------------------/

        private void searchButton_Click(object sender, EventArgs e)
        {
            gridViewEditPacjent.Focus();
            SendKeys.Send("^(F)");
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
    }
}