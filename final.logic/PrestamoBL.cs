using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final.logic
{
  public class PrestamoBL
    {
        public static List<Prestamo> Listar()
        {
            var prestamoData = new PrestamoData();
            return prestamoData.Listar();
        }
}
}

