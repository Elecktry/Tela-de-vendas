
namespace telaLogin
{
    partial class Form4
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_excluir_cadastro = new System.Windows.Forms.Button();
            this.btn_alterar_cadastro = new System.Windows.Forms.Button();
            this.btn_adicionar_cadastro = new System.Windows.Forms.Button();
            this.btn_pesquisar_cad = new System.Windows.Forms.Button();
            this.btn_atualiza_pagina = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv
            // 
            this.dtgv.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.dtgv.AllowUserToAddRows = false;
            this.dtgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(1);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dtgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.ColumnHeadersHeight = 50;
            this.dtgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dtgv.Location = new System.Drawing.Point(150, 121);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dtgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightCyan;
            this.dtgv.Size = new System.Drawing.Size(457, 193);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(150, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btn_excluir_cadastro
            // 
            this.btn_excluir_cadastro.BackColor = System.Drawing.Color.Black;
            this.btn_excluir_cadastro.FlatAppearance.BorderSize = 0;
            this.btn_excluir_cadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_excluir_cadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_excluir_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir_cadastro.Image = ((System.Drawing.Image)(resources.GetObject("btn_excluir_cadastro.Image")));
            this.btn_excluir_cadastro.Location = new System.Drawing.Point(-3, 208);
            this.btn_excluir_cadastro.Name = "btn_excluir_cadastro";
            this.btn_excluir_cadastro.Size = new System.Drawing.Size(131, 121);
            this.btn_excluir_cadastro.TabIndex = 4;
            this.btn_excluir_cadastro.UseVisualStyleBackColor = false;
            this.btn_excluir_cadastro.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_alterar_cadastro
            // 
            this.btn_alterar_cadastro.BackColor = System.Drawing.Color.Black;
            this.btn_alterar_cadastro.FlatAppearance.BorderSize = 0;
            this.btn_alterar_cadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_alterar_cadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_alterar_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_alterar_cadastro.Image = global::telaLogin.Properties.Resources.alterar1;
            this.btn_alterar_cadastro.Location = new System.Drawing.Point(-3, 105);
            this.btn_alterar_cadastro.Name = "btn_alterar_cadastro";
            this.btn_alterar_cadastro.Size = new System.Drawing.Size(131, 110);
            this.btn_alterar_cadastro.TabIndex = 2;
            this.btn_alterar_cadastro.UseVisualStyleBackColor = false;
            this.btn_alterar_cadastro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_adicionar_cadastro
            // 
            this.btn_adicionar_cadastro.BackColor = System.Drawing.Color.Black;
            this.btn_adicionar_cadastro.FlatAppearance.BorderSize = 0;
            this.btn_adicionar_cadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_adicionar_cadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_adicionar_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adicionar_cadastro.Image = ((System.Drawing.Image)(resources.GetObject("btn_adicionar_cadastro.Image")));
            this.btn_adicionar_cadastro.Location = new System.Drawing.Point(-3, -7);
            this.btn_adicionar_cadastro.Name = "btn_adicionar_cadastro";
            this.btn_adicionar_cadastro.Size = new System.Drawing.Size(131, 117);
            this.btn_adicionar_cadastro.TabIndex = 1;
            this.btn_adicionar_cadastro.UseVisualStyleBackColor = false;
            this.btn_adicionar_cadastro.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_pesquisar_cad
            // 
            this.btn_pesquisar_cad.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar_cad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar_cad.Image = ((System.Drawing.Image)(resources.GetObject("btn_pesquisar_cad.Image")));
            this.btn_pesquisar_cad.Location = new System.Drawing.Point(440, 20);
            this.btn_pesquisar_cad.Name = "btn_pesquisar_cad";
            this.btn_pesquisar_cad.Size = new System.Drawing.Size(66, 68);
            this.btn_pesquisar_cad.TabIndex = 5;
            this.btn_pesquisar_cad.UseVisualStyleBackColor = true;
            this.btn_pesquisar_cad.Click += new System.EventHandler(this.btn_pesquisar_cad_Click);
            // 
            // btn_atualiza_pagina
            // 
            this.btn_atualiza_pagina.FlatAppearance.BorderSize = 0;
            this.btn_atualiza_pagina.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualiza_pagina.Image = ((System.Drawing.Image)(resources.GetObject("btn_atualiza_pagina.Image")));
            this.btn_atualiza_pagina.Location = new System.Drawing.Point(512, 15);
            this.btn_atualiza_pagina.Name = "btn_atualiza_pagina";
            this.btn_atualiza_pagina.Size = new System.Drawing.Size(67, 73);
            this.btn_atualiza_pagina.TabIndex = 6;
            this.btn_atualiza_pagina.UseVisualStyleBackColor = true;
            this.btn_atualiza_pagina.Click += new System.EventHandler(this.btn_atualiza_pagina_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(644, 326);
            this.Controls.Add(this.btn_atualiza_pagina);
            this.Controls.Add(this.btn_pesquisar_cad);
            this.Controls.Add(this.btn_excluir_cadastro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_alterar_cadastro);
            this.Controls.Add(this.btn_adicionar_cadastro);
            this.Controls.Add(this.dtgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Button btn_alterar_cadastro;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_excluir_cadastro;
        private System.Windows.Forms.Button btn_adicionar_cadastro;
        private System.Windows.Forms.Button btn_pesquisar_cad;
        private System.Windows.Forms.Button btn_atualiza_pagina;
    }
}