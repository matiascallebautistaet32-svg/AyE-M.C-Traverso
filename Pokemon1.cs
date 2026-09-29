using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Programa8
{
    internal class Pokemon
    {
        public int Id { get; set; }
        public string? nombre { get; set; }
        public string? tipo1 { get; set; }
        public string? tipo2 { get; set; }
        public int vida { get; set; }
        public int ataque { get; set; }
        public int defensa { get; set; }
        public int ataque_especial { get; set; }
        public int defensa_especial { get; set; }
        public int velocidad { get; set; }
        public int nivel { get; set; }
    }
}