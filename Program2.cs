using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int optMenu;
            do {
                
                Console.WriteLine("\n === Bem vindo ao nosso programa === \n\n 1 - Cria arquivo \n 2 - Ler arquivo \n 0 - Sair");
                optMenu = int.Parse(Console.ReadLine());

                switch (optMenu)
                {
                    case 1:
                                Console.Clear();
                                string contentName;
                                double age;
                                FileStream stream = new FileStream(@"C:\Users\Aluno\source\repos\exercicio 2\exercicio 2\arquiveString.txt", FileMode.Create);
                                BinaryWriter writer = new BinaryWriter(stream);

                                Console.WriteLine("Digite seu nome: ");
                                contentName = Console.ReadLine(); 
                                Console.WriteLine("Digite sua idade: ");
                                age = int.Parse(Console.ReadLine());

                        writer.Write(contentName);
                                writer.Write(age);

                                writer.Flush();
                                writer.Close();
                        break;
                    case 2:
                        string url = @"C:\Users\Aluno\source\repos\Atividade Arquivo Txt\Atividade Arquivo Txt\textArquive.txt";

                        System.IO.StreamReader sr;
                        string linhaAtual;

                        if (!System.IO.File.Exists(url))
                        {
                            throw (new System.IO.FileNotFoundException("Não foi possível localizar o Arquivo Especificado"));
                        }
                        using (sr = new System.IO.StreamReader(url))
                        {
                            Console.Clear();
                            Console.WriteLine("Conteúdo do arquivo lido: \n");
                            while (!sr.EndOfStream)
                            {
                                linhaAtual = sr.ReadLine();
                                Console.WriteLine(linhaAtual);
                            }
                        }
                        break;
                }
            } while (optMenu!=0);
            Console.Clear();
            Console.WriteLine("Tchau :p");
            Console.ReadKey();
        }
    }
}
