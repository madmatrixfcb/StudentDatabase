using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class EditVisit : DevExpress.XtraEditors.XtraForm
    {
        public EditVisit()
        {
            InitializeComponent();
        }

        private void EditVisit_Load(object sender, EventArgs e)
        {

            this.wizytaTableAdapter.Fill(this.poradniaDataSet.WIZYTA);
            // TODO: This line of code loads data into the 'poradniaDataSet.PACJENT' table. You can move, or remove it, as needed.
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            // TODO: This line of code loads data into the 'poradniaDataSet.UZYTKOWNIK' table. You can move, or remove it, as needed.
            this.uZYTKOWNIKTableAdapter.Fill(this.poradniaDataSet.UZYTKOWNIK);
            // TODO: This line of code loads data into the 'poradniaDataSet.ICD' table. You can move, or remove it, as needed.
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);

        }

        private void gridView5_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            wizytaTB.EditValue = gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "ID_Wizyta");
            pacjentCB.EditValue = gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "ID_Pacjent");
            pacjentCB.ForceInitialize();
            dateEdit.EditValue = gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "Data");
            timeEdit.EditValue = gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "Godzina");
            objawyTB.Text = Convert.ToString(gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "Objawy"));
            bprzedTB.Text = Convert.ToString(gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "BPrzedmiotowe"));
            bpodTB.Text = Convert.ToString(gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "BPodmiotowe"));
            ICDCB1.EditValue = gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "ID_ICD_1");
            ICDCB1.ForceInitialize();
            ICDCB2.EditValue = gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "ID_ICD_2");
            ICDCB2.ForceInitialize();
            ICDCB3.EditValue = gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "ID_ICD_3");
            ICDCB3.ForceInitialize();
            rozpoznanieTB.Text = Convert.ToString(gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "Rozpoznanie"));
            lekiTB.Text = Convert.ToString(gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "Leki"));
            zaleceniaTB.Text = Convert.ToString(gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "Zalecenia"));
            userCB.EditValue = gridViewEditWizyta.GetRowCellValue(e.FocusedRowHandle, "ID_Lekarz");
            userCB.ForceInitialize();
        }

        private void timeEdit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
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
                //e.DisplayText = Convert.ToString(this.uZYTKOWNIKTableAdapter.SelectUserInfo(Login.LoginInfo.userID));
                e.DisplayText = row["Tytul"].ToString() + " " + row["Imie"].ToString() + " " + row["Nazwisko"].ToString();
            }
        }

        private void editVisitButton_Click(object sender, EventArgs e)
        {
            string patient = Convert.ToString(pacjentCB.EditValue);
            DateTime date = Convert.ToDateTime(dateEdit.Text);
            string time = Convert.ToString(timeEdit.Text);
            string objawy = Convert.ToString(objawyTB.Text);
            string bprzed = Convert.ToString(bprzedTB.Text);
            string bpod = Convert.ToString(bpodTB.Text);
            string icd1 = Convert.ToString(ICDCB1.EditValue);
            string icd2 = Convert.ToString(ICDCB2.EditValue);
            string icd3 = Convert.ToString(ICDCB3.EditValue);
            string rozpoznanie = Convert.ToString(rozpoznanieTB.Text);
            string leki = Convert.ToString(lekiTB.Text);
            string zalecenia = Convert.ToString(zaleceniaTB.Text);
            string user = Convert.ToString(userCB.EditValue);

            bool isValid = dxValidationProvider.Validate();

            if (isValid == true)
            {
                try
                {
                    wizytaTableAdapter.UpdateQuery(patient, date, time, objawy, bprzed, bpod, icd1, icd2, icd3, rozpoznanie, leki, zalecenia, user, Convert.ToInt16(wizytaTB.EditValue));
                    MessageBox.Show("Wizyta zedytowana", "Zedytowano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();
                }
                
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
