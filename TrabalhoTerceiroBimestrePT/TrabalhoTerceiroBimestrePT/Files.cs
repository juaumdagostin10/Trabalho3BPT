using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhoTerceiroBimestrePT
{
    class Files
    {
        static public void salvaArquivo(String arquivo, List<JogadorClube> listaJogador)
        {

            StreamWriter file = new StreamWriter(arquivo, true);
            {
                listaJogador.ForEach(jogador =>
                {
                    file.WriteLine(jogador.ToString());
                });
                file.Close();
            }
        }

        static public List<string> lerArquivoJogadores(String arquivo)
        {
            string line;
            List<string> listaJogadores = new List<string>();
            StreamReader file = new StreamReader(arquivo);
            while ((line = file.ReadLine()) != null)
            {
                listaJogadores.Add(line);
            }
            file.Close();
            return listaJogadores;
        }
    }
}

