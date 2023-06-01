using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AparatHomework.Klase
{
    internal class MesecnaKarta : Karta
    {
        public string ImeVlasnika { get; set; }
        public DateOnly DatumVazenja { get; set; }
        public MesecnaKarta(int id, string imeVlasnika, DateOnly datum) : base(id)
        {
            this.ImeVlasnika = imeVlasnika;
            this.DatumVazenja = datum;
        }

        public void ProduziVazenjeKarte(int mesec, int godina)
        {
            this.DatumVazenja = new DateOnly(godina, mesec, 1); //year, month, day
        }
        public override string ToString()
        {
            return $"Identifikator karte je: {Id}, valjanost karte je: {Valjana}, ime vlasnika karte je: {ImeVlasnika}, a datum vazenja karte je do: {DatumVazenja.ToString("dd.MM.yyyy")}";
        }

        public override bool Valjanost(DateOnly datum, double cenaVoznje = 0)
        {
            if (this.DatumVazenja >= datum) //ako je vazeca do zadatog datuma ili vise od toga, valjana je. 
            {
                this.Valjana = true;
                return true;
            }
            else
            {
                this.Valjana = false;
                return false;
            }
        }
    }
}
