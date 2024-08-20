using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facundo_Ejercicio_1._1
{
    public interface iCollection
    {
        public bool EstaVacia();
        public object Extraer();
        public object Primero();
        public bool Añadir(object Elemento);

    }
}
