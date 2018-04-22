using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Columns;

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

            patientIDLabel.Text = PatientData.pacjentRow["ID_Pacjent"].ToString();
            nameLabel.Text = PatientData.pacjentRow["Imie"].ToString();
            surnameLabel.Text = PatientData.pacjentRow["Nazwisko"].ToString();
            string data_ur = PatientData.pacjentRow["Data_urodzenia"].ToString();
            birthLabel.Text = data_ur.Substring(0, 10);
            countryLabel.Text = PatientData.pacjentRow["Kraj"].ToString();
            sexLabel.Text = PatientData.pacjentRow["Plec"].ToString();
            addressLabel.Text = PatientData.pacjentRow["Ulica"].ToString() + " " + PatientData.pacjentRow["Nr_budynku"].ToString() + "/" + PatientData.pacjentRow["Nr_mieszkania"].ToString() + " " + PatientData.pacjentRow["Kod_pocztowy"].ToString() + " " + PatientData.pacjentRow["Miasto"].ToString();
            phoneLabel.Text = PatientData.pacjentRow["Telefon"].ToString();
            peselLabel.Text = PatientData.pacjentRow["PESEL"].ToString();
            poleCardLabel.Text = PatientData.pacjentRow["Karta_polaka"].ToString();
            dowodLabel.Text = PatientData.pacjentRow["Dowod_osobisty"].ToString();
            passportLabel.Text = PatientData.pacjentRow["Paszport"].ToString();
            insuranceLabel.Text = PatientData.pacjentRow["Ubezpieczenie"].ToString();
            gridControl1.Visible = false;
        }


        private void LoadVisitInfo()
        {
            DataRow visit = AdminMenu.VisitPreview.visitRow;
            visitIDLabel.Text = visit["ID_Wizyta"].ToString();
            string data = visit["Data"].ToString();
            dateLabel.Text =  data.Substring(0,10) + " " + visit["Godzina"].ToString();
            objawyLabel.Text = visit["Objawy"].ToString();
            bprzedmiotoweLabel.Text = visit["BPrzedmiotowe"].ToString();
            bpodmiotowe.Text = visit["Bpodmiotowe"].ToString();
            ICD1Label.Text = visit["ID_ICD_1"].ToString();
            ICD2Label.Text = visit["ID_ICD_2"].ToString();
            ICD3Label.Text = visit["ID_ICD_3"].ToString();
            rozpoznanieLabel.Text = visit["Rozpoznanie"].ToString();
            lekiLabel.Text = visit["Leki"].ToString();
            zaleceniaLabel.Text = visit["Zalecenia"].ToString();
            przyrjmujacyLabel.Text = visit["ID_Lekarz"].ToString();
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
    }
}
