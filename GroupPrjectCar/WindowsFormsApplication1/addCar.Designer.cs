namespace WindowsFormsApplication1
{
    partial class frmAddCar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblMultidate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearInformation = new System.Windows.Forms.Button();
            this.txtInfoAdd = new System.Windows.Forms.TextBox();
            this.btnInformationAdd = new System.Windows.Forms.Button();
            this.lsInformation = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdEstate = new System.Windows.Forms.RadioButton();
            this.rdCoupe = new System.Windows.Forms.RadioButton();
            this.rdConvertible = new System.Windows.Forms.RadioButton();
            this.rdSUV = new System.Windows.Forms.RadioButton();
            this.rdMPV = new System.Windows.Forms.RadioButton();
            this.rdHatchBack = new System.Windows.Forms.RadioButton();
            this.rdSaloon = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMiles = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.Brand = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDatabaseAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeleteNewCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.priceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectYearBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.brandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblMultidate);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(251, 379);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(315, 68);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Edit";
            // 
            // lblMultidate
            // 
            this.lblMultidate.AutoSize = true;
            this.lblMultidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMultidate.Location = new System.Drawing.Point(115, 18);
            this.lblMultidate.Name = "lblMultidate";
            this.lblMultidate.Size = new System.Drawing.Size(91, 13);
            this.lblMultidate.TabIndex = 3;
            this.lblMultidate.Text = "this is date Saved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "this is date edited";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "this is date Saved";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearInformation);
            this.groupBox4.Controls.Add(this.txtInfoAdd);
            this.groupBox4.Controls.Add(this.btnInformationAdd);
            this.groupBox4.Controls.Add(this.lsInformation);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(250, 193);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(316, 180);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Inforation";
            // 
            // btnClearInformation
            // 
            this.btnClearInformation.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClearInformation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInformation.ForeColor = System.Drawing.Color.White;
            this.btnClearInformation.Location = new System.Drawing.Point(181, 151);
            this.btnClearInformation.Name = "btnClearInformation";
            this.btnClearInformation.Size = new System.Drawing.Size(129, 23);
            this.btnClearInformation.TabIndex = 23;
            this.btnClearInformation.Text = "Clear Information";
            this.btnClearInformation.UseVisualStyleBackColor = false;
            this.btnClearInformation.Click += new System.EventHandler(this.btnClearInformation_Click);
            // 
            // txtInfoAdd
            // 
            this.txtInfoAdd.Location = new System.Drawing.Point(13, 123);
            this.txtInfoAdd.Name = "txtInfoAdd";
            this.txtInfoAdd.Size = new System.Drawing.Size(162, 22);
            this.txtInfoAdd.TabIndex = 10;
            // 
            // btnInformationAdd
            // 
            this.btnInformationAdd.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInformationAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInformationAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformationAdd.ForeColor = System.Drawing.Color.White;
            this.btnInformationAdd.Location = new System.Drawing.Point(181, 122);
            this.btnInformationAdd.Name = "btnInformationAdd";
            this.btnInformationAdd.Size = new System.Drawing.Size(129, 23);
            this.btnInformationAdd.TabIndex = 22;
            this.btnInformationAdd.Text = "Add Information";
            this.btnInformationAdd.UseVisualStyleBackColor = false;
            this.btnInformationAdd.Click += new System.EventHandler(this.btnInformationAdd_Click);
            // 
            // lsInformation
            // 
            this.lsInformation.Location = new System.Drawing.Point(13, 19);
            this.lsInformation.Name = "lsInformation";
            this.lsInformation.Size = new System.Drawing.Size(297, 97);
            this.lsInformation.TabIndex = 0;
            this.lsInformation.UseCompatibleStateImageBehavior = false;
            this.lsInformation.View = System.Windows.Forms.View.List;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbAuto);
            this.groupBox3.Controls.Add(this.rbManual);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 395);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(222, 52);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "GearBox";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(89, 22);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(94, 20);
            this.rbAuto.TabIndex = 1;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automatic";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(7, 22);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(76, 20);
            this.rbManual.TabIndex = 0;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdEstate);
            this.groupBox2.Controls.Add(this.rdCoupe);
            this.groupBox2.Controls.Add(this.rdConvertible);
            this.groupBox2.Controls.Add(this.rdSUV);
            this.groupBox2.Controls.Add(this.rdMPV);
            this.groupBox2.Controls.Add(this.rdHatchBack);
            this.groupBox2.Controls.Add(this.rdSaloon);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 122);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Body Tpe";
            // 
            // rdEstate
            // 
            this.rdEstate.AutoSize = true;
            this.rdEstate.Location = new System.Drawing.Point(7, 95);
            this.rdEstate.Name = "rdEstate";
            this.rdEstate.Size = new System.Drawing.Size(70, 20);
            this.rdEstate.TabIndex = 6;
            this.rdEstate.TabStop = true;
            this.rdEstate.Text = "Estate";
            this.rdEstate.UseVisualStyleBackColor = true;
            // 
            // rdCoupe
            // 
            this.rdCoupe.AutoSize = true;
            this.rdCoupe.Location = new System.Drawing.Point(112, 74);
            this.rdCoupe.Name = "rdCoupe";
            this.rdCoupe.Size = new System.Drawing.Size(71, 20);
            this.rdCoupe.TabIndex = 5;
            this.rdCoupe.TabStop = true;
            this.rdCoupe.Text = "Coupe";
            this.rdCoupe.UseVisualStyleBackColor = true;
            // 
            // rdConvertible
            // 
            this.rdConvertible.AutoSize = true;
            this.rdConvertible.Location = new System.Drawing.Point(7, 74);
            this.rdConvertible.Name = "rdConvertible";
            this.rdConvertible.Size = new System.Drawing.Size(105, 20);
            this.rdConvertible.TabIndex = 4;
            this.rdConvertible.TabStop = true;
            this.rdConvertible.Text = "Convertible";
            this.rdConvertible.UseVisualStyleBackColor = true;
            // 
            // rdSUV
            // 
            this.rdSUV.AutoSize = true;
            this.rdSUV.Location = new System.Drawing.Point(112, 48);
            this.rdSUV.Name = "rdSUV";
            this.rdSUV.Size = new System.Drawing.Size(57, 20);
            this.rdSUV.TabIndex = 3;
            this.rdSUV.TabStop = true;
            this.rdSUV.Text = "SUV";
            this.rdSUV.UseVisualStyleBackColor = true;
            // 
            // rdMPV
            // 
            this.rdMPV.AutoSize = true;
            this.rdMPV.Location = new System.Drawing.Point(8, 48);
            this.rdMPV.Name = "rdMPV";
            this.rdMPV.Size = new System.Drawing.Size(58, 20);
            this.rdMPV.TabIndex = 2;
            this.rdMPV.TabStop = true;
            this.rdMPV.Text = "MPV";
            this.rdMPV.UseVisualStyleBackColor = true;
            // 
            // rdHatchBack
            // 
            this.rdHatchBack.AutoSize = true;
            this.rdHatchBack.Location = new System.Drawing.Point(112, 22);
            this.rdHatchBack.Name = "rdHatchBack";
            this.rdHatchBack.Size = new System.Drawing.Size(100, 20);
            this.rdHatchBack.TabIndex = 1;
            this.rdHatchBack.TabStop = true;
            this.rdHatchBack.Text = "Hatchback";
            this.rdHatchBack.UseVisualStyleBackColor = true;
            // 
            // rdSaloon
            // 
            this.rdSaloon.AutoSize = true;
            this.rdSaloon.Location = new System.Drawing.Point(7, 22);
            this.rdSaloon.Name = "rdSaloon";
            this.rdSaloon.Size = new System.Drawing.Size(75, 20);
            this.rdSaloon.TabIndex = 0;
            this.rdSaloon.TabStop = true;
            this.rdSaloon.Text = "Saloon";
            this.rdSaloon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMiles);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtYear);
            this.groupBox1.Controls.Add(this.txtModel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBrand);
            this.groupBox1.Controls.Add(this.Brand);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(250, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 133);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Characreristics";
            // 
            // txtMiles
            // 
            this.txtMiles.Location = new System.Drawing.Point(86, 106);
            this.txtMiles.Name = "txtMiles";
            this.txtMiles.Size = new System.Drawing.Size(100, 22);
            this.txtMiles.TabIndex = 9;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(222, 76);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(75, 22);
            this.txtPrice.TabIndex = 8;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(86, 78);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(75, 22);
            this.txtYear.TabIndex = 7;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(86, 50);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 22);
            this.txtModel.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Miles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model";
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(86, 22);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(100, 22);
            this.txtBrand.TabIndex = 1;
            // 
            // Brand
            // 
            this.Brand.AutoSize = true;
            this.Brand.Location = new System.Drawing.Point(10, 25);
            this.Brand.Name = "Brand";
            this.Brand.Size = new System.Drawing.Size(49, 16);
            this.Brand.TabIndex = 0;
            this.Brand.Text = "Brand";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(158, 482);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(293, 453);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(129, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "Next Car";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.SteelBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(158, 453);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(129, 23);
            this.button5.TabIndex = 17;
            this.button5.Text = "Previous Car";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(293, 482);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 23);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(51, 232);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(129, 23);
            this.btnBrowse.TabIndex = 20;
            this.btnBrowse.Text = "Browse Image";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(578, 40);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDatabaseToolStripMenuItem,
            this.saveDatabaseToolStripMenuItem,
            this.saveDatabaseAsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fIleToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.Documents_icon;
            this.fIleToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(74, 36);
            this.fIleToolStripMenuItem.Text = "FIle";
            // 
            // openDatabaseToolStripMenuItem
            // 
            this.openDatabaseToolStripMenuItem.Name = "openDatabaseToolStripMenuItem";
            this.openDatabaseToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.openDatabaseToolStripMenuItem.Text = "Open Database";
            // 
            // saveDatabaseToolStripMenuItem
            // 
            this.saveDatabaseToolStripMenuItem.Name = "saveDatabaseToolStripMenuItem";
            this.saveDatabaseToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveDatabaseToolStripMenuItem.Text = "Save Database";
            // 
            // saveDatabaseAsToolStripMenuItem
            // 
            this.saveDatabaseAsToolStripMenuItem.Name = "saveDatabaseAsToolStripMenuItem";
            this.saveDatabaseAsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.saveDatabaseAsToolStripMenuItem.Text = "Save Database As";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCarToolStripMenuItem,
            this.updateDeleteNewCarToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.Folder_Links_icon;
            this.editToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(76, 36);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // addNewCarToolStripMenuItem
            // 
            this.addNewCarToolStripMenuItem.Enabled = false;
            this.addNewCarToolStripMenuItem.Name = "addNewCarToolStripMenuItem";
            this.addNewCarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.addNewCarToolStripMenuItem.Text = "Add New Car";
            // 
            // updateDeleteNewCarToolStripMenuItem
            // 
            this.updateDeleteNewCarToolStripMenuItem.Name = "updateDeleteNewCarToolStripMenuItem";
            this.updateDeleteNewCarToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.updateDeleteNewCarToolStripMenuItem.Text = "Update/Delete New Car";
            this.updateDeleteNewCarToolStripMenuItem.Click += new System.EventHandler(this.updateDeleteNewCarToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortByToolStripMenuItem,
            this.selectYearBrandToolStripMenuItem});
            this.viewToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.Search_icon;
            this.viewToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(82, 36);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // sortByToolStripMenuItem
            // 
            this.sortByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearToolStripMenuItem,
            this.brandToolStripMenuItem,
            this.priceToolStripMenuItem});
            this.sortByToolStripMenuItem.Name = "sortByToolStripMenuItem";
            this.sortByToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.sortByToolStripMenuItem.Text = "Sort By";
            // 
            // yearToolStripMenuItem
            // 
            this.yearToolStripMenuItem.Name = "yearToolStripMenuItem";
            this.yearToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.yearToolStripMenuItem.Text = "Year";
            // 
            // brandToolStripMenuItem
            // 
            this.brandToolStripMenuItem.Name = "brandToolStripMenuItem";
            this.brandToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.brandToolStripMenuItem.Text = "Brand";
            // 
            // priceToolStripMenuItem
            // 
            this.priceToolStripMenuItem.Name = "priceToolStripMenuItem";
            this.priceToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.priceToolStripMenuItem.Text = "Price";
            // 
            // selectYearBrandToolStripMenuItem
            // 
            this.selectYearBrandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearToolStripMenuItem1,
            this.brandToolStripMenuItem1});
            this.selectYearBrandToolStripMenuItem.Name = "selectYearBrandToolStripMenuItem";
            this.selectYearBrandToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.selectYearBrandToolStripMenuItem.Text = "Select Year Brand";
            // 
            // yearToolStripMenuItem1
            // 
            this.yearToolStripMenuItem1.Name = "yearToolStripMenuItem1";
            this.yearToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.yearToolStripMenuItem1.Text = "Year";
            // 
            // brandToolStripMenuItem1
            // 
            this.brandToolStripMenuItem1.Name = "brandToolStripMenuItem1";
            this.brandToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.brandToolStripMenuItem1.Text = "Brand";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem1,
            this.abouToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::WindowsFormsApplication1.Properties.Resources.Apps_Help_icon;
            this.helpToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(81, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewToolStripMenuItem1
            // 
            this.viewToolStripMenuItem1.Name = "viewToolStripMenuItem1";
            this.viewToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.viewToolStripMenuItem1.Text = "View Help";
            // 
            // abouToolStripMenuItem
            // 
            this.abouToolStripMenuItem.Name = "abouToolStripMenuItem";
            this.abouToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.abouToolStripMenuItem.Text = "About";
            // 
            // carImage
            // 
            this.carImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.carImage.Location = new System.Drawing.Point(11, 43);
            this.carImage.Name = "carImage";
            this.carImage.Size = new System.Drawing.Size(222, 183);
            this.carImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.carImage.TabIndex = 8;
            this.carImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmAddCar
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(578, 514);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.carImage);
            this.Name = "frmAddCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Manager - Add Car";
            this.Load += new System.EventHandler(this.frmAddCar_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox carImage;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label Brand;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMiles;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.RadioButton rdEstate;
        private System.Windows.Forms.RadioButton rdCoupe;
        private System.Windows.Forms.RadioButton rdConvertible;
        private System.Windows.Forms.RadioButton rdSUV;
        private System.Windows.Forms.RadioButton rdMPV;
        private System.Windows.Forms.RadioButton rdHatchBack;
        private System.Windows.Forms.RadioButton rdSaloon;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDatabaseAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeleteNewCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem priceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectYearBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem brandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem abouToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnClearInformation;
        private System.Windows.Forms.TextBox txtInfoAdd;
        private System.Windows.Forms.Button btnInformationAdd;
        private System.Windows.Forms.ListView lsInformation;
        private System.Windows.Forms.Label lblMultidate;
    }
}