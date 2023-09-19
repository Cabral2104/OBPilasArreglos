using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBPilasArreglos
{
    internal class Pila
    {
        int[] items;
        int contador;

        public Pila(int capacidad)
        {
            items = new int[capacidad];
            contador = 0;
        }

        public void Apilar(int item)//Agrega un elemento a la pila
        {
            if (contador == items.Length)
                throw new InvalidOperationException("Pila llena");

            items[contador] = item;
            contador++;
        }

        public int Desapilar()//Saca el último elemento apilado
        {
            if (contador == 0)
                throw new InvalidOperationException("Pila vacía");

            contador--;
            return items[contador];
        }

        public int Cima()// Obtiene el último elemento sin sacarlo
        {
            if (contador == 0)
                throw new InvalidOperationException("Pila vacía");

            return items[contador - 1];
        }

        public int Tamaño()//Obtiene el número de elementos
        {
            return contador;
        }
    }
}
