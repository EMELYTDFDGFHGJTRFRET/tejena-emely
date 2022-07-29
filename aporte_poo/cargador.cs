using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte_poo
{
    public class Cargador : Decorador
    {

        public Cargador(OrdenBase ordenBase) : base(ordenBase)
        {

        }
        public override string extension()
        {
            var teclado = orden.extension();
            Console.WriteLine("Has agregado el cargador adicional");
            return teclado;
        }
    }
}
