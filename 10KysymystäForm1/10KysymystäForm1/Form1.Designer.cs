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
            KysymysLB = new Label();
            VastausLB = new Label();
            groupBox1 = new GroupBox();
            DUMMY = new RadioButton();
            RBD = new RadioButton();
            RBC = new RadioButton();
            RBB = new RadioButton();
            RBA = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Location = new Point(26, 24);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(161, 20);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Vastaus kysymykseen 1.";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(26, 170);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(58, 20);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DUMMY);
            groupBox1.Controls.Add(RBD);
            groupBox1.Controls.Add(RBC);
            groupBox1.Controls.Add(RBB);
            groupBox1.Controls.Add(RBA);
            groupBox1.Location = new Point(304, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(104, 166);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vastaus";
            // 
            // DUMMY
            // 
            DUMMY.AutoCheck = false;
            DUMMY.AutoSize = true;
            DUMMY.Location = new Point(62, 9);
            DUMMY.Name = "DUMMY";
            DUMMY.Size = new Size(36, 24);
            DUMMY.TabIndex = 1;
            DUMMY.Text = "-";
            DUMMY.UseVisualStyleBackColor = true;
            DUMMY.Visible = false;
            // 
            // RBD
            // 
            RBD.AutoSize = true;
            RBD.Location = new Point(33, 129);
            RBD.Name = "RBD";
            RBD.Size = new Size(41, 24);
            RBD.TabIndex = 3;
            RBD.Text = "D";
            RBD.UseVisualStyleBackColor = true;
            // 
            // RBC
            // 
            RBC.AutoSize = true;
            RBC.Location = new Point(33, 99);
            RBC.Name = "RBC";
            RBC.Size = new Size(39, 24);
            RBC.TabIndex = 4;
            RBC.Text = "C";
            RBC.UseVisualStyleBackColor = true;
            // 
            // RBB
            // 
            RBB.AutoSize = true;
            RBB.Location = new Point(33, 69);
            RBB.Name = "RBB";
            RBB.Size = new Size(39, 24);
            RBB.TabIndex = 3;
            RBB.Text = "B";
            RBB.UseVisualStyleBackColor = true;
            // 
            // RBA
            // 
            RBA.AutoSize = true;
            RBA.Location = new Point(33, 39);
            RBA.Name = "RBA";
            RBA.Size = new Size(40, 24);
            RBA.TabIndex = 2;
            RBA.Text = "A";
            RBA.UseVisualStyleBackColor = true;
            // 
            // VastauslomakeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 243);
            Controls.Add(groupBox1);
            Controls.Add(VastausLB);
            Controls.Add(KysymysLB);
            Name = "VastauslomakeForm";
            Text = "Vastaus lomake";
            Load += VastauslomakeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private Label VastausLB;
        private GroupBox groupBox1;
        private RadioButton RBC;
        private RadioButton RBB;
        private RadioButton RBA;
        private RadioButton RBD;
        private RadioButton DUMMY;
    }
}