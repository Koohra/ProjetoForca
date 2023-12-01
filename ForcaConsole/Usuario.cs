using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcaConsole
{
    internal static class Usuario
    {
        internal static void MetodoPrincipal(string categoriaSorteada, string palavraSorteada)
        {
            ImprimirMensagemInicial();
            char[] palavraEscondida = new char[palavraSorteada.Length];
            palavraEscondida = AlterarArray(palavraEscondida, palavraSorteada);
            Console.WriteLine($"A categoria da palavra é: {categoriaSorteada} ");
            List<char> letraGuardada = new List<char>();
            int erro = 0;
            while (true)
            {
                char letra = ReceberLetra();
                if (palavraSorteada.Contains(letra))
                {
                    if (VerificaLetraRepetida(letra, letraGuardada)) 
                    {
                        Console.WriteLine("\nVocê ja inseriu essa Letra");

                    }
                    else
                    {
                        palavraEscondida = VerificarLetra(palavraEscondida, palavraSorteada, letra);
                        if(!VerificarVitoria(palavraEscondida))
                        {
                            break;
                        }
                        
                    }
                }
                else
                {
                    erro++;
                    Console.WriteLine($"\nVoce errou {erro} vezes");
                    if (Perdeu(erro))
                        break;
                }
                
             Console.WriteLine($"\n{string.Join("", palavraEscondida)}");

            }
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
        private static bool VerificarVitoria(char[] palavraEscondida)
        {
            if (palavraEscondida.Contains('_'))
            {
                return true;
            }
            string palavraFinal = new string(palavraEscondida);
            Console.WriteLine($"\nVocê venceu parabens voce encontrou a palavra: {palavraFinal}");
            return false;
        }

        private static bool Perdeu(int erro)
        {
            if (erro == 6)
            {
                return true;
            }
            return false;
        }
        private static bool VerificaLetraRepetida(char letra, List<char> letraGuardada)
        {
            if (letraGuardada.Contains(letra))
            {
                return true;
            }
            else
            {
                letraGuardada.Add(letra);
                return false;
            }
        }
        private static void ImprimirMensagemInicial()
        {
            Console.WriteLine("BEM VINDO AO JOGO DA FORCA");
            Console.WriteLine("Tente adivinhar qual é a palavra\n");
        }
    }
}
