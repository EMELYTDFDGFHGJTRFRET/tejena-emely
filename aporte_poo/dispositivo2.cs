using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte_poo
{
    public class Dispositivo2 : OrdenBase
    {
        public override string reparacion()
        {
            var repa = "Has reparado tu telefono";
            return repa;
        }
        public override string extension()
        {
            var repa = "Desea agregar una extencion?";
            return repa;
        }
    }
}
