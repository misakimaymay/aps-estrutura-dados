using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            HashTable<int> tabela = new HashTable<int>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Tabela Hash! ( ˶ˆᗜˆ˵ )");
                Console.WriteLine("1- Inserir valor: ");
                Console.WriteLine("2- Buscar valor: ");
                Console.WriteLine("3- Remover valor: ");
                Console.WriteLine("4- Exibir tabela: ");
                Console.WriteLine("0- Sair. ");
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();
                Console.Clear();

                switch (opcao)
                {
                    case "1":
                        Console.Write("Valor a inserir: ");
                        if (int.TryParse(Console.ReadLine(), out int valorInserir))
                            tabela.Inserir(valorInserir);
                        else
                            Console.WriteLine("Valor inválido.");
                        break;
                    case "2":
                        Console.Write("Valor a buscar: ");
                        if (int.TryParse(Console.ReadLine(), out int valorBuscar))
                        {
                            if (tabela.Buscar(valorBuscar))
                            {
                                Console.WriteLine($"{valorBuscar} encontrado! :D");
                            }
                            else
                                Console.WriteLine($"{valorBuscar} não encontrado na tabela.");
                        }
                        else
                            Console.WriteLine("Valor inválido.");
                        break;
                    case "3":
                        Console.Write("Valor a remover: ");
                        if (int.TryParse(Console.ReadLine(), out int valorRemover))
                        {
                            if (tabela.Remover(valorRemover))
                                Console.WriteLine($"{valorRemover} removido!");
                            else
                                Console.WriteLine($"{valorRemover} não encontrado. ");
                        }
                        else
                            Console.WriteLine("Valor inválido.");
                        break;
                    case "4":
                        Console.Write("Tabela Hash:");
                        tabela.Exibir();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Opção inválida. ");
                        break;
                }

                Console.WriteLine("\nPressione ENTER para continuar!");
                Console.ReadLine();
            }
        }
    }
}
