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
    public partial class AddICD : DevExpress.XtraEditors.XtraForm
    {
        public AddICD()
        {
            InitializeComponent();
        }

        private void addICDButton_Click(object sender, EventArgs e)
        {

            string kodICD = Convert.ToString(kodTB.Text);
            string rozpoznanie = Convert.ToString(rozpoznanieTB.Text);

            iCDTableAdapter.InsertQuery(kodICD, rozpoznanie);


            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.ResetText();
                }
            }
        }
    }
}