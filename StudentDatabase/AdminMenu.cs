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

        //-----------------------FUNCTIONS----------------------------------/

        private void DeleteSelectedRows(DevExpress.XtraGrid.Views.Grid.GridView view)
        {
            if (view == null || view.SelectedRowsCount == 0) return;

            DataRow[] rows = new DataRow[view.SelectedRowsCount];

            for (int i = 0; i < view.SelectedRowsCount; i++)

                rows[i] = view.GetDataRow(gridView1.GetSelectedRows()[i]);

            try
            {
                foreach (DataRow row in rows)

                    row.Delete();
            }
            finally
            {
            }
        }

        //-----------------------------------PATIENT RIBBON-----------------------------------//

        private void refreshButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.pACJENTTableAdapter.Fill(this.poradniaDataSet.PACJENT);
        }

        private void saveChanges_ItemClick(object sender, ItemClickEventArgs e)
        {
            
            {
                pACJENTTableAdapter.Update(poradniaDataSet.PACJENT);
                MessageBox.Show("Dane pacjentów zaktualizowanie", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteButtonP_ItemClick(object sender, ItemClickEventArgs e)
        { 
            DialogResult warning = MessageBox.Show("Czy na pewno chcesz usunąć wybranego(ych) pacjenta(ów)?", "Potwierdzenie usunięcia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (warning == DialogResult.Yes)
            {
                try
                {
                    gridView1.DeleteRow(gridView1.FocusedRowHandle);
                    //DeleteSelectedRows(gridView1);
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

        private void addPatient_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddPatient addPat = new AddPatient();
            addPat.Show();
        }

        private void editPatient_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        //-----------------------------------UBEZPIECZENIE RIBBON-----------------------------------//

        private void deleteButtonU_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DeleteSelectedRows(gridView2);
                MessageBox.Show("Ubezpieczenie(a) usunięte", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshUbezp_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.uBEZPIECZENIETableAdapter.Fill(this.poradniaDataSet.UBEZPIECZENIE);
        }

        private void dodajUbezp_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddUbezp addUbezp = new AddUbezp();
            addUbezp.Show();
        }

        //-----------------------------------ICD RIBBON-----------------------------------//

        private void addICD_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddICD addICD = new AddICD();
            addICD.Show();
        }

        private void refreshICD_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);
        }

        private void saveChangesICD_ItemClick(object sender, ItemClickEventArgs e)
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

        private void deleteButtonI_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                DeleteSelectedRows(gridView3);
                MessageBox.Show("Kod ICD usunięty", "Usunięto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //-----------------------------------VIST RIBBON-----------------------------------//

        private void addVisit_ItemClick(object sender, ItemClickEventArgs e)
        {
            AddVisit add_Visit = new AddVisit();
            add_Visit.Show();
        }

        private void refreshVisit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.wIZYTATableAdapter.Fill(this.poradniaDataSet.WIZYTA);
        }


    }
}