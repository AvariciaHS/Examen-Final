using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final.Dominio
{
  public class DetallePrestamo
    {
        public int ID { get; set; }
        public int IdPrestamo { get; set; }
        public int NumeroCuota { get; set; }
        public decimal ImporteCuota { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public bool Estado { get; set; }
    }
}
