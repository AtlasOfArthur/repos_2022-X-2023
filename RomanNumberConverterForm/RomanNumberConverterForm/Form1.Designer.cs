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
            RoomalaisetNumerotLB = new Label();
            label2 = new Label();
            VastausLB = new Label();
            MuunnaBT = new Button();
            NumeroTB = new TextBox();
            SuspendLayout();
            // 
            // RoomalaisetNumerotLB
            // 
            RoomalaisetNumerotLB.AutoSize = true;
            RoomalaisetNumerotLB.BackColor = Color.Transparent;
            RoomalaisetNumerotLB.Font = new Font("Old English Text MT", 36F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            RoomalaisetNumerotLB.ForeColor = Color.Khaki;
            RoomalaisetNumerotLB.Location = new Point(43, 45);
            RoomalaisetNumerotLB.Name = "RoomalaisetNumerotLB";
            RoomalaisetNumerotLB.Size = new Size(558, 71);
            RoomalaisetNumerotLB.TabIndex = 0;
            RoomalaisetNumerotLB.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Old English Text MT", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gold;
            label2.Location = new Point(43, 140);
            label2.Name = "label2";
            label2.Size = new Size(272, 24);
            label2.TabIndex = 1;
            label2.Text = "Anna numero väliltä 1 - 3999 \r\n";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.BackColor = Color.Transparent;
            VastausLB.Font = new Font("Castellar", 12F, FontStyle.Bold, GraphicsUnit.Point);
            VastausLB.ForeColor = Color.Gold;
            VastausLB.Location = new Point(31, 260);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(118, 25);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // MuunnaBT
            // 
            MuunnaBT.BackColor = Color.Black;
            MuunnaBT.Font = new Font("Bernard MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MuunnaBT.ForeColor = Color.Khaki;
            MuunnaBT.Location = new Point(205, 176);
            MuunnaBT.Name = "MuunnaBT";
            MuunnaBT.Size = new Size(110, 41);
            MuunnaBT.TabIndex = 3;
            MuunnaBT.Text = "Muunna";
            MuunnaBT.UseVisualStyleBackColor = false;
            MuunnaBT.Click += MuunnaBT_Click;
            // 
            // NumeroTB
            // 
            NumeroTB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumeroTB.Location = new Point(43, 178);
            NumeroTB.Name = "NumeroTB";
            NumeroTB.Size = new Size(125, 34);
            NumeroTB.TabIndex = 4;
            // 
            // RomanConverter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(639, 363);
            Controls.Add(NumeroTB);
            Controls.Add(MuunnaBT);
            Controls.Add(VastausLB);
            Controls.Add(label2);
            Controls.Add(RoomalaisetNumerotLB);
            Name = "RomanConverter";
            Text = "Numeron muutos arabialaisesta roomalaiseksi - Anselmi Harjama";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label RoomalaisetNumerotLB;
        private Label label2;
        private Label VastausLB;
        private Button MuunnaBT;
        private TextBox NumeroTB;
    }
}