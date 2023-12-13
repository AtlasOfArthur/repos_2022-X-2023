namespace _14_Päiväkirja
{
    partial class PäiväkirjaForm
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
            SyottoTB = new TextBox();
            TallennaBT = new Button();
            SuspendLayout();
            // 
            // SyottoTB
            // 
            SyottoTB.BackColor = Color.Ivory;
            SyottoTB.Location = new Point(12, 28);
            SyottoTB.Multiline = true;
            SyottoTB.Name = "SyottoTB";
            SyottoTB.Size = new Size(943, 835);
            SyottoTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            TallennaBT.BackColor = Color.MintCream;
            TallennaBT.FlatAppearance.BorderColor = Color.DarkGray;
            TallennaBT.FlatAppearance.BorderSize = 3;
            TallennaBT.FlatStyle = FlatStyle.Flat;
            TallennaBT.Font = new Font("Forte", 19.8000011F, FontStyle.Italic, GraphicsUnit.Point, 0);
            TallennaBT.ForeColor = Color.DarkRed;
            TallennaBT.Location = new Point(12, 885);
            TallennaBT.Name = "TallennaBT";
            TallennaBT.Size = new Size(943, 68);
            TallennaBT.TabIndex = 1;
            TallennaBT.Text = "Tallenna päiväkirjaan";
            TallennaBT.UseVisualStyleBackColor = false;
            TallennaBT.Click += TallennaBT_Click;
            // 
            // PäiväkirjaForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(967, 990);
            Controls.Add(TallennaBT);
            Controls.Add(SyottoTB);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "PäiväkirjaForm";
            Text = "Päiväkirja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SyottoTB;
        private Button TallennaBT;
    }
}
