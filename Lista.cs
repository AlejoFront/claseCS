namespace Listas
{
    class Lista
    {
        // P             U
        // 5 10 15 20 25 30 

        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public Lista()
        {
            primero = null;
            ultimo = null;
        }


        // 1. Mostrar lista.  ->  P AL U  ||  U AL P
        // PRIMERO AL ULTIMO
        public void MostrarListaPU()
        {
            Nodo actual = new Nodo();
            actual = primero;
            while (actual != null)
            {
                Console.WriteLine("" + actual.Dato);
                actual = actual.Siguiente;
            }
        }


        // 2. Adicionar nodo al inicio de la lista.
        public void addNodoStart()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el nuevo dato a guardar al Inicio de la lista: ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                primero.Atras = nuevo;
                nuevo.Siguiente = primero;
                primero = nuevo;
            }
            Console.WriteLine("Nodo insertado correctamente");
        }


        // 3. Adicionar nodo al final de la lista.

        /* 
            nuevo = #    primero = 5, ultimo = 10   
            <- nodo ->
            null <- 5 ->  <- 10 -> null
        */

        public void addNodoEnd()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("Ingrese el nuevo dato a guardar al final de la lista: ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            if (primero == null)
            {
                primero = nuevo;
                ultimo = nuevo;
                primero.Siguiente = null;
                primero.Atras = null;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                nuevo.Atras = ultimo;
                ultimo = nuevo;

            }
            Console.WriteLine("Nodo insertado correctamente");
        }

        // 4. Adicionar nodo en una posición dada.
        public void addNodoPosicionDada()
        {
            Nodo nuevo = new Nodo();
            Nodo temporal = new Nodo();
            Console.WriteLine("Ingrese el nuevo dato a guardar: ");
            nuevo.Dato = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la posicion donde se va a guardar el nuevo nodo: ");
            int posicion = int.Parse(Console.ReadLine());

            if (posicion == 1)
            {
                if (primero == null)
                {
                    primero = nuevo;
                    ultimo = nuevo;

                    // aqui puede colocar el mensaje de q no puede En caso de estar vacía avisara que no se puede insertar.
                }
                else
                {
                    primero.Atras = nuevo;
                    nuevo.Siguiente = primero;
                    primero = nuevo;
                }
            }
            else
            {
                int banderaPos = 2;
                temporal = primero;
                while (banderaPos < posicion)
                {
                    temporal = temporal.Siguiente;
                    banderaPos++;
                }
                nuevo.Siguiente = temporal.Siguiente;
                nuevo.Atras = temporal;
                temporal.Siguiente.Atras = nuevo;
                temporal.Siguiente = nuevo;
            }


        }

        // 5. Eliminar un nodo en una posición dada.
        public void deleteNodo()
        {
            Nodo actual = new Nodo();
            Nodo nodoAnterior = new Nodo();
            actual = primero;
            nodoAnterior = null;
            bool encontrado = false;
            Console.WriteLine("Ingrese el nodo a eliminar");
            int nodoB = int.Parse(Console.ReadLine());
            while (actual != null && encontrado == false)
            {
                if (actual.Dato == nodoB)
                {
                    if (actual == primero)
                    {
                        primero = primero.Siguiente;
                        primero.Atras = null;

                    }
                    else if (actual == ultimo)
                    {
                        nodoAnterior.Siguiente = null;
                        ultimo = nodoAnterior;
                    }
                    else
                    {
                        nodoAnterior.Siguiente = actual.Siguiente;
                        actual.Siguiente.Atras = nodoAnterior;
                    }
                    Console.WriteLine("\n Nodo con el dato ({0}) fue eliminado", actual.Dato);
                    encontrado = true;
                }
                nodoAnterior = actual;
                actual = actual.Siguiente;
            }
            if (!encontrado)
            {
                Console.WriteLine("\n Nodo No Encontrado  ");
            }
        }

    }
}