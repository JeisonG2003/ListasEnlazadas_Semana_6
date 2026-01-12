using System;

// Clase que representa la lista enlazada simple
public class ListaEnlazada
{
    private Nodo head; // Primer nodo de la lista

    // Constructor de la lista
    public ListaEnlazada()
    {
        head = null; // La lista inicia vacía
    }

    // Inserta un nuevo nodo al final de la lista
    public void InsertarFinal(int dato)
    {
        Nodo nuevo = new Nodo(dato);

        // Si la lista está vacía, el nuevo nodo será el primero
        if (head == null)
        {
            head = nuevo;
        }
        else
        {
            // Recorremos la lista hasta llegar al último nodo
            Nodo actual = head;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // EJERCICIO 1:
    // Método que cuenta cuántos elementos tiene la lista enlazada
    public int ContarElementos()
    {
        int contador = 0;
        Nodo actual = head;

        // Recorremos la lista nodo por nodo
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }

        return contador;
    }

    // Muestra la lista en pantalla de forma clara
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
