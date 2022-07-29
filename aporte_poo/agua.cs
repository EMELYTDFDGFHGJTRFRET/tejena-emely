using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte_poo
{
    public class Agua : Decorador
    {

        public Agua(OrdenBase ordenBase) : base(ordenBase) { }
        public virtual string reparacion()
        {
            var repacion = "Has Elegido arreglar tu telefono que se le metio agua";
            return repacion;
        }
    }
}
