namespace meow.gang
{
    public partial class Form1 : Form
    {
        Coek[] Coeci = new Coek[100];
        static int brojCoeka, izabrani;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] coekIzFajla;
            brojCoeka = 0;

            ListaCoeka.Items.Clear();

            //Ovo ucitava ljude iz fajla
            try
            {
                StreamReader Citac = new StreamReader("Adresar.csv");
                do
                {
                    coekIzFajla = Citac.ReadLine().Split(';');
                    Coeci[brojCoeka] = new Coek(int.Parse(coekIzFajla[0]), coekIzFajla[1], coekIzFajla[2], coekIzFajla[3], coekIzFajla[4], coekIzFajla[5]);
                    ListaCoeka.Items.Add(Coeci[brojCoeka].LS_box());
                    brojCoeka++;
                }
                while (!Citac.EndOfStream);

                Citac.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ListaCoeka_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListaCoeka.SelectedIndex < 0)
            {
                ime.Text = "";
                prezime.Text = "";
                telefon.Text = "";
                email.Text = "";
                adresa.Text = "";
                return;
            }

            izabrani = ListaCoeka.SelectedIndex;

            ime.Text = Coeci[ListaCoeka.SelectedIndex].Ime;
            prezime.Text = Coeci[ListaCoeka.SelectedIndex].Prezime;
            telefon.Text = Coeci[ListaCoeka.SelectedIndex].Telefon;
            email.Text = Coeci[ListaCoeka.SelectedIndex].Email;
            adresa.Text = Coeci[ListaCoeka.SelectedIndex].Adresa;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Size = new Size(412, 435);
        }

        private void pretraga_TextChanged(object sender, EventArgs e)
        {
            if (pretraga.Text == string.Empty || (ListaCoeka.Items.Count == 0))
            {
                ListaCoeka.SelectedIndex = -1;
                return;
            }

            ListaCoeka.Items.Clear();
            for (int i = 0; i < brojCoeka; i++)
            {
                if (Coeci[i].Pretraga(pretraga.Text))
                {
                    ListaCoeka.SelectedIndex = i;

                }
                else
                {
                    ListaCoeka.SelectedIndex = -1;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter Pisac = new StreamWriter("Adresar.csv", false);

            for (int i = 0; i < brojCoeka; i++)
            {
                if (Coeci[i].Id != -1)
                {
                    Pisac.WriteLine(Coeci[i].Save());
                }
            }

            Pisac.Close();
        }

        private void brisanje_bt_Click(object sender, EventArgs e)
        {
            //Ako je id -1 save funkcija ga nece upisati u fajl
            Coeci[izabrani].Id = -1;

            //Ovo sluzi da osvezi list box
            ListaCoeka.Items.Clear();
            for (int i = 0; i < brojCoeka; i++)
            {
                if (Coeci[i].Id != -1)
                {
                    ListaCoeka.Items.Add(Coeci[i].LS_box());
                }
            }

            //Ovo sluzi da osvezi polja za unos teksta
            if (ListaCoeka.SelectedIndex < 0)
            {
                ime.Text = "";
                prezime.Text = "";
                telefon.Text = "";
                email.Text = "";
                adresa.Text = "";
                return;
            }

            izabrani = ListaCoeka.SelectedIndex;

            ime.Text = Coeci[ListaCoeka.SelectedIndex].Ime;
            prezime.Text = Coeci[ListaCoeka.SelectedIndex].Prezime;
            telefon.Text = Coeci[ListaCoeka.SelectedIndex].Telefon;
            email.Text = Coeci[ListaCoeka.SelectedIndex].Email;
            adresa.Text = Coeci[ListaCoeka.SelectedIndex].Adresa;
        }

        private void izmeni_bt_Click(object sender, EventArgs e)
        {
            //Prepisujem sva polja za unos u niz
            Coeci[izabrani].Ime = ime.Text;
            Coeci[izabrani].Prezime = prezime.Text;
            Coeci[izabrani].Telefon = telefon.Text;
            Coeci[izabrani].Email = email.Text;
            Coeci[izabrani].Adresa = adresa.Text;

            //Ovo sluzi da osvezi list box
            ListaCoeka.Items.Clear();
            for (int i = 0; i < brojCoeka; i++)
            {
                if (Coeci[i].Id != -1)
                {
                    ListaCoeka.Items.Add(Coeci[i].LS_box());
                }
            }
        }

        private void dodaj_bt_Click(object sender, EventArgs e)
        {
            Coeci[brojCoeka] = new Coek(brojCoeka, ime_novo.Text, prezime_novo.Text, telefon_novo.Text, email_novo.Text, adresa_novo.Text);

            brojCoeka++;

            //Ovo sluzi da osvezi list box
            ListaCoeka.Items.Clear();
            for (int i = 0; i < brojCoeka; i++)
            {
                if (Coeci[i].Id != -1)
                {
                    ListaCoeka.Items.Add(Coeci[i].LS_box());
                }
            }

            //Ovo sluzi da osvezi polja za unos teksta
            if (ListaCoeka.SelectedIndex < 0)
            {
                ime.Text = "";
                prezime.Text = "";
                telefon.Text = "";
                email.Text = "";
                adresa.Text = "";
                return;
            }

            izabrani = ListaCoeka.SelectedIndex;

            ime.Text = Coeci[ListaCoeka.SelectedIndex].Ime;
            prezime.Text = Coeci[ListaCoeka.SelectedIndex].Prezime;
            telefon.Text = Coeci[ListaCoeka.SelectedIndex].Telefon;
            email.Text = Coeci[ListaCoeka.SelectedIndex].Email;
            adresa.Text = Coeci[ListaCoeka.SelectedIndex].Adresa;
        }
    }
}