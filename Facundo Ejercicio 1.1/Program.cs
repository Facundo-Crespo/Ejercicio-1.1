// See https://aka.ms/new-console-template for more information
using Facundo_Ejercicio_1._1;

Console.WriteLine("Hello, World!");
Collection cola = new Cola(2);
Collection pila = new Pila(2);



Console.WriteLine("Vacia= " + cola.EstaVacia());
Console.WriteLine("Añadida= " + cola.Añadir(1));
Console.WriteLine("Primera coleccion= " + cola.Primero());
Console.WriteLine(cola.Extraer());