using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.esame
{
    class Negozio

    {
        public string proprietario { get; set; }
        public string nome { get; set; }
        public List<Prodotto> listaprodotti = new List<Prodotto>();
        public Negozio(string Nome, string Proprietario)
        {
            this.nome = Nome; this.proprietario = Proprietario;
        }
        public Negozio(string Nome, string Proprietario, Prodotto prodotto)
        {
            this.nome = Nome; this.proprietario = Proprietario;
            listaprodotti.Add(prodotto);
        }
        public Negozio(string Nome, string Proprietario, List<Prodotto> lista1)
        {
            this.nome = Nome; this.proprietario = Proprietario;
            foreach (var item in lista1)
            {
                listaprodotti.Add(item);
            }

        }
        public void addprodotto(Prodotto prodotto)
        {
            listaprodotti.Add(prodotto);

        }
        public void StampaProdotti()

        {
            System.Console.WriteLine("Nome Negozio: " + this.nome + "\n Proprietario:   " + this.proprietario + "\n");
            foreach (var item in this.listaprodotti)

            {

                System.Console.WriteLine(item.Getdescrizione());
            }
        }
        public void StampaRepertorio()

        {
            foreach (var item in this.listaprodotti)
            {
                System.Console.WriteLine(item.Getdescrizione());

                try
                {
                    ProdottoinOfferta off = (ProdottoinOfferta)item;

                    off.StampaDescrizioneeOfferta(off.datainizio, off.datafine);
                    System.Console.WriteLine(" \n \n  ");

                }

                catch (Exception)
                {


                    System.Console.WriteLine(" (PRODOTTO NON IN OFFERTA) \n \n");


                }

            }
        }
    }
}
