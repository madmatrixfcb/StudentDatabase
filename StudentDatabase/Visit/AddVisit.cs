﻿using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class AddVisit : DevExpress.XtraEditors.XtraForm
    {
        public AddVisit()
        {
            InitializeComponent();
            iCDTableAdapter.Fill(poradniaDataSet.ICD);
            wizytaTableAdapter.Fill(poradniaDataSet.WIZYTA);
        }

        private void AddVisit_Load(object sender, EventArgs e)
        {
            this.uzytkownikTableAdapter.Fill(this.poradniaDataSet.UZYTKOWNIK);
            this.pacjentTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);
            this.AcceptButton = addVisitButton;


            userCB.EditValue = Convert.ToInt16(uzytkownikTableAdapter.SelectUserID(Login.LoginInfo.login, Login.LoginInfo.pass));
            LoadArrangedVisitInfo();
        }

        private void LoadArrangedVisitInfo()
        {
            if (StudentDatabase.Menu.ArrangedVisitParams.arrangedVisit == true)
            {
                DataRow ArrangeRow = StudentDatabase.Menu.ArrangedVisitParams.arrangeVisitRow;
                pacjentCB.Text = ArrangeRow["ID_Pacjent"].ToString();
                pacjentCB.Refresh();
                string arrangeData = ArrangeRow["Data"].ToString();
                dateEdit.Text = arrangeData.Substring(0, 10);
                timeEdit.EditValue = ArrangeRow["Godzina"].ToString();
                MessageBox.Show("Godzina: " + ArrangeRow["Godzina"].ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                TimeLoad();
                dateEdit.EditValue = DateTime.Now;
            }
        }

        //-----------------------BUTTONS----------------------------------/
        private void addVisitButton_Click(object sender, EventArgs e)
        {
            string patient = Convert.ToString(pacjentCB.EditValue);
            DateTime date = Convert.ToDateTime(dateEdit.Text);
            string time = Convert.ToString(timeEdit.Text);
            string objawy = Convert.ToString(objawyTB.Text);
            string bpod = Convert.ToString(bprzedTB.Text);
            string bprzed = Convert.ToString(bpodTB.Text);
            string icd1 = Convert.ToString(ICDCB1.EditValue);
            string icd2 = Convert.ToString(ICDCB2.EditValue);
            string icd3 = Convert.ToString(ICDCB3.EditValue);
            string rozpoznanie = Convert.ToString(rozpoznanieTB.Text);
            string leki = Convert.ToString(lekiTB.Text);
            string zalecenia = Convert.ToString(zaleceniaTB.Text);
            string user = Convert.ToString(userCB.EditValue);

            bool isValid = dxValidationProvider.Validate();

            if (isValid == false)
            {
                MessageBox.Show("Wypełnij wszystkie pola by dodać wizytę", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Convert.ToInt16(wizytaTableAdapter.WizytaDataCount(date, time)) >= 1)
                {
                    MessageBox.Show("Na wybraną datę i godzinę jest już odnotowana wizyta." + Environment.NewLine + "Wybierz inną datę lub godzinę.", "Data zajęta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToInt16(umoW_WIZTETableAdapter.UmowDataCount(date, time)) >= 1 && StudentDatabase.Menu.ArrangedVisitParams.arrangedVisit == false)
                    {
                        DialogResult overwriteVisit = MessageBox.Show("Na wybraną datę i godzinę jest już umówiona wizyta." + Environment.NewLine + "Wybierz TAK jeśli chcesz zapisać tę wizytę mimo to i usunąć umówiąną wizytę na tę godznę" + Environment.NewLine + "Wybierz NIE jeśli chcesz wybrać inną datę lub godzinę.", "Data zajęta", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (overwriteVisit == DialogResult.Yes)
                        {
                            try
                            {
                                wizytaTableAdapter.InsertQuery(patient, date, time, objawy, bprzed, bpod, icd1, icd2, icd3, rozpoznanie, leki, zalecenia, user);
                                umoW_WIZTETableAdapter.DeleteArrangedbyDate(date, time);
                                MessageBox.Show("Wizyta dodana", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                StudentDatabase.Menu.ArrangedVisitParams.arrangeStatus = true;
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        try
                        {
                            wizytaTableAdapter.InsertQuery(patient, date, time, objawy, bprzed, bpod, icd1, icd2, icd3, rozpoznanie, leki, zalecenia, user);
                            MessageBox.Show("Wizyta " + pacjentCB.Text + " dodana", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz wyjść bez dodawania wizyty", "Potwierdzenie wyjścia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.No)
            {
                return;
            }
            else
            {
                this.Close();
            }
        }

        //-----------------------CONTROLS----------------------------------/

        private void timeEdit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            var timeEdit = sender as TimeEdit;
            var minuteStart = timeEdit.Text.IndexOf(":") + 1;
            if (timeEdit.SelectionStart == minuteStart)
            {
                e.Handled = true;
                var time = timeEdit.Time;
                var minuteIncrement = 15;
                int minute = time.AddMinutes((e.IsSpinUp ? 1 : -1) * minuteIncrement).Minute;
                if (minute >= 45)
                {
                    minute = 45;
                }
                else if (minute >= 30)
                {
                    minute = 30;
                }
                else if (minute >= 15)
                {
                    minute = 15;
                }
                else
                {
                    minute = 0;
                }
                var selectionStart = timeEdit.SelectionStart;
                var selectionLength = timeEdit.SelectionLength;
                timeEdit.Time = new DateTime(time.Year, time.Month, time.Day, time.Hour, minute, time.Second);
                timeEdit.SelectionStart = selectionStart;
                timeEdit.SelectionLength = selectionLength;
            }
        }

        private void TimeLoad()
        {
            timeEdit.Time = DateTime.Now;
            var time = timeEdit.Time;
            
            //timeEdit.Time = new DateTime(time.Year, time.Month, time.Day, time.Hour, time.Minute, time.Second);
            int minute = time.Minute;
            if (minute >= 45)
            {
                minute = 45;
            }
            else if (minute >= 30)
            {
                minute = 30;
            }
            else if (minute >= 15)
            {
                minute = 15;
            }
            else
            {
                minute = 0;
            }
            timeEdit.EditValue = new DateTime(time.Year, time.Month, time.Day, time.Hour, minute, time.Second);
        }

        //-----------------------CUSTOM DISPLAY----------------------------------/

        private void pacjentCB_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            int theIndex = pacjentCB.Properties.GetIndexByKeyValue(pacjentCB.EditValue);
            if (pacjentCB.Properties.View.IsDataRow(theIndex))
            {
                DataRow row = pacjentCB.Properties.View.GetDataRow(theIndex);
                e.DisplayText = row["Imie"].ToString() + " " + row["Nazwisko"].ToString();
            }
        }

        private void ICDCB1_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            int theIndex = ICDCB1.Properties.GetIndexByKeyValue(ICDCB1.EditValue);
            if (ICDCB1.Properties.View.IsDataRow(theIndex))
            {
                DataRow row = ICDCB1.Properties.View.GetDataRow(theIndex);
                e.DisplayText = row["Kod_ICD"].ToString() + " - " + row["Rozpoznanie"].ToString();
            }
        }

        private void ICDCB2_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            int theIndex = ICDCB2.Properties.GetIndexByKeyValue(ICDCB2.EditValue);
            if (ICDCB2.Properties.View.IsDataRow(theIndex))
            {
                DataRow row = ICDCB2.Properties.View.GetDataRow(theIndex);
                e.DisplayText = row["Kod_ICD"].ToString() + " - " + row["Rozpoznanie"].ToString();
            }
        }

        private void ICDCB3_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            int theIndex = ICDCB3.Properties.GetIndexByKeyValue(ICDCB3.EditValue);
            if (ICDCB3.Properties.View.IsDataRow(theIndex))
            {
                DataRow row = ICDCB3.Properties.View.GetDataRow(theIndex);
                e.DisplayText = row["Kod_ICD"].ToString() + " - " + row["Rozpoznanie"].ToString();
            }
        }

        private void userCB_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            int theIndex = userCB.Properties.GetIndexByKeyValue(userCB.EditValue);
            if (userCB.Properties.View.IsDataRow(theIndex))
            {
                DataRow row = userCB.Properties.View.GetDataRow(theIndex);
                e.DisplayText = row["Tytul"].ToString() + " " + row["Imie"].ToString() + " " + row["Nazwisko"].ToString();
            }
        }

        private void addPatientButton_Click(object sender, EventArgs e)
        {
            {
                AddPatient addPat = new AddPatient();
                addPat.Show();
                addPat.FormClosed += AddPat_FormClosed;
            }
        }

        private void AddPat_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.pacjentTableAdapter.Fill(this.poradniaDataSet.PACJENT);
        }

        private void txtMessage_KeyPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addVisitButton_Click(sender, e);
            }
        }
    }
}