﻿namespace OmaProjekti_RuoanKoontiSovellus_Arthur
{
    partial class AterianKoontiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AterianKoontiForm));
            WelcomePanel = new Panel();
            CloseWelcomeBT = new Button();
            TervetuloaTextiLB = new Label();
            TervetuloaLB = new Label();
            Otsikko1LB = new Label();
            KokoaAteriasiLB = new Label();
            MittaritPanel = new Panel();
            MuuRavSisLB = new Label();
            label1 = new Label();
            RavintoarvojenYksikotMineralLB = new Label();
            B12ArvoLB = new Label();
            B6ArvoLB = new Label();
            B2ArvoLB = new Label();
            B1ArvoLB = new Label();
            KuidutLB = new Label();
            KArvoLB = new Label();
            PRasvaLB = new Label();
            EArvoLB = new Label();
            KRasvaLB = new Label();
            DArvoLB = new Label();
            SokeriArvoLB = new Label();
            CArvoLB = new Label();
            ProteinArvoLB = new Label();
            AArvoLB = new Label();
            HiHyArvoLB = new Label();
            KupariArvoLB = new Label();
            RavintoarvojenYksikotLB = new Label();
            JodiArvoLB = new Label();
            KCalArvoLB = new Label();
            SinkkiArvoLB = new Label();
            RavintosisältoLB = new Label();
            RautaArvoLB = new Label();
            MagnesiumArvoLB = new Label();
            FosforiArvoLB = new Label();
            KaliumArvoLB = new Label();
            PotassiumArvoLB = new Label();
            NatriumArvoLB = new Label();
            VitamiiniOtsikkoLB = new Label();
            MineraaliOtsikkoLB = new Label();
            VitamiinitLB = new Label();
            MineraalitLB = new Label();
            MittaritLB = new Label();
            KategoriaLB = new Label();
            AinesosaLB = new Label();
            KategoriaCB = new ComboBox();
            LajiCB = new ComboBox();
            ValinnatFlowLayoutPanel = new FlowLayoutPanel();
            WelcomePanel.SuspendLayout();
            MittaritPanel.SuspendLayout();
            SuspendLayout();
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.Ivory;
            WelcomePanel.Controls.Add(CloseWelcomeBT);
            WelcomePanel.Controls.Add(TervetuloaTextiLB);
            WelcomePanel.Controls.Add(TervetuloaLB);
            WelcomePanel.Location = new Point(1322, 143);
            WelcomePanel.Margin = new Padding(2, 3, 2, 3);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(1382, 931);
            WelcomePanel.TabIndex = 0;
            // 
            // CloseWelcomeBT
            // 
            CloseWelcomeBT.FlatAppearance.BorderSize = 0;
            CloseWelcomeBT.FlatAppearance.MouseDownBackColor = Color.Ivory;
            CloseWelcomeBT.FlatAppearance.MouseOverBackColor = Color.Ivory;
            CloseWelcomeBT.FlatStyle = FlatStyle.Flat;
            CloseWelcomeBT.Font = new Font("OCR A Extended", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseWelcomeBT.ForeColor = Color.Gray;
            CloseWelcomeBT.Location = new Point(1109, 24);
            CloseWelcomeBT.Name = "CloseWelcomeBT";
            CloseWelcomeBT.Size = new Size(44, 46);
            CloseWelcomeBT.TabIndex = 2;
            CloseWelcomeBT.Text = "X";
            CloseWelcomeBT.UseVisualStyleBackColor = true;
            CloseWelcomeBT.Click += CloseWelcomeBT_Click;
            CloseWelcomeBT.MouseLeave += CloseWelcomeBT_MouseLeave;
            CloseWelcomeBT.MouseHover += CloseWelcomeBT_MouseHover;
            // 
            // TervetuloaTextiLB
            // 
            TervetuloaTextiLB.AutoSize = true;
            TervetuloaTextiLB.Location = new Point(422, 141);
            TervetuloaTextiLB.Name = "TervetuloaTextiLB";
            TervetuloaTextiLB.Size = new Size(733, 336);
            TervetuloaTextiLB.TabIndex = 1;
            TervetuloaTextiLB.Text = resources.GetString("TervetuloaTextiLB.Text");
            TervetuloaTextiLB.TextAlign = ContentAlignment.TopCenter;
            // 
            // TervetuloaLB
            // 
            TervetuloaLB.AutoSize = true;
            TervetuloaLB.Font = new Font("Script MT Bold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TervetuloaLB.Location = new Point(479, 61);
            TervetuloaLB.Name = "TervetuloaLB";
            TervetuloaLB.Size = new Size(217, 48);
            TervetuloaLB.TabIndex = 0;
            TervetuloaLB.Text = "Tervetuloa !";
            TervetuloaLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Otsikko1LB
            // 
            Otsikko1LB.AutoSize = true;
            Otsikko1LB.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Otsikko1LB.Location = new Point(539, 35);
            Otsikko1LB.Name = "Otsikko1LB";
            Otsikko1LB.Size = new Size(375, 49);
            Otsikko1LB.TabIndex = 1;
            Otsikko1LB.Text = "Aterian koonti sovellus";
            Otsikko1LB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KokoaAteriasiLB
            // 
            KokoaAteriasiLB.AutoSize = true;
            KokoaAteriasiLB.Font = new Font("Monotype Corsiva", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            KokoaAteriasiLB.Location = new Point(12, 125);
            KokoaAteriasiLB.Name = "KokoaAteriasiLB";
            KokoaAteriasiLB.Size = new Size(206, 41);
            KokoaAteriasiLB.TabIndex = 2;
            KokoaAteriasiLB.Text = "Kokoa ateriasi";
            KokoaAteriasiLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MittaritPanel
            // 
            MittaritPanel.BackColor = Color.SeaShell;
            MittaritPanel.Controls.Add(MuuRavSisLB);
            MittaritPanel.Controls.Add(label1);
            MittaritPanel.Controls.Add(RavintoarvojenYksikotMineralLB);
            MittaritPanel.Controls.Add(B12ArvoLB);
            MittaritPanel.Controls.Add(B6ArvoLB);
            MittaritPanel.Controls.Add(B2ArvoLB);
            MittaritPanel.Controls.Add(B1ArvoLB);
            MittaritPanel.Controls.Add(KuidutLB);
            MittaritPanel.Controls.Add(KArvoLB);
            MittaritPanel.Controls.Add(PRasvaLB);
            MittaritPanel.Controls.Add(EArvoLB);
            MittaritPanel.Controls.Add(KRasvaLB);
            MittaritPanel.Controls.Add(DArvoLB);
            MittaritPanel.Controls.Add(SokeriArvoLB);
            MittaritPanel.Controls.Add(CArvoLB);
            MittaritPanel.Controls.Add(ProteinArvoLB);
            MittaritPanel.Controls.Add(AArvoLB);
            MittaritPanel.Controls.Add(HiHyArvoLB);
            MittaritPanel.Controls.Add(KupariArvoLB);
            MittaritPanel.Controls.Add(RavintoarvojenYksikotLB);
            MittaritPanel.Controls.Add(JodiArvoLB);
            MittaritPanel.Controls.Add(KCalArvoLB);
            MittaritPanel.Controls.Add(SinkkiArvoLB);
            MittaritPanel.Controls.Add(RavintosisältoLB);
            MittaritPanel.Controls.Add(RautaArvoLB);
            MittaritPanel.Controls.Add(MagnesiumArvoLB);
            MittaritPanel.Controls.Add(FosforiArvoLB);
            MittaritPanel.Controls.Add(KaliumArvoLB);
            MittaritPanel.Controls.Add(PotassiumArvoLB);
            MittaritPanel.Controls.Add(NatriumArvoLB);
            MittaritPanel.Controls.Add(VitamiiniOtsikkoLB);
            MittaritPanel.Controls.Add(MineraaliOtsikkoLB);
            MittaritPanel.Controls.Add(VitamiinitLB);
            MittaritPanel.Controls.Add(MineraalitLB);
            MittaritPanel.Location = new Point(510, 300);
            MittaritPanel.Name = "MittaritPanel";
            MittaritPanel.Size = new Size(807, 407);
            MittaritPanel.TabIndex = 3;
            // 
            // MuuRavSisLB
            // 
            MuuRavSisLB.AutoSize = true;
            MuuRavSisLB.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            MuuRavSisLB.Location = new Point(445, 25);
            MuuRavSisLB.Name = "MuuRavSisLB";
            MuuRavSisLB.Size = new Size(244, 23);
            MuuRavSisLB.TabIndex = 30;
            MuuRavSisLB.Text = "Muu ravintosisältö";
            MuuRavSisLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(371, 81);
            label1.Name = "label1";
            label1.Size = new Size(28, 289);
            label1.TabIndex = 29;
            label1.Text = "mg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nµg\r\n";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RavintoarvojenYksikotMineralLB
            // 
            RavintoarvojenYksikotMineralLB.AutoSize = true;
            RavintoarvojenYksikotMineralLB.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RavintoarvojenYksikotMineralLB.Location = new Point(181, 81);
            RavintoarvojenYksikotMineralLB.Name = "RavintoarvojenYksikotMineralLB";
            RavintoarvojenYksikotMineralLB.Size = new Size(28, 289);
            RavintoarvojenYksikotMineralLB.TabIndex = 28;
            RavintoarvojenYksikotMineralLB.Text = "mg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n\r\nmg\r\n";
            RavintoarvojenYksikotMineralLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // B12ArvoLB
            // 
            B12ArvoLB.AutoSize = true;
            B12ArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B12ArvoLB.Location = new Point(320, 351);
            B12ArvoLB.Name = "B12ArvoLB";
            B12ArvoLB.Size = new Size(21, 19);
            B12ArvoLB.TabIndex = 27;
            B12ArvoLB.Text = "0";
            // 
            // B6ArvoLB
            // 
            B6ArvoLB.AutoSize = true;
            B6ArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B6ArvoLB.Location = new Point(320, 317);
            B6ArvoLB.Name = "B6ArvoLB";
            B6ArvoLB.Size = new Size(21, 19);
            B6ArvoLB.TabIndex = 26;
            B6ArvoLB.Text = "0";
            // 
            // B2ArvoLB
            // 
            B2ArvoLB.AutoSize = true;
            B2ArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B2ArvoLB.Location = new Point(320, 283);
            B2ArvoLB.Name = "B2ArvoLB";
            B2ArvoLB.Size = new Size(21, 19);
            B2ArvoLB.TabIndex = 25;
            B2ArvoLB.Text = "0";
            // 
            // B1ArvoLB
            // 
            B1ArvoLB.AutoSize = true;
            B1ArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            B1ArvoLB.Location = new Point(320, 249);
            B1ArvoLB.Name = "B1ArvoLB";
            B1ArvoLB.Size = new Size(21, 19);
            B1ArvoLB.TabIndex = 24;
            B1ArvoLB.Text = "0";
            // 
            // KuidutLB
            // 
            KuidutLB.AutoSize = true;
            KuidutLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KuidutLB.Location = new Point(674, 309);
            KuidutLB.Name = "KuidutLB";
            KuidutLB.Size = new Size(21, 19);
            KuidutLB.TabIndex = 13;
            KuidutLB.Text = "0";
            // 
            // KArvoLB
            // 
            KArvoLB.AutoSize = true;
            KArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KArvoLB.Location = new Point(320, 215);
            KArvoLB.Name = "KArvoLB";
            KArvoLB.Size = new Size(21, 19);
            KArvoLB.TabIndex = 23;
            KArvoLB.Text = "0";
            // 
            // PRasvaLB
            // 
            PRasvaLB.AutoSize = true;
            PRasvaLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PRasvaLB.Location = new Point(674, 233);
            PRasvaLB.Name = "PRasvaLB";
            PRasvaLB.Size = new Size(21, 19);
            PRasvaLB.TabIndex = 12;
            PRasvaLB.Text = "0";
            // 
            // EArvoLB
            // 
            EArvoLB.AutoSize = true;
            EArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EArvoLB.Location = new Point(320, 181);
            EArvoLB.Name = "EArvoLB";
            EArvoLB.Size = new Size(21, 19);
            EArvoLB.TabIndex = 22;
            EArvoLB.Text = "0";
            // 
            // KRasvaLB
            // 
            KRasvaLB.AutoSize = true;
            KRasvaLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KRasvaLB.Location = new Point(674, 271);
            KRasvaLB.Name = "KRasvaLB";
            KRasvaLB.Size = new Size(21, 19);
            KRasvaLB.TabIndex = 11;
            KRasvaLB.Text = "0";
            // 
            // DArvoLB
            // 
            DArvoLB.AutoSize = true;
            DArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DArvoLB.Location = new Point(320, 147);
            DArvoLB.Name = "DArvoLB";
            DArvoLB.Size = new Size(21, 19);
            DArvoLB.TabIndex = 21;
            DArvoLB.Text = "0";
            // 
            // SokeriArvoLB
            // 
            SokeriArvoLB.AutoSize = true;
            SokeriArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SokeriArvoLB.Location = new Point(674, 195);
            SokeriArvoLB.Name = "SokeriArvoLB";
            SokeriArvoLB.Size = new Size(21, 19);
            SokeriArvoLB.TabIndex = 10;
            SokeriArvoLB.Text = "0";
            // 
            // CArvoLB
            // 
            CArvoLB.AutoSize = true;
            CArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CArvoLB.Location = new Point(320, 113);
            CArvoLB.Name = "CArvoLB";
            CArvoLB.Size = new Size(21, 19);
            CArvoLB.TabIndex = 20;
            CArvoLB.Text = "0";
            // 
            // ProteinArvoLB
            // 
            ProteinArvoLB.AutoSize = true;
            ProteinArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProteinArvoLB.Location = new Point(674, 119);
            ProteinArvoLB.Name = "ProteinArvoLB";
            ProteinArvoLB.Size = new Size(21, 19);
            ProteinArvoLB.TabIndex = 9;
            ProteinArvoLB.Text = "0";
            // 
            // AArvoLB
            // 
            AArvoLB.AutoSize = true;
            AArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AArvoLB.Location = new Point(320, 79);
            AArvoLB.Name = "AArvoLB";
            AArvoLB.Size = new Size(21, 19);
            AArvoLB.TabIndex = 19;
            AArvoLB.Text = "0";
            // 
            // HiHyArvoLB
            // 
            HiHyArvoLB.AutoSize = true;
            HiHyArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HiHyArvoLB.Location = new Point(674, 157);
            HiHyArvoLB.Name = "HiHyArvoLB";
            HiHyArvoLB.Size = new Size(21, 19);
            HiHyArvoLB.TabIndex = 8;
            HiHyArvoLB.Text = "0";
            // 
            // KupariArvoLB
            // 
            KupariArvoLB.AutoSize = true;
            KupariArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KupariArvoLB.Location = new Point(134, 351);
            KupariArvoLB.Name = "KupariArvoLB";
            KupariArvoLB.Size = new Size(21, 19);
            KupariArvoLB.TabIndex = 18;
            KupariArvoLB.Text = "0";
            // 
            // RavintoarvojenYksikotLB
            // 
            RavintoarvojenYksikotLB.AutoSize = true;
            RavintoarvojenYksikotLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RavintoarvojenYksikotLB.Location = new Point(726, 81);
            RavintoarvojenYksikotLB.Name = "RavintoarvojenYksikotLB";
            RavintoarvojenYksikotLB.Size = new Size(57, 247);
            RavintoarvojenYksikotLB.TabIndex = 7;
            RavintoarvojenYksikotLB.Text = "KCal\r\n\r\ng\r\n\r\ng\r\n\r\ng\r\n\r\ng\r\n\r\ng\r\n\r\ng";
            RavintoarvojenYksikotLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // JodiArvoLB
            // 
            JodiArvoLB.AutoSize = true;
            JodiArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JodiArvoLB.Location = new Point(134, 317);
            JodiArvoLB.Name = "JodiArvoLB";
            JodiArvoLB.Size = new Size(21, 19);
            JodiArvoLB.TabIndex = 17;
            JodiArvoLB.Text = "0";
            // 
            // KCalArvoLB
            // 
            KCalArvoLB.AutoSize = true;
            KCalArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KCalArvoLB.Location = new Point(674, 81);
            KCalArvoLB.Name = "KCalArvoLB";
            KCalArvoLB.Size = new Size(21, 19);
            KCalArvoLB.TabIndex = 6;
            KCalArvoLB.Text = "0";
            // 
            // SinkkiArvoLB
            // 
            SinkkiArvoLB.AutoSize = true;
            SinkkiArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SinkkiArvoLB.Location = new Point(134, 283);
            SinkkiArvoLB.Name = "SinkkiArvoLB";
            SinkkiArvoLB.Size = new Size(21, 19);
            SinkkiArvoLB.TabIndex = 16;
            SinkkiArvoLB.Text = "0";
            // 
            // RavintosisältoLB
            // 
            RavintosisältoLB.AutoSize = true;
            RavintosisältoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RavintosisältoLB.Location = new Point(445, 81);
            RavintosisältoLB.Name = "RavintosisältoLB";
            RavintosisältoLB.Size = new Size(213, 247);
            RavintosisältoLB.TabIndex = 5;
            RavintosisältoLB.Text = "KCal:\r\n\r\nProteini:\r\n\r\nHiilihydraatit:\r\n\r\nJoista sokereita:\r\n\r\nPehmeä rasva:\r\n\r\nKova rasva:\r\n\r\nKuidut:";
            RavintosisältoLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // RautaArvoLB
            // 
            RautaArvoLB.AutoSize = true;
            RautaArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RautaArvoLB.Location = new Point(134, 249);
            RautaArvoLB.Name = "RautaArvoLB";
            RautaArvoLB.Size = new Size(21, 19);
            RautaArvoLB.TabIndex = 15;
            RautaArvoLB.Text = "0";
            // 
            // MagnesiumArvoLB
            // 
            MagnesiumArvoLB.AutoSize = true;
            MagnesiumArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MagnesiumArvoLB.Location = new Point(134, 215);
            MagnesiumArvoLB.Name = "MagnesiumArvoLB";
            MagnesiumArvoLB.Size = new Size(21, 19);
            MagnesiumArvoLB.TabIndex = 14;
            MagnesiumArvoLB.Text = "0";
            // 
            // FosforiArvoLB
            // 
            FosforiArvoLB.AutoSize = true;
            FosforiArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FosforiArvoLB.Location = new Point(134, 181);
            FosforiArvoLB.Name = "FosforiArvoLB";
            FosforiArvoLB.Size = new Size(21, 19);
            FosforiArvoLB.TabIndex = 13;
            FosforiArvoLB.Text = "0";
            // 
            // KaliumArvoLB
            // 
            KaliumArvoLB.AutoSize = true;
            KaliumArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KaliumArvoLB.Location = new Point(134, 147);
            KaliumArvoLB.Name = "KaliumArvoLB";
            KaliumArvoLB.Size = new Size(21, 19);
            KaliumArvoLB.TabIndex = 12;
            KaliumArvoLB.Text = "0";
            // 
            // PotassiumArvoLB
            // 
            PotassiumArvoLB.AutoSize = true;
            PotassiumArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PotassiumArvoLB.Location = new Point(134, 113);
            PotassiumArvoLB.Name = "PotassiumArvoLB";
            PotassiumArvoLB.Size = new Size(21, 19);
            PotassiumArvoLB.TabIndex = 11;
            PotassiumArvoLB.Text = "0";
            // 
            // NatriumArvoLB
            // 
            NatriumArvoLB.AutoSize = true;
            NatriumArvoLB.Font = new Font("OCR A Extended", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NatriumArvoLB.Location = new Point(134, 79);
            NatriumArvoLB.Name = "NatriumArvoLB";
            NatriumArvoLB.Size = new Size(21, 19);
            NatriumArvoLB.TabIndex = 10;
            NatriumArvoLB.Text = "0";
            // 
            // VitamiiniOtsikkoLB
            // 
            VitamiiniOtsikkoLB.AutoSize = true;
            VitamiiniOtsikkoLB.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            VitamiiniOtsikkoLB.Location = new Point(236, 25);
            VitamiiniOtsikkoLB.Name = "VitamiiniOtsikkoLB";
            VitamiiniOtsikkoLB.Size = new Size(140, 23);
            VitamiiniOtsikkoLB.TabIndex = 9;
            VitamiiniOtsikkoLB.Text = "Vitamiinit";
            VitamiiniOtsikkoLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MineraaliOtsikkoLB
            // 
            MineraaliOtsikkoLB.AutoSize = true;
            MineraaliOtsikkoLB.Font = new Font("OCR A Extended", 12F, FontStyle.Bold);
            MineraaliOtsikkoLB.Location = new Point(15, 25);
            MineraaliOtsikkoLB.Name = "MineraaliOtsikkoLB";
            MineraaliOtsikkoLB.Size = new Size(140, 23);
            MineraaliOtsikkoLB.TabIndex = 8;
            MineraaliOtsikkoLB.Text = "Mineraalit";
            MineraaliOtsikkoLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // VitamiinitLB
            // 
            VitamiinitLB.AutoSize = true;
            VitamiinitLB.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VitamiinitLB.Location = new Point(266, 81);
            VitamiinitLB.Name = "VitamiinitLB";
            VitamiinitLB.Size = new Size(48, 289);
            VitamiinitLB.TabIndex = 7;
            VitamiinitLB.Text = "A:\r\n\r\nC:\r\n\r\nD:\r\n\r\nE:\r\n\r\nK:\r\n\r\nB1:\r\n\r\nB2:\r\n\r\nB6:\r\n\r\nB12:";
            VitamiinitLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MineraalitLB
            // 
            MineraalitLB.AutoSize = true;
            MineraalitLB.Font = new Font("OCR A Extended", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MineraalitLB.Location = new Point(20, 81);
            MineraalitLB.Name = "MineraalitLB";
            MineraalitLB.Size = new Size(108, 289);
            MineraalitLB.TabIndex = 6;
            MineraalitLB.Text = "Natrium:\r\n\r\nPotassium:\r\n\r\nKalsium:\r\n\r\nFosfori:\r\n\r\nMagnesium:\r\n\r\nRauta:\r\n\r\nSinkki:\r\n\r\nJodi:\r\n\r\nKupari:";
            MineraalitLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MittaritLB
            // 
            MittaritLB.AutoSize = true;
            MittaritLB.Font = new Font("Monotype Corsiva", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MittaritLB.Location = new Point(510, 239);
            MittaritLB.Name = "MittaritLB";
            MittaritLB.Size = new Size(128, 41);
            MittaritLB.TabIndex = 4;
            MittaritLB.Text = "Mittarit";
            MittaritLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // KategoriaLB
            // 
            KategoriaLB.AutoSize = true;
            KategoriaLB.Font = new Font("OCR A Extended", 10.2F, FontStyle.Bold);
            KategoriaLB.Location = new Point(36, 210);
            KategoriaLB.Name = "KategoriaLB";
            KategoriaLB.Size = new Size(195, 18);
            KategoriaLB.TabIndex = 28;
            KategoriaLB.Text = "Valitse kategoria";
            KategoriaLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AinesosaLB
            // 
            AinesosaLB.AutoSize = true;
            AinesosaLB.Font = new Font("OCR A Extended", 10.2F, FontStyle.Bold);
            AinesosaLB.Location = new Point(285, 210);
            AinesosaLB.Name = "AinesosaLB";
            AinesosaLB.Size = new Size(184, 18);
            AinesosaLB.TabIndex = 29;
            AinesosaLB.Text = "Valitse ainesosa";
            AinesosaLB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // KategoriaCB
            // 
            KategoriaCB.Font = new Font("OCR A Extended", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            KategoriaCB.FormattingEnabled = true;
            KategoriaCB.Location = new Point(36, 239);
            KategoriaCB.Name = "KategoriaCB";
            KategoriaCB.Size = new Size(243, 26);
            KategoriaCB.TabIndex = 30;
            // 
            // LajiCB
            // 
            LajiCB.Font = new Font("OCR A Extended", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LajiCB.FormattingEnabled = true;
            LajiCB.Location = new Point(285, 239);
            LajiCB.Name = "LajiCB";
            LajiCB.Size = new Size(184, 26);
            LajiCB.TabIndex = 31;
            LajiCB.SelectedIndexChanged += LajiCB_SelectedIndexChanged;
            // 
            // ValinnatFlowLayoutPanel
            // 
            ValinnatFlowLayoutPanel.BackColor = Color.Snow;
            ValinnatFlowLayoutPanel.Location = new Point(36, 300);
            ValinnatFlowLayoutPanel.Name = "ValinnatFlowLayoutPanel";
            ValinnatFlowLayoutPanel.Size = new Size(433, 407);
            ValinnatFlowLayoutPanel.TabIndex = 32;
            // 
            // AterianKoontiForm
            // 
            AutoScaleDimensions = new SizeF(13F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1356, 748);
            Controls.Add(WelcomePanel);
            Controls.Add(ValinnatFlowLayoutPanel);
            Controls.Add(LajiCB);
            Controls.Add(KategoriaCB);
            Controls.Add(AinesosaLB);
            Controls.Add(KategoriaLB);
            Controls.Add(MittaritLB);
            Controls.Add(MittaritPanel);
            Controls.Add(KokoaAteriasiLB);
            Controls.Add(Otsikko1LB);
            Font = new Font("Script MT Bold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 3, 5, 3);
            Name = "AterianKoontiForm";
            Text = "Ruoan koonti sovellus";
            Load += RuoanKoontiForm_Load;
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            MittaritPanel.ResumeLayout(false);
            MittaritPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel WelcomePanel;
        private Button CloseWelcomeBT;
        private Label TervetuloaTextiLB;
        private Label TervetuloaLB;
        private Label Otsikko1LB;
        private Label KokoaAteriasiLB;
        private Panel MittaritPanel;
        private Label MittaritLB;
        private Label RavintosisältoLB;
        private Label KCalArvoLB;
        private Label RavintoarvojenYksikotLB;
        private Label HiHyArvoLB;
        private Label ProteinArvoLB;
        private Label PRasvaLB;
        private Label KRasvaLB;
        private Label SokeriArvoLB;
        private Label KuidutLB;
        private Label MineraalitLB;
        private Label VitamiinitLB;
        private Label KupariArvoLB;
        private Label JodiArvoLB;
        private Label SinkkiArvoLB;
        private Label RautaArvoLB;
        private Label MagnesiumArvoLB;
        private Label FosforiArvoLB;
        private Label KaliumArvoLB;
        private Label PotassiumArvoLB;
        private Label NatriumArvoLB;
        private Label VitamiiniOtsikkoLB;
        private Label MineraaliOtsikkoLB;
        private Label B12ArvoLB;
        private Label B6ArvoLB;
        private Label B2ArvoLB;
        private Label B1ArvoLB;
        private Label KArvoLB;
        private Label EArvoLB;
        private Label DArvoLB;
        private Label CArvoLB;
        private Label AArvoLB;
        private Label KategoriaLB;
        private Label AinesosaLB;
        private ComboBox KategoriaCB;
        private ComboBox LajiCB;
        private FlowLayoutPanel ValinnatFlowLayoutPanel;
        private Label label1;
        private Label RavintoarvojenYksikotMineralLB;
        private Label MuuRavSisLB;
    }
}
