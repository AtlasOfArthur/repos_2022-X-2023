namespace ValitseLohikäärmeForm
{
    partial class HautomoPeliForm
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
            this.AloitusPaneli = new System.Windows.Forms.Panel();
            this.AloitusLB1 = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.NimenvalintaPaneli = new System.Windows.Forms.Panel();
            this.OkBT = new System.Windows.Forms.Button();
            this.EikohanMennaBT = new System.Windows.Forms.Button();
            this.NamingBox = new System.Windows.Forms.TextBox();
            this.GreenPuheLB = new System.Windows.Forms.Label();
            this.GreenEsittäytLB = new System.Windows.Forms.Label();
            this.MrGreenPB = new System.Windows.Forms.PictureBox();
            this.HautomoTaloPaneli = new System.Windows.Forms.Panel();
            this.OnValitaBT = new System.Windows.Forms.Button();
            this.TassaOnHautomoLB = new System.Windows.Forms.Label();
            this.BT1 = new System.Windows.Forms.Button();
            this.BT2 = new System.Windows.Forms.Button();
            this.BT4 = new System.Windows.Forms.Button();
            this.BT3 = new System.Windows.Forms.Button();
            this.AloitusPaneli.SuspendLayout();
            this.NimenvalintaPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MrGreenPB)).BeginInit();
            this.HautomoTaloPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // AloitusPaneli
            // 
            this.AloitusPaneli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AloitusPaneli.Controls.Add(this.AloitusLB1);
            this.AloitusPaneli.Controls.Add(this.StartBT);
            this.AloitusPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AloitusPaneli.Location = new System.Drawing.Point(0, 0);
            this.AloitusPaneli.Name = "AloitusPaneli";
            this.AloitusPaneli.Size = new System.Drawing.Size(800, 450);
            this.AloitusPaneli.TabIndex = 0;
            // 
            // AloitusLB1
            // 
            this.AloitusLB1.AutoSize = true;
            this.AloitusLB1.Font = new System.Drawing.Font("Magneto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AloitusLB1.ForeColor = System.Drawing.Color.DarkOrange;
            this.AloitusLB1.Location = new System.Drawing.Point(216, 96);
            this.AloitusLB1.Name = "AloitusLB1";
            this.AloitusLB1.Size = new System.Drawing.Size(379, 36);
            this.AloitusLB1.TabIndex = 1;
            this.AloitusLB1.Text = "Tervetuloa hautomoon!";
            // 
            // StartBT
            // 
            this.StartBT.BackColor = System.Drawing.Color.Teal;
            this.StartBT.Font = new System.Drawing.Font("Magneto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StartBT.ForeColor = System.Drawing.Color.Orange;
            this.StartBT.Location = new System.Drawing.Point(289, 238);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(222, 75);
            this.StartBT.TabIndex = 0;
            this.StartBT.Text = "Lähde matkaan";
            this.StartBT.UseVisualStyleBackColor = false;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // NimenvalintaPaneli
            // 
            this.NimenvalintaPaneli.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.NimenvalintaPaneli.Controls.Add(this.AloitusPaneli);
            this.NimenvalintaPaneli.Controls.Add(this.OkBT);
            this.NimenvalintaPaneli.Controls.Add(this.EikohanMennaBT);
            this.NimenvalintaPaneli.Controls.Add(this.NamingBox);
            this.NimenvalintaPaneli.Controls.Add(this.GreenPuheLB);
            this.NimenvalintaPaneli.Controls.Add(this.GreenEsittäytLB);
            this.NimenvalintaPaneli.Controls.Add(this.MrGreenPB);
            this.NimenvalintaPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NimenvalintaPaneli.Location = new System.Drawing.Point(0, 0);
            this.NimenvalintaPaneli.Name = "NimenvalintaPaneli";
            this.NimenvalintaPaneli.Size = new System.Drawing.Size(800, 450);
            this.NimenvalintaPaneli.TabIndex = 1;
            this.NimenvalintaPaneli.Visible = false;
            // 
            // OkBT
            // 
            this.OkBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OkBT.Enabled = false;
            this.OkBT.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OkBT.Location = new System.Drawing.Point(436, 238);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(170, 47);
            this.OkBT.TabIndex = 4;
            this.OkBT.Text = "OK";
            this.OkBT.UseVisualStyleBackColor = false;
            this.OkBT.Click += new System.EventHandler(this.NimiBT_Click);
            // 
            // EikohanMennaBT
            // 
            this.EikohanMennaBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.EikohanMennaBT.Enabled = false;
            this.EikohanMennaBT.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EikohanMennaBT.Location = new System.Drawing.Point(436, 309);
            this.EikohanMennaBT.Name = "EikohanMennaBT";
            this.EikohanMennaBT.Size = new System.Drawing.Size(170, 80);
            this.EikohanMennaBT.TabIndex = 5;
            this.EikohanMennaBT.Text = "Eiköhän mennä !";
            this.EikohanMennaBT.UseVisualStyleBackColor = false;
            this.EikohanMennaBT.Visible = false;
            this.EikohanMennaBT.Click += new System.EventHandler(this.EikohanMennaBT_Click);
            // 
            // NamingBox
            // 
            this.NamingBox.BackColor = System.Drawing.Color.Linen;
            this.NamingBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NamingBox.Location = new System.Drawing.Point(571, 96);
            this.NamingBox.Name = "NamingBox";
            this.NamingBox.Size = new System.Drawing.Size(167, 38);
            this.NamingBox.TabIndex = 3;
            this.NamingBox.TextChanged += new System.EventHandler(this.NamingBox_TextChanged);
            // 
            // GreenPuheLB
            // 
            this.GreenPuheLB.AutoSize = true;
            this.GreenPuheLB.Font = new System.Drawing.Font("Magneto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GreenPuheLB.Location = new System.Drawing.Point(347, 103);
            this.GreenPuheLB.MaximumSize = new System.Drawing.Size(430, 430);
            this.GreenPuheLB.Name = "GreenPuheLB";
            this.GreenPuheLB.Size = new System.Drawing.Size(218, 28);
            this.GreenPuheLB.TabIndex = 2;
            this.GreenPuheLB.Text = "Mikä on nimesi?";
            this.GreenPuheLB.UseWaitCursor = true;
            // 
            // GreenEsittäytLB
            // 
            this.GreenEsittäytLB.AutoSize = true;
            this.GreenEsittäytLB.Font = new System.Drawing.Font("Magneto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GreenEsittäytLB.Location = new System.Drawing.Point(347, 41);
            this.GreenEsittäytLB.Name = "GreenEsittäytLB";
            this.GreenEsittäytLB.Size = new System.Drawing.Size(359, 28);
            this.GreenEsittäytLB.TabIndex = 1;
            this.GreenEsittäytLB.Text = "Hei nimeni on Brad Greens";
            this.GreenEsittäytLB.UseWaitCursor = true;
            // 
            // MrGreenPB
            // 
            this.MrGreenPB.BackgroundImage = global::ValitseLohikäärmeForm.Properties.Resources.man_7752637_1280_Greens2;
            this.MrGreenPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MrGreenPB.Location = new System.Drawing.Point(37, 41);
            this.MrGreenPB.Name = "MrGreenPB";
            this.MrGreenPB.Size = new System.Drawing.Size(223, 348);
            this.MrGreenPB.TabIndex = 0;
            this.MrGreenPB.TabStop = false;
            // 
            // HautomoTaloPaneli
            // 
            this.HautomoTaloPaneli.BackgroundImage = global::ValitseLohikäärmeForm.Properties.Resources.architecture_5544726_1280_hautomo;
            this.HautomoTaloPaneli.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HautomoTaloPaneli.Controls.Add(this.NimenvalintaPaneli);
            this.HautomoTaloPaneli.Controls.Add(this.OnValitaBT);
            this.HautomoTaloPaneli.Controls.Add(this.TassaOnHautomoLB);
            this.HautomoTaloPaneli.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HautomoTaloPaneli.Location = new System.Drawing.Point(0, 0);
            this.HautomoTaloPaneli.Name = "HautomoTaloPaneli";
            this.HautomoTaloPaneli.Size = new System.Drawing.Size(800, 450);
            this.HautomoTaloPaneli.TabIndex = 8;
            this.HautomoTaloPaneli.Visible = false;
            // 
            // OnValitaBT
            // 
            this.OnValitaBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OnValitaBT.Enabled = false;
            this.OnValitaBT.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OnValitaBT.Location = new System.Drawing.Point(156, 368);
            this.OnValitaBT.Name = "OnValitaBT";
            this.OnValitaBT.Size = new System.Drawing.Size(489, 36);
            this.OnValitaBT.TabIndex = 8;
            this.OnValitaBT.Text = "Minulla on siis mistä valita";
            this.OnValitaBT.UseVisualStyleBackColor = false;
            this.OnValitaBT.Click += new System.EventHandler(this.OnValitaBT_Click);
            // 
            // TassaOnHautomoLB
            // 
            this.TassaOnHautomoLB.AutoSize = true;
            this.TassaOnHautomoLB.BackColor = System.Drawing.Color.Transparent;
            this.TassaOnHautomoLB.Font = new System.Drawing.Font("Magneto", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TassaOnHautomoLB.Location = new System.Drawing.Point(60, 27);
            this.TassaOnHautomoLB.MaximumSize = new System.Drawing.Size(700, 200);
            this.TassaOnHautomoLB.Name = "TassaOnHautomoLB";
            this.TassaOnHautomoLB.Size = new System.Drawing.Size(692, 56);
            this.TassaOnHautomoLB.TabIndex = 2;
            this.TassaOnHautomoLB.Text = "Tässä on hautomo. Täällä kasvatamme jopa kymmentä erilaista lohikäärme rotua.";
            // 
            // BT1
            // 
            this.BT1.BackColor = System.Drawing.Color.Transparent;
            this.BT1.BackgroundImage = global::ValitseLohikäärmeForm.Properties.Resources.Tulisielut_Ovi;
            this.BT1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT1.Location = new System.Drawing.Point(41, 139);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(125, 197);
            this.BT1.TabIndex = 9;
            this.BT1.UseVisualStyleBackColor = false;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // BT2
            // 
            this.BT2.BackColor = System.Drawing.Color.Transparent;
            this.BT2.BackgroundImage = global::ValitseLohikäärmeForm.Properties.Resources.Kylmäveriset_Ovi;
            this.BT2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT2.Location = new System.Drawing.Point(238, 139);
            this.BT2.Name = "BT2";
            this.BT2.Size = new System.Drawing.Size(125, 197);
            this.BT2.TabIndex = 10;
            this.BT2.UseVisualStyleBackColor = false;
            this.BT2.Click += new System.EventHandler(this.BT2_Click);
            // 
            // BT4
            // 
            this.BT4.BackColor = System.Drawing.Color.Transparent;
            this.BT4.BackgroundImage = global::ValitseLohikäärmeForm.Properties.Resources.Tasalämpöiset_Ovi;
            this.BT4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT4.Location = new System.Drawing.Point(631, 139);
            this.BT4.Name = "BT4";
            this.BT4.Size = new System.Drawing.Size(125, 197);
            this.BT4.TabIndex = 12;
            this.BT4.UseVisualStyleBackColor = false;
            this.BT4.Click += new System.EventHandler(this.BT4_Click);
            // 
            // BT3
            // 
            this.BT3.BackColor = System.Drawing.Color.Transparent;
            this.BT3.BackgroundImage = global::ValitseLohikäärmeForm.Properties.Resources.Kuumakallet_Ovi;
            this.BT3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT3.Location = new System.Drawing.Point(435, 139);
            this.BT3.Name = "BT3";
            this.BT3.Size = new System.Drawing.Size(125, 197);
            this.BT3.TabIndex = 11;
            this.BT3.UseVisualStyleBackColor = false;
            this.BT3.Click += new System.EventHandler(this.BT3_Click);
            // 
            // HautomoPeliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ValitseLohikäärmeForm.Properties.Resources._4_Ovea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HautomoTaloPaneli);
            this.Controls.Add(this.BT4);
            this.Controls.Add(this.BT3);
            this.Controls.Add(this.BT2);
            this.Controls.Add(this.BT1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HautomoPeliForm";
            this.Text = "Hautomo peli";
            this.AloitusPaneli.ResumeLayout(false);
            this.AloitusPaneli.PerformLayout();
            this.NimenvalintaPaneli.ResumeLayout(false);
            this.NimenvalintaPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MrGreenPB)).EndInit();
            this.HautomoTaloPaneli.ResumeLayout(false);
            this.HautomoTaloPaneli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel AloitusPaneli;
        private Label AloitusLB1;
        private Button StartBT;
        private Panel NimenvalintaPaneli;
        private Button OkBT;
        private TextBox NamingBox;
        private Label GreenPuheLB;
        private Label GreenEsittäytLB;
        private PictureBox MrGreenPB;
        private Panel HautomoTaloPaneli;
        private Button OnValitaBT;
        private Label TassaOnHautomoLB;
        private Button EikohanMennaBT;
        private Button BT1;
        private Button BT2;
        private Button BT4;
        private Button BT3;
    }
}