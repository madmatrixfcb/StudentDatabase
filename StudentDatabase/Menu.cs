using DevExpress.XtraBars;
using System;
using System.Data;
using System.Windows.Forms;

namespace StudentDatabase
{
    public partial class Menu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Menu()
        {
            InitializeComponent();
            time.Start();
            //tabPane1.SelectedPage = null;
            UserInfo();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            DefaultRowCout();
            CheckAdmin();
            RefreshPacjenci();
            RefreshWizyta();
            RefreshUmowWizyte();
            RefreshStatystyki();
            RefreshUbezpieczenie();
            RefreshICD();
        }

        //-----------------------TIME----------------------------------/
        private void Time_Tick(object sender, EventArgs e)
        {
            timeItem.Caption = "Aktualna godzina: " + DateTime.Now.ToLongTimeString();
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
            gridPacjent.RefreshDataSource();
        }

        public void RefreshWizyta()
        {
            this.visit_viewTableAdapter.Fill(this.poradniaDataSet.visit_view);
            this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
            gridWizyta.RefreshDataSource();
        }

        public void RefreshUmowWizyte()
        {
            this.arrange_visit_viewTableAdapter.Fill(this.poradniaDataSet.arrange_visit_view);
            gridUmowWizyte.RefreshDataSource();
        }

        public void RefreshStatystyki()
        {
            this.statistics_viewTableAdapter.Fill(this.poradniaDataSet.statistics_view);
            gridStatistics.RefreshDataSource();
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

        private void gridViewStatistics_RowCountChanged(object sender, EventArgs e)
        {
            recordNumberTB.Text = "Liczba rekordów: " + Convert.ToString(gridViewStatistics.DataRowCount);
        }

        private void DefaultRowCout()
        {
            recordNumberTB.Text = "Liczba rekordów: " + Convert.ToString(gridViewStatistics.DataRowCount);
        }

        private void CheckAdmin()
        {
            if (Login.LoginInfo.userType == "Admin")
            {
                userGroup.Visible = true;
            }
        }

        //-----------------------PANE BUTTONS----------------------------------/

        private void patientButton_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = PacjenciPage;
        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = WizytaPage;
        }

