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
    public partial class ViewVisit : DevExpress.XtraEditors.XtraForm
    {
        public ViewVisit()
        {
            InitializeComponent();
        }

        private void VisitView_Load(object sender, EventArgs e)
        {
            LoadPatientInfo();
            LoadVisitInfo();
        }


        private void LoadPatientInfo()
        {/*
            //int userID = Convert.ToInt16(AdminMenu.VisitPreview.patientID);
            DataRow patient = AdminMenu.VisitPreview.patientRow;
            //patientIDLabel.Text = gridViewPacjent.GetRowCellValue(userID, "ID_Pacjent");
            patientIDLabel.Text = patient["ID_Pacjent"].ToString();
            nameLabel.Text = patient["Imie"].ToString();
            surnameLabel.Text = patient["Nazwisko"].ToString();
            birthLabel.Text = patient["Data_urodzenia"].ToString();
            countryLabel.Text = patient["Kraj"].ToString();
            sexLabel.Text = patient["Plec"].ToString();
            addressLabel.Text = patient["Ulica"].ToString() + " " + patient["Nr_budynku"].ToString() + "/" + patient["Nr_mieszkania"].ToString() + " " + patient["Kod_pocztowy"].ToString() + " " + patient["Miasto"].ToString();
            phoneLabel.Text = patient["Telefon"].ToString();
            peselLabel.Text = patient["PESEL"].ToString();
            poleCardLabel.Text = patient["Karta_polaka"].ToString();
            dowodLabel.Text = patient["Dowod"].ToString();
            insuranceLabel.Text = patient["Ubezpieczenie"].ToString();*/
        }

        private void LoadVisitInfo()
        {
            DataRow visit = AdminMenu.VisitPreview.visitRow;
            visitIDLabel.Text = visit["ID_Wizyta"].ToString();
            dateLabel.Text = visit["Data"].ToString() + " " + visit["Godzina"].ToString();
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

    }
}
