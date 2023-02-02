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
            this.label1 = new System.Windows.Forms.Label();
            this.OkBT = new System.Windows.Forms.Button();
            this.NamingBox = new System.Windows.Forms.TextBox();
            this.GreenPuheLB = new System.Windows.Forms.Label();
            this.GreenEsittäytLB = new System.Windows.Forms.Label();
            this.MrGreenPB = new System.Windows.Forms.PictureBox();
            this.AloitusPaneli.SuspendLayout();
            this.NimenvalintaPaneli.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MrGreenPB)).BeginInit();
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
            this.StartBT.Text = "Astu sisään";
            this.StartBT.UseVisualStyleBackColor = false;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // NimenvalintaPaneli
            // 
            this.NimenvalintaPaneli.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.NimenvalintaPaneli.Controls.Add(this.label1);
            this.NimenvalintaPaneli.Controls.Add(this.OkBT);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(347, 132);
            this.label1.MaximumSize = new System.Drawing.Size(420, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // OkBT
            // 
            this.OkBT.BackColor = System.Drawing.Color.LightSeaGreen;
            this.OkBT.Enabled = false;
            this.OkBT.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OkBT.Location = new System.Drawing.Point(436, 309);
            this.OkBT.Name = "OkBT";
            this.OkBT.Size = new System.Drawing.Size(170, 80);
            this.OkBT.TabIndex = 4;
            this.OkBT.Text = "OK";
            this.OkBT.UseVisualStyleBackColor = false;
            this.OkBT.Click += new System.EventHandler(this.NimiBT_Click);
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
            // HautomoPeliForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NimenvalintaPaneli);
            this.Controls.Add(this.AloitusPaneli);
            this.Name = "HautomoPeliForm";
            this.Text = "Hautomo peli";
            this.AloitusPaneli.ResumeLayout(false);
            this.AloitusPaneli.PerformLayout();
            this.NimenvalintaPaneli.ResumeLayout(false);
            this.NimenvalintaPaneli.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MrGreenPB)).EndInit();
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
        private Label label1;
    }
}