using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            arbol.InsertarNodo(1, "Juan");
            arbol.InsertarNodo(2, "Jose");
            arbol.InsertarNodo(3, "Pedro");
            arbol.InsertarNodo(4, "Pablo");
            arbol.InsertarNodo(5, "Lucas");

            
            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

            arbol.Eliminar(arbol.GetRaiz(), 2);

            Console.WriteLine("Inorden:");
            arbol.Inorden(arbol.GetRaiz());
            Console.WriteLine("");

            //Console.WriteLine("Preorden:");
            //arbol.Preorden(arbol.GetRaiz());
            //Console.WriteLine("");
            //Console.WriteLine("Postorden:");
            //arbol.Postorden(arbol.GetRaiz());
            //Console.WriteLine("");
            Console.Read();
           
        }
    }
}
