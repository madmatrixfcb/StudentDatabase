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
            // TODO: This line of code loads data into the 'poradniaDataSet.admin_view' table. You can move, or remove it, as needed.
            this.admin_viewTableAdapter.Fill(this.poradniaDataSet.admin_view);
            // TODO: This line of code loads data into the 'poradniaDataSet.visit_view' table. You can move, or remove it, as needed.
            this.visit_viewTableAdapter.Fill(this.poradniaDataSet.visit_view);
            // TODO: This line of code loads data into the 'poradniaDataSet1.WIZYTA' table. You can move, or remove it, as needed.
            this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
            // TODO: This line of code loads data into the 'poradniaDataSet1.visit_view' table. You can move, or remove it, as needed.
            this.visit_viewTableAdapter.Fill(this.poradniaDataSet.visit_view);
            // TODO: This line of code loads data into the 'poradniaDataSet1.PACJENT' table. You can move, or remove it, as needed.
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            // TODO: This line of code loads data into the 'poradniaDataSet1.admin_view' table. You can move, or remove it, as needed.
            this.admin_viewTableAdapter.Fill(this.poradniaDataSet.admin_view);
            this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);

            /*if (Login.LoginInfo.userType == "Admin")
            {
                MessageBox.Show("Witaj "+ Login.LoginInfo.login+"!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (Login.LoginInfo.userType == "Lekarz")
            {
                MessageBox.Show("Witaj " + Login.LoginInfo.userType + "!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
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
            this.admin_viewTableAdapter.Fill(this.poradniaDataSet.admin_view);
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
            gridPacjenci.RefreshDataSource();
        }

        public void RefreshWizyta()
        {
            this.visit_viewTableAdapter.Fill(this.poradniaDataSet.visit_view);
            this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
            gridWizyta.RefreshDataSource();
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

            if (tabPane1.SelectedPage == PacjenciPage)
            {
                PacjenciGroup.Enabled = true;
                RefreshPacjenci();
            }

            if (tabPane1.SelectedPage == UbezpieczeniePage && Login.LoginInfo.userType == "Admin")
            {
                UbezpieczenieGroup.Enabled = true;
                RefreshUbezpieczenie();
            }

            if (tabPane1.SelectedPage == ICDPage && Login.LoginInfo.userType == "Admin")
            {
                ICDGroup.Enabled = true;
                RefreshICD();
            }

            if (tabPane1.SelectedPage == WizytaPage)
            {
                WizytaGroup.Enabled = true;
                RefreshWizyta();
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
                gridPacjenci.DataSource = this.poradniaDataSet.admin_view;
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
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
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

        //-----------------------------------UBEZPIECZENIE RIBBON-----------------------------------//

        private void DeleteButtonU_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybrane ubezpieczenie?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    gridView2.DeleteRow(gridView2.FocusedRowHandle);
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

        private void DeleteButtonI_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybrany kod ICD?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    gridView3.DeleteRow(gridView3.FocusedRowHandle);
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

        private void DeleteButtonW_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybraną wizytę?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    gridView4.DeleteRow(gridView4.FocusedRowHandle);
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