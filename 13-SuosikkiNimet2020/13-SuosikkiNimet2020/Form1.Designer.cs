namespace _13_SuosikkiNimet2020
{
    partial class Form1
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
            KerroNimesiLB = new Label();
            VastausLB = new Label();
            TarkistaBT = new Button();
            NimiTB = new TextBox();
            SuspendLayout();
            // 
            // KerroNimesiLB
            // 
            KerroNimesiLB.AutoSize = true;
            KerroNimesiLB.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KerroNimesiLB.Location = new Point(29, 37);
            KerroNimesiLB.Name = "KerroNimesiLB";
            KerroNimesiLB.Size = new Size(591, 23);
            KerroNimesiLB.TabIndex = 0;
            KerroNimesiLB.Text = "Kerro nimesi, niin katson onko se suosituimpien nimien joukossa 2020";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Sylfaen", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VastausLB.Location = new Point(29, 73);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(75, 23);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            // 
            // TarkistaBT
            // 
            TarkistaBT.Font = new Font("Stencil", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TarkistaBT.Location = new Point(645, 72);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(121, 29);
            TarkistaBT.TabIndex = 2;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(645, 36);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(121, 27);
            NimiTB.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(NimiTB);
            Controls.Add(TarkistaBT);
            Controls.Add(VastausLB);
            Controls.Add(KerroNimesiLB);
            Name = "Form1";
            Text = "Suosituimmat nimet 2020";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KerroNimesiLB;
        private Label VastausLB;
        private Button TarkistaBT;
        private TextBox NimiTB;
    }
}
