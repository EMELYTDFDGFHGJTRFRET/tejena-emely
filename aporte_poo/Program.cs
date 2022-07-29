using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aporte_poo
{
    class Program
    {

        public static void Main(String[] args)
        {

            //telefono #1

            var telefono = new Dispositivo1();

            var reparacion = new PantallaRota(telefono);
            Console.WriteLine("" + reparacion.reparacion());

            var reparacion2 = new Agua(telefono);
            Console.WriteLine("" + reparacion2.reparacion());

            var reparacion3 = new Formateo(telefono);
            Console.WriteLine("" + reparacion3.reparacion());

            var cargador = new Cargador(telefono);
            Console.WriteLine("" + cargador.extension());

            //telefono 2
            var telefono2 = new Dispositivo2();

            var reparacion4 = new Agua(telefono);
            Console.WriteLine("" + reparacion4.reparacion());

            var reparacion5 = new Formateo(telefono);
            Console.WriteLine("" + reparacion5.reparacion());

            var parlante2 = new Parlante(telefono);
            Console.WriteLine("" + parlante2.extension());


            //telefono 3
            var telefono3 = new Dispositivo3();

            var audifonos3 = new Audifonos(telefono);
            Console.WriteLine("" + audifonos3.extension());
        }
    }
}
