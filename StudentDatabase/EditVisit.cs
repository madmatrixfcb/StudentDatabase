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
    public partial class EditVisit : DevExpress.XtraEditors.XtraForm
    {
        public EditVisit()
        {
            InitializeComponent();
        }

        private void EditVisit_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'poradniaDataSet.UZYTKOWNIK' table. You can move, or remove it, as needed.
            this.uZYTKOWNIKTableAdapter.Fill(this.poradniaDataSet.UZYTKOWNIK);
            // TODO: This line of code loads data into the 'poradniaDataSet.ICD' table. You can move, or remove it, as needed.
            this.iCDTableAdapter.Fill(this.poradniaDataSet.ICD);
            // TODO: This line of code loads data into the 'poradniaDataSet.visit_view' table. You can move, or remove it, as needed.
            this.visit_viewTableAdapter.Fill(this.poradniaDataSet.visit_view);

        }

        private void gridView5_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            wizytaTB.EditValue = gridView5.GetRowCellValue(e.FocusedRowHandle, "ID_Wizyta");
            pacjentCB.EditValue = gridView5.GetRowCellValue(e.FocusedRowHandle, "ID_Pacjent");
            dateEdit.EditValue = gridView5.GetRowCellValue(e.FocusedRowHandle, "Data");
            timeEdit.EditValue = gridView5.GetRowCellValue(e.FocusedRowHandle, "Godzina");
            objawyTB.Text = Convert.ToString(gridView5.GetRowCellValue(e.FocusedRowHandle, "Objawy"));
            bprzedTB.Text = Convert.ToString(gridView5.GetRowCellValue(e.FocusedRowHandle, "BPrzedmiotowe"));
            bpodTB.Text = Convert.ToString(gridView5.GetRowCellValue(e.FocusedRowHandle, "BPodmiotowe"));
            ICDCB1.EditValue = gridView5.GetRowCellValue(e.FocusedRowHandle, "ID_ICD_1");
            ICDCB2.EditValue = gridView5.GetRowCellValue(e.FocusedRowHandle, "ID_ICD_2");
            ICDCB3.EditValue = gridView5.GetRowCellValue(e.FocusedRowHandle, "ID_ICD_3");
            rozpoznanieTB.Text = Convert.ToString(gridView5.GetRowCellValue(e.FocusedRowHandle, "Rozpoznanie"));
            lekiTB.Text = Convert.ToString(gridView5.GetRowCellValue(e.FocusedRowHandle, "Leki"));
            userCB.EditValue = gridView5.GetRowCellValue(e.FocusedRowHandle, "ID_Lekarz");
        }
    }
}
