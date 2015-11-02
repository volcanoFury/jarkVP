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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmHelp help = new frmHelp();
            help.Show();
        }

        private void abouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create By, \r\nB00654860 - Jake Bloor \r\nB00654973 - Andrew Robinson");
        }

        private void updateDeleteNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateDelete ud = new frmUpdateDelete();
            ud.Show();
        }

        private void addNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCar add = new frmAddCar();
            add.Show();
        }
    }
}
