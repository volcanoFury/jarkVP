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
        int year = 0;
        double price = 0, miles = 0;
        DateTime currentDate = DateTime.Today;
        String brand, model, addInfo;
        String filename = "", filepath ="";

        List<string> upreDatebase = new List<string>(); 

        public frmUpdateDelete(List<string> datebase)
        {
            InitializeComponent();
            upreDatebase = datebase;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
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
            frmAddCar add = new frmAddCar(upreDatebase);
            add.Show();
        }

        private void frmUpdateDelete_Load(object sender, EventArgs e)
        {

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
            catch (FormatException fe)
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

            MessageBox.Show("" + brand + model + year + price + miles + (filepath += filename));
        }

        private void btnInformationAdd_Click(object sender, EventArgs e)
        {
            lsInformation.Items.Add(txtInfoAdd.Text);
            txtInfoAdd.Text = "";
        }

        private void btnClearInformation_Click(object sender, EventArgs e)
        {
            lsInformation.Clear();
        }
    }
}
