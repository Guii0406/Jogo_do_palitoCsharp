using System;
using System.Windows.Forms;

namespace JogoDoPalito
{
    public partial class Form1 : Form
    {
            int quantPalitos = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void ConfiguracoesIniciais(bool a, bool b)
        {
            numUDquantidade.Enabled = a;
            BtnJogar.Enabled = a;
            maskedRetirar.Visible = b;
            BtnRetirar.Visible = b;
            label2.Visible = b;
        }
        private int CalculoDaJogadaDoPC()
        {
            int jogadaPC = 3;
            int resto = quantPalitos;

            while(resto >= (3 + 1))
            {
                resto -= (3 + 1);
            }
            if(resto > 1)
            {
                jogadaPC = resto - 1;
            }
            return jogadaPC;
        }
        private void TextoDaJogadaDoComputador()
        {
            RegistroDeJogadas.AppendText($"\r\nRetiro {CalculoDaJogadaDoPC()} palitos");
            quantPalitos -= CalculoDaJogadaDoPC();
            RegistroDeJogadas.AppendText("\r\nSua vez...");
            RegistroDeJogadas.AppendText($"\r\nRestam {quantPalitos} palitos");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            quantPalitos = (int)numUDquantidade.Value;

            ConfiguracoesIniciais(false, true);
            maskedRetirar.Focus();

            RegistroDeJogadas.AppendText("Eu começo!!");
            TextoDaJogadaDoComputador();
        }
        private void ReiniciarJogo()
        {
            ConfiguracoesIniciais(true, false);
            RegistroDeJogadas.Clear();
            numUDquantidade.Focus();
            maskedRetirar.Clear();
            numUDquantidade.Value = 20;
        }
        private void CheckarDerrotas(string mensagem, string titulo)
        {
                MessageBox.Show(mensagem, titulo);

                if (MessageBox.Show("Quer jogar denovo?", "desafio", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ReiniciarJogo();
                }
                else
                {
                    Close();
                }  
        }
        private bool TestarPossiveisErros(int jogadaPlayer)
        { 
            if (jogadaPlayer < 1 || jogadaPlayer > 3)
            {
                MessageBox.Show("São permitidos tirar 1 a 3 palitos por jogada.");
                maskedRetirar.Clear(); maskedRetirar.Focus();
                return true;
            }
            if (jogadaPlayer > quantPalitos)
            {
                MessageBox.Show("Não é possivel retirar essa quantidade de palitos!", "Palitos insuficientes");
                maskedRetirar.Clear(); maskedRetirar.Focus();
                return true;
            }
            if (quantPalitos <= 1)
            {
                CheckarDerrotas("kkkkk Muito Fácil!!!", "Você perdeu...");
                return true;
            }
            return false;
        }
        private void TextoDaJogadaDoUsuario(int jogadaPlayer)
        {
            RegistroDeJogadas.AppendText($"\r\nVocê retirou {jogadaPlayer} palitos");
            quantPalitos -= jogadaPlayer;
            RegistroDeJogadas.AppendText($"\r\nRestam {quantPalitos} palitos");
        }
        private bool VezDoUsuario()
        {
            if (string.IsNullOrEmpty(maskedRetirar.Text))
            {
                MessageBox.Show("Preenchimento obrigatório da quantidade de palitos a remover", "Atenção");
                maskedRetirar.Focus();
                return true;
            }
            int jogadaPlayer = Convert.ToInt32(maskedRetirar.Text);

            if(TestarPossiveisErros(jogadaPlayer))
            {
                return true;
            }

            TextoDaJogadaDoUsuario(jogadaPlayer);

            return false;
        }
        private void VezDoComputador()
        {
            if (quantPalitos <= 1)
            {
                CheckarDerrotas("Eu perdi!", "Impossivel!!!!");
                return;
            }

            TextoDaJogadaDoComputador();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!VezDoUsuario())
            {
                VezDoComputador();
                maskedRetirar.Clear(); maskedRetirar.Focus();
            }    
        }
        private void RegistroDeJogadas_TextChanged(object sender, EventArgs e)
        {
                RegistroDeJogadas.ScrollToCaret();
        }
    }
}
