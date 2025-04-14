namespace kirjasto_ohjelma5
{
    partial class Form5
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
            Takaisin = new Button();
            Poista_kirja = new Button();
            Lisaa_kirja = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTitle = new TextBox();
            txtAuthorID = new TextBox();
            txtISBN = new TextBox();
            dataGridViewKirjat = new DataGridView();
            Nayta_kirja = new Button();
            txtYear = new TextBox();
            label4 = new Label();
            txtPages = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewKirjat).BeginInit();
            SuspendLayout();
            // 
            // Takaisin
            // 
            Takaisin.Location = new Point(684, 365);
            Takaisin.Name = "Takaisin";
            Takaisin.Size = new Size(100, 73);
            Takaisin.TabIndex = 17;
            Takaisin.Text = "Takaisin";
            Takaisin.UseVisualStyleBackColor = true;
            Takaisin.Click += Takaisin_Click;
            // 
            // Poista_kirja
            // 
            Poista_kirja.Location = new Point(304, 343);
            Poista_kirja.Name = "Poista_kirja";
            Poista_kirja.Size = new Size(183, 58);
            Poista_kirja.TabIndex = 16;
            Poista_kirja.Text = "Poista Kirjaa";
            Poista_kirja.UseVisualStyleBackColor = true;
            Poista_kirja.Click += Poista_kirja_Click;
            // 
            // Lisaa_kirja
            // 
            Lisaa_kirja.Location = new Point(612, 236);
            Lisaa_kirja.Name = "Lisaa_kirja";
            Lisaa_kirja.Size = new Size(137, 67);
            Lisaa_kirja.TabIndex = 15;
            Lisaa_kirja.Text = "Lisää Kirjaa";
            Lisaa_kirja.UseVisualStyleBackColor = true;
            Lisaa_kirja.Click += Lisaa_kirja_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 236);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 12;
            label3.Text = "Kirjan Nimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(137, 236);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 13;
            label2.Text = "Kirjailija Tunnus";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 236);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 14;
            label1.Text = "ISBN";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(261, 271);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 9;
            // 
            // txtAuthorID
            // 
            txtAuthorID.Location = new Point(137, 271);
            txtAuthorID.Name = "txtAuthorID";
            txtAuthorID.Size = new Size(100, 23);
            txtAuthorID.TabIndex = 10;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(12, 271);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(100, 23);
            txtISBN.TabIndex = 11;
            // 
            // dataGridViewKirjat
            // 
            dataGridViewKirjat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewKirjat.Location = new Point(192, 12);
            dataGridViewKirjat.Name = "dataGridViewKirjat";
            dataGridViewKirjat.RowTemplate.Height = 25;
            dataGridViewKirjat.Size = new Size(592, 210);
            dataGridViewKirjat.TabIndex = 8;
            // 
            // Nayta_kirja
            // 
            Nayta_kirja.Location = new Point(16, 65);
            Nayta_kirja.Name = "Nayta_kirja";
            Nayta_kirja.Size = new Size(157, 35);
            Nayta_kirja.TabIndex = 7;
            Nayta_kirja.Text = "Kaikki Kirjat";
            Nayta_kirja.UseVisualStyleBackColor = true;
            Nayta_kirja.Click += Nayta_kirja_Click;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(376, 271);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(100, 23);
            txtYear.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(386, 236);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 12;
            label4.Text = "Vuosi";
            // 
            // txtPages
            // 
            txtPages.Location = new Point(491, 271);
            txtPages.Name = "txtPages";
            txtPages.Size = new Size(100, 23);
            txtPages.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(501, 236);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 12;
            label5.Text = "Sivut";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Takaisin);
            Controls.Add(Poista_kirja);
            Controls.Add(Lisaa_kirja);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPages);
            Controls.Add(txtYear);
            Controls.Add(txtTitle);
            Controls.Add(txtAuthorID);
            Controls.Add(txtISBN);
            Controls.Add(dataGridViewKirjat);
            Controls.Add(Nayta_kirja);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridViewKirjat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Takaisin;
        private Button Poista_kirja;
        private Button Lisaa_kirja;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtTitle;
        private TextBox txtAuthorID;
        private TextBox txtISBN;
        private DataGridView dataGridViewKirjat;
        private Button Nayta_kirja;
        private TextBox txtYear;
        private Label label4;
        private TextBox txtPages;
        private Label label5;
    }
}