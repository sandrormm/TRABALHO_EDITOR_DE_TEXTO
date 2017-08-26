using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_EDITOR_DE_TEXTO
    {
    public class Message
        // essa é a classe onde vai tratar os erros, ele é criada com intuito de reduzir códigos
        // A ideia é reaproveitar a criação do messsageBox
        {
        public static void MensagemSucesso(string mensagem)
            {
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        public static void MensagemErro(string mensagem)
            {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        public static void ErroLogin(string mensagem)
            {
            MessageBox.Show(mensagem, "Alerta Erro Login",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        public static void Informar(string mensagem)
            {
            MessageBox.Show(mensagem, "Informação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        public static void Alertar(string mensagem)
            {
            MessageBox.Show(mensagem, "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        public static void Erro(string mensagem)
            {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }









