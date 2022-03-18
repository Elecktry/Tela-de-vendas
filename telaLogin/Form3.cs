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
    public partial class Form3 : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source = DESKTOP-D6H06NL; Initial Catalog = PROJETO_TESTE; Integrated Security = True");
        public Form3()
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

        private void button1_Click(object sender, EventArgs e)
        {


            conectar.Open();
            SqlCommand criar = new SqlCommand("INSERT INTO _LOGIN (nome_usuario, senha_usuario) VALUES('" + txt_criar_usuario.Text+ "'," +txt_criar_senha.Text+");", conectar);
            criar.ExecuteNonQuery();

            SqlCommand verificar = new SqlCommand("SELECT * FROM _LOGIN  WHERE nome_usuario = '" + txt_criar_usuario.Text + "' AND senha_usuario = '" + txt_criar_senha.Text + "'", conectar);

            bool resultado = verificar.ExecuteReader().HasRows;
            if (resultado == true)
            {
               
                MessageBox.Show("Sua conta foi criada com sucesso!");
                Form1 f2 = new Form1();
                this.Hide();
                f2.ShowDialog();
                this.Close();


                }
            else
                {
                    MessageBox.Show("Usuário ou senha inválidos!");

                    

                }
          conectar.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void txt_criar_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_icon_Click(object sender, EventArgs e)
        {

        }
    }
}
