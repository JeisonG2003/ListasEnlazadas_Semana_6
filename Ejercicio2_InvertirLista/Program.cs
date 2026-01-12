using System;

// Clase principal del programa
class Program
{
    static void Main()
    {
        // Se crea la lista enlazada
        ListaEnlazada lista = new ListaEnlazada();

        // Se insertan datos
        lista.InsertarFinal(1);
        lista.InsertarFinal(2);
        lista.InsertarFinal(3);
        lista.InsertarFinal(4);

        // Se muestra la lista original
        Console.WriteLine("Lista original:");
        lista.MostrarLista();

        // Se invierte la lista
        lista.InvertirLista();

        // Se muestra la lista invertida
        Console.WriteLine("Lista invertida:");
        lista.MostrarLista();
    }
}

