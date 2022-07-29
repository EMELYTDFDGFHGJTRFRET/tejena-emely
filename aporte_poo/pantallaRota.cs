using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte_poo
{
    public class PantallaRota : Decorador
    {

        public PantallaRota(OrdenBase ordenBase) : base(ordenBase) { }
        public virtual string reparacion()
        {
            var repacion = "Has Elegido arreglar tu pantalla rota";
            return repacion;
        }
    }
}
