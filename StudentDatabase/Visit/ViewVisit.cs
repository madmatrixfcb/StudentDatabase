using DevExpress.XtraGrid.Views.Base;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class ViewVisit : DevExpress.XtraEditors.XtraForm
    {
        public ViewVisit()
        {
            InitializeComponent();
        }

        private void VisitView_Load(object sender, EventArgs e)
        {
            this.patient_viewTableAdapter.Fill(this.poradniaDataSet.patient_view);
            LoadVisitInfo();
            int userID = Convert.ToInt16(AdminMenu.VisitPreview.patientID);
            gridView1.ActiveFilterString = "[ID_Pacjent] LIKE " + userID;
        }

        public static class PatientData
        {
            public static DataRow pacjentRow = AdminMenu.VisitPreview.patientRow;
        }

        private void LoadPatientInfo()
        {
            patientIDLabelTB.Text = PatientData.pacjentRow["ID_Pacjent"].ToString();
            nameLabelTB.Text = PatientData.pacjentRow["Imie"].ToString();
            surnameLabelTB.Text = PatientData.pacjentRow["Nazwisko"].ToString();
            string data_ur = PatientData.pacjentRow["Data_urodzenia"].ToString();
            birthLabelTB.Text = data_ur.Substring(0, 10);
            countryLabelTB.Text = PatientData.pacjentRow["Kraj"].ToString();
            sexLabelTB.Text = PatientData.pacjentRow["Plec"].ToString();
            addressLabelTB.Text = PatientData.pacjentRow["Ulica"].ToString() + " " + PatientData.pacjentRow["Nr_budynku"].ToString() + "/" + PatientData.pacjentRow["Nr_mieszkania"].ToString() + " " + PatientData.pacjentRow["Kod_pocztowy"].ToString() + " " + PatientData.pacjentRow["Miasto"].ToString();
            phoneLabelTB.Text = PatientData.pacjentRow["Telefon"].ToString();
            peselLabelTB.Text = PatientData.pacjentRow["PESEL"].ToString();
            poleCardLabelTB.Text = PatientData.pacjentRow["Karta_polaka"].ToString();
            dowodLabelTB.Text = PatientData.pacjentRow["Dowod_osobisty"].ToString();
            passportLabelTB.Text = PatientData.pacjentRow["Paszport"].ToString();
            insuranceLabelTB.Text = PatientData.pacjentRow["Ubezpieczenie"].ToString();
            ekuzNumberTB.Text = PatientData.pacjentRow["Numer_EKUZ"].ToString();
            gridControl1.Visible = false;
        }

        public static class DataGet
        {
            public static string data;
        }

        public void LoadVisitInfo()
        {
            DataRow visit = AdminMenu.VisitPreview.visitRow;
            visitIDLabelTB.Text = visit["ID_Wizyta"].ToString();
            DataGet.data = visit["Data"].ToString();
            dateLabelTB.Text = DataGet.data.Substring(0, 10) + " " + visit["Godzina"].ToString();
            objawyLabelTB.Text = visit["Objawy"].ToString();
            bprzedmiotoweLabelTB.Text = visit["BPrzedmiotowe"].ToString();
            bpodmiotoweLabelTB.Text = visit["Bpodmiotowe"].ToString();
            ICD1LabelTB.Text = visit["ID_ICD_1"].ToString();
            ICD2LabelTB.Text = visit["ID_ICD_2"].ToString();
            ICD3LabelTB.Text = visit["ID_ICD_3"].ToString();
            rozpoznanieLabelTB.Text = visit["Rozpoznanie"].ToString();
            lekiLabelTB.Text = visit["Leki"].ToString();
            zaleceniaLabelTB.Text = visit["Zalecenia"].ToString();
            przyrjmujacyLabelTB.Text = visit["ID_Lekarz"].ToString();
        }

        private void gridView1_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (gridView1.DataRowCount > 0)
            {
                PatientData.pacjentRow = gridView1.GetFocusedDataRow();
                LoadPatientInfo();
            }
            else
            {
                MessageBox.Show("Wystąpił błąd, spróbuj jeszcze raz", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportToPDFButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "PDF (*.pdf)|*.pdf|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Zapisz jako dokument PDF";
            string filename = saveFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    splashScreenManager.ShowWaitForm();
                    filename = saveFileDialog.FileName;
                    layoutControl1.ExportToPdf(filename);
                    splashScreenManager.CloseWaitForm();
                }
                catch
                {
                    MessageBox.Show("Wystąpił błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            filename = "";
        }

        private void printPreviewButton_Click(object sender, EventArgs e)
        {
            try
            {
                layoutControl1.ShowPrintPreview();
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            try
            {
                layoutControl1.Print();
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}