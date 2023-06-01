using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AparatHomework.Klase
{
    public class Aparat
    {
        public List<Karta> listaKarata = new List<Karta>();
        public List<string> listaPoruka = new List<string>();
        public Aparat(){}

        public void dodajKartu(Karta karta)
        {
            bool idJedinstven  = true;
            
            if(listaKarata.Count > 0)
            {
                foreach (Karta item in listaKarata)
                {
                    if (item.Id == karta.Id)
                    {
                        idJedinstven = false;
                    }
                }
            }

            if (idJedinstven)
            {
                 listaKarata.Add(karta);
            }
            else
            {
                MessageBox.Show("Neka od karti vec ima ovaj id. Id karte mora biti jedinstven. Pokusajte ponovo.");
            }
        }

        public List<string>? valjanostSvihKarata(double cenaKarte, DateOnly datum)
        {
            foreach(Karta item in listaKarata)
            {
                item.Valjanost(datum, cenaKarte); //nema potrebe proveravati posebno za oba tipa karte, jer je isti potpis metode i za mesecnu i za pojedinacnu
                
                listaPoruka.Add(item.ToString());
            }

            return listaPoruka;
        }
    }
}
