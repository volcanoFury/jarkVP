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
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            int count = 0;
            //Delcare String for text
            string inputline;

            //Read in Help Information From Text file
            System.IO.StreamReader inFile = new System.IO.StreamReader("help.txt");

            //Loop through text file to and  add line to textbox
            while((inputline= inFile.ReadLine()) !=null)
            {
                count++;
                if(count == 1)
                {
                    //AddText Line To Textbox
                    txtHelp.Text += inputline;
                }
                else
                {
                    //AddText Line To Textbox
                    txtHelp.Text += "\r\n" + inputline;
                }
                
            }
            //Close Connection To File7
            inFile.Close();
        }
    }
}
