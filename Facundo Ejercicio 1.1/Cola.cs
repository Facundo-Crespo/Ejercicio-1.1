using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Facundo_Ejercicio_1._1
{
    public class Cola : Collection
    {
        public Cola(int Capacidad) : base(Capacidad)
        { }

        public override object Extraer()
        {

            object o = null;
            if (!EstaVacia())
            {
                o = array[0];
                for (int i = 1; i <= next; ++i)
                {
                    array[i - 1] = array[i];
                }
                array[next] = null;
                next--;
            }
            return o;
        }
    }
}
