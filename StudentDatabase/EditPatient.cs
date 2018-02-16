﻿using System;
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


            // This line of code is generated by Data Source Configuration Wizard
            this.pACJENTTableAdapter.Fill(poradniaDataSet.PACJENT);
        }




        public void UpdateValues()
        {
            //    IDTB.Text = gridView1.Columns.View.GetFocusedRowCellValue("your fild");
        }

        private void EditPatient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poradniaDataSet.PACJENT' table. You can move, or remove it, as needed.
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            IDTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "ID_Pacjent");
            imieTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Imie");
            nazwiskoTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Nazwisko");
            dataur.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Data_urodzenia");
            krajTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Kraj");
            telefonTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Telefon");
            string ulica = Convert.ToString(ulicaTB.Text);
            string nr_budynku = Convert.ToString(budynekTB.Text);
            string nr_mieszkania = Convert.ToString(mieszkanieTB.Text);
            string kod_pocztowy = Convert.ToString(kodTB.Text);
            string miasto = Convert.ToString(miastoTB.Text);
            peselTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "PESEL");
            kartapolakaTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Karta_polaka");
            dowodTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Dowod_osobisty");
            paszportTB.EditValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Paszport");
            ubezpieczenieCB.SelectedValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "ID_Ubezpieczenie");
            plecCB.SelectedValue = gridView1.GetRowCellValue(e.FocusedRowHandle, "Plec");

            string adres = ulica + " " + nr_budynku + " " + "m. " + nr_mieszkania + " " + kod_pocztowy + " " + miasto;

        }


        //bool isValid = dxValidationProvider1.Validate();

        private void EditPatient2_Click(object sender, EventArgs e)
        {
            string imie = Convert.ToString(imieTB.Text);
            string nazwisko = Convert.ToString(nazwiskoTB.Text);
            string data_ur = Convert.ToString(dataur.Text);
            string kraj = Convert.ToString(krajTB.Text);
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
            string plec = Convert.ToString(plecCB.SelectedValue);
            string ubezpieczenie = Convert.ToString(ubezpieczenieCB.SelectedValue);

            string adres = ulica + " " + nr_budynku + " " + "m. " + nr_mieszkania + " " + kod_pocztowy + " " + miasto;

            // string wrong_phone = "+48";

            /*  if (String.IsNullOrEmpty(imieTB.Text) || String.IsNullOrEmpty(nazwiskoTB.Text) || String.IsNullOrEmpty(dataur.Text) || String.IsNullOrEmpty(krajTB.Text) || String.IsNullOrEmpty(telefonTB.Text) || String.Equals(telefonTB.Text,wrong_phone)  ||  String.IsNullOrEmpty(adres))
              else
              {*/

            bool isValid = dxValidationProvider1.Validate();
        }
    }
}