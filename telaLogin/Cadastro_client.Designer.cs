
namespace telaLogin
{
    partial class Cadastro_client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro_client));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nome_cadastro = new System.Windows.Forms.TextBox();
            this.txt_endereco_cadastro = new System.Windows.Forms.TextBox();
            this.txt_bairro_cadastro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mk_txt_cep_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.mk_txt_tel_cadastro = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.cb_txt_estado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_obs_cadastro = new System.Windows.Forms.TextBox();
            this.btn_adcionar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_alterar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(38, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Endereço";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(51, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_nome_cadastro
            // 
            this.txt_nome_cadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_nome_cadastro.Location = new System.Drawing.Point(117, 25);
            this.txt_nome_cadastro.Name = "txt_nome_cadastro";
            this.txt_nome_cadastro.Size = new System.Drawing.Size(436, 25);
            this.txt_nome_cadastro.TabIndex = 2;
            this.txt_nome_cadastro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_endereco_cadastro
            // 
            this.txt_endereco_cadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_endereco_cadastro.Location = new System.Drawing.Point(117, 61);
            this.txt_endereco_cadastro.Name = "txt_endereco_cadastro";
            this.txt_endereco_cadastro.Size = new System.Drawing.Size(436, 25);
            this.txt_endereco_cadastro.TabIndex = 3;
            // 
            // txt_bairro_cadastro
            // 
            this.txt_bairro_cadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_bairro_cadastro.Location = new System.Drawing.Point(117, 98);
            this.txt_bairro_cadastro.Name = "txt_bairro_cadastro";
            this.txt_bairro_cadastro.Size = new System.Drawing.Size(235, 25);
            this.txt_bairro_cadastro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(52, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bairro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(358, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "CEP";
            // 
            // mk_txt_cep_cadastro
            // 
            this.mk_txt_cep_cadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mk_txt_cep_cadastro.Location = new System.Drawing.Point(392, 98);
            this.mk_txt_cep_cadastro.Mask = "00000-000";
            this.mk_txt_cep_cadastro.Name = "mk_txt_cep_cadastro";
            this.mk_txt_cep_cadastro.Size = new System.Drawing.Size(161, 25);
            this.mk_txt_cep_cadastro.TabIndex = 7;
            this.mk_txt_cep_cadastro.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // mk_txt_tel_cadastro
            // 
            this.mk_txt_tel_cadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.mk_txt_tel_cadastro.Location = new System.Drawing.Point(117, 140);
            this.mk_txt_tel_cadastro.Mask = "(00)00000-0000";
            this.mk_txt_tel_cadastro.Name = "mk_txt_tel_cadastro";
            this.mk_txt_tel_cadastro.Size = new System.Drawing.Size(115, 25);
            this.mk_txt_tel_cadastro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(44, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Telefone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(236, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cidade";
            // 
            // txt_cidade
            // 
            this.txt_cidade.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_cidade.Location = new System.Drawing.Point(282, 140);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(119, 25);
            this.txt_cidade.TabIndex = 11;
            // 
            // cb_txt_estado
            // 
            this.cb_txt_estado.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.cb_txt_estado.FormattingEnabled = true;
            this.cb_txt_estado.Items.AddRange(new object[] {
            "(AC)",
            "(AL)",
            "(AP)",
            "(AM)",
            "(BA)",
            "(CE)",
            "(DF)",
            "(ES)",
            "(GO)",
            "(MA)",
            "(MT)",
            "(MS)",
            "(MG)",
            "(PA)",
            "(PB)",
            "(PR)",
            "(PE)",
            "(PI)",
            "(RJ)",
            "(RN)",
            "(RS)",
            "(RO)",
            "(RR)",
            "(SC)",
            "(SP)",
            "(SE)",
            "(TO)"});
            this.cb_txt_estado.Location = new System.Drawing.Point(458, 140);
            this.cb_txt_estado.Name = "cb_txt_estado";
            this.cb_txt_estado.Size = new System.Drawing.Size(95, 25);
            this.cb_txt_estado.TabIndex = 12;
            this.cb_txt_estado.SelectedIndexChanged += new System.EventHandler(this.cb_txt_estado_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(403, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Estados";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(16, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Observações";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txt_obs_cadastro
            // 
            this.txt_obs_cadastro.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.txt_obs_cadastro.Location = new System.Drawing.Point(117, 174);
            this.txt_obs_cadastro.Multiline = true;
            this.txt_obs_cadastro.Name = "txt_obs_cadastro";
            this.txt_obs_cadastro.Size = new System.Drawing.Size(436, 93);
            this.txt_obs_cadastro.TabIndex = 15;
            this.txt_obs_cadastro.TextChanged += new System.EventHandler(this.txt_obs_cadastro_TextChanged);
            // 
            // btn_adcionar
            // 
            this.btn_adcionar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_adcionar.FlatAppearance.BorderSize = 0;
            this.btn_adcionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_adcionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btn_adcionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adcionar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_adcionar.ForeColor = System.Drawing.Color.Silver;
            this.btn_adcionar.Image = ((System.Drawing.Image)(resources.GetObject("btn_adcionar.Image")));
            this.btn_adcionar.Location = new System.Drawing.Point(41, 283);
            this.btn_adcionar.Name = "btn_adcionar";
            this.btn_adcionar.Size = new System.Drawing.Size(72, 53);
            this.btn_adcionar.TabIndex = 16;
            this.btn_adcionar.UseVisualStyleBackColor = true;
            this.btn_adcionar.Click += new System.EventHandler(this.btn_adcionar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaShell;
            this.btn_excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_excluir.ForeColor = System.Drawing.Color.Silver;
            this.btn_excluir.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir.Image")));
            this.btn_excluir.Location = new System.Drawing.Point(131, 283);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(72, 53);
            this.btn_excluir.TabIndex = 18;
            this.btn_excluir.UseVisualStyleBackColor = true;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaShell;
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.Silver;
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(392, 282);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(72, 53);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Azure;
            this.btn_pesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_pesquisar.ForeColor = System.Drawing.Color.Silver;
            this.btn_pesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar.Image")));
            this.btn_pesquisar.Location = new System.Drawing.Point(481, 281);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(72, 53);
            this.btn_pesquisar.TabIndex = 20;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_alterar
            // 
            this.btn_alterar.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_alterar.FlatAppearance.BorderSize = 0;
            this.btn_alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Honeydew;
            this.btn_alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn_alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_alterar.ForeColor = System.Drawing.Color.Silver;
            this.btn_alterar.Image = global::telaLogin.Properties.Resources.alterar1;
            this.btn_alterar.Location = new System.Drawing.Point(221, 278);
            this.btn_alterar.Name = "btn_alterar";
            this.btn_alterar.Size = new System.Drawing.Size(74, 63);
            this.btn_alterar.TabIndex = 17;
            this.btn_alterar.UseVisualStyleBackColor = true;
            this.btn_alterar.Click += new System.EventHandler(this.btn_alterar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.7F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(236, 342);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Alterar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.7F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(48, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Adicionar";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.7F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(145, 338);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Excluir";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.7F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(393, 338);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = " Cancelar  ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.7F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(478, 338);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Pesquisar";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Cadastro_client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 368);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_alterar);
            this.Controls.Add(this.btn_adcionar);
            this.Controls.Add(this.txt_obs_cadastro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_txt_estado);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mk_txt_tel_cadastro);
            this.Controls.Add(this.mk_txt_cep_cadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_bairro_cadastro);
            this.Controls.Add(this.txt_endereco_cadastro);
            this.Controls.Add(this.txt_nome_cadastro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cadastro_client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life boot Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nome_cadastro;
        private System.Windows.Forms.TextBox txt_endereco_cadastro;
        private System.Windows.Forms.TextBox txt_bairro_cadastro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mk_txt_cep_cadastro;
        private System.Windows.Forms.MaskedTextBox mk_txt_tel_cadastro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.ComboBox cb_txt_estado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_obs_cadastro;
        private System.Windows.Forms.Button btn_adcionar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_alterar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}