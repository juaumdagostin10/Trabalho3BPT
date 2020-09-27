using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoTerceiroBimestrePT
{
    public partial class Form1 : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {

        }

        List<JogadorClube> listaJogador = new List<JogadorClube>();
        List<JogadorClube> listaJogadorFiltrada = new List<JogadorClube>();
        private String arquivo = @"C:\Users\vibag\source\repos\save1\pessoa.txt ";

        public Form1()
        {
            InitializeComponent();
        }

        private JogadorClube getJogador()
        {
            JogadorClube umJogador = new JogadorClube();
            umJogador.Nome = textBNome.Text;
            umJogador.Posicao = textBPosicao.Text;
            try
            {
                umJogador.Idade = LerValoresNumericos.LeInt1(textBIdade.Text);
                umJogador.NumeroCamisa = LerValoresNumericos.LeInt2(textBNumeroCamisa.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
                //Console.WriteLine("Erro:" + e.ToString());
            }
            return umJogador;
        }

        private JogadorClube getJogadorAlterar()
        {
            JogadorClube umJogador2 = new JogadorClube();
            umJogador2.Nome = textBNomeAlterar.Text;
            umJogador2.Posicao = textBPosicaoAlterar.Text;
            try
            {
                umJogador2.Idade = LerValoresNumericos.LeInt1(textBIdadeAlterar.Text);
                umJogador2.NumeroCamisa = LerValoresNumericos.LeInt2(textBNumCamisaAlterar.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
                //Console.WriteLine("Erro:" + e.ToString());
            }
            return umJogador2;
        }

        private void LimparCampos1()
        {
            textBIdade.Clear();
            textBNumeroCamisa.Clear();
            textBNome.Clear();
            textBPosicao.Clear();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                JogadorClube umJogador = getJogador();
                listaJogador.Add(umJogador);
                LimparCampos1();
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void btnProcurarID_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();
                richTextBox1.AppendText($"{listaJogador[Convert.ToInt16(textBProcurarID.Text)]}\n");
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Clear();

                listaJogador.Remove(listaJogador[Convert.ToInt16(textBProcurarID.Text)]);

                JogadorClube umJogador2 = getJogadorAlterar();
                listaJogador.Insert(Convert.ToInt32(textBProcurarID.Text), umJogador2);
                LimparCampos1();

                richTextBox1.AppendText(Convert.ToString(umJogador2));
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                listaJogador.Remove(listaJogador[Convert.ToInt16(textBProcurarID.Text)]);
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void btnProcurarName_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Clear();

                if (textBProcurarName.Text == null)
                {
                    MessageBox.Show("Preencha o campo por favor !!!");
                }
                else
                {
                    listaJogadorFiltrada = listaJogador.Where(umJogador => umJogador.Nome.Equals(textBProcurarName.Text)).ToList();
                    foreach (var player in listaJogadorFiltrada)
                    {
                        richTextBox2.AppendText(Convert.ToString(player));
                    }
                }
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("O sistema irá encerrar, até a próxima", "Tchau Brigado");
                Application.Exit();
            }
            catch
            {
                MessageBox.Show($"Valores Inválidos!", "Atenção!");
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
