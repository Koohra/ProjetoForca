using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForcaConsole
{
    internal class ColetarDados
    {
        internal static void MetodoPrincipal()
        {
            //Caminho do arquivo de texto
            string caminhoBancoDeDados = "C:\\Users\\miguels\\Documents\\ADA\\Logica da programação\\Exercicio\\ProjetoForca\\ProjetoForca\\ForcaConsole\\BancoDeDados.txt";
            //Classe "File" com o metodo "ReadAllLines" para ler todas as linhas do arquivo
            string[] linhas = File.ReadAllLines(caminhoBancoDeDados);

            //criar um dicionario para separar e armazenar categorias e palavras
            Dictionary<string, List<string>> categoriasPalavras = new Dictionary<string, List<string>>();

            //preencher o dicionario com base no arquivo linhas
            foreach (string linha in linhas)
            {
                string[] partes = linha.Split(',');
                string categoria = partes[0].Trim();
                string palavra = partes[1].Trim();

                if (categoriasPalavras.ContainsKey(categoria))
                {
                    categoriasPalavras[categoria].Add(palavra);
                }
                else
                {
                    categoriasPalavras.Add(categoria, new List<string> { palavra });
                }
            }

            //Sorteio da categoria
            Random random = new Random();
            List<string> categorias = new List<string>(categoriasPalavras.Keys);
            string categoriasSorteada = categorias[random.Next(categorias.Count)];

            //Obter a lista de palavras associadas à categoria sorteada
            List<string> palavrasNaCategoria = categoriasPalavras[categoriasSorteada];

            //Sortear uma palavra
            string palavraSorteada = palavrasNaCategoria[random.Next(palavrasNaCategoria.Count)];
            Usuario.MetodoPrincipal(categoriasSorteada, palavraSorteada);
        }
    }
}