        private void arrangeVisitButtonOnTab_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = UmowWizytePage;
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = StatystykiPage;
        }

        private void insuranceButton_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = UbezpieczeniePage;
        }

        private void ICDButton_Click(object sender, EventArgs e)
        {
            tabPane1.SelectedPage = ICDPage;
        }

        //-----------------------RIBBON ENABLING----------------------------------/
        public void TabPane1_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            PacjenciGroup.Enabled = false;
            UbezpieczenieGroup.Enabled = false;
            ICDGroup.Enabled = false;
            WizytaGroup.Enabled = false;
            UmowWizyteGroup.Enabled = false;
            StatystykiGroup.Enabled = false;
            userGroup.Visible = false;

            if (tabPane1.SelectedPage == PacjenciPage)
            {
                PacjenciGroup.Enabled = true;
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
                RefreshPacjenci();
                deleteButtonP.Enabled = true;
            }
            else
            {
                RefreshPacjenci();
                deleteButtonP.Enabled = false;
            }
        }

        private void deleteBarWizyta_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (deleteBarWizyta.Checked == true)
            {
                RefreshWizyta();
                deleteButtonW.Enabled = true;
            }
            else
            {
                RefreshWizyta();
                deleteButtonW.Enabled = false;
            }
        }

        //-----------------------------------PATIENT RIBBON-----------------------------------//
        public static class PatientPreview
        {
            public static object patientID;
        }

        private void gridViewPacjent_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            PatientPreview.patientID = gridViewPacjent.GetRowCellValue(e.FocusedRowHandle, "ID_Pacjent");
        }

        private void DeleteButtonP_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybranego pacjenta?" + Environment.NewLine + "Usuwając pacjenta usuniesz również wszystkie jego dotychczasowe oraz umówione wizyty!", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    pACJENTTableAdapter.DeletePatient(Convert.ToInt16(PatientPreview.patientID));
                    wIZYTATableAdapter.DeleteVisitByPatientID(Convert.ToString(PatientPreview.patientID));
                    uMOW_WIZTETableAdapter.DeleteArrangedByPatient(Convert.ToString(PatientPreview.patientID));
                    RefreshPacjenci();
                    RefreshWizyta();
                    RefreshUmowWizyte();
                    MessageBox.Show("Pacjent oraz powiązane z nim wizyty zostały usunięte", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void savePatientXLSButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            saveFileDialog.Filter = "XLS (*.xls)|*.xls|XLSX (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Zapisz jako arkusz programu Microsoft Office Excel";
            string filename = saveFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        gridViewPacjent.ExportToXls(filename);
                        filename = "";
                        break;

                    case 2:
                        gridViewPacjent.ExportToXlsx(filename);
                        filename = "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wysąpił błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            if (VisitPreview.visitID != null)
            {
                VisitPreview.visitRow = gridViewWizyta.GetFocusedDataRow();
                ViewVisit view_Visit = new ViewVisit();
                view_Visit.Show();
            }
            else
            {
                MessageBox.Show("Żadna wizyta nie została wybrana do podglądu!", "Brak wybranej wizyty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    wIZYTATableAdapter.DeleteVisit(Convert.ToInt16(VisitPreview.visitID));
                    RefreshWizyta();
                    MessageBox.Show("Wizyta usunięta", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void saveVisitXLSButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            saveFileDialog.Filter = "XLS (*.xls)|*.xls|XLSX (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Zapisz jako arkusz programu Microsoft Office Excel";
            string filename = saveFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        gridViewWizyta.ExportToXls(filename);
                        filename = "";
                        break;

                    case 2:
                        gridViewWizyta.ExportToXlsx(filename);
                        filename = "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wysąpił błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static class ArrangedVisitParams
        {
            public static int arrangedVisitID;
            public static bool arrangeStatus;
            public static DataRow arrangeVisitRow;
            public static bool arrangedVisit = false;
        }

        private void gridViewUmowWizyte_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ArrangedVisitParams.arrangedVisitID = Convert.ToInt16(gridViewUmowWizyte.GetRowCellValue(e.FocusedRowHandle, "ID_Umow_Wizyte"));
        }

        private void deleteArrangedVisitButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybraną wizytę?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    uMOW_WIZTETableAdapter.DeleteArrangedVisit(ArrangedVisitParams.arrangedVisitID);
                    RefreshUmowWizyte();
                    MessageBox.Show("Umówiona wizyta została usunięta", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void saveArrangedVisitXLSButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            saveFileDialog.Filter = "XLS (*.xls)|*.xls|XLSX (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Zapisz jako arkusz programu Microsoft Office Excel";
            string filename = saveFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        gridViewStatistics.ExportToXls(filename);
                        filename = "";
                        break;

                    case 2:
                        gridViewStatistics.ExportToXlsx(filename);
                        filename = "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wysąpił błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startArrangedVisitButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            ArrangedVisitParams.arrangedVisit = true;
            ArrangedVisitParams.arrangeVisitRow = gridViewUmowWizyte.GetFocusedDataRow();
            AddVisit add_Visit = new AddVisit();
            add_Visit.Show();
            add_Visit.FormClosed += Add_Visit_FormClosed;
            ArrangedVisitParams.arrangedVisit = false;
            if (ArrangedVisitParams.arrangeStatus == true)
            {
                uMOW_WIZTETableAdapter.DeleteArrangedVisit(ArrangedVisitParams.arrangedVisitID);
                ArrangedVisitParams.arrangeStatus = false;
            }
        }

        //-----------------------------------STATISTICS RIBBON-----------------------------------//
        private void statisticsExportToXLSButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            saveFileDialog.Filter = "XLS (*.xls)|*.xls|XLSX (*.xlsx)|*.xlsx";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.Title = "Zapisz jako arkusz programu Microsoft Office Excel";
            string filename = saveFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filename = saveFileDialog.FileName;
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        gridViewStatistics.ExportToXls(filename);
                        filename = "";
                        break;

                    case 2:
                        gridViewStatistics.ExportToXlsx(filename);
                        filename = "";
                        break;
                }
            }
            else
            {
                MessageBox.Show("Wysąpił błąd.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearFiltersStatictisButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridViewStatistics.ClearColumnsFilter();
        }

        //-----------------------------------OTHER RIBBON-----------------------------------//

        private void refreshButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            RefreshPacjenci();
            RefreshWizyta();
            RefreshUmowWizyte();
            RefreshStatystyki();
            RefreshUbezpieczenie();
            RefreshICD();
        }

        private void clearFilter_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (tabPane1.SelectedPage == PacjenciPage)
            {
                gridViewPacjent.ClearColumnsFilter();
            }
            else if (tabPane1.SelectedPage == WizytaPage)
            {
                gridViewWizyta.ClearColumnsFilter();
            }
            else if (tabPane1.SelectedPage == UmowWizytePage)
            {
                gridViewUmowWizyte.ClearColumnsFilter();
            }
            else if (tabPane1.SelectedPage == StatystykiPage)
            {
                gridViewStatistics.ClearColumnsFilter();
            }
            else if (tabPane1.SelectedPage == UbezpieczeniePage)
            {
                gridViewUbezpieczenie.ClearColumnsFilter();
            }
            else if (tabPane1.SelectedPage == ICDPage)
            {
                gridViewICD.ClearColumnsFilter();
            }
            else
            {
                MessageBox.Show("Żadna z zakładek nie jest aktywna!", "Brak aktywnej zakładki", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void closeButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        //-----------------------------------USER RIBBON-----------------------------------//

        private void addUserButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
        }

        //-----------------------------------POTWIERDZENIE WYJŚCIA Z APLIKAJCI-----------------------------------//
        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
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