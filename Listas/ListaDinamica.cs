using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDinamica
{
        public class ListaDinamica<T> where T : IComparable<T>
        {
            private List<T> elementos;

            public ListaDinamica()
            {
                elementos = new List<T>();
            }
            public void Inserir(T valor)
            {
                elementos.Add(valor);
            }
            public void Exibir()
            {
                if (elementos.Count == 0)
                {
                    Console.WriteLine("Lista vazia.");
                    return;
                }
                Console.Write("Lista: ");
                foreach (var item in elementos)
                {
                    Console.Write($"{item}" + " ");
                }
                Console.WriteLine();
            }
            public int BuscaSequencial(T valor)
            {
                for (int i = 0; i < elementos.Count; i++)
                {
                    if (elementos[i].CompareTo(valor) == 0)
                    {
                        return i;
                    }
                }
                return 0;
            }
            public int BuscaBinaria(T valor)
            {
                int inicio = 0;
                int fim = elementos.Count - 1;

                while (inicio <= fim)
                {
                    int meio = (inicio + fim) / 2;

                    if (elementos[meio].CompareTo(valor) == 0)
                    {
                        return meio;
                    }
                    if (elementos[meio].CompareTo(valor) > 0)
                    {
                        fim = meio - 1;
                    }
                    else
                    {
                        inicio = meio + 1;
                    }
                }
                return -1;
            }
        }
    public class Program
    { 
        static void Main(string[] args)
        {
        Console.WriteLine("Digite a quantidade de elementos da lista: ");
        int n = int.Parse(Console.ReadLine());

        ListaDinamica<int> lista = new ListaDinamica<int>();

        for (int i = 0; i < n; i++)
        {
        Console.WriteLine($"Digite o {i + 1} elemento: ");
        int valor = int.Parse(Console.ReadLine());
        lista.Inserir(valor);
        }

        lista.Exibir();

            Console.WriteLine("Digite o elemento a ser buscado: ");
            int elementoBuscado = int.Parse(Console.ReadLine());

            int resultadoSequencial = lista.BuscaSequencial(elementoBuscado);

            if (resultadoSequencial != -1)
            {
                Console.WriteLine($"Elemento {elementoBuscado} encontrado na posição {resultadoSequencial}");
            }
            else
            {
                Console.WriteLine($"Elemento {elementoBuscado} não encontrado (Busca Sequencial)");
            }

            int resultadoBinario = lista.BuscaBinaria(elementoBuscado);

            if (resultadoBinario != -1)
            {
                Console.WriteLine($"Elemento {elementoBuscado} encontrado na posição {resultadoBinario}");
            }
            else
            {
                Console.WriteLine($"Elemento {elementoBuscado} não encontrado (Busca Binária)");
            }
        }
    }
}
