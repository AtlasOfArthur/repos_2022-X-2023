namespace _19_KahvilaMenubar
{
    partial class KahvilaMenubarForm
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
            VasenPanel = new Panel();
            YläPanel = new Panel();
            meistaPanel = new Panel();
            RuuatPanel = new Panel();
            juomatPanel = new Panel();
            herkutPanel = new Panel();
            koriPanel = new Panel();
            SuspendLayout();
            // 
            // VasenPanel
            // 
            VasenPanel.BackColor = Color.FromArgb(62, 172, 64);
            VasenPanel.Dock = DockStyle.Left;
            VasenPanel.Location = new Point(0, 0);
            VasenPanel.Name = "VasenPanel";
            VasenPanel.Size = new Size(135, 253);
            VasenPanel.TabIndex = 0;
            // 
            // YläPanel
            // 
            YläPanel.BackColor = Color.FromArgb(255, 153, 2);
            YläPanel.Dock = DockStyle.Top;
            YläPanel.Location = new Point(135, 0);
            YläPanel.Name = "YläPanel";
            YläPanel.Size = new Size(497, 40);
            YläPanel.TabIndex = 1;
            // 
            // meistaPanel
            // 
            meistaPanel.Dock = DockStyle.Fill;
            meistaPanel.Location = new Point(135, 40);
            meistaPanel.Name = "meistaPanel";
            meistaPanel.Size = new Size(497, 213);
            meistaPanel.TabIndex = 2;
            // 
            // RuuatPanel
            // 
            RuuatPanel.Dock = DockStyle.Fill;
            RuuatPanel.Location = new Point(135, 40);
            RuuatPanel.Name = "RuuatPanel";
            RuuatPanel.Size = new Size(497, 213);
            RuuatPanel.TabIndex = 3;
            // 
            // juomatPanel
            // 
            juomatPanel.Dock = DockStyle.Fill;
            juomatPanel.Location = new Point(135, 40);
            juomatPanel.Name = "juomatPanel";
            juomatPanel.Size = new Size(497, 213);
            juomatPanel.TabIndex = 4;
            // 
            // herkutPanel
            // 
            herkutPanel.Dock = DockStyle.Fill;
            herkutPanel.Location = new Point(135, 40);
            herkutPanel.Name = "herkutPanel";
            herkutPanel.Size = new Size(497, 213);
            herkutPanel.TabIndex = 5;
            // 
            // koriPanel
            // 
            koriPanel.Dock = DockStyle.Fill;
            koriPanel.Location = new Point(135, 40);
            koriPanel.Name = "koriPanel";
            koriPanel.Size = new Size(497, 213);
            koriPanel.TabIndex = 6;
            // 
            // KahvilaMenubarForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(228, 228, 228);
            ClientSize = new Size(632, 253);
            Controls.Add(koriPanel);
            Controls.Add(herkutPanel);
            Controls.Add(juomatPanel);
            Controls.Add(RuuatPanel);
            Controls.Add(meistaPanel);
            Controls.Add(YläPanel);
            Controls.Add(VasenPanel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 6, 6, 6);
            Name = "KahvilaMenubarForm";
            Text = "Ruokalista";
            ResumeLayout(false);
        }

        #endregion

        private Panel VasenPanel;
        private Panel YläPanel;
        private Panel meistaPanel;
        private Panel RuuatPanel;
        private Panel juomatPanel;
        private Panel herkutPanel;
        private Panel koriPanel;
    }
}
