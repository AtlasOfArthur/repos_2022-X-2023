namespace _10KysymystäForm1
{
    partial class VastauslomakeForm
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.VastausLB = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBD = new System.Windows.Forms.RadioButton();
            this.RBC = new System.Windows.Forms.RadioButton();
            this.RBB = new System.Windows.Forms.RadioButton();
            this.RBA = new System.Windows.Forms.RadioButton();
            this.DummyRB = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(26, 24);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(161, 20);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaus kysymykseen 1.";
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(26, 170);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(58, 20);
            this.VastausLB.TabIndex = 1;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBD);
            this.groupBox1.Controls.Add(this.RBC);
            this.groupBox1.Controls.Add(this.RBB);
            this.groupBox1.Controls.Add(this.RBA);
            this.groupBox1.Controls.Add(this.DummyRB);
            this.groupBox1.Location = new System.Drawing.Point(224, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(104, 166);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vastaus";
            // 
            // RBD
            // 
            this.RBD.AutoSize = true;
            this.RBD.Location = new System.Drawing.Point(28, 129);
            this.RBD.Name = "RBD";
            this.RBD.Size = new System.Drawing.Size(41, 24);
            this.RBD.TabIndex = 4;
            this.RBD.TabStop = true;
            this.RBD.Text = "D";
            this.RBD.UseVisualStyleBackColor = true;
            // 
            // RBC
            // 
            this.RBC.AutoSize = true;
            this.RBC.Location = new System.Drawing.Point(28, 99);
            this.RBC.Name = "RBC";
            this.RBC.Size = new System.Drawing.Size(39, 24);
            this.RBC.TabIndex = 3;
            this.RBC.TabStop = true;
            this.RBC.Text = "C";
            this.RBC.UseVisualStyleBackColor = true;
            // 
            // RBB
            // 
            this.RBB.AutoSize = true;
            this.RBB.Location = new System.Drawing.Point(28, 69);
            this.RBB.Name = "RBB";
            this.RBB.Size = new System.Drawing.Size(39, 24);
            this.RBB.TabIndex = 2;
            this.RBB.TabStop = true;
            this.RBB.Text = "B";
            this.RBB.UseVisualStyleBackColor = true;
            // 
            // RBA
            // 
            this.RBA.AutoSize = true;
            this.RBA.Location = new System.Drawing.Point(28, 39);
            this.RBA.Name = "RBA";
            this.RBA.Size = new System.Drawing.Size(40, 24);
            this.RBA.TabIndex = 1;
            this.RBA.TabStop = true;
            this.RBA.Text = "A";
            this.RBA.UseVisualStyleBackColor = true;
            // 
            // DummyRB
            // 
            this.DummyRB.AutoCheck = false;
            this.DummyRB.AutoSize = true;
            this.DummyRB.Location = new System.Drawing.Point(28, 39);
            this.DummyRB.Name = "DummyRB";
            this.DummyRB.Size = new System.Drawing.Size(36, 24);
            this.DummyRB.TabIndex = 0;
            this.DummyRB.TabStop = true;
            this.DummyRB.Text = "-";
            this.DummyRB.UseVisualStyleBackColor = true;
            this.DummyRB.Visible = false;
            // 
            // VastauslomakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 451);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.KysymysLB);
            this.Name = "VastauslomakeForm";
            this.Text = "Vastaus lomake";
            this.Load += new System.EventHandler(this.VastauslomakeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label KysymysLB;
        private Label VastausLB;
        private GroupBox groupBox1;
        private RadioButton RBD;
        private RadioButton RBC;
        private RadioButton RBB;
        private RadioButton RBA;
        private RadioButton DummyRB;
    }
}