namespace NoppaForm2
{
    partial class heitanoppaaForm
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
            this.noppaBox1 = new System.Windows.Forms.PictureBox();
            this.noppaBox2 = new System.Windows.Forms.PictureBox();
            this.noppaBox3 = new System.Windows.Forms.PictureBox();
            this.noppaBox4 = new System.Windows.Forms.PictureBox();
            this.heitaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noppaBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppaBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppaBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppaBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // noppaBox1
            // 
            this.noppaBox1.BackColor = System.Drawing.Color.Transparent;
            this.noppaBox1.BackgroundImage = global::NoppaForm2.Properties.Resources.dices_1;
            this.noppaBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppaBox1.Location = new System.Drawing.Point(45, 155);
            this.noppaBox1.Name = "noppaBox1";
            this.noppaBox1.Size = new System.Drawing.Size(100, 100);
            this.noppaBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppaBox1.TabIndex = 0;
            this.noppaBox1.TabStop = false;
            // 
            // noppaBox2
            // 
            this.noppaBox2.BackColor = System.Drawing.Color.Transparent;
            this.noppaBox2.BackgroundImage = global::NoppaForm2.Properties.Resources.dices_1;
            this.noppaBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppaBox2.Location = new System.Drawing.Point(169, 155);
            this.noppaBox2.Name = "noppaBox2";
            this.noppaBox2.Size = new System.Drawing.Size(100, 100);
            this.noppaBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppaBox2.TabIndex = 1;
            this.noppaBox2.TabStop = false;
            // 
            // noppaBox3
            // 
            this.noppaBox3.BackColor = System.Drawing.Color.Transparent;
            this.noppaBox3.BackgroundImage = global::NoppaForm2.Properties.Resources.dices_1;
            this.noppaBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppaBox3.Location = new System.Drawing.Point(293, 155);
            this.noppaBox3.Name = "noppaBox3";
            this.noppaBox3.Size = new System.Drawing.Size(100, 100);
            this.noppaBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppaBox3.TabIndex = 2;
            this.noppaBox3.TabStop = false;
            // 
            // noppaBox4
            // 
            this.noppaBox4.BackColor = System.Drawing.Color.Transparent;
            this.noppaBox4.BackgroundImage = global::NoppaForm2.Properties.Resources.dices_1;
            this.noppaBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppaBox4.Location = new System.Drawing.Point(417, 155);
            this.noppaBox4.Name = "noppaBox4";
            this.noppaBox4.Size = new System.Drawing.Size(100, 100);
            this.noppaBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppaBox4.TabIndex = 3;
            this.noppaBox4.TabStop = false;
            // 
            // heitaBT
            // 
            this.heitaBT.BackColor = System.Drawing.Color.Black;
            this.heitaBT.Font = new System.Drawing.Font("Magneto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.heitaBT.ForeColor = System.Drawing.Color.Firebrick;
            this.heitaBT.Location = new System.Drawing.Point(169, 277);
            this.heitaBT.Name = "heitaBT";
            this.heitaBT.Size = new System.Drawing.Size(224, 36);
            this.heitaBT.TabIndex = 4;
            this.heitaBT.Text = "Heitä noppaa";
            this.heitaBT.UseVisualStyleBackColor = false;
            this.heitaBT.Click += new System.EventHandler(this.heitaBT_Click);
            // 
            // heitanoppaaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NoppaForm2.Properties.Resources.dices_3857549_1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(560, 410);
            this.Controls.Add(this.heitaBT);
            this.Controls.Add(this.noppaBox4);
            this.Controls.Add(this.noppaBox3);
            this.Controls.Add(this.noppaBox2);
            this.Controls.Add(this.noppaBox1);
            this.Name = "heitanoppaaForm";
            this.Text = "Nopan heitto";
            ((System.ComponentModel.ISupportInitialize)(this.noppaBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppaBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppaBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppaBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox noppaBox1;
        private PictureBox noppaBox2;
        private PictureBox noppaBox3;
        private PictureBox noppaBox4;
        private Button heitaBT;
    }
}