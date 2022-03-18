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

    public partial class Apagar_conta : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source = DESKTOP-D6H06NL; Initial Catalog = PROJETO_TESTE; Integrated Security = True");



        public Apagar_conta()
        {
           
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txt_Senha_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_Usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            conectar.Open();
            SqlCommand criar = new SqlCommand("DELETE FROM _LOGIN WHERE nome_usuario = '" + txt_usuario.Text+"' AND senha_usuario = " + txt_Senha.Text + "", conectar);
            criar.ExecuteNonQuery();
            
            SqlCommand verificar = new SqlCommand("SELECT * FROM _LOGIN  WHERE nome_usuario = '" + txt_usuario.Text + "' AND senha_usuario = '" + txt_Senha.Text + "'", conectar);


            bool resultado = verificar.ExecuteReader().HasRows;
            if (resultado == true)
            {

                 MessageBox.Show("Usuário ou senha inválidos!");

            }
            else
            {

               
                MessageBox.Show("Sua conta foi criada com sucesso!");
                Form1 f2 = new Form1();
                this.Hide();
                f2.ShowDialog();
                this.Close();
            }
            conectar.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close(); //esconde a tela anterior*/

        }

        private void txt_usuario_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    
}
