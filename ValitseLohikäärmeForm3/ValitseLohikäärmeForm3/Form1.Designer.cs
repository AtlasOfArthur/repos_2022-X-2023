namespace ValitseLohikäärmeForm3
{
    partial class ValitseLohikaarmeesiForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AloitusLB = new System.Windows.Forms.Label();
            this.AloitaBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.mennaBT = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.BradGreensLB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OkBT = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TasaPanel = new System.Windows.Forms.Panel();
            this.PalaaBT4 = new System.Windows.Forms.Button();
            this.KuumaPanel = new System.Windows.Forms.Panel();
            this.PalaaBT3 = new System.Windows.Forms.Button();
            this.kylmaPanel = new System.Windows.Forms.Panel();
            this.PalaaBT2 = new System.Windows.Forms.Button();
            this.TuliPanel = new System.Windows.Forms.Panel();
            this.PalaaBT1 = new System.Windows.Forms.Button();
            this.TasaOviBT = new System.Windows.Forms.Button();
            this.KuumaOviBT = new System.Windows.Forms.Button();
            this.KylmaOviBT = new System.Windows.Forms.Button();
            this.TuliOviBT = new System.Windows.Forms.Button();
            this.AstuSisäänBT = new System.Windows.Forms.Button();
            this.HautomoLB = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.TasaPanel.SuspendLayout();
            this.KuumaPanel.SuspendLayout();
            this.kylmaPanel.SuspendLayout();
            this.TuliPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AloitusLB
            // 
            this.AloitusLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AloitusLB.AutoSize = true;
            this.AloitusLB.BackColor = System.Drawing.Color.Transparent;
            this.AloitusLB.Font = new System.Drawing.Font("Impact", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.AloitusLB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.AloitusLB.Location = new System.Drawing.Point(180, 185);
            this.AloitusLB.Name = "AloitusLB";
            this.AloitusLB.Size = new System.Drawing.Size(624, 45);
            this.AloitusLB.TabIndex = 0;
            this.AloitusLB.Text = "Tervetuloa valitsemaan lohikäärmettäsi";
            // 
            // AloitaBT
            // 
            this.AloitaBT.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.AloitaBT.ForeColor = System.Drawing.Color.DarkRed;
            this.AloitaBT.Image = global::ValitseLohikäärmeForm3.Properties.Resources.gothic_4746967_1280_frame;
            this.AloitaBT.Location = new System.Drawing.Point(398, 269);
            this.AloitaBT.Name = "AloitaBT";
            this.AloitaBT.Size = new System.Drawing.Size(233, 100);
            this.AloitaBT.TabIndex = 1;
            this.AloitaBT.Text = "Aloita";
            this.AloitaBT.UseVisualStyleBackColor = true;
            this.AloitaBT.Visible = false;
            this.AloitaBT.Click += new System.EventHandler(this.AloitaBT_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.mennaBT);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.BradGreensLB);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.OkBT);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 600);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // mennaBT
            // 
            this.mennaBT.BackColor = System.Drawing.Color.YellowGreen;
            this.mennaBT.Enabled = false;
            this.mennaBT.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mennaBT.Location = new System.Drawing.Point(547, 316);
            this.mennaBT.Name = "mennaBT";
            this.mennaBT.Size = new System.Drawing.Size(257, 50);
            this.mennaBT.TabIndex = 4;
            this.mennaBT.Text = "Eiköhän mennä!";
            this.mennaBT.UseVisualStyleBackColor = false;
            this.mennaBT.Visible = false;
            this.mennaBT.Click += new System.EventHandler(this.mennaBT_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameBox.Location = new System.Drawing.Point(561, 248);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(229, 34);
            this.NameBox.TabIndex = 3;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // BradGreensLB
            // 
            this.BradGreensLB.AutoSize = true;
            this.BradGreensLB.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BradGreensLB.Location = new System.Drawing.Point(454, 37);
            this.BradGreensLB.MaximumSize = new System.Drawing.Size(500, 500);
            this.BradGreensLB.Name = "BradGreensLB";
            this.BradGreensLB.Size = new System.Drawing.Size(437, 148);
            this.BradGreensLB.TabIndex = 2;
            this.BradGreensLB.Text = " Hei! Nimeni on Brad Greens. \n \nAntaisitko nimesi jotta tiedän ketä puhutella.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.man_7752637_1280_Greens2;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(3, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(363, 542);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // OkBT
            // 
            this.OkBT.BackColor = System.Drawing.Color.YellowGreen;
            this.OkBT.Enabled = false;
            this.OkBT.Font = new System.Drawing.Font("Impact", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OkBT.Location = new System.Drawing.Point(628, 316);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(100, 50);
            this.OkBT.TabIndex = 0;
            this.OkBT.Text = "OK";
            this.OkBT.UseVisualStyleBackColor = false;
            this.OkBT.Click += new System.EventHandler(this.OkBT_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.architecture_5544726_1280_hautomo;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.AstuSisäänBT);
            this.panel2.Controls.Add(this.HautomoLB);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 600);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources._4_Ovea_WoodFloor;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.TasaPanel);
            this.panel3.Controls.Add(this.KuumaPanel);
            this.panel3.Controls.Add(this.kylmaPanel);
            this.panel3.Controls.Add(this.TuliPanel);
            this.panel3.Controls.Add(this.TasaOviBT);
            this.panel3.Controls.Add(this.KuumaOviBT);
            this.panel3.Controls.Add(this.KylmaOviBT);
            this.panel3.Controls.Add(this.TuliOviBT);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1000, 600);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // TasaPanel
            // 
            this.TasaPanel.BackColor = System.Drawing.Color.Green;
            this.TasaPanel.Controls.Add(this.PalaaBT4);
            this.TasaPanel.Location = new System.Drawing.Point(0, 0);
            this.TasaPanel.Name = "TasaPanel";
            this.TasaPanel.Size = new System.Drawing.Size(1000, 600);
            this.TasaPanel.TabIndex = 7;
            this.TasaPanel.Visible = false;
            // 
            // PalaaBT4
            // 
            this.PalaaBT4.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.gothic_4746967_1280_frame;
            this.PalaaBT4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PalaaBT4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PalaaBT4.ForeColor = System.Drawing.Color.SeaShell;
            this.PalaaBT4.Location = new System.Drawing.Point(420, 500);
            this.PalaaBT4.Name = "PalaaBT4";
            this.PalaaBT4.Size = new System.Drawing.Size(160, 50);
            this.PalaaBT4.TabIndex = 1;
            this.PalaaBT4.Text = "Takaisin";
            this.PalaaBT4.UseVisualStyleBackColor = true;
            this.PalaaBT4.Click += new System.EventHandler(this.PalaaBT4_Click);
            // 
            // KuumaPanel
            // 
            this.KuumaPanel.BackColor = System.Drawing.Color.SandyBrown;
            this.KuumaPanel.Controls.Add(this.PalaaBT3);
            this.KuumaPanel.Location = new System.Drawing.Point(0, 0);
            this.KuumaPanel.Name = "KuumaPanel";
            this.KuumaPanel.Size = new System.Drawing.Size(1000, 600);
            this.KuumaPanel.TabIndex = 6;
            this.KuumaPanel.Visible = false;
            // 
            // PalaaBT3
            // 
            this.PalaaBT3.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.gothic_4746967_1280_frame;
            this.PalaaBT3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PalaaBT3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PalaaBT3.ForeColor = System.Drawing.Color.SeaShell;
            this.PalaaBT3.Location = new System.Drawing.Point(420, 500);
            this.PalaaBT3.Name = "PalaaBT3";
            this.PalaaBT3.Size = new System.Drawing.Size(160, 50);
            this.PalaaBT3.TabIndex = 1;
            this.PalaaBT3.Text = "Takaisin";
            this.PalaaBT3.UseVisualStyleBackColor = true;
            this.PalaaBT3.Click += new System.EventHandler(this.PalaaBT3_Click);
            // 
            // kylmaPanel
            // 
            this.kylmaPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.kylmaPanel.Controls.Add(this.PalaaBT2);
            this.kylmaPanel.Location = new System.Drawing.Point(0, 0);
            this.kylmaPanel.Name = "kylmaPanel";
            this.kylmaPanel.Size = new System.Drawing.Size(1000, 600);
            this.kylmaPanel.TabIndex = 5;
            this.kylmaPanel.Visible = false;
            // 
            // PalaaBT2
            // 
            this.PalaaBT2.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.gothic_4746967_1280_frame;
            this.PalaaBT2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PalaaBT2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PalaaBT2.ForeColor = System.Drawing.Color.SeaShell;
            this.PalaaBT2.Location = new System.Drawing.Point(420, 500);
            this.PalaaBT2.Name = "PalaaBT2";
            this.PalaaBT2.Size = new System.Drawing.Size(160, 50);
            this.PalaaBT2.TabIndex = 1;
            this.PalaaBT2.Text = "Takaisin";
            this.PalaaBT2.UseVisualStyleBackColor = true;
            this.PalaaBT2.Click += new System.EventHandler(this.PalaaBT2_Click);
            // 
            // TuliPanel
            // 
            this.TuliPanel.BackColor = System.Drawing.Color.OrangeRed;
            this.TuliPanel.Controls.Add(this.PalaaBT1);
            this.TuliPanel.Location = new System.Drawing.Point(0, 0);
            this.TuliPanel.Name = "TuliPanel";
            this.TuliPanel.Size = new System.Drawing.Size(1000, 600);
            this.TuliPanel.TabIndex = 4;
            this.TuliPanel.Visible = false;
            // 
            // PalaaBT1
            // 
            this.PalaaBT1.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.gothic_4746967_1280_frame;
            this.PalaaBT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PalaaBT1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PalaaBT1.ForeColor = System.Drawing.Color.SeaShell;
            this.PalaaBT1.Location = new System.Drawing.Point(420, 500);
            this.PalaaBT1.Name = "PalaaBT1";
            this.PalaaBT1.Size = new System.Drawing.Size(160, 50);
            this.PalaaBT1.TabIndex = 0;
            this.PalaaBT1.Text = "Takaisin";
            this.PalaaBT1.UseVisualStyleBackColor = true;
            this.PalaaBT1.Click += new System.EventHandler(this.PalaaBT1_Click);
            // 
            // TasaOviBT
            // 
            this.TasaOviBT.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.Tasalämpöiset_Ovi;
            this.TasaOviBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TasaOviBT.Location = new System.Drawing.Point(782, 185);
            this.TasaOviBT.Name = "TasaOviBT";
            this.TasaOviBT.Size = new System.Drawing.Size(168, 264);
            this.TasaOviBT.TabIndex = 3;
            this.TasaOviBT.UseVisualStyleBackColor = true;
            this.TasaOviBT.Click += new System.EventHandler(this.TasaOviBT_Click);
            // 
            // KuumaOviBT
            // 
            this.KuumaOviBT.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.Kuumakallet_Ovi;
            this.KuumaOviBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KuumaOviBT.Location = new System.Drawing.Point(537, 185);
            this.KuumaOviBT.Name = "KuumaOviBT";
            this.KuumaOviBT.Size = new System.Drawing.Size(168, 264);
            this.KuumaOviBT.TabIndex = 2;
            this.KuumaOviBT.UseVisualStyleBackColor = true;
            this.KuumaOviBT.Click += new System.EventHandler(this.KuumaOviBT_Click);
            // 
            // KylmaOviBT
            // 
            this.KylmaOviBT.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.Kylmäveriset_Ovi;
            this.KylmaOviBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KylmaOviBT.Location = new System.Drawing.Point(292, 185);
            this.KylmaOviBT.Name = "KylmaOviBT";
            this.KylmaOviBT.Size = new System.Drawing.Size(168, 264);
            this.KylmaOviBT.TabIndex = 1;
            this.KylmaOviBT.UseVisualStyleBackColor = true;
            this.KylmaOviBT.Click += new System.EventHandler(this.KylmaOviBT_Click);
            // 
            // TuliOviBT
            // 
            this.TuliOviBT.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.Tulisielut_Ovi;
            this.TuliOviBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TuliOviBT.Location = new System.Drawing.Point(47, 185);
            this.TuliOviBT.Name = "TuliOviBT";
            this.TuliOviBT.Size = new System.Drawing.Size(168, 264);
            this.TuliOviBT.TabIndex = 0;
            this.TuliOviBT.UseVisualStyleBackColor = true;
            this.TuliOviBT.Click += new System.EventHandler(this.TuliOviBT_Click);
            // 
            // AstuSisäänBT
            // 
            this.AstuSisäänBT.BackColor = System.Drawing.Color.PowderBlue;
            this.AstuSisäänBT.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AstuSisäänBT.Location = new System.Drawing.Point(400, 470);
            this.AstuSisäänBT.Name = "AstuSisäänBT";
            this.AstuSisäänBT.Size = new System.Drawing.Size(200, 80);
            this.AstuSisäänBT.TabIndex = 1;
            this.AstuSisäänBT.Text = "Astu sisään";
            this.AstuSisäänBT.UseVisualStyleBackColor = false;
            this.AstuSisäänBT.Click += new System.EventHandler(this.AstuSisäänBT_Click);
            // 
            // HautomoLB
            // 
            this.HautomoLB.AutoSize = true;
            this.HautomoLB.BackColor = System.Drawing.Color.Transparent;
            this.HautomoLB.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HautomoLB.Location = new System.Drawing.Point(124, 9);
            this.HautomoLB.Name = "HautomoLB";
            this.HautomoLB.Size = new System.Drawing.Size(726, 105);
            this.HautomoLB.TabIndex = 0;
            this.HautomoLB.Text = "        Tässä on hautomo, eli kasvatti lohikäärmeidemme pesä.\nTäällä kasvatamme j" +
    "opa kymmentä erilaista lohikäärme rotua.\n                                     Si" +
    "nulla on siis mistä valita";
            // 
            // ValitseLohikaarmeesiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::ValitseLohikäärmeForm3.Properties.Resources.gothic_4746967_1280_frame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AloitaBT);
            this.Controls.Add(this.AloitusLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.Name = "ValitseLohikaarmeesiForm";
            this.Text = "Valitse Lohikäärmeesi";
            this.Load += new System.EventHandler(this.ValitseLohikaarmeesiForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.TasaPanel.ResumeLayout(false);
            this.KuumaPanel.ResumeLayout(false);
            this.kylmaPanel.ResumeLayout(false);
            this.TuliPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label AloitusLB;
        private Button AloitaBT;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Button OkBT;
        private TextBox NameBox;
        private Label BradGreensLB;
        private PictureBox pictureBox1;
        private Button mennaBT;
        private Panel panel2;
        private Label HautomoLB;
        private Button AstuSisäänBT;
        private Panel panel3;
        private Button TasaOviBT;
        private Button KuumaOviBT;
        private Button KylmaOviBT;
        private Button TuliOviBT;
        private Panel TasaPanel;
        private Panel KuumaPanel;
        private Panel kylmaPanel;
        private Panel TuliPanel;
        private Button PalaaBT4;
        private Button PalaaBT3;
        private Button PalaaBT2;
        private Button PalaaBT1;
    }
}