using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace telaLogin
{
    public partial class Form2 : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source = DESKTOP-D6H06NL; Initial Catalog = PROJETO_TESTE; Integrated Security = True");
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_voltar_tela_inicial_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente voltar para tela inicial?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                Form1 f2 = new Form1();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            else
            {

            }
        }

        private void btn_CriarConta_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            this.Hide();
            f2.ShowDialog();
            this.Close(); //esconde a tela anterior*/
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cadastro_client f2 = new Cadastro_client();
            this.Hide();
            f2.ShowDialog();
            this.Close(); //esconde a tela anterior*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Apagar_conta f2 = new Apagar_conta();
            this.Hide();
            f2.ShowDialog();
            this.Close(); //esconde a tela anterior*/
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
