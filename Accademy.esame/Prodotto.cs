using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.esame
{
    public class Prodotto
    {
        protected int codice { get; }
        protected int sconto { get; }
        protected double prezzo { get; }
        protected string descrizione;

        public string Getdescrizione()
        {
            Type a = this.GetType();
            string s = "Tipo di articolo:   " + this.descrizione + "        Prezzo=" + prezzo.ToString() + "     Codice prodotto=" + codice.ToString() + "      Questo prodotto ha lo sconto del " + sconto.ToString() + "%";
            return s;
        }
        public Prodotto() { }
        public Prodotto(int Codice, int Sconto, double Prezzo, string Descrizione)
        {
            this.prezzo = Prezzo;
            this.sconto = Sconto; this.descrizione = Descrizione; this.codice = Codice;
        }
        public Prodotto(int Sconto, double Prezzo, string Descrizione)
        {
            this.prezzo = Prezzo;
            this.sconto = Sconto; this.descrizione = Descrizione; this.codice = -1;
        }

        public Prodotto(string Descrizione, int Codice)
        {
            this.prezzo = 0.00;
            this.sconto = 0; this.descrizione = Descrizione; this.codice = Codice;
        }

        public Prodotto(string Descrizione)
        {
            this.prezzo = 0.00;
            this.sconto = 0; this.descrizione = Descrizione; this.codice = -1;
        }
    }
}
