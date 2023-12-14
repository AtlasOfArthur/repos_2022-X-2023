namespace _17_Muistio
{
    partial class MuistioForm
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
            TextRichTB = new RichTextBox();
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            uusiToolStripMenuItem = new ToolStripMenuItem();
            avaaToolStripMenuItem = new ToolStripMenuItem();
            tallennaToolStripMenuItem = new ToolStripMenuItem();
            lopetaToolStripMenuItem = new ToolStripMenuItem();
            muotoileToolStripMenuItem = new ToolStripMenuItem();
            kirjasinToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TextRichTB
            // 
            TextRichTB.BackColor = Color.Black;
            TextRichTB.Dock = DockStyle.Fill;
            TextRichTB.ForeColor = Color.MintCream;
            TextRichTB.Location = new Point(0, 30);
            TextRichTB.Name = "TextRichTB";
            TextRichTB.Size = new Size(1100, 600);
            TextRichTB.TabIndex = 0;
            TextRichTB.Text = "";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Yu Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, muotoileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1100, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uusiToolStripMenuItem, avaaToolStripMenuItem, tallennaToolStripMenuItem, lopetaToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(95, 26);
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            uusiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            uusiToolStripMenuItem.Size = new Size(229, 26);
            uusiToolStripMenuItem.Text = "Uusi";
            uusiToolStripMenuItem.Click += uusiToolStripMenuItem_Click;
            // 
            // avaaToolStripMenuItem
            // 
            avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            avaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            avaaToolStripMenuItem.Size = new Size(229, 26);
            avaaToolStripMenuItem.Text = "Avaa";
            avaaToolStripMenuItem.Click += avaaToolStripMenuItem_Click;
            // 
            // tallennaToolStripMenuItem
            // 
            tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            tallennaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            tallennaToolStripMenuItem.Size = new Size(229, 26);
            tallennaToolStripMenuItem.Text = "Tallenna";
            tallennaToolStripMenuItem.Click += tallennaToolStripMenuItem_Click;
            // 
            // lopetaToolStripMenuItem
            // 
            lopetaToolStripMenuItem.Name = "lopetaToolStripMenuItem";
            lopetaToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            lopetaToolStripMenuItem.Size = new Size(229, 26);
            lopetaToolStripMenuItem.Text = "Lopeta";
            lopetaToolStripMenuItem.Click += lopetaToolStripMenuItem_Click;
            // 
            // muotoileToolStripMenuItem
            // 
            muotoileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kirjasinToolStripMenuItem });
            muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            muotoileToolStripMenuItem.Size = new Size(97, 26);
            muotoileToolStripMenuItem.Text = "Muotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            kirjasinToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            kirjasinToolStripMenuItem.Size = new Size(274, 26);
            kirjasinToolStripMenuItem.Text = "Kirjasin";
            kirjasinToolStripMenuItem.Click += kirjasinToolStripMenuItem_Click;
            // 
            // MuistioForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(TextRichTB);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "MuistioForm";
            Text = "Muistio";
            Load += MuistioForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox TextRichTB;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private ToolStripMenuItem tallennaToolStripMenuItem;
        private ToolStripMenuItem lopetaToolStripMenuItem;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem kirjasinToolStripMenuItem;
    }
}
