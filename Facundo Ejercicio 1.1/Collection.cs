using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facundo_Ejercicio_1._1
{
    public abstract class Collection : iCollection
    {
        public Object[] array;

        public int next;

        public Collection(int Capacidad)
        {

            this.array = new object[Capacidad];
            this.next = 0; // Inicializar next
        }

        public bool Añadir(object Elemento)
        {
            if (next < array.Length)
            {
                array[next] = Elemento;
                // Incrementar next después de añadir el elemento
                return true;
            }
            return false; // No se añadió el elemento porque la colección está llena
        }

        public bool EstaVacia()
        {
            return next == -1; // La colección está vacía si next es 0
        }

        public abstract object Extraer();


        public virtual object Primero()
        {
            Object Primero = null;
            if (!this.EstaVacia())
            {
                Primero = array[0];

            }
            return Primero;

        }
    }
}
