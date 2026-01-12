// Clase Nodo
// Representa cada elemento de la lista enlazada
// Contiene un dato y un enlace al siguiente nodo
public class Nodo
{
    public int Dato;          // Información que guarda el nodo
    public Nodo Siguiente;    // Referencia al siguiente nodo

    // Constructor del nodo
    public Nodo(int dato)
    {
        Dato = dato;
        Siguiente = null; // Al inicio no apunta a ningún otro nodo
    }
}
