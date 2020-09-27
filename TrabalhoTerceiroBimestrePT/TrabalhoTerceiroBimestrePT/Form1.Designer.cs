namespace TrabalhoTerceiroBimestrePT
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Alterar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnInserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBNumeroCamisa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBIdade = new System.Windows.Forms.TextBox();
            this.textBPosicao = new System.Windows.Forms.TextBox();
            this.textBNome = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBProcurarID = new System.Windows.Forms.TextBox();
            this.btnProcurarID = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBNumCamisaAlterar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBIdadeAlterar = new System.Windows.Forms.TextBox();
            this.textBPosicaoAlterar = new System.Windows.Forms.TextBox();
            this.textBNomeAlterar = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.textBProcurarName = new System.Windows.Forms.TextBox();
            this.btnProcurarName = new System.Windows.Forms.Button();
            this.Sair = new System.Windows.Forms.TabPage();
            this.btnSair = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Alterar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.Sair.SuspendLayout();
            this.SuspendLayout();
            // 
            // Alterar
            // 
            this.Alterar.Controls.Add(this.tabPage1);
            this.Alterar.Controls.Add(this.tabPage2);
            this.Alterar.Controls.Add(this.tabPage3);
            this.Alterar.Controls.Add(this.Sair);
            this.Alterar.Location = new System.Drawing.Point(0, 1);
            this.Alterar.Name = "Alterar";
            this.Alterar.SelectedIndex = 0;
            this.Alterar.Size = new System.Drawing.Size(801, 448);
            this.Alterar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.btnInserir);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.textBNumeroCamisa);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBIdade);
            this.tabPage1.Controls.Add(this.textBPosicao);
            this.tabPage1.Controls.Add(this.textBNome);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Incluir";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(381, 251);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 8;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Número da camisa";
            // 
            // textBNumeroCamisa
            // 
            this.textBNumeroCamisa.Location = new System.Drawing.Point(369, 225);
            this.textBNumeroCamisa.Name = "textBNumeroCamisa";
            this.textBNumeroCamisa.Size = new System.Drawing.Size(100, 20);
            this.textBNumeroCamisa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Idade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Posição";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome";
            // 
            // textBIdade
            // 
            this.textBIdade.Location = new System.Drawing.Point(369, 182);
            this.textBIdade.Name = "textBIdade";
            this.textBIdade.Size = new System.Drawing.Size(100, 20);
            this.textBIdade.TabIndex = 2;
            // 
            // textBPosicao
            // 
            this.textBPosicao.Location = new System.Drawing.Point(369, 140);
            this.textBPosicao.Name = "textBPosicao";
            this.textBPosicao.Size = new System.Drawing.Size(100, 20);
            this.textBPosicao.TabIndex = 1;
            // 
            // textBNome
            // 
            this.textBNome.Location = new System.Drawing.Point(369, 97);
            this.textBNome.Name = "textBNome";
            this.textBNome.Size = new System.Drawing.Size(100, 20);
            this.textBNome.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.richTextBox1);
            this.tabPage2.Controls.Add(this.textBProcurarID);
            this.tabPage2.Controls.Add(this.btnProcurarID);
            this.tabPage2.Controls.Add(this.btnAlterar);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textBNumCamisaAlterar);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.textBIdadeAlterar);
            this.tabPage2.Controls.Add(this.textBPosicaoAlterar);
            this.tabPage2.Controls.Add(this.textBNomeAlterar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alterar e Excluir";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(504, 371);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 21;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(382, 123);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(312, 242);
            this.richTextBox1.TabIndex = 20;
            this.richTextBox1.Text = "";
            // 
            // textBProcurarID
            // 
            this.textBProcurarID.Location = new System.Drawing.Point(471, 68);
            this.textBProcurarID.Name = "textBProcurarID";
            this.textBProcurarID.Size = new System.Drawing.Size(137, 20);
            this.textBProcurarID.TabIndex = 19;
            // 
            // btnProcurarID
            // 
            this.btnProcurarID.Location = new System.Drawing.Point(471, 94);
            this.btnProcurarID.Name = "btnProcurarID";
            this.btnProcurarID.Size = new System.Drawing.Size(137, 23);
            this.btnProcurarID.TabIndex = 18;
            this.btnProcurarID.Text = "Procurar(ID)";
            this.btnProcurarID.UseVisualStyleBackColor = true;
            this.btnProcurarID.Click += new System.EventHandler(this.btnProcurarID_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(212, 301);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 17;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Número da camisa";
            // 
            // textBNumCamisaAlterar
            // 
            this.textBNumCamisaAlterar.Location = new System.Drawing.Point(200, 275);
            this.textBNumCamisaAlterar.Name = "textBNumCamisaAlterar";
            this.textBNumCamisaAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBNumCamisaAlterar.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(160, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Idade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Posição";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nome";
            // 
            // textBIdadeAlterar
            // 
            this.textBIdadeAlterar.Location = new System.Drawing.Point(200, 232);
            this.textBIdadeAlterar.Name = "textBIdadeAlterar";
            this.textBIdadeAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBIdadeAlterar.TabIndex = 11;
            // 
            // textBPosicaoAlterar
            // 
            this.textBPosicaoAlterar.Location = new System.Drawing.Point(200, 190);
            this.textBPosicaoAlterar.Name = "textBPosicaoAlterar";
            this.textBPosicaoAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBPosicaoAlterar.TabIndex = 10;
            // 
            // textBNomeAlterar
            // 
            this.textBNomeAlterar.Location = new System.Drawing.Point(200, 147);
            this.textBNomeAlterar.Name = "textBNomeAlterar";
            this.textBNomeAlterar.Size = new System.Drawing.Size(100, 20);
            this.textBNomeAlterar.TabIndex = 9;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.richTextBox2);
            this.tabPage3.Controls.Add(this.textBProcurarName);
            this.tabPage3.Controls.Add(this.btnProcurarName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(793, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pesquisar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(240, 118);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(312, 242);
            this.richTextBox2.TabIndex = 23;
            this.richTextBox2.Text = "";
            // 
            // textBProcurarName
            // 
            this.textBProcurarName.Location = new System.Drawing.Point(329, 63);
            this.textBProcurarName.Name = "textBProcurarName";
            this.textBProcurarName.Size = new System.Drawing.Size(137, 20);
            this.textBProcurarName.TabIndex = 22;
            // 
            // btnProcurarName
            // 
            this.btnProcurarName.Location = new System.Drawing.Point(329, 89);
            this.btnProcurarName.Name = "btnProcurarName";
            this.btnProcurarName.Size = new System.Drawing.Size(137, 23);
            this.btnProcurarName.TabIndex = 21;
            this.btnProcurarName.Text = "Procurar";
            this.btnProcurarName.UseVisualStyleBackColor = true;
            this.btnProcurarName.Click += new System.EventHandler(this.btnProcurarName_Click);
            // 
            // Sair
            // 
            this.Sair.Controls.Add(this.btnSair);
            this.Sair.Location = new System.Drawing.Point(4, 22);
            this.Sair.Name = "Sair";
            this.Sair.Padding = new System.Windows.Forms.Padding(3);
            this.Sair.Size = new System.Drawing.Size(793, 422);
            this.Sair.TabIndex = 3;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(323, 152);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(128, 49);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(328, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "CADASTRO DE JOGADORES";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(429, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(231, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "PROCURAR ID PARA ALTERAR TORCEDOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(149, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "ADICIONAR NOVAS INFORMAÇÕES";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(291, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "PESQUISE O NOME DE ALGUM JOGADOR ADICIONADO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Alterar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Alterar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.Sair.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Alterar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBNumeroCamisa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBIdade;
        private System.Windows.Forms.TextBox textBPosicao;
        private System.Windows.Forms.TextBox textBNome;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBProcurarID;
        private System.Windows.Forms.Button btnProcurarID;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBNumCamisaAlterar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBIdadeAlterar;
        private System.Windows.Forms.TextBox textBPosicaoAlterar;
        private System.Windows.Forms.TextBox textBNomeAlterar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBProcurarName;
        private System.Windows.Forms.Button btnProcurarName;
        private System.Windows.Forms.TabPage Sair;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
    }
}

