using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

            Console.WriteLine("Ingrese un numero");
            Console.WriteLine("-Solo pueden ser enteros-");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("-Solo pueden ser enteros-");


            
            Operacion.Suma(n1, n2);
            Operacion.Resta(n1, n2);
            

            Console.ReadKey();
        }
    }
}
