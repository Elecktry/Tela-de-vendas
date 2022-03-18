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
    public partial class Form4 : Form
    {
        SqlConnection conectar = new SqlConnection(@"Data Source = DESKTOP-D6H06NL; Initial Catalog = PROJETO_TESTE; Integrated Security = True");
        SqlDataAdapter dados;
        SqlCommandBuilder cmd;
        DataTable datb;

        Clientes cli = new Clientes();

        Cadastro_client inicio = new Cadastro_client();
        public Form4()
        {
            InitializeComponent();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            SqlConnection conectar = new SqlConnection(@"Data Source = DESKTOP-D6H06NL; Initial Catalog = PROJETO_TESTE; Integrated Security = True");
            dados = new SqlDataAdapter("select pk_id_cliente AS COD_CLIENTE, nome_cliente AS NOME_CLIENTE, endreco_cliente AS ENDEREÇO_CLIENTE, cep_cliente AS CEP_CLIENTE, numero_cliente AS TELEFONE_CLIENTE, bairro_cliente AS BAIRRO_CLIENTE, estado_cliente AS ESTADO_CLIENTE, cidade_cliente AS CIDADE_CLIENTE, observacao_cliente AS OBSERVAÇÃO_CLIENTE  from CLIENTE", conectar);
            datb = new DataTable();//preenche data table
            dados.Fill(datb);// transfere os pensamnetos da base para o BD

            dtgv.DataSource = datb;

            dtgv.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            cli.cod_cliente = Convert.ToInt32(dtgv[0, dtgv.CurrentRow.Index].Value.ToString());
            cli.nome = dtgv[1, dtgv.CurrentRow.Index].Value.ToString();
            cli.endereco = dtgv[2, dtgv.CurrentRow.Index].Value.ToString();
            cli.cep = dtgv[3, dtgv.CurrentRow.Index].Value.ToString();
            cli.telefone = dtgv[4, dtgv.CurrentRow.Index].Value.ToString();
            cli.bairro = dtgv[5, dtgv.CurrentRow.Index].Value.ToString();
            cli.estado = dtgv[6, dtgv.CurrentRow.Index].Value.ToString();
            cli.cidade = dtgv[7, dtgv.CurrentRow.Index].Value.ToString();
            cli.obs = dtgv[8, dtgv.CurrentRow.Index].Value.ToString();



            Cadastro_client editar_dados = new Cadastro_client(cli);
            editar_dados.ShowDialog();
        }

        public void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dtgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nada selecionado para exclusão");
                return;
            }



            else
            {
                DialogResult resp = MessageBox.Show("Tem certeza que deseja excluir o usuário?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resp == DialogResult.Yes)
                {
                    DataGridViewRow row = dtgv.SelectedRows[0];
                    dtgv.Rows.RemoveAt(row.Index);
                    cmd = new SqlCommandBuilder(dados);
                    dados.Update(datb);
                }
            }
        }

        private void btn_atualiza_pagina_Click(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_cad_Click(object sender, EventArgs e)
        {

        }
    }
}
