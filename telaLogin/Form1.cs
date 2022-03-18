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
    public partial class Form1 : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source = DESKTOP-D6H06NL; Initial Catalog = PROJETO_TESTE; Integrated Security = True");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conectar.Open();



                SqlCommand verificar = new SqlCommand("SELECT * FROM _LOGIN  WHERE nome_usuario = '" + txt_Usuario.Text + "' AND senha_usuario = '" + txt_Senha.Text + "'", conectar);



                //verificar.CommandText = "SELECT * FROM usuario WHERE Usuario = '" +txtUsuario.Text+"' AND Senha = '"+txtSenha.Text+"'";



                bool resultado = verificar.ExecuteReader().HasRows;



                if (resultado == true)
                {
                    Form2 f2 = new Form2();
                    this.Hide();
                    f2.ShowDialog();
                    this.Close(); //esconde a tela anterior*/



                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");
                    conectar.Close();
                }
            }
            catch
            {
                MessageBox.Show("Não foi possivel estabelecer a conexão, verifique o código!");
            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            this.Hide();
            f2.ShowDialog();
            this.Close(); //esconde a tela anterior*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja realmente sair?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resposta == DialogResult.OK)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
