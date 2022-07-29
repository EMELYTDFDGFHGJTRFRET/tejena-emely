using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte_poo
{
    public class Formateo : Decorador
    {

        public Formateo(OrdenBase ordenBase) : base(ordenBase) { }
        public virtual string reparacion()
        {
            var repacion = "Has agregado el formateo para tu celular";
            return repacion;
        }
    }
}
