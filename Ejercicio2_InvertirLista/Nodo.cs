// Clase Nodo
// Representa un elemento de la lista enlazada
public class Nodo
{
    public int Dato;          // Valor almacenado en el nodo
    public Nodo Siguiente;    // Enlace al siguiente nodo

    // Constructor del nodo
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}
