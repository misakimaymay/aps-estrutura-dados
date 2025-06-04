using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataSort
{
    public class ListaDinamica<T> where T : IComparable<T>
    {
        private List<T> elementos; // elementos da lista
        public int Comparacoes { get; private set; } // comparar valores
        public int Trocas { get; private set; } // faz trocas de valores na lista

        public ListaDinamica()
        {
            elementos = new List<T>();
        }

        public void Inserir (T valor)
        {
            elementos.Add(valor);
        }

        public void Exibir()
        {
            if (elementos.Count ==0)
            {
                Console.WriteLine("Lista vazia.");
                return;
            }
            Console.Write("Lista: ");
            foreach (var item in elementos)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public bool Vazia()
        {
            return elementos.Count == 0;
        }

        public void GerarAleatorio(int quantidade, int min, int max)
        {
            Random rand = new Random(); // gerar valor aleat
            elementos.Clear(); // limpar o ultimo elemento gerado
            for (int i = 0; i < quantidade; i++) 
            {
                int valor = rand.Next(min, max + 1);
                elementos.Add((T)Convert.ChangeType(valor, typeof(T))); // "convert" é porque a lista não ta especificada para algum tipo de valor, então vai converter para "int"
            }
        }

        public List<T> ObterTodos()
        {
            return new List<T>(elementos);
        }

        public ListaDinamica<T> Clonar()
        {
            var copia = new ListaDinamica<T>(); // clonar lista
            foreach (var item in elementos)
            {
                copia.Inserir(item);
            }
            return copia;
        }

        private void ResetarContadores() // reseta tudo
        {
           Comparacoes = 0;
           Trocas = 0;
        }

        // bubble sort 
        public void OrdenarBubble()
        {
            ResetarContadores();
            for (int i = 0; i < elementos.Count - 1;i++)
            {
                for (int j = 0; j < elementos.Count -1; j++) // p gerar esse for: selecionar "for loop for"
                {
                    Comparacoes++;
                    if (elementos[j].CompareTo(elementos[j+1]) > 0)
                    {
                        Trocar(j, j + 1); // exemplo: j = 1; se 1 for maior, ele vai trocar pra 2 e vice versa
                    }
                }
            }
        }
        // trocar
        void Trocar(int a, int b)
        {
            T temp = elementos[a];
            elementos[a] = elementos[b];
            elementos[b] = temp;
            Trocas++;
        }
    }
}
