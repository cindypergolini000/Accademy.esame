using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.esame
{
    public class ProdottoinOfferta : Prodotto

    {
        public string datainizio, datafine;

        public ProdottoinOfferta(int Codice, int Sconto, double Prezzo, string Descrizione, string DataInizio, string datafine) : base(Codice, Sconto, Prezzo, Descrizione)
        {
            this.datainizio = DataInizio; this.datafine = datafine;
        }
        public ProdottoinOfferta(int Sconto, double Prezzo, string Descrizione, string DataInizio, string datafine) : base(Sconto, Prezzo, Descrizione)
        {
            this.datainizio = DataInizio; this.datafine = datafine;
        }

        public ProdottoinOfferta(string Descrizione, int Codice, string DataInizio, string datafine) : base(Descrizione, Codice)
        {
            this.datainizio = DataInizio; this.datafine = datafine;
        }

        public ProdottoinOfferta(string Descrizione, string DataInizio, string datafine) : base(Descrizione)
        {
            this.datainizio = DataInizio; this.datafine = datafine;
        }



        public void StampaDescrizioneeOfferta(string Inizio, string fine)
        {
            this.Getdescrizione();

            System.Console.WriteLine(" PRODOTTO IN OFFERTA  : \n  Offerta valida dal " + datainizio + "  al " + datafine + "\n");

        }

    }
}
