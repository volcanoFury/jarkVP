using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmUpdateDelete : Form
    {
        public frmUpdateDelete()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            String filename = "", filepath;
            OpenFileDialog open = new OpenFileDialog() { Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                filename =open.FileName;
            }

            Bitmap bmp = new Bitmap(filename);
            carImage.Image = bmp;//add this line
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] bimage = new byte[fs.Length];
            fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
            filepath = Path.GetDirectoryName(filename);
            fs.Close();
        }

        private void addNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddCar add = new frmAddCar();
            add.Show();
        }
    }
}
