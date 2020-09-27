using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoTerceiroBimestrePT
{
    class LerValoresNumericos
    {
        static public Int32 LeInt1(String valor)
        {
            try
            {
                return Convert.ToInt32(valor);
            }
            catch (Exception e)
            {
                //MessageBox.Show($"Valores Inválidos!", "Atenção!");
                //Console.WriteLine("Erro:" + e.ToString());
                throw e;
            }
        }
        static public Int32 LeInt2(String valor)
        {
            try
            {
                return Convert.ToInt32(valor);
            }
            catch (Exception e)
            {
                //MessageBox.Show($"Valores Inválidos!", "Atenção!");
                //Console.WriteLine("Erro:" + e.ToString());
                throw e;
            }
        }
    }
}
