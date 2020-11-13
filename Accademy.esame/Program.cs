using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.esame
{
   
        public class Program
        {
            static void Main(string[] args)
            {

                List<Prodotto> prodottinegozio = new List<Prodotto>();
                Negozio mynegozio, negozio2;
                System.Console.WriteLine("Enter nome e proprietario negozio:");
                string input = Console.ReadLine();
                string[] res = input.Split(' ');
                System.Console.WriteLine(" Facciamo rifornimento del negozio, inserire articoli secondo questi formati: \n int Codice, int Sconto, double Prezzo, string Descrizione \n int Sconto, double Prezzo, string Descrizione \n string Descrizione, int Codice \n string Descrizione \n");

                for (int i = 0; i < 2; i++)
                {

                    string input2 = Console.ReadLine();

                    string[] res2 = input2.Split(' ');
                    {
                        if (res2.Length == 2)
                        {
                            Prodotto prodotto = new Prodotto(res2[0], Int32.Parse(res2[1]));
                            prodottinegozio.Add(prodotto);


                        }
                        if (res2.Length == 1)
                        {
                            Prodotto prodotto = new Prodotto(res2[0]);
                            prodottinegozio.Add(prodotto);


                        }
                        if (res2.Length == 3)
                        {
                            Prodotto prodotto = new Prodotto(Int32.Parse(res2[0]), Int32.Parse(res2[1]), res[2]);
                            prodottinegozio.Add(prodotto);


                        }
                        if (res2.Length == 4)
                        {
                            Prodotto prodotto = new Prodotto(Int32.Parse(res2[0]), Int32.Parse(res2[0]), Int32.Parse(res2[0]), res2[0]);
                            prodottinegozio.Add(prodotto);


                        }
                        if (res2.Length > 4)
                        {
                            break;


                        }
                    }
                }

                mynegozio = new Negozio(res[0], res[1], prodottinegozio);



                string inizio, fine;

                System.Console.WriteLine("Enter data inizio offerta limoni Sicilia (formato dd/mm/yy):");
                inizio = System.Console.ReadLine();
                System.Console.WriteLine("Enter data fine offerta limoni Sicilia  (formato dd/mm/yy):");
                fine = System.Console.ReadLine();
                ProdottoinOfferta lim = new ProdottoinOfferta(321321, 10, 0.4, "Limoni dalla Sicilia", inizio, fine);
                System.Console.WriteLine("Enter data inizio offerta arance  Spagna (formato dd/mm/yy):");
                inizio = System.Console.ReadLine();
                System.Console.WriteLine("Enter data fine offerta arance Spagna (formato dd/mm/yy):");
                fine = System.Console.ReadLine();
                ProdottoinOfferta arancia = new ProdottoinOfferta(32131, 20, 0.4, "Arance dalla Spagna", inizio, fine);


                mynegozio.addprodotto(lim);
                mynegozio.addprodotto(arancia);


                negozio2 = new Negozio("Alimentari", "Silvia", arancia);
                Prodotto pentola = new Prodotto(1234, 10, 43.76, " pentola");
                Prodotto coltello = new Prodotto(10, 43.76, "coltello");
                Prodotto cucchiaio = new Prodotto("cucchiaio", 1567);
                Prodotto salvietta = new Prodotto("salvietta ");
                negozio2.addprodotto(pentola);
                negozio2.addprodotto(cucchiaio);
                negozio2.addprodotto(salvietta);
                negozio2.addprodotto(coltello);
                List<Negozio> listadinegozi = new List<Negozio>();
                listadinegozi.Add(negozio2); listadinegozi.Add(mynegozio);
                Console.WriteLine("\n  \n ");
                foreach (var item in listadinegozi)
                {
                    Console.WriteLine("\n \n Listino di tutti i prodotti del negozio {0} di {1}, sia in offerta che non: \n \n  ", item.nome, item.proprietario);
                    item.StampaRepertorio();

                }
                Console.ReadLine();


            }
        }
    
    
}
