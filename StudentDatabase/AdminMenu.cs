﻿using DevExpress.XtraBars;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class AdminMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public AdminMenu()
        {
            InitializeComponent();
            time.Start();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            tabPane1.Refresh();
            // TODO: This line of code loads data into the 'poradniaDataSet.WIZYTA' table. You can move, or remove it, as needed.
            this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
            // TODO: This line of code loads data into the 'poradniaDataSet.PACJENT' table. You can move, or remove it, as needed.
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            // TODO: This line of code loads data into the 'poradniaDataSet.UBEZPIECZENIE' table. You can move, or remove it, as needed.
            this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
            // TODO: This line of code loads data into the 'poradniaDataSet.ICD' table. You can move, or remove it, as needed.
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);
        }

        //-----------------------TIME----------------------------------/
        private void Time_Tick(object sender, EventArgs e)
        {
            timeItem.Caption = "Aktualna godzina "+DateTime.Now.ToLongTimeString();
        }

        //-----------------------FUNCTIONS----------------------------------/
        public void RefreshPacjenci()
        {
            gridPacjenci.RefreshDataSource();
        }

        //-----------------------RIBBON ENABLING----------------------------------/
        private void TabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            PacjenciGroup.Enabled = false;
            UbezpieczenieGroup.Enabled = false;
            ICDGroup.Enabled = false;
            WizytaGroup.Enabled = false;

            if (tabPane1.SelectedPage == PacjenciPage)
            {
                PacjenciGroup.Enabled = true;
            }

            if (tabPane1.SelectedPage == UbezpieczeniePage)
            {
                UbezpieczenieGroup.Enabled = true;
            }

            if (tabPane1.SelectedPage == ICDPage)
            {
                ICDGroup.Enabled = true;
            }

            if (tabPane1.SelectedPage == WizytaPage)
            {
                WizytaGroup.Enabled = true;
            }
        }
            //-----------------------------------PATIENT RIBBON-----------------------------------//
            private void RefreshButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
        }

        private void SaveChanges_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                pACJENTTableAdapter.Update(poradniaDataSet.PACJENT);
                MessageBox.Show("Dane pacjentów zaktualizowanie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButtonP_ItemClick(object sender, ItemClickEventArgs e)
        { 
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybranego pacjenta?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    this.pACJENTTableAdapter.Update(poradniaDataSet.PACJENT);
                    MessageBox.Show("Pacjent(ci) usunięty(ci)", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                return;
            }
        }

        private void AddPatient_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddPatient addPat = new AddPatient();
            addPat.Show();
            addPat.FormClosed += AddPat_FormClosed;

        }

        private void AddPat_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshPacjenci();
        }

        private void EditPatient_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditPatient editPat = new EditPatient();
            editPat.ShowDialog();

        }

        //-----------------------------------UBEZPIECZENIE RIBBON-----------------------------------//

        private void DeleteButtonU_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                gridView2.DeleteRow(gridView2.FocusedRowHandle);
                this.uBEZPIECZENIETableAdapter.Update(poradniaDataSet.UBEZPIECZENIE);
                MessageBox.Show("Ubezpieczenie(a) usunięte", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshUbezp_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
        }

        private void DodajUbezp_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddUbezp addUbezp = new AddUbezp();
            addUbezp.Show();
        }

        //-----------------------------------ICD RIBBON-----------------------------------//

        private void AddICD_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddICD addICD = new AddICD();
            addICD.Show();
        }

        private void RefreshICD_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);
        }

        private void SaveChangesICD_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                this.iCDTableAdapter.Update(poradniaDataSet.ICD);
                MessageBox.Show("Dane kodów ICD zaktualizowanie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButtonI_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                gridView3.DeleteRow(gridView3.FocusedRowHandle);
                this.iCDTableAdapter.Update(poradniaDataSet.ICD);
                MessageBox.Show("Kod ICD usunięty", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------VIST RIBBON-----------------------------------//

        private void AddVisit_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddVisit add_Visit = new AddVisit();
            add_Visit.Show();
        }

        private void RefreshVisit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
        }

        private void DeleteButtonW_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                gridView4.DeleteRow(gridView4.FocusedRowHandle);
                this.wIZYTATableAdapter.Update(poradniaDataSet.WIZYTA);
                MessageBox.Show("Wizyta usunięta", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}