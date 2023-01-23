namespace RomanNumberConverterForm
{
    partial class RomanConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RomanConverter));
            this.RoomalaisetNumerotLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuunnaBT = new System.Windows.Forms.Button();
            this.NumeroTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RoomalaisetNumerotLB
            // 
            this.RoomalaisetNumerotLB.AutoSize = true;
            this.RoomalaisetNumerotLB.BackColor = System.Drawing.Color.Transparent;
            this.RoomalaisetNumerotLB.Font = new System.Drawing.Font("Old English Text MT", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.RoomalaisetNumerotLB.ForeColor = System.Drawing.Color.Khaki;
            this.RoomalaisetNumerotLB.Location = new System.Drawing.Point(43, 45);
            this.RoomalaisetNumerotLB.Name = "RoomalaisetNumerotLB";
            this.RoomalaisetNumerotLB.Size = new System.Drawing.Size(558, 71);
            this.RoomalaisetNumerotLB.TabIndex = 0;
            this.RoomalaisetNumerotLB.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Old English Text MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(43, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna numero väliltä 1 - 3999 \r\n";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.BackColor = System.Drawing.Color.Transparent;
            this.VastausLB.Font = new System.Drawing.Font("Castellar", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.VastausLB.ForeColor = System.Drawing.Color.Gold;
            this.VastausLB.Location = new System.Drawing.Point(31, 260);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(118, 25);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // MuunnaBT
            // 
            this.MuunnaBT.BackColor = System.Drawing.Color.Black;
            this.MuunnaBT.Font = new System.Drawing.Font("Bernard MT Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MuunnaBT.ForeColor = System.Drawing.Color.Khaki;
            this.MuunnaBT.Location = new System.Drawing.Point(205, 176);
            this.MuunnaBT.Name = "MuunnaBT";
            this.MuunnaBT.Size = new System.Drawing.Size(110, 41);
            this.MuunnaBT.TabIndex = 3;
            this.MuunnaBT.Text = "Muunna";
            this.MuunnaBT.UseVisualStyleBackColor = false;
            this.MuunnaBT.Click += new System.EventHandler(this.MuunnaBT_Click);
            // 
            // NumeroTB
            // 
            this.NumeroTB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumeroTB.Location = new System.Drawing.Point(43, 178);
            this.NumeroTB.Name = "NumeroTB";
            this.NumeroTB.Size = new System.Drawing.Size(125, 34);
            this.NumeroTB.TabIndex = 4;
            // 
            // RomanConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(639, 363);
            this.Controls.Add(this.NumeroTB);
            this.Controls.Add(this.MuunnaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomalaisetNumerotLB);
            this.Name = "RomanConverter";
            this.Text = "Numeron muutos arabialaisesta roomalaiseksi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label RoomalaisetNumerotLB;
        private Label label2;
        private Label VastausLB;
        private Button MuunnaBT;
        private TextBox NumeroTB;
    }
}