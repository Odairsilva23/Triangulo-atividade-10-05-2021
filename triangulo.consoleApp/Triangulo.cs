using System;
namespace triangulo.consoleApp
{

     public class Triangulo
    {
        public double A;
        public double B;
        public double C;

    

        public Triangulo(double A, double B, double C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public string ExibirValores()
        {
            return "(" + A + "," + B + "," + C + ")";
        }

        public bool Validar()
        {
            bool validacao = true;
            if ((A <= 0) || (B <= 0) || (C <= 0))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" os valores dos lados do triangulo devem ser numeros positivos");
                Console.ResetColor();
                return false;
            }
            if ((A > (B + C)) || (B > (A + C)) || (C > (A + B)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" um lado do triangulo é maior que a soma dos outros dois lados");
                Console.ResetColor();
                return false;
            }
           else
            {
                Console.WriteLine("Triangulo Valido");
                return(validacao);
            }
        }

        public string Tipo()
        {
            string tipo = "";

            if (Validar())
            {
                if ((A == B) && (B == C))
                {
                    tipo = "Equilátero: Todos os lados iguais";
                }
                else if ((A == B) || (A == C) || (B == C))
                {
                    tipo = "É  um Triangulo Isósceles: Dois lados iguais";
                }
                else
                {
                    tipo = "É um triangulo Escaleno: Todos os lados diferentes";
                }
            }
            else
            {
                tipo = "";
            }
            return tipo;
        }
    }
}