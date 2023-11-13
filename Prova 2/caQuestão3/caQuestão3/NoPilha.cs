using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão3
{
    internal class NoPilha
    {
        private int dado;
        private NoPilha proximo;


        public NoPilha() { }

        public NoPilha(int _dado)
        {
            dado = _dado;
            proximo = null;
        }

        public int Dado { get => dado; set => dado = value; }
        internal NoPilha Proximo { get => proximo; set => proximo = value; }
    }
}
