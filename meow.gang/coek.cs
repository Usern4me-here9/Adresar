using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace meow.gang
{
    internal class Coek
    {
        private string ime, prezime, telefon, email, adresa;
        private int id;

        public Coek(int id, string ime, string prezime, string telefon, string email, string adresa)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.telefon = telefon;
            this.email = email;
            this.adresa = adresa;
            this.id = id;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Email { get => email; set => email = value; }
        public string Adresa { get => adresa; set => adresa = value; }
        public int Id { get => id; set => id = value; }

        public string Save()
        {
            return id.ToString() + ";" + ime + ";" + prezime + ";" + telefon + ";" + email + ";" + adresa;
        }

        public bool Pretraga(string input)
        {
            string tmpi, tmpp, tmpe;

            input=input.ToLower();
            tmpi = ime.ToLower(); 
            tmpp = prezime.ToLower();
            tmpe = email.ToLower();

            return (tmpi.StartsWith(input) || tmpp.StartsWith(input) || tmpe.StartsWith(input));
        }

        public string LS_box()
        {
            return ime + " " + prezime + " " + telefon + " " + email + " " + adresa;
        }
    }
}
