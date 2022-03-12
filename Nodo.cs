namespace Listas
{
    class Nodo // aplicamos algo de encapsulamiento .... del nodo
    {
        private int dato;
        private Nodo siguiente;
        private Nodo atras;
        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }
        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }
        public Nodo Atras
        {
            get { return atras; }
            set { atras = value; }
        }
    }
}