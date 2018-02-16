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

namespace StudentDatabase
{
    public partial class AddVisit : DevExpress.XtraEditors.XtraForm
    {
        public AddVisit()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            iCDTableAdapter.Fill(poradniaDataSet.ICD);
        }


        private void AddVisit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poradniaDataSet.PACJENT' table. You can move, or remove it, as needed.
            this.pacjentTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            // TODO: This line of code loads data into the 'poradniaDataSet.ICD' table. You can move, or remove it, as needed.
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);

        }

        private void addVisitButton_Click(object sender, EventArgs e)
        {
            int patient = Convert.ToInt32(pacjentCB.SelectedValue);
            DateTime date = Convert.ToDateTime(dateEdit1.Text);
           // string godzina = Convert.ToString(timeEdit1.Text);
            string objawy = Convert.ToString(objawyTB.Text);
            string bprzed = Convert.ToString(bprzedTB.Text);
            string bpod = Convert.ToString(bpodTB.Text);
            int icd1 = Convert.ToInt16(ICDCB1.SelectedValue);
            int icd2 = Convert.ToInt16(ICDCB2.SelectedValue);
            int icd3 = Convert.ToInt16(ICDCB3.SelectedValue);
            string rozpoznanie = Convert.ToString(rozpoznanieTB.Text);
            string leki = Convert.ToString(lekiTB.Text);

            //string datawizyty = date + godzina;
            //string icd = icd1 + " " + icd2 + " " + icd3;

            if (String.IsNullOrEmpty(pacjentCB.Text) || String.IsNullOrEmpty(objawyTB.Text) || String.IsNullOrEmpty(bprzedTB.Text) || String.IsNullOrEmpty(bpodTB.Text) || String.IsNullOrEmpty(ICDCB1.Text) || String.IsNullOrEmpty(rozpoznanieTB.Text) || String.IsNullOrEmpty(lekiTB.Text))
            {
                MessageBox.Show("Wypełnij wszystkie pola by dodać wizytę", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    wIZYTATableAdapter.InsertQuery(patient, date, objawy, bprzed, bpod, icd1, icd2, icd3 ,rozpoznanie, leki);
                    MessageBox.Show("Wizyta dodana", "Dodano", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Close();

                    this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}