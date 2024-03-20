using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    internal class Propiedad
    {
        int numeroCasa;
        int dpi_owner;
        decimal cuota;

        public int NumeroCasa { get => numeroCasa; set => numeroCasa = value; }
        public int Dpi_owner { get => dpi_owner; set => dpi_owner = value; }
        public decimal Cuota { get => cuota; set => cuota = value; }
    }
}
