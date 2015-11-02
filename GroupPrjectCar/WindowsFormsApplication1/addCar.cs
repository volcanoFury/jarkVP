using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmAddCar : Form
    {
        int year = 0;

        public frmAddCar()
        {
            InitializeComponent();
        }

        //private void radioButtonChecked
        //{

        //}

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                year = Convert.ToInt32(txtYear.Text);
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Year needs to be a Number and Filled in");
            }
        }

    }
}
