namespace AutokuluKustannusForm
{
    partial class kustForm
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.LainaLB = new System.Windows.Forms.Label();
            this.VakuutusLB = new System.Windows.Forms.Label();
            this.NesteetLB = new System.Windows.Forms.Label();
            this.PolttoaineLB = new System.Windows.Forms.Label();
            this.HuollotLB = new System.Windows.Forms.Label();
            this.MuutLB = new System.Windows.Forms.Label();
            this.PesutLB = new System.Windows.Forms.Label();
            this.RenkaatLB = new System.Windows.Forms.Label();
            this.KmVuosiLB = new System.Windows.Forms.Label();
            this.lainaTB = new System.Windows.Forms.TextBox();
            this.nesteetTB = new System.Windows.Forms.TextBox();
            this.muutTB = new System.Windows.Forms.TextBox();
            this.vakuutusTB = new System.Windows.Forms.TextBox();
            this.pesuTB = new System.Windows.Forms.TextBox();
            this.huollotTB = new System.Windows.Forms.TextBox();
            this.polttoTB = new System.Windows.Forms.TextBox();
            this.renkaatTB = new System.Windows.Forms.TextBox();
            this.KMPVCB = new System.Windows.Forms.ComboBox();
            this.vastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Magneto", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.ForeColor = System.Drawing.Color.Orange;
            this.OtsikkoLB.Location = new System.Drawing.Point(251, 35);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(420, 36);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Auton kustannus laskuri";
            // 
            // LainaLB
            // 
            this.LainaLB.AutoSize = true;
            this.LainaLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LainaLB.ForeColor = System.Drawing.Color.Gold;
            this.LainaLB.Location = new System.Drawing.Point(15, 108);
            this.LainaLB.Name = "LainaLB";
            this.LainaLB.Size = new System.Drawing.Size(322, 25);
            this.LainaLB.TabIndex = 1;
            this.LainaLB.Text = "Lainan lyhennys korkoineen";
            // 
            // VakuutusLB
            // 
            this.VakuutusLB.AutoSize = true;
            this.VakuutusLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VakuutusLB.ForeColor = System.Drawing.Color.Gold;
            this.VakuutusLB.Location = new System.Drawing.Point(151, 143);
            this.VakuutusLB.Name = "VakuutusLB";
            this.VakuutusLB.Size = new System.Drawing.Size(186, 25);
            this.VakuutusLB.TabIndex = 2;
            this.VakuutusLB.Text = "Vakuutus masut";
            // 
            // NesteetLB
            // 
            this.NesteetLB.AutoSize = true;
            this.NesteetLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NesteetLB.ForeColor = System.Drawing.Color.Gold;
            this.NesteetLB.Location = new System.Drawing.Point(595, 108);
            this.NesteetLB.Name = "NesteetLB";
            this.NesteetLB.Size = new System.Drawing.Size(215, 25);
            this.NesteetLB.TabIndex = 3;
            this.NesteetLB.Text = "Lisättävät nesteet";
            // 
            // PolttoaineLB
            // 
            this.PolttoaineLB.AutoSize = true;
            this.PolttoaineLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PolttoaineLB.ForeColor = System.Drawing.Color.Gold;
            this.PolttoaineLB.Location = new System.Drawing.Point(595, 146);
            this.PolttoaineLB.Name = "PolttoaineLB";
            this.PolttoaineLB.Size = new System.Drawing.Size(122, 25);
            this.PolttoaineLB.TabIndex = 4;
            this.PolttoaineLB.Text = "Polttoaine";
            // 
            // HuollotLB
            // 
            this.HuollotLB.AutoSize = true;
            this.HuollotLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HuollotLB.ForeColor = System.Drawing.Color.Gold;
            this.HuollotLB.Location = new System.Drawing.Point(243, 213);
            this.HuollotLB.Name = "HuollotLB";
            this.HuollotLB.Size = new System.Drawing.Size(94, 25);
            this.HuollotLB.TabIndex = 5;
            this.HuollotLB.Text = "Huollot";
            // 
            // MuutLB
            // 
            this.MuutLB.AutoSize = true;
            this.MuutLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MuutLB.ForeColor = System.Drawing.Color.Gold;
            this.MuutLB.Location = new System.Drawing.Point(595, 209);
            this.MuutLB.Name = "MuutLB";
            this.MuutLB.Size = new System.Drawing.Size(133, 25);
            this.MuutLB.TabIndex = 9;
            this.MuutLB.Text = "Muut kulut";
            // 
            // PesutLB
            // 
            this.PesutLB.AutoSize = true;
            this.PesutLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PesutLB.ForeColor = System.Drawing.Color.Gold;
            this.PesutLB.Location = new System.Drawing.Point(595, 181);
            this.PesutLB.Name = "PesutLB";
            this.PesutLB.Size = new System.Drawing.Size(74, 25);
            this.PesutLB.TabIndex = 8;
            this.PesutLB.Text = "Pesut";
            // 
            // RenkaatLB
            // 
            this.RenkaatLB.AutoSize = true;
            this.RenkaatLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RenkaatLB.ForeColor = System.Drawing.Color.Gold;
            this.RenkaatLB.Location = new System.Drawing.Point(235, 178);
            this.RenkaatLB.Name = "RenkaatLB";
            this.RenkaatLB.Size = new System.Drawing.Size(102, 25);
            this.RenkaatLB.TabIndex = 7;
            this.RenkaatLB.Text = "Renkaat";
            // 
            // KmVuosiLB
            // 
            this.KmVuosiLB.AutoSize = true;
            this.KmVuosiLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KmVuosiLB.ForeColor = System.Drawing.Color.Gold;
            this.KmVuosiLB.Location = new System.Drawing.Point(136, 273);
            this.KmVuosiLB.Name = "KmVuosiLB";
            this.KmVuosiLB.Size = new System.Drawing.Size(201, 25);
            this.KmVuosiLB.TabIndex = 6;
            this.KmVuosiLB.Text = "Kilometrit / vuosi";
            // 
            // lainaTB
            // 
            this.lainaTB.Location = new System.Drawing.Point(343, 111);
            this.lainaTB.Name = "lainaTB";
            this.lainaTB.Size = new System.Drawing.Size(110, 27);
            this.lainaTB.TabIndex = 10;
            // 
            // nesteetTB
            // 
            this.nesteetTB.Location = new System.Drawing.Point(479, 111);
            this.nesteetTB.Name = "nesteetTB";
            this.nesteetTB.Size = new System.Drawing.Size(110, 27);
            this.nesteetTB.TabIndex = 11;
            // 
            // muutTB
            // 
            this.muutTB.Location = new System.Drawing.Point(479, 209);
            this.muutTB.Name = "muutTB";
            this.muutTB.Size = new System.Drawing.Size(110, 27);
            this.muutTB.TabIndex = 13;
            // 
            // vakuutusTB
            // 
            this.vakuutusTB.Location = new System.Drawing.Point(343, 143);
            this.vakuutusTB.Name = "vakuutusTB";
            this.vakuutusTB.Size = new System.Drawing.Size(110, 27);
            this.vakuutusTB.TabIndex = 12;
            // 
            // pesuTB
            // 
            this.pesuTB.Location = new System.Drawing.Point(479, 176);
            this.pesuTB.Name = "pesuTB";
            this.pesuTB.Size = new System.Drawing.Size(110, 27);
            this.pesuTB.TabIndex = 17;
            // 
            // huollotTB
            // 
            this.huollotTB.Location = new System.Drawing.Point(343, 208);
            this.huollotTB.Name = "huollotTB";
            this.huollotTB.Size = new System.Drawing.Size(110, 27);
            this.huollotTB.TabIndex = 16;
            // 
            // polttoTB
            // 
            this.polttoTB.Location = new System.Drawing.Point(479, 144);
            this.polttoTB.Name = "polttoTB";
            this.polttoTB.Size = new System.Drawing.Size(110, 27);
            this.polttoTB.TabIndex = 15;
            // 
            // renkaatTB
            // 
            this.renkaatTB.Location = new System.Drawing.Point(343, 176);
            this.renkaatTB.Name = "renkaatTB";
            this.renkaatTB.Size = new System.Drawing.Size(110, 27);
            this.renkaatTB.TabIndex = 14;
            // 
            // KMPVCB
            // 
            this.KMPVCB.FormattingEnabled = true;
            this.KMPVCB.Items.AddRange(new object[] {
            "5000",
            "10000",
            "15000",
            "20000",
            "25000",
            "30000",
            "35000",
            "40000",
            "45000",
            "50000",
            "55000",
            "60000",
            "65000",
            "70000",
            "75000",
            "80000",
            "85000",
            "90000",
            "100000",
            "110000",
            "120000",
            "130000",
            "140000",
            "150000",
            "160000",
            "170000",
            "180000",
            "190000",
            "200000"});
            this.KMPVCB.Location = new System.Drawing.Point(343, 270);
            this.KMPVCB.Name = "KMPVCB";
            this.KMPVCB.Size = new System.Drawing.Size(246, 28);
            this.KMPVCB.TabIndex = 18;
            this.KMPVCB.SelectedIndexChanged += new System.EventHandler(this.KMPVcomboBox_SelectedIndexChanged);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.ForeColor = System.Drawing.Color.Gold;
            this.vastausLB.Location = new System.Drawing.Point(136, 350);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(98, 25);
            this.vastausLB.TabIndex = 19;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // kustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(922, 425);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.KMPVCB);
            this.Controls.Add(this.pesuTB);
            this.Controls.Add(this.huollotTB);
            this.Controls.Add(this.polttoTB);
            this.Controls.Add(this.renkaatTB);
            this.Controls.Add(this.muutTB);
            this.Controls.Add(this.vakuutusTB);
            this.Controls.Add(this.nesteetTB);
            this.Controls.Add(this.lainaTB);
            this.Controls.Add(this.MuutLB);
            this.Controls.Add(this.PesutLB);
            this.Controls.Add(this.RenkaatLB);
            this.Controls.Add(this.KmVuosiLB);
            this.Controls.Add(this.HuollotLB);
            this.Controls.Add(this.PolttoaineLB);
            this.Controls.Add(this.NesteetLB);
            this.Controls.Add(this.VakuutusLB);
            this.Controls.Add(this.LainaLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "kustForm";
            this.Text = "Auton kustannukset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private Label LainaLB;
        private Label VakuutusLB;
        private Label NesteetLB;
        private Label PolttoaineLB;
        private Label HuollotLB;
        private Label MuutLB;
        private Label PesutLB;
        private Label RenkaatLB;
        private Label KmVuosiLB;
        private TextBox lainaTB;
        private TextBox nesteetTB;
        private TextBox muutTB;
        private TextBox vakuutusTB;
        private TextBox pesuTB;
        private TextBox huollotTB;
        private TextBox polttoTB;
        private TextBox renkaatTB;
        private ComboBox KMPVCB;
        private Label vastausLB;
    }
}