namespace EDDemo
{
    public class Pilas
    {
        private Nodo top; // Referencia al tope de la pila.

        public Pilas()
        {
            top = null; // Inicializa la pila vacía.
        }

        public void Push(int dato)
        {
            Nodo nuevoNodo = new Nodo(dato); 
            nuevoNodo.Sig = top; 
            top = nuevoNodo; 
        }

        public int Pop()
        {
            if (top == null) 
            {
                return -1;
            }

            int datoEliminado = top.Dato; 
            top = top.Sig;
            return datoEliminado; 
        }

        public int buscar(int dato)
        {
            Nodo actual = top; // Empieza desde el tope.
            int posicion = 1; // Contador para la posición.

            while (actual != null) // Recorre la pila.
            {
                if (actual.Dato == dato) // Si encuentra el dato, retorna la posición.
                {
                    return posicion;
                }

                actual = actual.Sig; // Avanza al siguiente nodo.
                posicion++;
            }

            return -1; // Retorna -1 si no se encuentra el dato.
        }

        // Método para vaciar completamente la pila.
        public void Vaciar()
        {
            top = null; // Borra la referencia al tope, vaciando la pila.
        }

        // Método para obtener el nodo en el tope de la pila.
        public Nodo ObtenerTope()
        {
            return top; // Retorna la referencia al nodo tope.
        }
    }
}
