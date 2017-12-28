namespace WSB_Restaurant
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnIceCreams = new System.Windows.Forms.Button();
            this.btnDrinks = new System.Windows.Forms.Button();
            this.btnFries = new System.Windows.Forms.Button();
            this.btnBurgers = new System.Windows.Forms.Button();
            this.btnBoxes = new System.Windows.Forms.Button();
            this.bntHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.frenchFriesUserControl1 = new WSB_Restaurant.Control.frenchFriesUserControl();
            this.burgerUserControl1 = new WSB_Restaurant.BurgerUserControl();
            this.boxesUserControl1 = new WSB_Restaurant.BoxesUserControl();
            this.honeUserControl1 = new WSB_Restaurant.HomeUserControl();
            this.iceCreamUserControl1 = new WSB_Restaurant.Control.IceCreamUserControl();
            this.drinksUserControl11 = new WSB_Restaurant.Control.DrinksUserControl1();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.btnPayment);
            this.panel1.Controls.Add(this.btnIceCreams);
            this.panel1.Controls.Add(this.btnDrinks);
            this.panel1.Controls.Add(this.btnFries);
            this.panel1.Controls.Add(this.btnBurgers);
            this.panel1.Controls.Add(this.btnBoxes);
            this.panel1.Controls.Add(this.bntHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 748);
            this.panel1.TabIndex = 0;
            // 
            // btnPayment
            // 
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.Location = new System.Drawing.Point(0, 648);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(194, 78);
            this.btnPayment.TabIndex = 8;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.BtnPayment_Click);
            // 
            // btnIceCreams
            // 
            this.btnIceCreams.FlatAppearance.BorderSize = 0;
            this.btnIceCreams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIceCreams.Image = ((System.Drawing.Image)(resources.GetObject("btnIceCreams.Image")));
            this.btnIceCreams.Location = new System.Drawing.Point(0, 564);
            this.btnIceCreams.Name = "btnIceCreams";
            this.btnIceCreams.Size = new System.Drawing.Size(194, 78);
            this.btnIceCreams.TabIndex = 7;
            this.btnIceCreams.UseVisualStyleBackColor = true;
            this.btnIceCreams.Click += new System.EventHandler(this.BtnIceCreams_Click);
            // 
            // btnDrinks
            // 
            this.btnDrinks.FlatAppearance.BorderSize = 0;
            this.btnDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDrinks.Image = ((System.Drawing.Image)(resources.GetObject("btnDrinks.Image")));
            this.btnDrinks.Location = new System.Drawing.Point(0, 480);
            this.btnDrinks.Name = "btnDrinks";
            this.btnDrinks.Size = new System.Drawing.Size(194, 78);
            this.btnDrinks.TabIndex = 6;
            this.btnDrinks.UseVisualStyleBackColor = true;
            this.btnDrinks.Click += new System.EventHandler(this.BtnDrinks_Click);
            // 
            // btnFries
            // 
            this.btnFries.FlatAppearance.BorderSize = 0;
            this.btnFries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFries.Image = ((System.Drawing.Image)(resources.GetObject("btnFries.Image")));
            this.btnFries.Location = new System.Drawing.Point(0, 396);
            this.btnFries.Name = "btnFries";
            this.btnFries.Size = new System.Drawing.Size(194, 78);
            this.btnFries.TabIndex = 5;
            this.btnFries.Text = "\r\n";
            this.btnFries.UseVisualStyleBackColor = true;
            this.btnFries.Click += new System.EventHandler(this.BtnFries_Click);
            // 
            // btnBurgers
            // 
            this.btnBurgers.FlatAppearance.BorderSize = 0;
            this.btnBurgers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurgers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurgers.Image = ((System.Drawing.Image)(resources.GetObject("btnBurgers.Image")));
            this.btnBurgers.Location = new System.Drawing.Point(0, 312);
            this.btnBurgers.Name = "btnBurgers";
            this.btnBurgers.Size = new System.Drawing.Size(194, 78);
            this.btnBurgers.TabIndex = 5;
            this.btnBurgers.UseVisualStyleBackColor = true;
            this.btnBurgers.Click += new System.EventHandler(this.BtnBurgers_Click);
            // 
            // btnBoxes
            // 
            this.btnBoxes.FlatAppearance.BorderSize = 0;
            this.btnBoxes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoxes.Image = ((System.Drawing.Image)(resources.GetObject("btnBoxes.Image")));
            this.btnBoxes.Location = new System.Drawing.Point(0, 227);
            this.btnBoxes.Name = "btnBoxes";
            this.btnBoxes.Size = new System.Drawing.Size(194, 78);
            this.btnBoxes.TabIndex = 4;
            this.btnBoxes.UseVisualStyleBackColor = true;
            this.btnBoxes.Click += new System.EventHandler(this.BtnBoxes_Click);
            // 
            // bntHome
            // 
            this.bntHome.FlatAppearance.BorderSize = 0;
            this.bntHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntHome.Image = ((System.Drawing.Image)(resources.GetObject("bntHome.Image")));
            this.bntHome.Location = new System.Drawing.Point(0, 143);
            this.bntHome.Name = "bntHome";
            this.bntHome.Size = new System.Drawing.Size(194, 78);
            this.bntHome.TabIndex = 3;
            this.bntHome.UseVisualStyleBackColor = true;
            this.bntHome.Click += new System.EventHandler(this.BntHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(617, 33);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(229, 1);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(152, 150);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "MC Danald";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 143);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 79);
            this.SidePanel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(384, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "The fastest fast food restaurant in the world!";
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Black;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(742, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 35);
            this.button8.TabIndex = 10;
            this.button8.Text = "v";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(706, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "v";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(229, 227);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(555, 442);
            this.dataGridView1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(532, 688);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 48);
            this.button3.TabIndex = 15;
            this.button3.Text = "Accept";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.button2.Location = new System.Drawing.Point(325, 688);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 48);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancle order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // frenchFriesUserControl1
            // 
            this.frenchFriesUserControl1.ForeColor = System.Drawing.Color.Black;
            this.frenchFriesUserControl1.Location = new System.Drawing.Point(200, 154);
            this.frenchFriesUserControl1.Name = "frenchFriesUserControl1";
            this.frenchFriesUserControl1.Size = new System.Drawing.Size(617, 594);
            this.frenchFriesUserControl1.TabIndex = 9;
            // 
            // burgerUserControl1
            // 
            this.burgerUserControl1.ForeColor = System.Drawing.Color.Black;
            this.burgerUserControl1.Location = new System.Drawing.Point(200, 154);
            this.burgerUserControl1.Name = "burgerUserControl1";
            this.burgerUserControl1.Size = new System.Drawing.Size(617, 594);
            this.burgerUserControl1.TabIndex = 9;
            // 
            // boxesUserControl1
            // 
            this.boxesUserControl1.BackColor = System.Drawing.SystemColors.Control;
            this.boxesUserControl1.ForeColor = System.Drawing.Color.Black;
            this.boxesUserControl1.Location = new System.Drawing.Point(200, 154);
            this.boxesUserControl1.Name = "boxesUserControl1";
            this.boxesUserControl1.Size = new System.Drawing.Size(617, 594);
            this.boxesUserControl1.TabIndex = 12;
            // 
            // honeUserControl1
            // 
            this.honeUserControl1.Location = new System.Drawing.Point(200, 154);
            this.honeUserControl1.Name = "honeUserControl1";
            this.honeUserControl1.Size = new System.Drawing.Size(617, 594);
            this.honeUserControl1.TabIndex = 11;
            // 
            // iceCreamUserControl1
            // 
            this.iceCreamUserControl1.ForeColor = System.Drawing.Color.Black;
            this.iceCreamUserControl1.Location = new System.Drawing.Point(200, 161);
            this.iceCreamUserControl1.Name = "iceCreamUserControl1";
            this.iceCreamUserControl1.Size = new System.Drawing.Size(617, 584);
            this.iceCreamUserControl1.TabIndex = 9;
            // 
            // drinksUserControl11
            // 
            this.drinksUserControl11.ForeColor = System.Drawing.Color.Black;
            this.drinksUserControl11.Location = new System.Drawing.Point(200, 154);
            this.drinksUserControl11.Name = "drinksUserControl11";
            this.drinksUserControl11.Size = new System.Drawing.Size(617, 594);
            this.drinksUserControl11.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 748);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.frenchFriesUserControl1);
            this.Controls.Add(this.burgerUserControl1);
            this.Controls.Add(this.boxesUserControl1);
            this.Controls.Add(this.honeUserControl1);
            this.Controls.Add(this.iceCreamUserControl1);
            this.Controls.Add(this.drinksUserControl11);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnIceCreams;
        private System.Windows.Forms.Button btnDrinks;
        private System.Windows.Forms.Button btnFries;
        private System.Windows.Forms.Button btnBurgers;
        private System.Windows.Forms.Button btnBoxes;
        private System.Windows.Forms.Button bntHome;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button8;
        private HomeUserControl honeUserControl1;
        private BoxesUserControl boxesUserControl1;
        private BurgerUserControl burgerUserControl1;
        private Control.frenchFriesUserControl frenchFriesUserControl1;
        private Control.DrinksUserControl1 drinksUserControl11;
        private Control.IceCreamUserControl iceCreamUserControl1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

