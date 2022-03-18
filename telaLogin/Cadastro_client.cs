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
    public partial class Cadastro_client : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source = DESKTOP-D6H06NL; Initial Catalog = PROJETO_TESTE; Integrated Security = True");

        int cod_cliente;
        String NOME, ENDERECO, BAIRRO, CEP, TELEFONE, CIDADE, ESTADO, OBS;


        public Cadastro_client(Clientes cli)
        {


            InitializeComponent();
            this.Text = "Alterar - Cliente";
            cod_cliente = cli.cod_cliente;
            txt_nome_cadastro.Text = cli.nome;
            txt_endereco_cadastro.Text = cli.endereco;
            mk_txt_cep_cadastro.Text = cli.cep;
            mk_txt_tel_cadastro.Text = cli.telefone;
            txt_bairro_cadastro.Text = cli.bairro;
            cb_txt_estado.Text = cli.estado;
            txt_cidade.Text = cli.cidade;
            txt_obs_cadastro.Text = cli.obs;
        }

        public Cadastro_client()
        {
            InitializeComponent();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_client_Load(object sender, EventArgs e)
        {

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {

        }

        private void txt_obs_cadastro_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            conectar.Open();

            SqlCommand alterar = new SqlCommand("UPDATE CLIENTE SET nome_cliente ='" + txt_nome_cadastro.Text + "', endreco_cliente = '" + txt_endereco_cadastro.Text + "' , cep_cliente ='" + mk_txt_cep_cadastro.Text+ "', numero_cliente='" + mk_txt_tel_cadastro.Text + "', bairro_cliente='" + txt_bairro_cadastro.Text + "', estado_cliente ='" + cb_txt_estado.Text + "', cidade_cliente ='" + txt_cidade.Text + "', observacao_cliente='" + txt_obs_cadastro.Text + "' WHERE pk_id_cliente= '" + cod_cliente + "'" , conectar);
            alterar.ExecuteNonQuery();

            SqlCommand verificar = new SqlCommand("SELECT * FROM CLIENTE  WHERE  nome_cliente ='" + NOME + "' AND endreco_cliente='" + ENDERECO + "' AND bairro_cliente ='" + BAIRRO + "' AND cep_cliente = '" + CEP + "' AND numero_cliente='" + TELEFONE + "' AND cidade_cliente ='" + CIDADE + "' AND estado_cliente='" + ESTADO + "' AND observacao_cliente='" + OBS + "'", conectar);

            bool resultado = verificar.ExecuteReader().HasRows;
            if (resultado == false)
            {

                MessageBox.Show("Sua conta foi alterada com sucesso!");
                Form4 f2 = new Form4();
                this.Hide();
                f2.ShowDialog();
                this.Close();


            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");



            }

        }
        private void cb_txt_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
            this.Close(); //esconde a tela anterior*/
        }

        private void btn_adcionar_Click(object sender, EventArgs e)
        {



            String NOME, ENDERECO, BAIRRO, CEP, TELEFONE, CIDADE, ESTADO, OBS;

            NOME = txt_nome_cadastro.Text;
            ENDERECO = txt_endereco_cadastro.Text;
            BAIRRO = txt_bairro_cadastro.Text;
            CEP = mk_txt_cep_cadastro.Text;
            TELEFONE = mk_txt_tel_cadastro.Text;
            CIDADE = txt_cidade.Text;
            ESTADO = cb_txt_estado.Text;
            OBS = txt_obs_cadastro.Text;

            //abrindo a conexão
            conectar.Open();
            

               
                SqlCommand criar = new SqlCommand("INSERT INTO CLIENTE (nome_cliente, endreco_cliente, bairro_cliente, cep_cliente, numero_cliente, cidade_cliente, estado_cliente, observacao_cliente) VALUES('" + NOME + "', '" + ENDERECO + "','" + BAIRRO + "' ,'" + CEP + "' , '" + TELEFONE + "', '" + CIDADE + "', '" + ESTADO + "', '" + OBS + "');",conectar);
                criar.ExecuteNonQuery();

            SqlCommand verificar = new SqlCommand("SELECT * FROM CLIENTE  WHERE  nome_cliente ='"+NOME+"' AND endreco_cliente='"+ENDERECO+"' AND bairro_cliente ='"+BAIRRO+"' AND cep_cliente = '"+CEP+"' AND numero_cliente='"+TELEFONE+"' AND cidade_cliente ='"+CIDADE+"' AND estado_cliente='"+ESTADO+"' AND observacao_cliente='"+OBS+"'", conectar);

            bool resultado = verificar.ExecuteReader().HasRows;
            if (resultado == true)
            {

                MessageBox.Show("Sua conta foi criada com sucesso!");
                Form2 f2 = new Form2();
                this.Hide();
                f2.ShowDialog();
                this.Close();


            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos!");



            }
            conectar.Close();
            //}
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            Form4 f2 = new Form4();
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }
    }
}
