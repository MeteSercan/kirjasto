namespace kirjasto_ohjelma5
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tunnus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            etunimi = new TextBox();
            label3 = new Label();
            sukunimi = new TextBox();
            label4 = new Label();
            osoite = new TextBox();
            label5 = new Label();
            posti = new TextBox();
            label6 = new Label();
            kaupunki = new TextBox();
            label7 = new Label();
            puhelin = new TextBox();
            label9 = new Label();
            Lisaa_asiakas = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // tunnus
            // 
            tunnus.Location = new Point(352, 138);
            tunnus.Name = "tunnus";
            tunnus.Size = new Size(257, 23);
            tunnus.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 143);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Asiakas Tunnus";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(331, 81);
            label2.Name = "label2";
            label2.Size = new Size(119, 28);
            label2.TabIndex = 1;
            label2.Text = "Uusi Asiakas";
            // 
            // etunimi
            // 
            etunimi.Location = new Point(352, 181);
            etunimi.Name = "etunimi";
            etunimi.Size = new Size(257, 23);
            etunimi.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 186);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 1;
            label3.Text = "Etunimi";
            // 
            // sukunimi
            // 
            sukunimi.Location = new Point(352, 228);
            sukunimi.Name = "sukunimi";
            sukunimi.Size = new Size(257, 23);
            sukunimi.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(211, 233);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 1;
            label4.Text = "Sukunimi";
            // 
            // osoite
            // 
            osoite.Location = new Point(352, 272);
            osoite.Name = "osoite";
            osoite.Size = new Size(257, 23);
            osoite.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 277);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 1;
            label5.Text = "Osoite";
            // 
            // posti
            // 
            posti.Location = new Point(352, 311);
            posti.Name = "posti";
            posti.Size = new Size(257, 23);
            posti.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 316);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 1;
            label6.Text = "Posti No";
            // 
            // kaupunki
            // 
            kaupunki.Location = new Point(352, 350);
            kaupunki.Name = "kaupunki";
            kaupunki.Size = new Size(257, 23);
            kaupunki.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(211, 355);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 1;
            label7.Text = "Kaupunki";
            // 
            // puhelin
            // 
            puhelin.Location = new Point(350, 392);
            puhelin.Name = "puhelin";
            puhelin.Size = new Size(257, 23);
            puhelin.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(211, 397);
            label9.Name = "label9";
            label9.Size = new Size(47, 15);
            label9.TabIndex = 1;
            label9.Text = "Puhelin";
            // 
            // Lisaa_asiakas
            // 
            Lisaa_asiakas.Location = new Point(637, 216);
            Lisaa_asiakas.Name = "Lisaa_asiakas";
            Lisaa_asiakas.Size = new Size(142, 115);
            Lisaa_asiakas.TabIndex = 2;
            Lisaa_asiakas.Text = "Lisää Asiakas";
            Lisaa_asiakas.UseVisualStyleBackColor = true;
            Lisaa_asiakas.Click += Lisaa_asiakas_Click;
            // 
            // button1
            // 
            button1.Location = new Point(652, 386);
            button1.Name = "button1";
            button1.Size = new Size(121, 52);
            button1.TabIndex = 3;
            button1.Text = "Takaisin";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Lisaa_asiakas);
            Controls.Add(label2);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(puhelin);
            Controls.Add(kaupunki);
            Controls.Add(posti);
            Controls.Add(osoite);
            Controls.Add(sukunimi);
            Controls.Add(etunimi);
            Controls.Add(tunnus);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tunnus;
        private Label label1;
        private Label label2;
        private TextBox etunimi;
        private Label label3;
        private TextBox sukunimi;
        private Label label4;
        private TextBox osoite;
        private Label label5;
        private TextBox posti;
        private Label label6;
        private TextBox kaupunki;
        private Label label7;
        private TextBox puhelin;
        private Label label9;
        private Button Lisaa_asiakas;
        private Button button1;
    }
}