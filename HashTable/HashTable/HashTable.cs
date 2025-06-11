using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTable<T>
    {
        private List<LinkedList<T>> tabela;
        private int capacidade;

        public HashTable(int capacidade = 10)
        {
            this.capacidade = capacidade;
            tabela = new List<LinkedList<T>>(capacidade);

            for (int i = 0; i < capacidade; i++)
                tabela.Add(new LinkedList<T>());
        }
        
        private int Hash(T valor)
        {
            return Math.Abs(valor.GetHashCode()) % capacidade; // geralmente chamada de índice
        }

        public void Inserir(T valor)
        {
            int indice = Hash(valor);
            if (!tabela[indice].Contains(valor)) // o código indica que o valor existe, mas o "!" indica que o resultado é diferente (logo o código indica se o valor não existir, vai criar um valor na posição indicada)
            {
                tabela[indice].AddLast(valor);
                Console.WriteLine($"{valor} inserido na posição {indice}");
            }
            else
            {
                Console.WriteLine($"{valor} já existe na posição {indice}.");
            }
        }

        public bool Buscar(T valor)
        {
            int indice = Hash(valor);
            return tabela[indice].Contains(valor);
        }

        public bool Remover(T valor)
        {
            int indice = Hash(valor);
            return tabela[indice].Remove(valor);
        }

        public void Exibir()
        {
            for (int i = 0; i < capacidade; i++)
            {
                Console.Write($"[{i}]: ");
                foreach (var item in tabela[i])
                    Console.Write(item + " -> ");
                Console.WriteLine("null");
            }
        }
    }
}
