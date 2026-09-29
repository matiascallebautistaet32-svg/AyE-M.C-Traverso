using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Mago
    {
        public int VidaTotal { get; set; }
        public int VidaActual { get; set; }
        public string UltimoHechizo { get; set; }


        public Mago(int vidaTotal, int vidaActual, string ultimoHechizo)
        {
            this.VidaTotal = vidaTotal;
            this.VidaActual = vidaActual;
            this.UltimoHechizo = ultimoHechizo;
        }
    }
}
