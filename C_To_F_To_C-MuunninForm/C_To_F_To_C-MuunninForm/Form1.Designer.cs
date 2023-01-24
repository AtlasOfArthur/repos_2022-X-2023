namespace C_To_F_To_C_MuunninForm
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
            this.MitenMuunnatBox = new System.Windows.Forms.GroupBox();
            this.fahrenheitRButton = new System.Windows.Forms.RadioButton();
            this.celsiusRButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.annaAsteetLB = new System.Windows.Forms.Label();
            this.asteetTB = new System.Windows.Forms.TextBox();
            this.muunnaBT = new System.Windows.Forms.Button();
            this.vastausLB = new System.Windows.Forms.Label();
            this.MitenMuunnatBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MitenMuunnatBox
            // 
            this.MitenMuunnatBox.Controls.Add(this.fahrenheitRButton);
            this.MitenMuunnatBox.Controls.Add(this.celsiusRButton);
            this.MitenMuunnatBox.Controls.Add(this.label1);
            this.MitenMuunnatBox.Font = new System.Drawing.Font("Kristen ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MitenMuunnatBox.ForeColor = System.Drawing.Color.Honeydew;
            this.MitenMuunnatBox.Location = new System.Drawing.Point(237, 12);
            this.MitenMuunnatBox.Name = "MitenMuunnatBox";
            this.MitenMuunnatBox.Size = new System.Drawing.Size(336, 157);
            this.MitenMuunnatBox.TabIndex = 0;
            this.MitenMuunnatBox.TabStop = false;
            this.MitenMuunnatBox.Text = "Miten muunnat";
            // 
            // fahrenheitRButton
            // 
            this.fahrenheitRButton.AutoSize = true;
            this.fahrenheitRButton.Location = new System.Drawing.Point(96, 92);
            this.fahrenheitRButton.Name = "fahrenheitRButton";
            this.fahrenheitRButton.Size = new System.Drawing.Size(165, 34);
            this.fahrenheitRButton.TabIndex = 5;
            this.fahrenheitRButton.TabStop = true;
            this.fahrenheitRButton.Text = "Fahrenheit";
            this.fahrenheitRButton.UseVisualStyleBackColor = true;
            // 
            // celsiusRButton
            // 
            this.celsiusRButton.AutoSize = true;
            this.celsiusRButton.Location = new System.Drawing.Point(96, 52);
            this.celsiusRButton.Name = "celsiusRButton";
            this.celsiusRButton.Size = new System.Drawing.Size(120, 34);
            this.celsiusRButton.TabIndex = 4;
            this.celsiusRButton.TabStop = true;
            this.celsiusRButton.Text = "Celsius";
            this.celsiusRButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 3;
            // 
            // annaAsteetLB
            // 
            this.annaAsteetLB.AutoSize = true;
            this.annaAsteetLB.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.annaAsteetLB.Location = new System.Drawing.Point(31, 44);
            this.annaAsteetLB.Name = "annaAsteetLB";
            this.annaAsteetLB.Size = new System.Drawing.Size(129, 24);
            this.annaAsteetLB.TabIndex = 3;
            this.annaAsteetLB.Text = "Anna asteet:";
            // 
            // asteetTB
            // 
            this.asteetTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(10)))));
            this.asteetTB.ForeColor = System.Drawing.Color.Honeydew;
            this.asteetTB.Location = new System.Drawing.Point(31, 81);
            this.asteetTB.Name = "asteetTB";
            this.asteetTB.Size = new System.Drawing.Size(125, 27);
            this.asteetTB.TabIndex = 4;
            // 
            // muunnaBT
            // 
            this.muunnaBT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(10)))));
            this.muunnaBT.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.muunnaBT.Location = new System.Drawing.Point(650, 64);
            this.muunnaBT.Name = "muunnaBT";
            this.muunnaBT.Size = new System.Drawing.Size(115, 44);
            this.muunnaBT.TabIndex = 5;
            this.muunnaBT.Text = "Muunna";
            this.muunnaBT.UseVisualStyleBackColor = false;
            this.muunnaBT.Click += new System.EventHandler(this.muunnaBT_Click);
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Kristen ITC", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(322, 218);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(131, 39);
            this.vastausLB.TabIndex = 6;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(33)))), ((int)(((byte)(10)))));
            this.ClientSize = new System.Drawing.Size(800, 325);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.muunnaBT);
            this.Controls.Add(this.asteetTB);
            this.Controls.Add(this.annaAsteetLB);
            this.Controls.Add(this.MitenMuunnatBox);
            this.ForeColor = System.Drawing.Color.Honeydew;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MitenMuunnatBox.ResumeLayout(false);
            this.MitenMuunnatBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox MitenMuunnatBox;
        private RadioButton fahrenheitRButton;
        private RadioButton celsiusRButton;
        private Label label1;
        private Label annaAsteetLB;
        private TextBox asteetTB;
        private Button muunnaBT;
        private Label vastausLB;
    }
}