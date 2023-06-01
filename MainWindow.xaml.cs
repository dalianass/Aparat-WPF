using AparatHomework.Klase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AparatHomework
{
    public partial class MainWindow : Window
    {
        PojedinacnaKarta pojedinacna = new PojedinacnaKarta(1, 250);
        PojedinacnaKarta pojedinacna2 = new PojedinacnaKarta(2, 30);
        MesecnaKarta mesecna = new MesecnaKarta(3, "Dalila", new DateOnly(2023, 7, 5));
        MesecnaKarta mesecna2 = new MesecnaKarta(4, "Emina", new DateOnly(2024, 2, 3));
        Aparat aparat = new Aparat();
        public MainWindow()
        {
            InitializeComponent();

        }

        //prikazuje valjanost karata
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            aparat.dodajKartu(pojedinacna);
            aparat.dodajKartu(pojedinacna2);
            aparat.dodajKartu(mesecna);
            aparat.dodajKartu(mesecna2);
            aparat.valjanostSvihKarata(150, new DateOnly(2023, 8, 6));

            foreach(var item in aparat.listaPoruka)
            {
                MessageBox.Show(item);

            }

            pojedinacna2.DopuniIznos(500);
            aparat.valjanostSvihKarata(150, new DateOnly(2023, 8, 6)); //da bi se pozvala funkcija valjanosti koja ispisuje vrednosti apdejtovane
            MessageBox.Show("Nakon dopune iznosa, karta: " + pojedinacna2.ToString() + " - JE VALJANA");

            mesecna.ProduziVazenjeKarte(8, 2025);
            aparat.valjanostSvihKarata(150, new DateOnly(2023, 8, 6)); 
            MessageBox.Show("Nakon produzenja datuma vazenja, karta: " + mesecna.ToString() + " - JE VALJANA");

            //ako se pokusa dodati karta sa postojecim id-jem, vraca gresku:
            PojedinacnaKarta kartaPonovljenId = new PojedinacnaKarta(2, 60);
            aparat.dodajKartu(kartaPonovljenId);
        }
    }
}
