namespace KäyttäjätunnusJaSalasana_Form
{
    partial class käyttäjätunnusJaSalasana
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
            salasanaPanel = new Panel();
            salasanaoikeinPanel = new Panel();
            TervetuloaLB = new Label();
            virheviestiLB = new Label();
            tarkistaBT = new Button();
            SalasanaBox = new TextBox();
            KayttajaBox = new TextBox();
            label2 = new Label();
            kayttajaLB = new Label();
            salasanaPanel.SuspendLayout();
            salasanaoikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // salasanaPanel
            // 
            salasanaPanel.BackColor = Color.FromArgb(2, 43, 26);
            salasanaPanel.Controls.Add(salasanaoikeinPanel);
            salasanaPanel.Controls.Add(virheviestiLB);
            salasanaPanel.Controls.Add(tarkistaBT);
            salasanaPanel.Controls.Add(SalasanaBox);
            salasanaPanel.Controls.Add(KayttajaBox);
            salasanaPanel.Controls.Add(label2);
            salasanaPanel.Controls.Add(kayttajaLB);
            salasanaPanel.Dock = DockStyle.Fill;
            salasanaPanel.Location = new Point(0, 0);
            salasanaPanel.Name = "salasanaPanel";
            salasanaPanel.Size = new Size(545, 268);
            salasanaPanel.TabIndex = 0;
            // 
            // salasanaoikeinPanel
            // 
            salasanaoikeinPanel.BackColor = Color.FromArgb(64, 0, 64);
            salasanaoikeinPanel.Controls.Add(TervetuloaLB);
            salasanaoikeinPanel.Dock = DockStyle.Fill;
            salasanaoikeinPanel.Location = new Point(0, 0);
            salasanaoikeinPanel.Name = "salasanaoikeinPanel";
            salasanaoikeinPanel.Size = new Size(545, 268);
            salasanaoikeinPanel.TabIndex = 1;
            salasanaoikeinPanel.Visible = false;
            // 
            // TervetuloaLB
            // 
            TervetuloaLB.AutoSize = true;
            TervetuloaLB.Font = new Font("Magneto", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            TervetuloaLB.Location = new Point(42, 106);
            TervetuloaLB.Name = "TervetuloaLB";
            TervetuloaLB.Size = new Size(461, 48);
            TervetuloaLB.TabIndex = 0;
            TervetuloaLB.Text = "Tervetuloa sivulleni!";
            // 
            // virheviestiLB
            // 
            virheviestiLB.AutoSize = true;
            virheviestiLB.Location = new Point(97, 223);
            virheviestiLB.Name = "virheviestiLB";
            virheviestiLB.Size = new Size(295, 20);
            virheviestiLB.TabIndex = 5;
            virheviestiLB.Text = "Käyttäjätunnus tai salasana viesti";
            virheviestiLB.Visible = false;
            // 
            // tarkistaBT
            // 
            tarkistaBT.BackColor = Color.FromArgb(0, 64, 0);
            tarkistaBT.Location = new Point(235, 167);
            tarkistaBT.Name = "tarkistaBT";
            tarkistaBT.Size = new Size(94, 29);
            tarkistaBT.TabIndex = 4;
            tarkistaBT.Text = "Tarkista";
            tarkistaBT.UseVisualStyleBackColor = false;
            tarkistaBT.Click += tarkistaBT_Click;
            // 
            // SalasanaBox
            // 
            SalasanaBox.Location = new Point(196, 99);
            SalasanaBox.Name = "SalasanaBox";
            SalasanaBox.Size = new Size(277, 27);
            SalasanaBox.TabIndex = 3;
            // 
            // KayttajaBox
            // 
            KayttajaBox.Location = new Point(196, 42);
            KayttajaBox.Name = "KayttajaBox";
            KayttajaBox.Size = new Size(277, 27);
            KayttajaBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 106);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Salasana";
            // 
            // kayttajaLB
            // 
            kayttajaLB.AutoSize = true;
            kayttajaLB.Location = new Point(42, 49);
            kayttajaLB.Name = "kayttajaLB";
            kayttajaLB.Size = new Size(139, 20);
            kayttajaLB.TabIndex = 0;
            kayttajaLB.Text = "Käyttäjätunnus";
            // 
            // käyttäjätunnusJaSalasana
            // 
            AutoScaleDimensions = new SizeF(11F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 268);
            Controls.Add(salasanaPanel);
            Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Gold;
            Margin = new Padding(5, 3, 5, 3);
            Name = "käyttäjätunnusJaSalasana";
            Text = "Salasanan tarkastus";
            salasanaPanel.ResumeLayout(false);
            salasanaPanel.PerformLayout();
            salasanaoikeinPanel.ResumeLayout(false);
            salasanaoikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel salasanaPanel;
        private Label virheviestiLB;
        private Button tarkistaBT;
        private TextBox SalasanaBox;
        private TextBox KayttajaBox;
        private Label label2;
        private Label kayttajaLB;
        private Panel salasanaoikeinPanel;
        private Label TervetuloaLB;
    }
}