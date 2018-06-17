using System;
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
    public partial class SelectPane : DevExpress.XtraEditors.XtraForm
    {
        public SelectPane()
        {
            InitializeComponent();
        }



        private void patientButton_Click(object sender, EventArgs e)
        {
            AdminMenu.SelectedPane.selectedId = 1;
            this.Close();
        }

        private void visitButton_Click(object sender, EventArgs e)
        {
            AdminMenu.SelectedPane.selectedId = 2;
            this.Close();
        }

        private void arrange_visitButton_Click(object sender, EventArgs e)
        {
            AdminMenu.SelectedPane.selectedId = 3;
            this.Close();
        }

        private void statisticsButton_Click(object sender, EventArgs e)
        {
            AdminMenu.SelectedPane.selectedId = 4;
            this.Close();
        }

        private void ICDButton_Click(object sender, EventArgs e)
        {
            AdminMenu.SelectedPane.selectedId = 5;
            this.Close();
        }

        private void insuranceButton_Click(object sender, EventArgs e)
        {
            AdminMenu.SelectedPane.selectedId = 6;
            this.Close();
        }
    }
}