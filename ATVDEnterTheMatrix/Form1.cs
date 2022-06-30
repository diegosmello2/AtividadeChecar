using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATVDEnterTheMatrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pibImagem.Image = Properties.Resources.F3;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Váriaveis para armazenar os campos::
            string nome;
            string sobrenome;
            int ano;
            int dataAtual;

            // Armazenar os dados:
            nome = txtNome.Text;
            sobrenome = txtSobrenome.Text;
            ano = int.Parse(txtAno.Text);
            dataAtual = int.Parse(DateTime.Now.ToString("yyyy"));

            // Checar:
            if (dataAtual - ano >= 18)
            {
                // Caso a idade seja aprovada:
                lblResultado.Text = "Bem vindo, " +
                nome + " " + sobrenome + " que possui " + (dataAtual - ano) + " anos.";

                lblResultado.ForeColor = Color.Green;
                pibImagem.Image = Properties.Resources.F1;
            }
            else
            {
                // Caso a idade seja negada:
                lblResultado.Text = "Acesso Negado, " +
                nome + " " + sobrenome + " que possui " + (dataAtual - ano) + " anos.";

                lblResultado.ForeColor = Color.Red;
                pibImagem.Image = Properties.Resources.F2;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // Comando para sair:
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Comando para limpar:
            txtNome.Text = null;
            txtSobrenome.Text = null;
            txtAno.Text = null;
            lblResultado.Text = " ";

            pibImagem.Image = Properties.Resources.F3;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
