using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hola_Mundo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros;
            int op = 0;
            do
            {
                Console.WriteLine("1. Escribir elementos!!");
                Console.WriteLine("2. Imprimir el arreglo!!");
                Console.WriteLine("3. Hacer una suma donde el primer numero digitado se sumara con el segundo numero digitado!!");
                Console.WriteLine("4. Escribir la cantidad de elementos!!");
                Console.WriteLine("5. Escribir la cantidad de elementos!!");
                Console.WriteLine("6. Escribir la cantidad de elementos!!");
                Console.WriteLine("7. Escribir la cantidad de elementos!!");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite la cantidad de elementos");
                        int cantidad= Convert.ToInt32( Console.ReadLine());
                        numeros = new int[cantidad];
                    break;
                    default:
                        break;
                }  
                
            } while (op<7);
        }
    }
}
