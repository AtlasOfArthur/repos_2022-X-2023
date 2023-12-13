namespace _15_Sekunttikello
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
            components = new System.ComponentModel.Container();
            AikaLB = new Label();
            KäynnistäBT = new Button();
            PysäytäBT = new Button();
            TyhjennäBT = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("OCR A Extended", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AikaLB.Location = new Point(12, 56);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(928, 123);
            AikaLB.TabIndex = 0;
            AikaLB.Text = "00:00:00:000";
            // 
            // KäynnistäBT
            // 
            KäynnistäBT.BackColor = Color.Bisque;
            KäynnistäBT.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KäynnistäBT.Location = new Point(53, 236);
            KäynnistäBT.Name = "KäynnistäBT";
            KäynnistäBT.Size = new Size(254, 123);
            KäynnistäBT.TabIndex = 1;
            KäynnistäBT.Text = "Start";
            KäynnistäBT.UseVisualStyleBackColor = false;
            KäynnistäBT.Click += KäynnistäBT_Click;
            // 
            // PysäytäBT
            // 
            PysäytäBT.BackColor = Color.Bisque;
            PysäytäBT.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PysäytäBT.Location = new Point(342, 236);
            PysäytäBT.Name = "PysäytäBT";
            PysäytäBT.Size = new Size(254, 123);
            PysäytäBT.TabIndex = 2;
            PysäytäBT.Text = "Stop";
            PysäytäBT.UseVisualStyleBackColor = false;
            PysäytäBT.Click += PysäytäBT_Click;
            // 
            // TyhjennäBT
            // 
            TyhjennäBT.BackColor = Color.Bisque;
            TyhjennäBT.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TyhjennäBT.Location = new Point(631, 236);
            TyhjennäBT.Name = "TyhjennäBT";
            TyhjennäBT.Size = new Size(254, 123);
            TyhjennäBT.TabIndex = 3;
            TyhjennäBT.Text = "Clear";
            TyhjennäBT.UseVisualStyleBackColor = false;
            TyhjennäBT.Click += TyhjennäBT_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(951, 411);
            Controls.Add(TyhjennäBT);
            Controls.Add(PysäytäBT);
            Controls.Add(KäynnistäBT);
            Controls.Add(AikaLB);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AikaLB;
        private Button KäynnistäBT;
        private Button PysäytäBT;
        private Button TyhjennäBT;
        private System.Windows.Forms.Timer timer1;
    }
}
