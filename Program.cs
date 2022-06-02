using System;
using System.IO;

namespace Atividade_Arquivo_Txt
{
    class Program
    {
        static void Main(string[] args)
        {
            int optMenu;
            do { 
            string textUser;

                Console.Clear();
            Console.WriteLine("=== Seja bem vindo ao nosso programa === \n\n 1 - Digitar \n 2 - Ler arquivo \n 0 - Sair");
            optMenu = int.Parse(Console.ReadLine());

            switch (optMenu) {
                case 1:
                    Console.Clear();
                    StreamWriter wr = new StreamWriter(@"C:\Users\Aluno\source\repos\Atividade Arquivo Txt\Atividade Arquivo Txt\textArquive.txt", true);

                    Console.WriteLine("Digite alguma coisa:");
                    textUser = Console.ReadLine();

                    wr.WriteLine(textUser);
                    wr.Close();
                    break;
                case 2:
                        Console.Clear();
                        string url = @"C:\Users\Aluno\source\repos\exercicio 2\exercicio 2\arquiveString.txt";

                        System.IO.StreamReader sr;
                        string linhaAtual;

                        if (!System.IO.File.Exists(url))
                        {
                            throw (new System.IO.FileNotFoundException("Não foi possível localizar o Arquivo Especificado"));
                        }
                        using (sr = new System.IO.StreamReader(url))
                        {
                            while (!sr.EndOfStream)
                            {
                                linhaAtual = sr.ReadLine();
                                Console.WriteLine(linhaAtual);
                            }
                        }
                    break;
            }
            } while (optMenu != 0);
            Console.Clear();
            Console.WriteLine("Tchau :p");
            Console.ReadKey();
        }
    }
}
