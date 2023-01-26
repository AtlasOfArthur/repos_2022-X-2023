namespace PainoindeksiLaskuriForm
{
    partial class BMI_Form
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
            this.painoLB = new System.Windows.Forms.Label();
            this.pituusLB = new System.Windows.Forms.Label();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.laskeBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.KuvausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // painoLB
            // 
            this.painoLB.AutoSize = true;
            this.painoLB.BackColor = System.Drawing.Color.Transparent;
            this.painoLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.painoLB.ForeColor = System.Drawing.Color.Gold;
            this.painoLB.Location = new System.Drawing.Point(12, 26);
            this.painoLB.Name = "painoLB";
            this.painoLB.Size = new System.Drawing.Size(130, 25);
            this.painoLB.TabIndex = 0;
            this.painoLB.Text = "Paino (KG)";
            // 
            // pituusLB
            // 
            this.pituusLB.AutoSize = true;
            this.pituusLB.BackColor = System.Drawing.Color.Transparent;
            this.pituusLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pituusLB.ForeColor = System.Drawing.Color.Gold;
            this.pituusLB.Location = new System.Drawing.Point(12, 70);
            this.pituusLB.Name = "pituusLB";
            this.pituusLB.Size = new System.Drawing.Size(125, 25);
            this.pituusLB.TabIndex = 1;
            this.pituusLB.Text = "Pituus (m)";
            // 
            // painoTB
            // 
            this.painoTB.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.painoTB.Location = new System.Drawing.Point(148, 25);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(125, 26);
            this.painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            this.pituusTB.Font = new System.Drawing.Font("Magneto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pituusTB.Location = new System.Drawing.Point(148, 69);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(125, 26);
            this.pituusTB.TabIndex = 3;
            // 
            // laskeBT
            // 
            this.laskeBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.laskeBT.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laskeBT.ForeColor = System.Drawing.Color.Gold;
            this.laskeBT.Location = new System.Drawing.Point(307, 29);
            this.laskeBT.Name = "laskeBT";
            this.laskeBT.Size = new System.Drawing.Size(111, 66);
            this.laskeBT.TabIndex = 4;
            this.laskeBT.Text = "Laske indeksi";
            this.laskeBT.UseVisualStyleBackColor = false;
            this.laskeBT.Click += new System.EventHandler(this.laskeBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.BackColor = System.Drawing.Color.Transparent;
            this.vastausLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.ForeColor = System.Drawing.Color.Gold;
            this.vastausLB.Location = new System.Drawing.Point(12, 118);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(98, 25);
            this.vastausLB.TabIndex = 5;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // KuvausLB
            // 
            this.KuvausLB.AutoSize = true;
            this.KuvausLB.BackColor = System.Drawing.Color.Transparent;
            this.KuvausLB.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.KuvausLB.ForeColor = System.Drawing.Color.Gold;
            this.KuvausLB.Location = new System.Drawing.Point(12, 154);
            this.KuvausLB.Name = "KuvausLB";
            this.KuvausLB.Size = new System.Drawing.Size(89, 25);
            this.KuvausLB.TabIndex = 6;
            this.KuvausLB.Text = "Kuvaus";
            this.KuvausLB.Visible = false;
            // 
            // BMI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PainoindeksiLaskuriForm.Properties.Resources.blur_2_1853262_1280_small1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 202);
            this.Controls.Add(this.KuvausLB);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.laskeBT);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.pituusLB);
            this.Controls.Add(this.painoLB);
            this.Name = "BMI_Form";
            this.Text = "BMI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label painoLB;
        private Label pituusLB;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button laskeBT;
        private Label vastausLB;
        private Label KuvausLB;
    }
}