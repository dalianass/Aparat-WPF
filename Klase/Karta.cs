using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AparatHomework.Klase
{
    public abstract class Karta
    {
        public int Id { get; set; }

        public bool Valjana { get; set; } = false;

        public Karta(int id)
        {
            this.Id = id;
        }
        public abstract bool Valjanost(DateOnly datum, double cenaVoznje = 0);
    }
}
