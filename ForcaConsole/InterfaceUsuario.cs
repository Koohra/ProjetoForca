using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcaConsole
{
    public class InterfaceUsuario
    {
        public static void ImprimirMensagemInicial()
        {
            Console.WriteLine("BEM VINDO AO JOGO DA FORCA");
            Console.WriteLine("Tente adivinhar qual é a palavra\n");
        }
        public static void DesenhoForca(int erro)
        {
            switch (erro)
            {
                case 0:
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                    break;
                case 1:
                    Console.WriteLine("\n|  (_) |");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                    break;
                case 2:
                    Console.WriteLine("\n| (_)  |");
                    Console.WriteLine(@"| \    |");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                    break;
                case 3:
                    Console.WriteLine("\n| (_)  |");
                    Console.WriteLine(@"| \|   |");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                    break;
                case 4:
                    Console.WriteLine("\n| (_)  |");
                    Console.WriteLine(@"| \|/  |");
                    Console.WriteLine("|      |");
                    Console.WriteLine("|      |");
                    break;
                case 5:
                    Console.WriteLine("\n| (_)  |");
                    Console.WriteLine(@"| \|/  |");
                    Console.WriteLine("|  |   |");
                    Console.WriteLine("|      |");
                    break;
                case 6:
                    Console.WriteLine("\n| (_)  |");
                    Console.WriteLine(@"| \|/  |");
                    Console.WriteLine("|  |   |");
                    Console.WriteLine("| /    |");
                    break;
                case 7:
                    Console.WriteLine("\n| (_)  |");
                    Console.WriteLine(@"| \|/  |");
                    Console.WriteLine("|  |   |");
                    Console.WriteLine(@"| / \  |");
                    break;
            }
        }
    }
}
