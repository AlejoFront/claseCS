namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******LISTAS DOBLEMENTE ENLAZADAS******");
            Lista lista = new Lista();
            // lista.addNodoEnd();
            // lista.addNodoEnd();
            // lista.addNodoEnd();
            // lista.addNodoEnd();
            // lista.addNodoEnd();
            // lista.addNodoEnd();
            lista.addNodoStart();
            lista.addNodoStart();
            lista.addNodoStart();
            lista.addNodoStart();
            lista.addNodoStart();
            Console.WriteLine("\n MOSTRAR PRIMERO AL ULTIMO");
            lista.MostrarListaPU();
            Console.WriteLine("\n agregar nodo en la posicion #");
            lista.addNodoPosicionDada();
            Console.WriteLine("\n MOSTRAR PRIMERO AL ULTIMO");
            lista.MostrarListaPU();
            Console.WriteLine("\n Eliminar Nodo en posicion ...");
            lista.deleteNodo();
            Console.WriteLine("\n MOSTRAR PRIMERO AL ULTIMO");
            lista.MostrarListaPU();
        }
    }
}