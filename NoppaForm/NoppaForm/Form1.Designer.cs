namespace NoppaForm
{
    partial class heitanoppaa
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
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.heitaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // noppa01PB
            // 
            this.noppa01PB.BackColor = System.Drawing.Color.Transparent;
            this.noppa01PB.BackgroundImage = global::NoppaForm.Properties.Resources.dices_1;
            this.noppa01PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppa01PB.Location = new System.Drawing.Point(143, 95);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(100, 100);
            this.noppa01PB.TabIndex = 0;
            this.noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            this.noppa02PB.BackColor = System.Drawing.Color.Transparent;
            this.noppa02PB.BackgroundImage = global::NoppaForm.Properties.Resources.dices_1;
            this.noppa02PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppa02PB.Location = new System.Drawing.Point(265, 95);
            this.noppa02PB.Name = "pictureBox1";
            this.noppa02PB.Size = new System.Drawing.Size(100, 100);
            this.noppa02PB.TabIndex = 1;
            this.noppa02PB.TabStop = false;
            // 
            // heitaBT
            // 
            this.heitaBT.BackColor = System.Drawing.Color.Black;
            this.heitaBT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.heitaBT.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heitaBT.ForeColor = System.Drawing.Color.DarkRed;
            this.heitaBT.Location = new System.Drawing.Point(143, 220);
            this.heitaBT.Name = "heitaBT";
            this.heitaBT.Size = new System.Drawing.Size(222, 60);
            this.heitaBT.TabIndex = 2;
            this.heitaBT.Text = "Heitä noppaa";
            this.heitaBT.UseVisualStyleBackColor = false;
            this.heitaBT.Click += new System.EventHandler(this.heitaBT_Click);
            // 
            // noppa02PB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NoppaForm.Properties.Resources.dices_3857549_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(501, 369);
            this.Controls.Add(this.heitaBT);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Name = "noppa02PB";
            this.Text = "Nopan heitto";
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private Button heitaBT;
    }
}