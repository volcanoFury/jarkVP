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
    public partial class frmAddCar : Form
    {
        int year = 0;
        double price = 0, miles = 0;
        DateTime currentDate = DateTime.Today;
        String brand, model;

        public frmAddCar()
        {
            InitializeComponent();
            lblMultidate.Text = "" + currentDate;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblMultidate.Text = "" + currentDate;

            try
            {
                brand = txtBrand.Text;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Brand needs and Filled in");
            }

            try
            {
                model = txtModel.Text;
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Model needs and Filled in");
            }

            try
            {
                year = Convert.ToInt32(txtYear.Text);
            }
            catch(FormatException fe)
            {
                MessageBox.Show("Year needs to be a Number and Filled in");
            }

            try
            {
                price = Convert.ToInt32(txtPrice.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Price needs to be a Number and Filled in");
            }

            try
            {
                miles = Convert.ToInt32(txtMiles.Text);
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Miles needs to be a Number and Filled in");
            }

            MessageBox.Show("" + brand + model + year + price + miles); 
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            String filename = "", filepath;
            OpenFileDialog open = new OpenFileDialog() { Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg" };
            if (open.ShowDialog() == DialogResult.OK)
            {
                filename = open.FileName;
            }

            Bitmap bmp = new Bitmap(filename);
            carImage.Image = bmp;//add this line
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            byte[] bimage = new byte[fs.Length];
            fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
            filepath = Path.GetDirectoryName(filename);
            fs.Close();
        }

        private void updateDeleteNewCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdateDelete ud = new frmUpdateDelete();
            ud.Show();
        }
    }
}
