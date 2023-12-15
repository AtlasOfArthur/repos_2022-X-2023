namespace _18_Pudotusvalikosta_riippuva_pudotusvalikko
{
    partial class AvainhenkilötForm
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
            OppilaitostenAvainhenkilötLB = new Label();
            ValitseOppilaitosLB = new Label();
            ValitseOppilaitosCB = new ComboBox();
            ValitseVastuuhenkiloCB = new ComboBox();
            ValitseVastuuhenkiloLB = new Label();
            OsoiteLB = new Label();
            PostinumeroLB = new Label();
            PostitoimipaikkaLB = new Label();
            PuhelinLB = new Label();
            Puhelin2LB = new Label();
            SahkopostiLB = new Label();
            OsastoLB = new Label();
            TitteliLB = new Label();
            SuspendLayout();
            // 
            // OppilaitostenAvainhenkilötLB
            // 
            OppilaitostenAvainhenkilötLB.AutoSize = true;
            OppilaitostenAvainhenkilötLB.Font = new Font("Ebrima", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OppilaitostenAvainhenkilötLB.Location = new Point(130, 51);
            OppilaitostenAvainhenkilötLB.Name = "OppilaitostenAvainhenkilötLB";
            OppilaitostenAvainhenkilötLB.Size = new Size(641, 62);
            OppilaitostenAvainhenkilötLB.TabIndex = 0;
            OppilaitostenAvainhenkilötLB.Text = "Oppilaitoksen avainhenkilöt\r\n";
            // 
            // ValitseOppilaitosLB
            // 
            ValitseOppilaitosLB.AutoSize = true;
            ValitseOppilaitosLB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValitseOppilaitosLB.Location = new Point(130, 166);
            ValitseOppilaitosLB.Name = "ValitseOppilaitosLB";
            ValitseOppilaitosLB.Size = new Size(200, 31);
            ValitseOppilaitosLB.TabIndex = 1;
            ValitseOppilaitosLB.Text = "Valitse oppilaitos";
            // 
            // ValitseOppilaitosCB
            // 
            ValitseOppilaitosCB.FormattingEnabled = true;
            ValitseOppilaitosCB.Location = new Point(130, 200);
            ValitseOppilaitosCB.Name = "ValitseOppilaitosCB";
            ValitseOppilaitosCB.Size = new Size(200, 31);
            ValitseOppilaitosCB.TabIndex = 2;
            ValitseOppilaitosCB.SelectedIndexChanged += ValitseOppilaitosCB_SelectedIndexChanged;
            // 
            // ValitseVastuuhenkiloCB
            // 
            ValitseVastuuhenkiloCB.FormattingEnabled = true;
            ValitseVastuuhenkiloCB.Location = new Point(455, 200);
            ValitseVastuuhenkiloCB.Name = "ValitseVastuuhenkiloCB";
            ValitseVastuuhenkiloCB.Size = new Size(200, 31);
            ValitseVastuuhenkiloCB.TabIndex = 4;
            ValitseVastuuhenkiloCB.TextChanged += ValitseVastuuhenkiloCB_TextChanged;
            // 
            // ValitseVastuuhenkiloLB
            // 
            ValitseVastuuhenkiloLB.AutoSize = true;
            ValitseVastuuhenkiloLB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ValitseVastuuhenkiloLB.Location = new Point(455, 166);
            ValitseVastuuhenkiloLB.Name = "ValitseVastuuhenkiloLB";
            ValitseVastuuhenkiloLB.Size = new Size(244, 31);
            ValitseVastuuhenkiloLB.TabIndex = 3;
            ValitseVastuuhenkiloLB.Text = "Valitse vastuuhenkilö";
            // 
            // OsoiteLB
            // 
            OsoiteLB.AutoSize = true;
            OsoiteLB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OsoiteLB.Location = new Point(130, 268);
            OsoiteLB.Name = "OsoiteLB";
            OsoiteLB.Size = new Size(83, 31);
            OsoiteLB.TabIndex = 5;
            OsoiteLB.Text = "Osoite";
            // 
            // PostinumeroLB
            // 
            PostinumeroLB.AutoSize = true;
            PostinumeroLB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PostinumeroLB.Location = new Point(130, 318);
            PostinumeroLB.Name = "PostinumeroLB";
            PostinumeroLB.Size = new Size(152, 31);
            PostinumeroLB.TabIndex = 6;
            PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            PostitoimipaikkaLB.AutoSize = true;
            PostitoimipaikkaLB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PostitoimipaikkaLB.Location = new Point(130, 369);
            PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            PostitoimipaikkaLB.Size = new Size(197, 31);
            PostitoimipaikkaLB.TabIndex = 7;
            PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            PuhelinLB.AutoSize = true;
            PuhelinLB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PuhelinLB.Location = new Point(130, 425);
            PuhelinLB.Name = "PuhelinLB";
            PuhelinLB.Size = new Size(96, 31);
            PuhelinLB.TabIndex = 8;
            PuhelinLB.Text = "Puhelin";
            // 
            // Puhelin2LB
            // 
            Puhelin2LB.AutoSize = true;
            Puhelin2LB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Puhelin2LB.Location = new Point(455, 425);
            Puhelin2LB.Name = "Puhelin2LB";
            Puhelin2LB.Size = new Size(96, 31);
            Puhelin2LB.TabIndex = 12;
            Puhelin2LB.Text = "Puhelin";
            // 
            // SahkopostiLB
            // 
            SahkopostiLB.AutoSize = true;
            SahkopostiLB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SahkopostiLB.Location = new Point(455, 369);
            SahkopostiLB.Name = "SahkopostiLB";
            SahkopostiLB.Size = new Size(134, 31);
            SahkopostiLB.TabIndex = 11;
            SahkopostiLB.Text = "Sähköposti";
            // 
            // OsastoLB
            // 
            OsastoLB.AutoSize = true;
            OsastoLB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OsastoLB.Location = new Point(455, 318);
            OsastoLB.Name = "OsastoLB";
            OsastoLB.Size = new Size(86, 31);
            OsastoLB.TabIndex = 10;
            OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            TitteliLB.AutoSize = true;
            TitteliLB.Font = new Font("Ebrima", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitteliLB.Location = new Point(455, 268);
            TitteliLB.Name = "TitteliLB";
            TitteliLB.Size = new Size(78, 31);
            TitteliLB.TabIndex = 9;
            TitteliLB.Text = "Titteli";
            // 
            // AvainhenkilötForm
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 546);
            Controls.Add(Puhelin2LB);
            Controls.Add(SahkopostiLB);
            Controls.Add(OsastoLB);
            Controls.Add(TitteliLB);
            Controls.Add(PuhelinLB);
            Controls.Add(PostitoimipaikkaLB);
            Controls.Add(PostinumeroLB);
            Controls.Add(OsoiteLB);
            Controls.Add(ValitseVastuuhenkiloCB);
            Controls.Add(ValitseVastuuhenkiloLB);
            Controls.Add(ValitseOppilaitosCB);
            Controls.Add(ValitseOppilaitosLB);
            Controls.Add(OppilaitostenAvainhenkilötLB);
            Font = new Font("Yu Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "AvainhenkilötForm";
            Text = "Avainhenkilot";
            Load += AvainhenkilötForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OppilaitostenAvainhenkilötLB;
        private Label ValitseOppilaitosLB;
        private ComboBox ValitseOppilaitosCB;
        private ComboBox ValitseVastuuhenkiloCB;
        private Label ValitseVastuuhenkiloLB;
        private Label OsoiteLB;
        private Label PostinumeroLB;
        private Label PostitoimipaikkaLB;
        private Label PuhelinLB;
        private Label Puhelin2LB;
        private Label SahkopostiLB;
        private Label OsastoLB;
        private Label TitteliLB;
    }
}
