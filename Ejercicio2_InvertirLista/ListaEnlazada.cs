using System;

// Clase que implementa una lista enlazada simple
public class ListaEnlazada
{
    private Nodo head; // Nodo inicial de la lista

    public ListaEnlazada()
    {
        head = null;
    }

    // Inserta un nodo al final de la lista
    public void InsertarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        if (head == null)
        {
            head = nuevo;
        }
        else
        {
            Nodo actual = head;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // EJERCICIO 2:
    // Método que invierte el orden de la lista enlazada
    public void InvertirLista()
    {
        Nodo anterior = null;
        Nodo actual = head;
        Nodo siguiente;

        // Se recorren los nodos cambiando la dirección de los enlaces
        while (actual != null)
        {
            siguiente = actual.Siguiente; // Guardamos el siguiente nodo
            actual.Siguiente = anterior;  // Invertimos el enlace
            anterior = actual;            // Avanzamos el nodo anterior
            actual = siguiente;           // Avanzamos al siguiente nodo
        }

        // El último nodo pasa a ser el primero
        head = anterior;
    }

    // Muestra la lista en pantalla
    public void MostrarLista()
    {
        Nodo actual = head;
        Console.Write("head -> ");

        while (actual != null)
        {
            Console.Write($"[{actual.Dato}] -> ");
            actual = actual.Siguiente;
        }

        Console.WriteLine("null");
    }
}
