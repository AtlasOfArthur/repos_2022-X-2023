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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.mennaBT.Location = new System.Drawing.Point(558, 316);
            this.mennaBT.Name = "mennaBT";
            this.mennaBT.Size = new System.Drawing.Size(246, 50);
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
            this.BradGreensLB.Size = new System.Drawing.Size(442, 148);
            this.BradGreensLB.TabIndex = 2;
            this.BradGreensLB.Text = " Hei! Nimeni on Brad Greens. \n \n Antaisitko nimesi jotta tiedän ketä puhutella.";
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
            this.panel2.Location = new System.Drawing.Point(477, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 125);
            this.panel2.TabIndex = 5;
            this.panel2.Visible = false;
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
    }
}