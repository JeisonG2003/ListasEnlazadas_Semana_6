using System;

// Clase principal del programa
class Program
{
    static void Main()
    {
        // Se crea una lista enlazada
        ListaEnlazada lista = new ListaEnlazada();

        // Se insertan datos de ejemplo
        lista.InsertarFinal(10);
        lista.InsertarFinal(20);
        lista.InsertarFinal(30);
        lista.InsertarFinal(40);

        // Se muestra la lista
        lista.MostrarLista();

        // Se muestra el número de elementos de la lista
        Console.WriteLine("Número de elementos en la lista: " + lista.ContarElementos());
    }
}
