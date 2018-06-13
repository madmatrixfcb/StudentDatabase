using DevExpress.XtraBars;
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
            tabPane1.SelectedPage = null;
            UserInfo();

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poradniaDataSet.UMOW_WIZTE' table. You can move, or remove it, as needed.
            /*
            this.uMOW_WIZTETableAdapter.Fill(this.poradniaDataSet.UMOW_WIZTE);
            this.visit_viewTableAdapter.Fill(this.poradniaDataSet.visit_view);
            this.patient_viewTableAdapter.Fill(this.poradniaDataSet.patient_view);
             this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
             this.visit_viewTableAdapter.Fill(this.poradniaDataSet.visit_view);
             this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
             this.patient_viewTableAdapter.Fill(this.poradniaDataSet.patient_view);
             this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
             this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);*/
        }

        //-----------------------TIME----------------------------------/
        private void Time_Tick(object sender, EventArgs e)
        {
            timeItem.Caption = "Aktualna godzina: "+DateTime.Now.ToLongTimeString();
        }

        //-----------------------USER----------------------------------/

        private void UserInfo()
        {
            loggedAsText.Caption = "Zalogowany jako: " + Convert.ToString(this.uzytkownikTableAdapter.SelectUserInfo(Login.LoginInfo.userID));
        }

        //-----------------------FUNCTIONS----------------------------------/
        public void RefreshPacjenci()
        {
            this.patient_viewTableAdapter.Fill(this.poradniaDataSet.patient_view);
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            gridPacjenci.RefreshDataSource();
        }

        public void RefreshWizyta()
        {
            this.visit_viewTableAdapter.Fill(this.poradniaDataSet.visit_view);
            this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
            gridWizyta.RefreshDataSource();
        }

        public void RefreshUmowWizyte()
        {
            this.uMOW_WIZTETableAdapter.Fill(this.poradniaDataSet.UMOW_WIZTE);
            gridUmowWiztye.RefreshDataSource();
        }

        public void RefreshStatystyki()
        {/*
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);
            gridICD.RefreshDataSource();*/
        }

        public void RefreshUbezpieczenie()
        {
            this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
            gridUbezpieczenie.RefreshDataSource();
        }

        public void RefreshICD()
        {
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);
            gridICD.RefreshDataSource();
        }
        //-----------------------RIBBON ENABLING----------------------------------/
        private void TabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            PacjenciGroup.Enabled = false;
            UbezpieczenieGroup.Enabled = false;
            ICDGroup.Enabled = false;
            WizytaGroup.Enabled = false;
            UmowWizyteGroup.Enabled = false;
            StatystykiGroup.Enabled = false;
            P.Enabled = false;

            if (tabPane1.SelectedPage == PacjenciPage)
            {
                PacjenciGroup.Enabled = true;
                if (Login.LoginInfo.userType == "Admin")
                {
                    P.Enabled = true;
                }
                RefreshPacjenci();
            }

            if (tabPane1.SelectedPage == UbezpieczeniePage)
            {
                
                RefreshUbezpieczenie();
                if (Login.LoginInfo.userType == "Admin")
                {
                    UbezpieczenieGroup.Enabled = true;
                }
            }

            if (tabPane1.SelectedPage == ICDPage)
            {
                RefreshICD();
                if (Login.LoginInfo.userType == "Admin")
                {
                    ICDGroup.Enabled = true;
                }
            }
            

            if (tabPane1.SelectedPage == WizytaPage)
            {
                WizytaGroup.Enabled = true;
                RefreshWizyta();
            }

            if (tabPane1.SelectedPage == StatystykiPage)
            {
                StatystykiGroup.Enabled = true;
                RefreshStatystyki();
            }

            if (tabPane1.SelectedPage == UmowWizytePage)
            {
                UmowWizyteGroup.Enabled = true;
                RefreshUmowWizyte();
            }
        }

        //-----------------------------------DELETE BAR-----------------------------------//
        private void deleteModeBar_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (deleteModeBar.Checked == true)
            {
                gridPacjenci.DataSource = this.poradniaDataSet.PACJENT;
                gridPacjenci.Refresh();
                deleteButtonP.Enabled = true;
            }
            else
            {
                gridPacjenci.DataSource = this.poradniaDataSet.patient_view;
                gridPacjenci.Refresh();
                deleteButtonP.Enabled = false;
            }
        }

        private void deleteBarWizyta_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (deleteBarWizyta.Checked == true)
            {
                gridWizyta.DataSource = this.poradniaDataSet.WIZYTA;
                gridWizyta.Refresh();
                deleteButtonW.Enabled = true;
            }
            else
            {
                gridWizyta.DataSource = this.poradniaDataSet.visit_view;
                gridWizyta.Refresh();
                deleteButtonW.Enabled = false;
            }
        }
        //-----------------------------------PATIENT RIBBON-----------------------------------//
        private void RefreshButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshPacjenci();
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
                    gridViewPacjent.DeleteRow(gridViewPacjent.FocusedRowHandle);
                    this.pACJENTTableAdapter.Update(poradniaDataSet.PACJENT);
                    MessageBox.Show("Pacjent(ci) usunięty(ci)", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshPacjenci();
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
            editPat.Show();
            editPat.FormClosed += EditPat_FormClosed;

        }

        private void EditPat_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshPacjenci();
        }

        private void findPatientButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridViewPacjent.Focus();
            SendKeys.Send("^(F)");
        }

        //-----------------------------------UBEZPIECZENIE RIBBON-----------------------------------//

        private void DeleteButtonU_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybrane ubezpieczenie?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    gridViewUbezpieczenie.DeleteRow(gridViewUbezpieczenie.FocusedRowHandle);
                    this.uBEZPIECZENIETableAdapter.Update(poradniaDataSet.UBEZPIECZENIE);
                    MessageBox.Show("Ubezpieczenie(a) usunięte", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshUbezpieczenie();
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

        private void RefreshUbezp_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshUbezpieczenie();
        }

        private void DodajUbezp_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz dodać nowy typ ubezpieczenia?", "Potwierdzenie dodania", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                AddUbezp addUbezp = new AddUbezp();
                addUbezp.Show();
                addUbezp.FormClosed += AddUbezp_FormClosed;
            }
            else
            {
                return;
            }
        }

        private void AddUbezp_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshUbezpieczenie();
        }


        //-----------------------------------ICD RIBBON-----------------------------------//

        private void AddICD_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz dodać nowy kod ICD?", "Potwierdzenie dodania", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                AddICD addICD = new AddICD();
                addICD.Show();
                addICD.FormClosed += AddICD_FormClosed;
            }
            else
            {
                return;
            }
        }

        private void AddICD_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshICD();
        }

        private void RefreshICD_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshICD();
        }

        private void findICDButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridViewICD.Focus();
            SendKeys.Send("^(F)");
        }

        private void DeleteButtonI_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybrany kod ICD?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    gridViewICD.DeleteRow(gridViewICD.FocusedRowHandle);
                    this.iCDTableAdapter.Update(poradniaDataSet.ICD);
                    MessageBox.Show("Kod ICD usunięty", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshICD();
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

        //-----------------------------------VIST RIBBON-----------------------------------//

        private void AddVisit_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddVisit add_Visit = new AddVisit();
            add_Visit.Show();
            add_Visit.FormClosed += Add_Visit_FormClosed;

        }

        private void Add_Visit_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshWizyta();
        }
    

        private void RefreshVisit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
        }

        private void findVisitButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridViewWizyta.Focus();
            SendKeys.Send("^(F)");
        }

        private void editVisit_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditVisit edit_Visit = new EditVisit();
            edit_Visit.Show();
            edit_Visit.FormClosed += Edit_Visit_FormClosed;
        }

        private void Edit_Visit_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshWizyta();
        }

        private void viewVisit_ItemClick(object sender, ItemClickEventArgs e)
        {
            VisitPreview.visitRow = gridViewWizyta.GetFocusedDataRow();
            ViewVisit view_Visit = new ViewVisit();
            view_Visit.Show();
        }

        private void gridViewWizyta_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            VisitPreview.patientID = gridViewWizyta.GetRowCellValue(e.FocusedRowHandle, "ID_Pacjent");
            VisitPreview.visitID = gridViewWizyta.GetRowCellValue(e.FocusedRowHandle, "ID_Wizyta");
        }

        public static class VisitPreview
        {
            public static object patientID;
            public static object visitID;
            public static DataRow visitRow;
            public static DataRow patientRow;
        }

            private void DeleteButtonW_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybraną wizytę?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    gridViewWizyta.DeleteRow(gridViewWizyta.FocusedRowHandle);
                    this.wIZYTATableAdapter.Update(poradniaDataSet.WIZYTA);
                    MessageBox.Show("Wizyta usunięta", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshWizyta();
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

        //-----------------------------------ARRANGE VIST RIBBON-----------------------------------//


        private void arrangeVisitButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            ArrangeVisit arrange_Visit = new ArrangeVisit();
            arrange_Visit.Show();
            arrange_Visit.FormClosed += Arrange_Visit_FormClosed;
        }

        private void Arrange_Visit_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshUmowWizyte();
        }

        private void deleteArrangedVisitButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybraną wizytę?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    gridUmowWiztyeView.DeleteRow(gridUmowWiztyeView.FocusedRowHandle);
                    this.uMOW_WIZTETableAdapter.Update(poradniaDataSet.UMOW_WIZTE);
                    MessageBox.Show("Wizyta usunięta", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshWizyta();
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

        public static class ArrangeVisitPreview
        {
            public static DataRow arrangeVisitRow;
            public static bool arrangedVisit = false;
        }

        private void startArrangedVisitButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            ArrangeVisitPreview.arrangedVisit = true;
            ArrangeVisitPreview.arrangeVisitRow = gridUmowWiztyeView.GetFocusedDataRow();
            AddVisit add_Visit = new AddVisit();
            add_Visit.Show();
            add_Visit.FormClosed += Add_Visit_FormClosed;
            ArrangeVisitPreview.arrangedVisit = false;
        }

        //-----------------------------------POTWIERDZENIE WYJŚCIA Z APLIKAJCI-----------------------------------//
        private void AdminMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz wyjść z aplikacji", "Potwierdzenie wyjścia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
        }
    }
}