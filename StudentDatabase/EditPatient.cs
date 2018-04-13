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
using DevExpress.XtraGrid;

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
            IDTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "ID_Pacjent");
            imieTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Imie");
            nazwiskoTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Nazwisko");
            dataur.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Data_urodzenia");
            krajSelect.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Kraj");
            telefonTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Telefon");
            ulicaTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Ulica");
            budynekTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Nr_budynku");
            mieszkanieTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Nr_mieszkania");
            kodTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Kod_pocztowy");
            miastoTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Miasto");
            peselTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "PESEL");
            kartapolakaTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Karta_polaka");
            dowodTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Dowod_osobisty");
            paszportTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Paszport");
            ubezpieczenieSelect.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Ubezpieczenie");
            plecSelect.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Plec");
        }

        //-----------------------BUTTONS----------------------------------/

        private void EditPatient2_Click(object sender, EventArgs e)
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
            string nr_kp = Convert.ToString(kartapolakaTB.Text);
            string dowod_osobisty = Convert.ToString(dowodTB.Text);
            string nr_paszportu = Convert.ToString(paszportTB.Text);
            string plec = Convert.ToString(plecSelect.EditValue);
            string ubezpieczenie = Convert.ToString(ubezpieczenieSelect.EditValue);


            bool isValid = dxValidationProvider1.Validate();

            if (isValid == true)
            {
                try
                {
                    pACJENTTableAdapter.UpdateQuery(imie, nazwisko, data_ur, kraj, telefon, plec, ulica, nr_budynku, nr_mieszkania, kod_pocztowy, miasto, nr_pesel, nr_kp, dowod_osobisty, nr_paszportu, ubezpieczenie, Convert.ToInt16(IDTB.EditValue));

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
                MessageBox.Show("Wypełnij wszystkie pola by dodać pacjenta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void kartapolakaTB_EditValueChanged(object sender, EventArgs e)
        {
            if (kartapolakaTB.Text != "")
            {
                kartapolakaTB.Enabled = true;
                kartapolakaCB.Checked = true;
            }
            else
            {
                kartapolakaTB.Enabled = false;
                kartapolakaCB.Checked = false;
            }
        }

        private void peselTB_EditValueChanged(object sender, EventArgs e)
        {
            if (peselTB.Text != "")
            {
                peselTB.Enabled = true;
                peselCB.Checked = true;
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

        private void kartapolakaCB_CheckedChanged(object sender, EventArgs e)
        {
            kartapolakaTB.Enabled = (kartapolakaCB.Checked == true);
        }

        private void dowodosobistyCB_CheckedChanged(object sender, EventArgs e)
        {
            dowodTB.Enabled = (dowodosobistyCB.Checked == true);
        }

        private void paszportCB_CheckedChanged(object sender, EventArgs e)
        {
            paszportTB.Enabled = (paszportCB.Checked == true);
        }
    }
}