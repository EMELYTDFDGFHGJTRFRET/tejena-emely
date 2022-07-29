using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte_poo
{
    class decorador
public class Decorador
    {
        protected OrdenBase orden;

        public Decorador(OrdenBase orden)
        {
            this.orden = orden;
        }
        public virtual string extension()
        {
            return orden.extension();
        }
        public virtual string reparacion()
        {
            return orden.extension();
        }
    }
}
