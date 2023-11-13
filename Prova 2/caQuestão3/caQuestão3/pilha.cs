using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão3
{
    internal class pilha
    {
        private NoPilha topo;


        public void Pilha()
        {
            topo = null;
        }

        public bool estaVazia()
        {
            if (topo == null) return true;

            else return false;
        }

        public void push(int n)
        {
            NoPilha novoNo = new NoPilha(n);

            if (estaVazia())
            {
                topo = novoNo;
            }
            else
            {
                novoNo.Proximo = topo;
                topo = novoNo;
            }
        }

        public void imprime()
        {
            if (estaVazia())
                Console.WriteLine("pilha vazia");
            else
            {
                NoPilha temp = topo;
                while (temp != null)
                {
                    Console.WriteLine(temp.Dado);
                    temp = temp.Proximo;
                }
            }
        }

        public int pop()
        {
            int temp = topo.Dado;
            topo = topo.Proximo;
            return temp;
        }
    }
}
