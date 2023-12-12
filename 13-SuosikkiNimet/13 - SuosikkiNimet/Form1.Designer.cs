namespace _13___SuosikkiNimet
{
    partial class SuosikkiForm
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
            AnnaNimesiLB = new Label();
            NimiTB = new TextBox();
            VastausLB = new Label();
            TarkistaBT = new Button();
            SuspendLayout();
            // 
            // AnnaNimesiLB
            // 
            AnnaNimesiLB.AutoSize = true;
            AnnaNimesiLB.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AnnaNimesiLB.Location = new Point(46, 46);
            AnnaNimesiLB.Name = "AnnaNimesiLB";
            AnnaNimesiLB.Size = new Size(584, 26);
            AnnaNimesiLB.TabIndex = 0;
            AnnaNimesiLB.Text = "Anna nimesi niin tarkistan onko se suosituimpien joukossa:";
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(636, 47);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(125, 27);
            NimiTB.TabIndex = 1;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(46, 98);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(86, 26);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            // 
            // TarkistaBT
            // 
            TarkistaBT.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TarkistaBT.Location = new Point(636, 98);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(125, 29);
            TarkistaBT.TabIndex = 3;
            TarkistaBT.Text = "Tarkasta";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SuosikkiForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 209);
            Controls.Add(TarkistaBT);
            Controls.Add(VastausLB);
            Controls.Add(NimiTB);
            Controls.Add(AnnaNimesiLB);
            Name = "SuosikkiForm";
            Text = "Onko nimesi suosikkien joukossa?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AnnaNimesiLB;
        private TextBox NimiTB;
        private Label VastausLB;
        private Button TarkistaBT;
    }
}
