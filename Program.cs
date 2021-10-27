using Atividade.Fixação.Heranças.Polimorfismo.Entitis;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Atividade.Fixação.Heranças.Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a quantidade de produtos comprados");
            int numero = int.Parse(Console.ReadLine());

            List<Produto> list = new List<Produto>();

            for(int i = 1; i <= numero; i++)
            {
                Console.WriteLine($"\nInformações Produto #{i}");
                Console.Write("Nacional, Importado ou Usado? (n,i,u): ");
                char opcao = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(opcao == 'n')
                {
                    list.Add(new Produto(nome, preco));
                }
                else if (opcao == 'i')
                {
                    Console.Write("Taxa Alfandega: ");
                    double taxaAlfandega = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Produto_Importado(taxaAlfandega, nome, preco));
                }
                else
                {
                    Console.Write("Data de Fabricação: ");
                    DateTime dataFabricacao = DateTime.Parse(Console.ReadLine());
                    list.Add(new Produto_Usado(dataFabricacao, nome, preco));
                }
            }
            Console.WriteLine("\n\nPreço Etiqueta: ");
            foreach(Produto emp in list)
            {
                Console.WriteLine(emp.PrecoEtiqueta());
            }
        }
    }
}
