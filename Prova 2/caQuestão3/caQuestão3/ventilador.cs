using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão3
{
    internal class ventilador
    {
        private peça p0 = new peça("suporte", 0);
        private peça p1 = new peça("helice", 1);
        private peça p2 = new peça("lampada", 2);
        private peça p3 = new peça("vidro",3);
        internal peça P0 { get => p0; set => p0 = value; }
        internal peça P1 { get => p1; set => p1 = value; }
        internal peça P2 { get => p2; set => p2 = value; }
        internal peça P3 { get => p3; set => p3 = value; }

        public int atribuipeça(string n)
        {
            if (n == "vidro") return 3;
            else if (n == "suporte") return 0;
            else if (n == "helice") return 1;
            else if (n == "lampada") return 2;
            return 999;
        }

        
    }
}
