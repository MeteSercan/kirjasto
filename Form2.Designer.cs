namespace kirjasto_ohjelma5
{
    partial class Form2
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
            label1 = new Label();
            Lisaa_kirja = new Button();
            Lisaa_kirjailija = new Button();
            Nayta_Lainaukset = new Button();
            dataGridViewLainaukset = new DataGridView();
            Nayta_Asiakkaat = new Button();
            dataGridView2 = new DataGridView();
            Lisaa_asiakas = new Button();
            Poista_asiakas = new Button();
            Poistu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLainaukset).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(296, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 46);
            label1.TabIndex = 0;
            label1.Text = "Admin Menu";
            // 
            // Lisaa_kirja
            // 
            Lisaa_kirja.Location = new Point(12, 58);
            Lisaa_kirja.Name = "Lisaa_kirja";
            Lisaa_kirja.Size = new Size(119, 39);
            Lisaa_kirja.TabIndex = 1;
            Lisaa_kirja.Text = "Lisää/Poistaa Kirja";
            Lisaa_kirja.UseVisualStyleBackColor = true;
            Lisaa_kirja.Click += Lisaa_kirja_Click;
            // 
            // Lisaa_kirjailija
            // 
            Lisaa_kirjailija.Location = new Point(171, 58);
            Lisaa_kirjailija.Name = "Lisaa_kirjailija";
            Lisaa_kirjailija.Size = new Size(119, 39);
            Lisaa_kirjailija.TabIndex = 1;
            Lisaa_kirjailija.Text = "Lisää/Poistaa Kirjalija";
            Lisaa_kirjailija.UseVisualStyleBackColor = true;
            Lisaa_kirjailija.Click += Lisaa_kirjailija_Click;
            // 
            // Nayta_Lainaukset
            // 
            Nayta_Lainaukset.Location = new Point(12, 167);
            Nayta_Lainaukset.Name = "Nayta_Lainaukset";
            Nayta_Lainaukset.Size = new Size(119, 39);
            Nayta_Lainaukset.TabIndex = 1;
            Nayta_Lainaukset.Text = "Näytä Lainaukset";
            Nayta_Lainaukset.UseVisualStyleBackColor = true;
            Nayta_Lainaukset.Click += Nayta_Lainaukset_Click;
            // 
            // dataGridViewLainaukset
            // 
            dataGridViewLainaukset.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLainaukset.Location = new Point(149, 126);
            dataGridViewLainaukset.Name = "dataGridViewLainaukset";
            dataGridViewLainaukset.RowTemplate.Height = 25;
            dataGridViewLainaukset.Size = new Size(591, 125);
            dataGridViewLainaukset.TabIndex = 2;
            // 
            // Nayta_Asiakkaat
            // 
            Nayta_Asiakkaat.Location = new Point(12, 312);
            Nayta_Asiakkaat.Name = "Nayta_Asiakkaat";
            Nayta_Asiakkaat.Size = new Size(119, 39);
            Nayta_Asiakkaat.TabIndex = 1;
            Nayta_Asiakkaat.Text = "Näytä Asiakkaat";
            Nayta_Asiakkaat.UseVisualStyleBackColor = true;
            Nayta_Asiakkaat.Click += Nayta_Asiakkaat_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(149, 271);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(603, 125);
            dataGridView2.TabIndex = 2;
            // 
            // Lisaa_asiakas
            // 
            Lisaa_asiakas.Location = new Point(320, 58);
            Lisaa_asiakas.Name = "Lisaa_asiakas";
            Lisaa_asiakas.Size = new Size(119, 39);
            Lisaa_asiakas.TabIndex = 1;
            Lisaa_asiakas.Text = "Lisää Asiakas";
            Lisaa_asiakas.UseVisualStyleBackColor = true;
            Lisaa_asiakas.Click += Lisaa_asiakas_Click;
            // 
            // Poista_asiakas
            // 
            Poista_asiakas.Location = new Point(471, 58);
            Poista_asiakas.Name = "Poista_asiakas";
            Poista_asiakas.Size = new Size(119, 39);
            Poista_asiakas.TabIndex = 1;
            Poista_asiakas.Text = "Poista Asiakas";
            Poista_asiakas.UseVisualStyleBackColor = true;
            Poista_asiakas.Click += Poista_asiakas_Click;
            // 
            // Poistu
            // 
            Poistu.Location = new Point(633, 58);
            Poistu.Name = "Poistu";
            Poistu.Size = new Size(119, 39);
            Poistu.TabIndex = 1;
            Poistu.Text = "POISTU";
            Poistu.UseVisualStyleBackColor = true;
            Poistu.Click += Poistu_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridViewLainaukset);
            Controls.Add(Nayta_Asiakkaat);
            Controls.Add(Nayta_Lainaukset);
            Controls.Add(Poistu);
            Controls.Add(Poista_asiakas);
            Controls.Add(Lisaa_asiakas);
            Controls.Add(Lisaa_kirjailija);
            Controls.Add(Lisaa_kirja);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLainaukset).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Lisaa_kirja;
        private Button Lisaa_kirjailija;
        private Button Nayta_Lainaukset;
        private DataGridView dataGridViewLainaukset;
        private Button Nayta_Asiakkaat;
        private DataGridView dataGridView2;
        private Button Lisaa_asiakas;
        private Button Poista_asiakas;
        private Button Poistu;
    }
}