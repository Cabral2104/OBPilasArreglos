using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBPilasArreglos
{
    internal class Program
    {
        static void Main()
        {
            Pila pila = new Pila(5);

            pila.Apilar(0);
            pila.Apilar(1);
            pila.Apilar(2);
            pila.Apilar(3);
            pila.Apilar(4);

            Console.WriteLine("Último elemento:" + pila.Cima()); 

            Console.WriteLine("Sacamos el último elemento:" + pila.Desapilar()); 

            Console.WriteLine("Número de elementos restantes: " + pila.Tamaño()); 
            
            Console.ReadKey();
        }
    }
}
