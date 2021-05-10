using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triangulo.consoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo1 = new Triangulo(2, 2, 3);
            Triangulo triangulo2 = new Triangulo(6, 6, 6);
            Triangulo triangulo3 = new Triangulo(2, 3, 5);
            Triangulo triangulo4 = new Triangulo(4, 4, 44);

            Console.Write("Triangulo 1:");
            Console.Write(triangulo1.ExibirValores());
            Console.WriteLine(triangulo1.Tipo());

            Console.Write("Triangulo 2: ");
            Console.Write(triangulo2.ExibirValores());
            Console.WriteLine(triangulo2.Tipo());

            Console.Write("Triangulo 3: ");
            Console.Write(triangulo3.ExibirValores());
            Console.WriteLine(triangulo3.Tipo());

            Console.Write("Triangulo 4: ");
            Console.Write(triangulo4.ExibirValores());
            Console.WriteLine(triangulo4.Tipo());


            Console.ReadLine();
        }

 
    }
}

