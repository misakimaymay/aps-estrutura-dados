using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaDinamica<int> lista = new ListaDinamica<int>();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Ordenar listas! <3");
                Console.WriteLine("1 - Inserir nova lista");
                Console.WriteLine("2 - Exibir lista atual");
                Console.WriteLine("3 - Ordenar lista");
                Console.WriteLine("4 - Gerar lista aleatória");
                Console.WriteLine("0 - Sair");
                Console.Write("Escolha uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        lista = new ListaDinamica<int>();
                        Console.WriteLine("\n Quantos elementos deseja inserir?");
                        if (int.TryParse(Console.ReadLine(), out int n) && n > 0) // && diz que o número inserido precisa ser maior que 0
                        {
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write($"Digite o {i + 1}° valor: ");
                                if (int.TryParse(Console.ReadLine(), out int valor))
                                    lista.Inserir(valor);
                                else
                                {
                                    Console.WriteLine("Opção inválida. D: Pressione ENTER para continuar.");
                                    Console.ReadLine();
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Número inválido. D: Pressione ENTER para continuar.");
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nLista atual: ");
                        lista.Exibir();
                        Console.WriteLine("Pressione ENTER para continuar");
                        Console.ReadLine();
                        break;
                    case "3":
                        if (lista.Vazia())
                        {
                            Console.WriteLine("Lista está vazia. Insira elementos primeiro.");
                            Console.ReadLine();
                        }
                        Console.WriteLine("\nEscolha um algoritmo de orientação: ");
                        Console.WriteLine("1- Bubble Sort");
                        Console.WriteLine("2- Selection Sort");
                        Console.WriteLine("3- Insertion Sort");
                        Console.WriteLine("4- Merge Sort");
                        Console.WriteLine("5- Quick Sort");
                        Console.WriteLine("");
                        string escolha = Console.ReadLine();

                        Console.WriteLine("\nLista antes da organização:");
                        Stopwatch sw = Stopwatch.StartNew(); 

                        var copiaOrdenavel = lista.Clonar();
                        switch (escolha)
                        {
                            case "1": copiaOrdenavel.OrdenarBubble(); break;
                            // implementar os demais (vamos fazer nas proximas aulas)
                            case "2": copiaOrdenavel.OrdenarBubble(); break;
                            case "3": copiaOrdenavel.OrdenarBubble(); break;
                            case "4": copiaOrdenavel.OrdenarBubble(); break;
                            case "5": copiaOrdenavel.OrdenarBubble(); break;
                            default:
                                Console.WriteLine("Opção inválida. D:");
                                Console.ReadLine();
                                continue;
                        }

                        sw.Stop();

                        Console.WriteLine("\nLista após ordenação: ");
                        copiaOrdenavel.Exibir();
                        Console.WriteLine($"\nTempo de execução: {sw.ElapsedMilliseconds} segundos.");
                        Console.WriteLine($"\nComparações: {copiaOrdenavel.Comparacoes}");
                        Console.WriteLine($"\nTrocas: {copiaOrdenavel.Trocas}");
                        Console.WriteLine($"\nPressione ENTER para continuar.");
                        Console.ReadLine();
                        break;
                    case "4":
                        break;
                    case "0":
                        Console.WriteLine("Saindo . . .");
                        return;
                    default:
                        Console.WriteLine("Opção inválida! D: Pressione ENTER para continuar.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
