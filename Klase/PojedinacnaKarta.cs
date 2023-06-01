using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AparatHomework.Klase
{
    public class PojedinacnaKarta : Karta
    {
        public double UplacenIznos { get; set; } = 50.0;

        public PojedinacnaKarta(int id, double uplacenIznos) : base(id)
        {
            this.UplacenIznos = uplacenIznos;
        }

        public void DopuniIznos(double iznos)
        {
            this.UplacenIznos += iznos;
        }

        public override bool Valjanost(DateOnly datum, double cenaVoznje = 0)
        {
            if (this.UplacenIznos > cenaVoznje)
            {
                this.UplacenIznos -= cenaVoznje;
                this.Valjana = true;
                return true;
            }
            else
            {
                this.Valjana = false;
                return false;
            }
        }

        public override string ToString()
        {
            return $"Identifikator karte je: {Id}, valjanost karte je: {Valjana}, a uplacen iznos je: {UplacenIznos}";
        }
    }
}
