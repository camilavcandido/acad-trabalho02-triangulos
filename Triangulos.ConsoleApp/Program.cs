using System;

namespace Triangulos.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triângulos\n");
            Console.WriteLine("*Apenas valores numericos inteiros são aceitos nas variáveis X, Y e Z.");

            bool continuar = true;
            while (continuar)
            {

                int x, y, z;
                Console.Write("Insira o valor de X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Insira o valor de Y: ");
                y = int.Parse(Console.ReadLine());
                Console.Write("Insira o valor de Z: ");
                z = int.Parse(Console.ReadLine());


                //condicao de existencia
                while (x > (y + z) || y > (z + x) || z > (y + x))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Triângulo inválido. ");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(
                        "lembre-se: Para construir um triângulo é necessário que a medida " +
                        "de qualquer um dos lados seja menor que a soma dos outros dois lados.");
                    Console.ResetColor();

                    Console.Write("Insira o valor de X: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Insira o valor de Y: ");
                    y = int.Parse(Console.ReadLine());
                    Console.Write("Insira o valor de Z: ");
                    z = int.Parse(Console.ReadLine());

                }

                //tipos 

                if (x == y && x == z && z == y)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Triângulo Equilátero - todos os lados iguais"); //todos lados iguais
                    Console.ResetColor();
                }
                else if (x == y || y == z || x == z)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Triângulo Isósceles - dois lados iguais");//dois lados iguais
                    Console.ResetColor();

                }
                else if (x != y && y != z && x != z)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Triângulo Escaleno - todos os lados diferentes");//todos os lados diferentes
                    Console.ResetColor();

                }

                Console.WriteLine("\nDigite  1 para verificar o Tipo de Triângulo\nDigite 'S' para sair");
                string strContinuar = Console.ReadLine();
                if (strContinuar == "1")
                {
                    continuar = true;
                }
                else if (strContinuar == "s" || strContinuar =="S")
                {
                    break;
                }

            }
        }
    }
}
