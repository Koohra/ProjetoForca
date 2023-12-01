using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcaConsole
{
    internal class Usuario
    {
        internal static void MetodoPrincipal(string categoriaSorteada, string palavraSorteada)
        {
            char letra = ReceberLetra();
            char[] palavraEscondida = new char[palavraSorteada.Length];
            palavraEscondida = AlterarArray(palavraEscondida, palavraSorteada);
            palavraEscondida = VerificarLetra(palavraEscondida, palavraSorteada, letra);
            Console.WriteLine($"\n{string.Join("", palavraEscondida)}");
        }
        private static char[] AlterarArray(char[] palavraEscondida, string palavraSorteada)
        {
            for (int i = 0; i < palavraSorteada.Length; i++)
            {
                if ((palavraEscondida[i] == ' '))
                {
                    palavraEscondida[i] = ' ';
                }
                else
                {
                    palavraEscondida[i] = '_';
                }
            }
            return palavraEscondida;
        }
        private static char[] VerificarLetra(char[] palavraEscondida, string palavraSorteada, char letra)
        {
            for (int i = 0; i < palavraSorteada.Length; i++)
            {
                if (palavraSorteada[i] == letra)
                {
                    palavraEscondida[i] = letra;
                }
            }
            return palavraEscondida;
        }
        private static char ReceberLetra()
        {
            Console.Write("Insira uma letra: ");
            char letra = Console.ReadKey().KeyChar;
            return letra;
        }
    }
}
