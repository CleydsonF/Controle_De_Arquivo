using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aula_WindowsForm_01_Exercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string origem = Path.Combine(@"C:\" + txtPastaOrigem.Text, txtNomeDoArquivo.Text);
                string destino = Path.Combine(@"C:\" + txtPastaDestino.Text, txtNomeDoArquivo.Text);

                File.Move(origem, destino);
                MessageBox.Show("Arquivo Tranferido!");
                txtPastaOrigem.Clear();
                txtPastaDestino.Clear();
                txtPastaOrigem.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCriarPasta_Click(object sender, EventArgs e)
        {
            string pastaCriada = @"C:\" + txtCriarPasta.Text;
            if (Directory.Exists(pastaCriada))
            {
                MessageBox.Show("Pasta já Existe!");
            }
            else
            {
                Directory.CreateDirectory(pastaCriada);
                MessageBox.Show("Pasta Criada!");
                txtCriarPasta.Clear();


            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string deletarPasta = @"C:\" + txtDeletarPasta.Text;
            if (!Directory.Exists(deletarPasta))
            {
                MessageBox.Show("Pasta inexistente!");
            }
            else
            {
                Directory.Delete(deletarPasta);
                MessageBox.Show("Pasta Deletada!");
                txtDeletarPasta.Clear();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
