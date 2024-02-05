namespace meow.gang
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            izmeni_bt = new Button();
            brisanje_bt = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            adresa = new TextBox();
            email = new TextBox();
            telefon = new TextBox();
            prezime = new TextBox();
            ime = new TextBox();
            label2 = new Label();
            ListaCoeka = new ListBox();
            pretraga = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            adresa_novo = new TextBox();
            email_novo = new TextBox();
            telefon_novo = new TextBox();
            prezime_novo = new TextBox();
            ime_novo = new TextBox();
            label11 = new Label();
            dodaj_bt = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(400, 400);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(izmeni_bt);
            tabPage1.Controls.Add(brisanje_bt);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(adresa);
            tabPage1.Controls.Add(email);
            tabPage1.Controls.Add(telefon);
            tabPage1.Controls.Add(prezime);
            tabPage1.Controls.Add(ime);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(ListaCoeka);
            tabPage1.Controls.Add(pretraga);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(392, 372);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Adrese";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // izmeni_bt
            // 
            izmeni_bt.ForeColor = Color.FromArgb(192, 192, 0);
            izmeni_bt.Location = new Point(312, 284);
            izmeni_bt.Name = "izmeni_bt";
            izmeni_bt.Size = new Size(52, 52);
            izmeni_bt.TabIndex = 14;
            izmeni_bt.Text = "Izmeni";
            izmeni_bt.UseVisualStyleBackColor = true;
            izmeni_bt.Click += izmeni_bt_Click;
            // 
            // brisanje_bt
            // 
            brisanje_bt.BackColor = Color.Transparent;
            brisanje_bt.ForeColor = Color.Red;
            brisanje_bt.Location = new Point(312, 191);
            brisanje_bt.Name = "brisanje_bt";
            brisanje_bt.Size = new Size(52, 52);
            brisanje_bt.TabIndex = 13;
            brisanje_bt.Text = "Izbrisi";
            brisanje_bt.UseVisualStyleBackColor = false;
            brisanje_bt.Click += brisanje_bt_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 303);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 12;
            label6.Text = "Adresa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 275);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 11;
            label5.Text = "Email:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 247);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 10;
            label4.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 219);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 9;
            label3.Text = "Prezieme:";
            // 
            // adresa
            // 
            adresa.Location = new Point(73, 307);
            adresa.Name = "adresa";
            adresa.Size = new Size(210, 23);
            adresa.TabIndex = 8;
            // 
            // email
            // 
            email.Location = new Point(73, 278);
            email.Name = "email";
            email.Size = new Size(210, 23);
            email.TabIndex = 7;
            // 
            // telefon
            // 
            telefon.Location = new Point(73, 249);
            telefon.Name = "telefon";
            telefon.Size = new Size(210, 23);
            telefon.TabIndex = 6;
            // 
            // prezime
            // 
            prezime.Location = new Point(73, 220);
            prezime.Name = "prezime";
            prezime.Size = new Size(210, 23);
            prezime.TabIndex = 5;
            // 
            // ime
            // 
            ime.Location = new Point(73, 191);
            ime.Name = "ime";
            ime.Size = new Size(210, 23);
            ime.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 191);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 3;
            label2.Text = "Ime:";
            // 
            // ListaCoeka
            // 
            ListaCoeka.FormattingEnabled = true;
            ListaCoeka.ItemHeight = 15;
            ListaCoeka.Location = new Point(8, 40);
            ListaCoeka.Name = "ListaCoeka";
            ListaCoeka.Size = new Size(372, 139);
            ListaCoeka.TabIndex = 2;
            ListaCoeka.SelectedIndexChanged += ListaCoeka_SelectedIndexChanged;
            // 
            // pretraga
            // 
            pretraga.Location = new Point(63, 11);
            pretraga.Name = "pretraga";
            pretraga.Size = new Size(317, 23);
            pretraga.TabIndex = 1;
            pretraga.TextChanged += pretraga_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 14);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 0;
            label1.Text = "Pretrazi:";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dodaj_bt);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(adresa_novo);
            tabPage2.Controls.Add(email_novo);
            tabPage2.Controls.Add(telefon_novo);
            tabPage2.Controls.Add(prezime_novo);
            tabPage2.Controls.Add(ime_novo);
            tabPage2.Controls.Add(label11);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(392, 372);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dodja kontakt";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 126);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 22;
            label7.Text = "Adresa:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(17, 98);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 21;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 70);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 20;
            label9.Text = "Telefon:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 42);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 19;
            label10.Text = "Prezieme:";
            // 
            // adresa_novo
            // 
            adresa_novo.Location = new Point(82, 130);
            adresa_novo.Name = "adresa_novo";
            adresa_novo.Size = new Size(210, 23);
            adresa_novo.TabIndex = 18;
            // 
            // email_novo
            // 
            email_novo.Location = new Point(82, 101);
            email_novo.Name = "email_novo";
            email_novo.Size = new Size(210, 23);
            email_novo.TabIndex = 17;
            // 
            // telefon_novo
            // 
            telefon_novo.Location = new Point(82, 72);
            telefon_novo.Name = "telefon_novo";
            telefon_novo.Size = new Size(210, 23);
            telefon_novo.TabIndex = 16;
            // 
            // prezime_novo
            // 
            prezime_novo.Location = new Point(82, 43);
            prezime_novo.Name = "prezime_novo";
            prezime_novo.Size = new Size(210, 23);
            prezime_novo.TabIndex = 15;
            // 
            // ime_novo
            // 
            ime_novo.Location = new Point(82, 14);
            ime_novo.Name = "ime_novo";
            ime_novo.Size = new Size(210, 23);
            ime_novo.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 14);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 13;
            label11.Text = "Ime:";
            // 
            // dodaj_bt
            // 
            dodaj_bt.ForeColor = Color.Green;
            dodaj_bt.Location = new Point(319, 56);
            dodaj_bt.Name = "dodaj_bt";
            dodaj_bt.Size = new Size(52, 52);
            dodaj_bt.TabIndex = 23;
            dodaj_bt.Text = "Dodaj";
            dodaj_bt.UseVisualStyleBackColor = true;
            dodaj_bt.Click += dodaj_bt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 396);
            Controls.Add(tabControl1);
            MinimizeBox = false;
            Name = "Form1";
            Text = "Adresar";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResizeEnd += Form1_ResizeEnd;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox adresa;
        private TextBox email;
        private TextBox telefon;
        private TextBox prezime;
        private TextBox ime;
        private Label label2;
        private ListBox ListaCoeka;
        private TextBox pretraga;
        private Label label1;
        private Button izmeni_bt;
        private Button brisanje_bt;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox adresa_novo;
        private TextBox email_novo;
        private TextBox telefon_novo;
        private TextBox prezime_novo;
        private TextBox ime_novo;
        private Label label11;
        private Button dodaj_bt;
    }
}