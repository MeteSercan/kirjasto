namespace kirjasto_ohjelma5
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
            label1 = new Label();
            kaikki_kirjat = new Button();
            dataGridView1 = new DataGridView();
            kirjailijat = new Button();
            dataGridView2 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Lainakirja_asiakas_numero = new TextBox();
            Lainakirja_isbn = new TextBox();
            Laina_kirja = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            palautakirja_asiakas_numero = new TextBox();
            palautakirja_isbn = new TextBox();
            palauta_kirja = new Button();
            Lainatut_kirjat = new Button();
            dataGridView3 = new DataGridView();
            admin_menu = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 0);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "Kirjasto";
            // 
            // kaikki_kirjat
            // 
            kaikki_kirjat.Location = new Point(12, 73);
            kaikki_kirjat.Name = "kaikki_kirjat";
            kaikki_kirjat.Size = new Size(123, 23);
            kaikki_kirjat.TabIndex = 1;
            kaikki_kirjat.Text = "Näytä Kaikki Kirjat";
            kaikki_kirjat.UseVisualStyleBackColor = true;
            kaikki_kirjat.Click += kaikki_kirjat_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(141, 49);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(398, 171);
            dataGridView1.TabIndex = 2;
            // 
            // kirjailijat
            // 
            kirjailijat.Location = new Point(12, 279);
            kirjailijat.Name = "kirjailijat";
            kirjailijat.Size = new Size(123, 23);
            kirjailijat.TabIndex = 3;
            kirjailijat.Text = "Kirjailijat";
            kirjailijat.UseVisualStyleBackColor = true;
            kirjailijat.Click += kirjailijat_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(141, 238);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(398, 171);
            dataGridView2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(642, 18);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Laina Kirja";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(554, 33);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Asiakas Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(729, 33);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "ISBN";
            // 
            // Lainakirja_asiakas_numero
            // 
            Lainakirja_asiakas_numero.Location = new Point(557, 51);
            Lainakirja_asiakas_numero.Name = "Lainakirja_asiakas_numero";
            Lainakirja_asiakas_numero.Size = new Size(100, 23);
            Lainakirja_asiakas_numero.TabIndex = 6;
            // 
            // Lainakirja_isbn
            // 
            Lainakirja_isbn.Location = new Point(688, 51);
            Lainakirja_isbn.Name = "Lainakirja_isbn";
            Lainakirja_isbn.Size = new Size(100, 23);
            Lainakirja_isbn.TabIndex = 7;
            // 
            // Laina_kirja
            // 
            Laina_kirja.Location = new Point(630, 80);
            Laina_kirja.Name = "Laina_kirja";
            Laina_kirja.Size = new Size(87, 39);
            Laina_kirja.TabIndex = 8;
            Laina_kirja.Text = "Laina";
            Laina_kirja.UseVisualStyleBackColor = true;
            Laina_kirja.Click += Laina_kirja_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(631, 312);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 4;
            label5.Text = "Palauta Kirja";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(557, 327);
            label6.Name = "label6";
            label6.Size = new Size(93, 15);
            label6.TabIndex = 4;
            label6.Text = "Asiakas Numero";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(729, 327);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 5;
            label7.Text = "ISBN";
            label7.Click += label7_Click;
            // 
            // palautakirja_asiakas_numero
            // 
            palautakirja_asiakas_numero.Location = new Point(557, 345);
            palautakirja_asiakas_numero.Name = "palautakirja_asiakas_numero";
            palautakirja_asiakas_numero.Size = new Size(100, 23);
            palautakirja_asiakas_numero.TabIndex = 6;
            palautakirja_asiakas_numero.TextChanged += textBox3_TextChanged;
            // 
            // palautakirja_isbn
            // 
            palautakirja_isbn.Location = new Point(688, 345);
            palautakirja_isbn.Name = "palautakirja_isbn";
            palautakirja_isbn.Size = new Size(100, 23);
            palautakirja_isbn.TabIndex = 7;
            palautakirja_isbn.TextChanged += textBox4_TextChanged;
            // 
            // palauta_kirja
            // 
            palauta_kirja.Location = new Point(631, 374);
            palauta_kirja.Name = "palauta_kirja";
            palauta_kirja.Size = new Size(87, 39);
            palauta_kirja.TabIndex = 8;
            palauta_kirja.Text = "Palauta";
            palauta_kirja.UseVisualStyleBackColor = true;
            palauta_kirja.Click += button4_Click;
            // 
            // Lainatut_kirjat
            // 
            Lainatut_kirjat.Location = new Point(548, 263);
            Lainatut_kirjat.Name = "Lainatut_kirjat";
            Lainatut_kirjat.Size = new Size(234, 28);
            Lainatut_kirjat.TabIndex = 9;
            Lainatut_kirjat.Text = "Lainatut Kirjat";
            Lainatut_kirjat.UseVisualStyleBackColor = true;
            Lainatut_kirjat.Click += Lainatut_kirjat_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(548, 125);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(240, 132);
            dataGridView3.TabIndex = 10;
            // 
            // admin_menu
            // 
            admin_menu.Location = new Point(12, 345);
            admin_menu.Name = "admin_menu";
            admin_menu.Size = new Size(75, 68);
            admin_menu.TabIndex = 11;
            admin_menu.Text = "Admin Menu";
            admin_menu.UseVisualStyleBackColor = true;
            admin_menu.Click += admin_menu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(admin_menu);
            Controls.Add(dataGridView3);
            Controls.Add(Lainatut_kirjat);
            Controls.Add(palauta_kirja);
            Controls.Add(palautakirja_isbn);
            Controls.Add(Laina_kirja);
            Controls.Add(palautakirja_asiakas_numero);
            Controls.Add(Lainakirja_isbn);
            Controls.Add(label7);
            Controls.Add(Lainakirja_asiakas_numero);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(kirjailijat);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(kaikki_kirjat);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button kaikki_kirjat;
        private DataGridView dataGridView1;
        private Button kirjailijat;
        private DataGridView dataGridView2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox Lainakirja_asiakas_numero;
        private TextBox Lainakirja_isbn;
        private Button Laina_kirja;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox palautakirja_asiakas_numero;
        private TextBox palautakirja_isbn;
        private Button palauta_kirja;
        private Button Lainatut_kirjat;
        private DataGridView dataGridView3;
        private Button admin_menu;
    }
}