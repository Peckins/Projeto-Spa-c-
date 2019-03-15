using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Spa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Estrutura de armazenamento de dados do cliente
        public struct Cliente
        {
            public string nome;
            public double peso;
            public double altura;
        }

        //variáveis de checagem de entrada
        double numero;

        //Definindo altura
        private void textBox1_TextChanged(object sender, EventArgs e)//Textbox de Definição de altura
        {
            double altura;
            Cliente select;

            if (double.TryParse(txtAltura.Text, out numero))//Verifica se o usuário digitou numero
            {
                MessageBox.Show("Digite um número válido!");
            }
            else
            {
                altura = double.Parse(txtAltura.Text);
                select.altura = altura;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Definindo o peso
        private void txtPeso_TextChanged(object sender, EventArgs e)//Textbox de Peso
        {
            double peso;
            Cliente select;

            if (double.TryParse(txtPeso.Text, out numero))//Verifica se o usuário digitou número
            {
                MessageBox.Show("Digite um número válido");
            }
            else
            {
                peso = double.Parse(txtPeso.Text);
                select.peso = peso;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            string nome;
            Cliente select;

            if (double.TryParse(txtNome.Text, out numero))
        }
    }
}
