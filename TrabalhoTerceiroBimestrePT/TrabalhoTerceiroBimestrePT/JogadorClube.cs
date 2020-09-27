using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoTerceiroBimestrePT
{
    class JogadorClube
    {
        public String Nome { get; set; }
        public String Posicao { get; set; }
        public int Idade { get; set; }
        public int NumeroCamisa { get; set; }

        public override string ToString()
        {
            return "Nome:" + Nome + ", " +
                   "Posição:" + Posicao + ", " +
                   "Idade:" + Idade + ", " +
                   "Número:" + NumeroCamisa;
        }
    }
}
