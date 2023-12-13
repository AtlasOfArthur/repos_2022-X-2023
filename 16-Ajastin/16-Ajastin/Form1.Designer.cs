namespace _16_Ajastin
{
    partial class AjastinForm
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
            MinuutitLB = new Label();
            SekunnitLB = new Label();
            MinCB = new ComboBox();
            SecCB = new ComboBox();
            StartBT = new Button();
            label1 = new Label();
            StopBT = new Button();
            AjastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // MinuutitLB
            // 
            MinuutitLB.AutoSize = true;
            MinuutitLB.Font = new Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinuutitLB.Location = new Point(35, 30);
            MinuutitLB.Name = "MinuutitLB";
            MinuutitLB.Size = new Size(205, 44);
            MinuutitLB.TabIndex = 0;
            MinuutitLB.Text = "Minuutit";
            // 
            // SekunnitLB
            // 
            SekunnitLB.AutoSize = true;
            SekunnitLB.Font = new Font("Stencil", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SekunnitLB.Location = new Point(243, 30);
            SekunnitLB.Name = "SekunnitLB";
            SekunnitLB.Size = new Size(209, 44);
            SekunnitLB.TabIndex = 1;
            SekunnitLB.Text = "Sekunnit";
            // 
            // MinCB
            // 
            MinCB.BackColor = Color.SeaShell;
            MinCB.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MinCB.FormattingEnabled = true;
            MinCB.Location = new Point(35, 77);
            MinCB.Name = "MinCB";
            MinCB.Size = new Size(205, 43);
            MinCB.TabIndex = 2;
            // 
            // SecCB
            // 
            SecCB.BackColor = Color.SeaShell;
            SecCB.Font = new Font("OCR A Extended", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SecCB.FormattingEnabled = true;
            SecCB.Location = new Point(243, 77);
            SecCB.Name = "SecCB";
            SecCB.Size = new Size(209, 43);
            SecCB.TabIndex = 3;
            // 
            // StartBT
            // 
            StartBT.BackColor = Color.SeaShell;
            StartBT.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StartBT.Location = new Point(35, 294);
            StartBT.Name = "StartBT";
            StartBT.Size = new Size(205, 66);
            StartBT.TabIndex = 4;
            StartBT.Text = "Start";
            StartBT.UseVisualStyleBackColor = false;
            StartBT.Click += StartBT_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 137);
            label1.Name = "label1";
            label1.Size = new Size(417, 123);
            label1.TabIndex = 5;
            label1.Text = "00:00";
            // 
            // StopBT
            // 
            StopBT.BackColor = Color.SeaShell;
            StopBT.Font = new Font("Stencil", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            StopBT.Location = new Point(243, 294);
            StopBT.Name = "StopBT";
            StopBT.Size = new Size(205, 66);
            StopBT.TabIndex = 6;
            StopBT.Text = "Stop";
            StopBT.UseVisualStyleBackColor = false;
            StopBT.Click += StopBT_Click;
            // 
            // AjastinTM
            // 
            AjastinTM.Interval = 1000;
            AjastinTM.Tick += AjastinTM_Tick;
            // 
            // AjastinForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(489, 386);
            Controls.Add(StopBT);
            Controls.Add(label1);
            Controls.Add(StartBT);
            Controls.Add(SecCB);
            Controls.Add(MinCB);
            Controls.Add(SekunnitLB);
            Controls.Add(MinuutitLB);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 4, 4, 4);
            Name = "AjastinForm";
            Text = "Ajastin";
            Load += AjastinForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label MinuutitLB;
        private Label SekunnitLB;
        private ComboBox MinCB;
        private ComboBox SecCB;
        private Button StartBT;
        private Label label1;
        private Button StopBT;
        private System.Windows.Forms.Timer AjastinTM;
    }
}
