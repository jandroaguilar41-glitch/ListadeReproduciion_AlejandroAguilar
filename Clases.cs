namespace ReproductorMusica;

// ============================================================
// Clase Cancion: guarda los datos de una canción
// ============================================================
public class Cancion
{
    public string Codigo { get; set; }
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public string Genero { get; set; }
    public int Duracion { get; set; }       // en segundos
}

// ============================================================
// Clase NodoCancion: una "cajita" de la lista DOBLE.
// Guarda una canción y tiene DOS enlaces:
//   Siguiente = la canción que viene después
//   Anterior  = la canción que viene antes
// ============================================================
public class NodoCancion
{
    public Cancion Dato;
    public NodoCancion Siguiente;
    public NodoCancion Anterior;

    public NodoCancion(Cancion dato)
    {
        Dato = dato;
        Siguiente = null;
        Anterior = null;
    }
}

// ============================================================
// Clase ListaReproduccion: LISTA ENLAZADA DOBLE hecha por nosotros.
// Guarda las canciones que están en la reproducción.
// ============================================================
public class ListaReproduccion
{
    private NodoCancion cabeza;     // primera canción de la lista
    private NodoCancion cola;       // última canción de la lista
    private NodoCancion actual;     // la canción que está sonando ahora (null si ninguna)

    // Dice si la lista no tiene nada
    public bool EstaVacia()
    {
        return cabeza == null;
    }

    // INSERTAR: agrega una canción al final de la lista
    public void Insertar(Cancion c)
    {
        NodoCancion nuevo = new NodoCancion(c);

        if (cabeza == null)
        {
            // Si la lista estaba vacía, el nuevo nodo es el primero y el último
            cabeza = nuevo;
            cola = nuevo;
        }
        else
        {
            // El nuevo apunta hacia atrás al último actual,
            // el último actual apunta hacia adelante al nuevo,
            // y el nuevo pasa a ser el último.
            nuevo.Anterior = cola;
            cola.Siguiente = nuevo;
            cola = nuevo;
        }
    }

    // BUSCAR (de uso interno): devuelve el nodo con ese código, o null si no está
    private NodoCancion BuscarNodo(string codigo)
    {
        NodoCancion aux = cabeza;               // empezamos en el primer nodo

        while (aux != null)                     // mientras no se acabe la lista
        {
            if (aux.Dato.Codigo.ToLower() == codigo.ToLower())
            {
                return aux;
            }
            aux = aux.Siguiente;                // pasamos al siguiente nodo
        }

        return null;
    }

    // BUSCAR: devuelve la canción con ese código, o null si no está en la lista
    public Cancion Buscar(string codigo)
    {
        NodoCancion nodo = BuscarNodo(codigo);
        if (nodo == null)
        {
            return null;
        }
        return nodo.Dato;
    }

    // ELIMINAR: quita de la lista la canción con ese código
    public bool Eliminar(string codigo)
    {
        NodoCancion nodo = BuscarNodo(codigo);
        if (nodo == null)
        {
            return false;       // no estaba en la lista
        }

        // Arreglar el enlace del nodo de atrás
        if (nodo.Anterior == null)
        {
            cabeza = nodo.Siguiente;                    // era el primero: la cabeza pasa al segundo
        }
        else
        {
            nodo.Anterior.Siguiente = nodo.Siguiente;   // el de atrás se salta al nodo borrado
        }

        // Arreglar el enlace del nodo de adelante
        if (nodo.Siguiente == null)
        {
            cola = nodo.Anterior;                       // era el último: la cola pasa al penúltimo
        }
        else
        {
            nodo.Siguiente.Anterior = nodo.Anterior;    // el de adelante se salta al nodo borrado
        }

        // Si justo estaba sonando esa canción, ya no hay ninguna sonando
        if (actual == nodo)
        {
            actual = null;
        }

        return true;
    }

    // RECORRER: devuelve todas las canciones de la primera a la última
    public List<Cancion> Recorrer()
    {
        List<Cancion> canciones = new List<Cancion>();
        NodoCancion aux = cabeza;

        while (aux != null)
        {
            canciones.Add(aux.Dato);
            aux = aux.Siguiente;
        }

        return canciones;
    }

    // RECORRER AL REVÉS: devuelve las canciones de la última a la primera
    // (esto se puede hacer gracias al enlace Anterior)
    public List<Cancion> RecorrerAlReves()
    {
        List<Cancion> canciones = new List<Cancion>();
        NodoCancion aux = cola;

        while (aux != null)
        {
            canciones.Add(aux.Dato);
            aux = aux.Anterior;
        }

        return canciones;
    }

    // ===== NAVEGACIÓN =====

    // Devuelve la canción que está sonando, o null si ninguna
    public Cancion Actual()
    {
        if (actual == null)
        {
            return null;
        }
        return actual.Dato;
    }

    // Empieza la reproducción desde la primera canción
    public bool Iniciar()
    {
        actual = cabeza;
        return actual != null;
    }

    // Pasa a la canción siguiente. Devuelve false si no hay siguiente.
    public bool IrAlSiguiente()
    {
        if (actual == null || actual.Siguiente == null)
        {
            return false;
        }
        actual = actual.Siguiente;
        return true;
    }

    // Pasa a la canción anterior. Devuelve false si no hay anterior.
    public bool IrAlAnterior()
    {
        if (actual == null || actual.Anterior == null)
        {
            return false;
        }
        actual = actual.Anterior;
        return true;
    }
}
