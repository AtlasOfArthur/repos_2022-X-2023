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
            this.salasanaPanel = new System.Windows.Forms.Panel();
            this.virheviestiLB = new System.Windows.Forms.Label();
            this.tarkistaBT = new System.Windows.Forms.Button();
            this.SalasanaBox = new System.Windows.Forms.TextBox();
            this.KayttajaBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kayttajaLB = new System.Windows.Forms.Label();
            this.salasanaoikeinPanel = new System.Windows.Forms.Panel();
            this.TervetuloaLB = new System.Windows.Forms.Label();
            this.salasanaPanel.SuspendLayout();
            this.salasanaoikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // salasanaPanel
            // 
            this.salasanaPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(43)))), ((int)(((byte)(26)))));
            this.salasanaPanel.Controls.Add(this.salasanaoikeinPanel);
            this.salasanaPanel.Controls.Add(this.virheviestiLB);
            this.salasanaPanel.Controls.Add(this.tarkistaBT);
            this.salasanaPanel.Controls.Add(this.SalasanaBox);
            this.salasanaPanel.Controls.Add(this.KayttajaBox);
            this.salasanaPanel.Controls.Add(this.label2);
            this.salasanaPanel.Controls.Add(this.kayttajaLB);
            this.salasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaPanel.Name = "salasanaPanel";
            this.salasanaPanel.Size = new System.Drawing.Size(545, 268);
            this.salasanaPanel.TabIndex = 0;
            // 
            // virheviestiLB
            // 
            this.virheviestiLB.AutoSize = true;
            this.virheviestiLB.Location = new System.Drawing.Point(97, 223);
            this.virheviestiLB.Name = "virheviestiLB";
            this.virheviestiLB.Size = new System.Drawing.Size(295, 20);
            this.virheviestiLB.TabIndex = 5;
            this.virheviestiLB.Text = "Käyttäjätunnus tai salasana viesti";
            this.virheviestiLB.Visible = false;
            // 
            // tarkistaBT
            // 
            this.tarkistaBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tarkistaBT.Location = new System.Drawing.Point(235, 167);
            this.tarkistaBT.Name = "tarkistaBT";
            this.tarkistaBT.Size = new System.Drawing.Size(94, 29);
            this.tarkistaBT.TabIndex = 4;
            this.tarkistaBT.Text = "Tarkista";
            this.tarkistaBT.UseVisualStyleBackColor = false;
            this.tarkistaBT.Click += new System.EventHandler(this.tarkistaBT_Click);
            // 
            // SalasanaBox
            // 
            this.SalasanaBox.Location = new System.Drawing.Point(196, 99);
            this.SalasanaBox.Name = "SalasanaBox";
            this.SalasanaBox.Size = new System.Drawing.Size(277, 27);
            this.SalasanaBox.TabIndex = 3;
            // 
            // KayttajaBox
            // 
            this.KayttajaBox.Location = new System.Drawing.Point(196, 42);
            this.KayttajaBox.Name = "KayttajaBox";
            this.KayttajaBox.Size = new System.Drawing.Size(277, 27);
            this.KayttajaBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana";
            // 
            // kayttajaLB
            // 
            this.kayttajaLB.AutoSize = true;
            this.kayttajaLB.Location = new System.Drawing.Point(42, 49);
            this.kayttajaLB.Name = "kayttajaLB";
            this.kayttajaLB.Size = new System.Drawing.Size(139, 20);
            this.kayttajaLB.TabIndex = 0;
            this.kayttajaLB.Text = "Käyttäjätunnus";
            // 
            // salasanaoikeinPanel
            // 
            this.salasanaoikeinPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.salasanaoikeinPanel.Controls.Add(this.TervetuloaLB);
            this.salasanaoikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salasanaoikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.salasanaoikeinPanel.Name = "salasanaoikeinPanel";
            this.salasanaoikeinPanel.Size = new System.Drawing.Size(545, 268);
            this.salasanaoikeinPanel.TabIndex = 1;
            this.salasanaoikeinPanel.Visible = false;
            // 
            // TervetuloaLB
            // 
            this.TervetuloaLB.AutoSize = true;
            this.TervetuloaLB.Font = new System.Drawing.Font("Magneto", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TervetuloaLB.Location = new System.Drawing.Point(42, 106);
            this.TervetuloaLB.Name = "TervetuloaLB";
            this.TervetuloaLB.Size = new System.Drawing.Size(461, 48);
            this.TervetuloaLB.TabIndex = 0;
            this.TervetuloaLB.Text = "Tervetuloa sivulleni!";
            // 
            // käyttäjätunnusJaSalasana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 268);
            this.Controls.Add(this.salasanaPanel);
            this.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gold;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "käyttäjätunnusJaSalasana";
            this.Text = "Salasanan tarkastus";
            this.salasanaPanel.ResumeLayout(false);
            this.salasanaPanel.PerformLayout();
            this.salasanaoikeinPanel.ResumeLayout(false);
            this.salasanaoikeinPanel.PerformLayout();
            this.ResumeLayout(false);

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