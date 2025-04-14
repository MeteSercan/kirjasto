namespace kirjasto_ohjelma5
{
    partial class Form4
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
            Nayta_kirjailija = new Button();
            dataGridViewKirjailijat = new DataGridView();
            kirtu = new TextBox();
            label1 = new Label();
            enimi = new TextBox();
            label2 = new Label();
            snimi = new TextBox();
            label3 = new Label();
            Lisaa_kirjailija = new Button();
            Poista_kirjailija = new Button();
            Takaisin = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKirjailijat).BeginInit();
            SuspendLayout();
            // 
            // Nayta_kirjailija
            // 
            Nayta_kirjailija.Location = new Point(12, 65);
            Nayta_kirjailija.Name = "Nayta_kirjailija";
            Nayta_kirjailija.Size = new Size(157, 35);
            Nayta_kirjailija.TabIndex = 0;
            Nayta_kirjailija.Text = "Kaikki Kirjailijat";
            Nayta_kirjailija.UseVisualStyleBackColor = true;
            Nayta_kirjailija.Click += Nayta_kirjailija_Click;
            // 
            // dataGridViewKirjailijat
            // 
            dataGridViewKirjailijat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKirjailijat.Location = new Point(188, 12);
            dataGridViewKirjailijat.Name = "dataGridViewKirjailijat";
            dataGridViewKirjailijat.RowTemplate.Height = 25;
            dataGridViewKirjailijat.Size = new Size(592, 210);
            dataGridViewKirjailijat.TabIndex = 1;
            // 
            // kirtu
            // 
            kirtu.Location = new Point(38, 271);
            kirtu.Name = "kirtu";
            kirtu.Size = new Size(100, 23);
            kirtu.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 236);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 3;
            label1.Text = "Tunnus";
            // 
            // enimi
            // 
            enimi.Location = new Point(244, 271);
            enimi.Name = "enimi";
            enimi.Size = new Size(100, 23);
            enimi.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 236);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 3;
            label2.Text = "Etunimi";
            // 
            // snimi
            // 
            snimi.Location = new Point(430, 271);
            snimi.Name = "snimi";
            snimi.Size = new Size(100, 23);
            snimi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 236);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Sukunimi";
            // 
            // Lisaa_kirjailija
            // 
            Lisaa_kirjailija.Location = new Point(608, 236);
            Lisaa_kirjailija.Name = "Lisaa_kirjailija";
            Lisaa_kirjailija.Size = new Size(137, 67);
            Lisaa_kirjailija.TabIndex = 4;
            Lisaa_kirjailija.Text = "Lisää Kirjailija";
            Lisaa_kirjailija.UseVisualStyleBackColor = true;
            Lisaa_kirjailija.Click += Lisaa_kirjailija_Click;
            // 
            // Poista_kirjailija
            // 
            Poista_kirjailija.Location = new Point(300, 343);
            Poista_kirjailija.Name = "Poista_kirjailija";
            Poista_kirjailija.Size = new Size(183, 58);
            Poista_kirjailija.TabIndex = 5;
            Poista_kirjailija.Text = "Poista Kirjailija";
            Poista_kirjailija.UseVisualStyleBackColor = true;
            Poista_kirjailija.Click += Poista_kirjailija_Click;
            // 
            // Takaisin
            // 
            Takaisin.Location = new Point(680, 365);
            Takaisin.Name = "Takaisin";
            Takaisin.Size = new Size(100, 73);
            Takaisin.TabIndex = 6;
            Takaisin.Text = "Takaisin";
            Takaisin.UseVisualStyleBackColor = true;
            Takaisin.Click += Takaisin_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Takaisin);
            Controls.Add(Poista_kirjailija);
            Controls.Add(Lisaa_kirjailija);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(snimi);
            Controls.Add(enimi);
            Controls.Add(kirtu);
            Controls.Add(dataGridViewKirjailijat);
            Controls.Add(Nayta_kirjailija);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridViewKirjailijat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Nayta_kirjailija;
        private DataGridView dataGridViewKirjailijat;
        private TextBox kirtu;
        private Label label1;
        private TextBox enimi;
        private Label label2;
        private TextBox snimi;
        private Label label3;
        private Button Lisaa_kirjailija;
        private Button Poista_kirjailija;
        private Button Takaisin;
    }
}