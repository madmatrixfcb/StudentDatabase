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
    public partial class ArrangeVisit : DevExpress.XtraEditors.XtraForm
    {
        public ArrangeVisit()
        {
            InitializeComponent();
        }

        private void ArrangeVisit_Load(object sender, EventArgs e)
        {
            this.pacjentTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            timeEdit.EditValue = DateTime.Now;
            dateEdit.EditValue = DateTime.Now;
        }

        //-----------------------BUTTONS----------------------------------/
        private void arrangeVisitButton_Click(object sender, EventArgs e)
        {
            string patient = Convert.ToString(pacjentCB.EditValue);
            DateTime date = Convert.ToDateTime(dateEdit.Text);
            string time = Convert.ToString(timeEdit.Text);

            bool isValid = dxValidationProvider.Validate();

            if (isValid == true)
            {
                MessageBox.Show("Wypełnij wszystkie pola by dodać wizytę", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (date < DateTime.Now)
                {
                    MessageBox.Show("Data jest zła." + Environment.NewLine + "Wybierz dzisiejszą datę lub przyszłą. Nie możesz umówić wizyty wstecz.", "Błąd daty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                else
                {
                    if (Convert.ToInt16(umoW_WIZTETableAdapter.UmowDataCount(date, time)) >= 1 && Convert.ToInt16(wizytaTableAdapter.WizytaDataCount(date, time)) >= 1)
                    {
                        MessageBox.Show("Na wybraną datę i godzinę jest już umówiona wizyta." + Environment.NewLine + "Wybierz inną datę lub godzinę.", "Data zajęta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        try
                        {
                            umoW_WIZTETableAdapter.InsertQuery(patient, date, time);
                            MessageBox.Show("Wizyta dla " + patient + " została umówiona", "Umówiono", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            this.Close();
        }

        //-----------------------CONTROLS----------------------------------/

        private void timeEdit_Spin(object sender, DevExpress.XtraEditors.Controls.SpinEventArgs e)
        {
            // var timeEdit = sender as TimeEdit;
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

      
    }
}
