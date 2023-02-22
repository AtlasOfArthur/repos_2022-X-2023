namespace Aliohjelmat.Methods_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KutsuHelloBT = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.ExampleLB1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Reverse2BTN = new System.Windows.Forms.Button();
            this.KutsuReverseBT = new System.Windows.Forms.Button();
            this.ExampleLB2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ExampleLB2_2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KutsuHelloBT);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.ExampleLB1);
            this.groupBox1.Location = new System.Drawing.Point(24, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(886, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // KutsuHelloBT
            // 
            this.KutsuHelloBT.Location = new System.Drawing.Point(200, 32);
            this.KutsuHelloBT.Name = "KutsuHelloBT";
            this.KutsuHelloBT.Size = new System.Drawing.Size(279, 29);
            this.KutsuHelloBT.TabIndex = 2;
            this.KutsuHelloBT.Text = "Kutsu aliohjelmaa Hello";
            this.KutsuHelloBT.UseVisualStyleBackColor = true;
            this.KutsuHelloBT.Click += new System.EventHandler(this.KutsuHelloBT_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(17, 75);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(786, 20);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://learn.microsoft.com/en-us/shows/csharp-fundamentals-for-absolute-beginner" +
    "s/defining-and-calling-methods";
            // 
            // ExampleLB1
            // 
            this.ExampleLB1.AutoSize = true;
            this.ExampleLB1.Location = new System.Drawing.Point(17, 36);
            this.ExampleLB1.Name = "ExampleLB1";
            this.ExampleLB1.Size = new System.Drawing.Size(116, 20);
            this.ExampleLB1.TabIndex = 0;
            this.ExampleLB1.Text = "Simple example";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ExampleLB2_2);
            this.groupBox2.Controls.Add(this.Reverse2BTN);
            this.groupBox2.Controls.Add(this.KutsuReverseBT);
            this.groupBox2.Controls.Add(this.ExampleLB2);
            this.groupBox2.Location = new System.Drawing.Point(24, 167);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(886, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // Reverse2BTN
            // 
            this.Reverse2BTN.Location = new System.Drawing.Point(524, 26);
            this.Reverse2BTN.Name = "Reverse2BTN";
            this.Reverse2BTN.Size = new System.Drawing.Size(279, 29);
            this.Reverse2BTN.TabIndex = 4;
            this.Reverse2BTN.Text = "Kutsu aliohjelmaa Reverse2";
            this.Reverse2BTN.UseVisualStyleBackColor = true;
            this.Reverse2BTN.Click += new System.EventHandler(this.Reverse2BTN_Click);
            // 
            // KutsuReverseBT
            // 
            this.KutsuReverseBT.Location = new System.Drawing.Point(200, 26);
            this.KutsuReverseBT.Name = "KutsuReverseBT";
            this.KutsuReverseBT.Size = new System.Drawing.Size(279, 29);
            this.KutsuReverseBT.TabIndex = 3;
            this.KutsuReverseBT.Text = "Kutsu aliohjelmaa Reverse";
            this.KutsuReverseBT.UseVisualStyleBackColor = true;
           // this.KutsuReverseBT.Click += new System.EventHandler(this.KutsuReverseBT_Click);
            // 
            // ExampleLB2
            // 
            this.ExampleLB2.AutoSize = true;
            this.ExampleLB2.Location = new System.Drawing.Point(17, 35);
            this.ExampleLB2.Name = "ExampleLB2";
            this.ExampleLB2.Size = new System.Drawing.Size(124, 20);
            this.ExampleLB2.TabIndex = 3;
            this.ExampleLB2.Text = "Simple example2";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(24, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(886, 125);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // ExampleLB2_2
            // 
            this.ExampleLB2_2.AutoSize = true;
            this.ExampleLB2_2.Location = new System.Drawing.Point(17, 73);
            this.ExampleLB2_2.Name = "ExampleLB2_2";
            this.ExampleLB2_2.Size = new System.Drawing.Size(135, 20);
            this.ExampleLB2_2.TabIndex = 5;
            this.ExampleLB2_2.Text = "Simple example2.2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private LinkLabel linkLabel1;
        private Label ExampleLB1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button KutsuHelloBT;
        private Label ExampleLB2;
        private Button KutsuReverseBT;
        private Button Reverse2BTN;
        private Label ExampleLB2_2;
    }
}