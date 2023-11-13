using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão3
{
    internal class peça
    {
        //atributos
        private string nome;
        private int identificador;

        //metodos:
        public peça (string nome, int identificador) 
        {
            this.nome = nome;
            this.identificador = identificador;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Identificador { get => identificador; set => identificador = value; }
    }
}
