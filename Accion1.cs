using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Accion
    {

        public string TipoAccion { get; }
        public string Contenido { get; }
        public int FechaHora { get; }

        public Accion(string tipoAccion, string contenido)
        {
            TipoAccion = tipoAccion;
            Contenido = contenido;
            FechaHora = FechaHora;
        }
    }
}