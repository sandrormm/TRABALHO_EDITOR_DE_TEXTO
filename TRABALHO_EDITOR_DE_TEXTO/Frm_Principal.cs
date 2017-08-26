using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRABALHO_EDITOR_DE_TEXTO
{
    public partial class Frm_Principal : Form
    {
        //public string filefilter = "Rich Texto format|*.rtf* |*.txt* |*.doc* |*.docx*";

        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //diretorio a ser manipulado
            string folder = @"C:\CSA_SISTEMAS";
            {
                //se o diretorio não existir
                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }
            }
     
            //método construtor da classe savedialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"c:\CSA_SISTEMAS";
            sfd.Title = " Salvando Arquivos";
            sfd.Filter = "Arquivo de Texto(*.txt)|*.txt | Rich Text Format(*.Rtf)|*.Rtf | Documento de Texto(*.doc)|*.Doc | (*.Docx)|*.docx";  //filtar o tipo de extensão
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName) == false) // se arquivo existir faça o que se pede abaixo
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))

                    {
                        writer.Write(txtconteudo.Text);
                        writer.Flush();

                    }

                }
                catch (Exception ex) //classe generica para exceções de erros
                {
                    Message.Alertar("Não foi Possível Salvar o seu Arquivo" + ex.Message);
                    Message.Erro("Contate seu Suporte Tecnico!" + ex.Message);
                }
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\CSA_SISTEMAS";
            //ofd.CheckFileExists = true;
            ofd.Filter = "Arquivo de Texto(*.txt)|*.txt | Rich Text Format(*.Rtf)|*.rtf | Documento de Texto(*.doc)|*.doc; *.docx";
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {
                try
                {
                    using (StreamReader str = new StreamReader(ofd.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage)))
                    {
                        txtconteudo.Text = str.ReadToEnd();
                    }
                }
                catch (Exception ex)
                {
                    Message.Alertar("Não foi Possível Abrir o seu Arquivo" + ex.Message);
                    Message.Erro("Contate seu Suporte Tecnico!" + ex.Message);

                }
            }
        }

        private void openToolStripButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\CSA_SISTEMAS";
            ofd.CheckFileExists = true;
            ofd.Filter = "Arquivo de Texto(*.txt)|*.txt"; //| Rich Text Format(*.Rtf)|*.Rtf | Documento de Texto(*.doc)|*.Doc | (*.Docx)|*.docx";
            ofd.ShowDialog();

            if (string.IsNullOrEmpty(ofd.FileName) == false)
            {
                try
                {
                    using (StreamReader str = new StreamReader(ofd.FileName, Encoding.GetEncoding(CultureInfo.GetCultureInfo("pt-BR").TextInfo.ANSICodePage)))
                    {
                        txtconteudo.Text = str.ReadToEnd();
                    }
                }
                catch (Exception)
                {
                    Message.Alertar("Não foi Possível Abrir o seu Arquivo");
                    Message.Erro("Contate seu Suporte Tecnico!");

                }
            }
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //método construtor da classe savedialog
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = @"c:\CSA_SISTEMAS";
            sfd.Filter = "Arquivo de Texto(*.txt)|*.txt | Rich Text Format(*.Rtf)|*.Rtf | Documento de Texto(*.doc)|*.Doc | (*.Docx)|*.docx";  //filtar o tipo de extensão
            sfd.ShowDialog();

            if (string.IsNullOrEmpty(sfd.FileName) == false)
            {

                try
                {
                    using (StreamWriter writer = new StreamWriter(sfd.FileName, false, Encoding.UTF8))
                    {
                        writer.Write(txtconteudo.Text);
                        writer.Flush();

                    }
                }
                catch (Exception)
                {
                    Message.Alertar("Não foi Possível Salvar o seu Arquivo");
                    Message.Erro("Contate seu Suporte Tecnico!");

                }
            }
        }
    }
}
