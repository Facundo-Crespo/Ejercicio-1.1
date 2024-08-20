using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Facundo_Ejercicio_1._1
{

    public class Pila : Collection
    {
        public Pila(int Capacidad) : base(Capacidad)
        { }

        public override object Extraer()
        {
            object o = null;
            if (!EstaVacia())
            {
                o = array[next];
                array[next] = null;
                next--;
            }
            return o;
        }
    }
}
