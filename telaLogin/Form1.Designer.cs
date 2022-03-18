
namespace telaLogin
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_CriarConta = new System.Windows.Forms.Button();
            this.btn_confirma = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(255, 93);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(258, 20);
            this.txt_Usuario.TabIndex = 2;
            this.txt_Usuario.TextChanged += new System.EventHandler(this.txt_Usuario_TextChanged);
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(255, 139);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(258, 20);
            this.txt_Senha.TabIndex = 3;
            this.txt_Senha.UseSystemPasswordChar = true;
            this.txt_Senha.TextChanged += new System.EventHandler(this.txt_Senha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(336, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(204, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Senha";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(195, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuário";
            // 
            // btn_sair
            // 
            this.btn_sair.BackgroundImage = global::telaLogin.Properties.Resources.entrar__3_;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaShell;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Location = new System.Drawing.Point(359, 180);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(53, 43);
            this.btn_sair.TabIndex = 5;
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_CriarConta
            // 
            this.btn_CriarConta.BackgroundImage = global::telaLogin.Properties.Resources.adicionar_usuario__1_;
            this.btn_CriarConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_CriarConta.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_CriarConta.FlatAppearance.BorderSize = 0;
            this.btn_CriarConta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightYellow;
            this.btn_CriarConta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightYellow;
            this.btn_CriarConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CriarConta.Location = new System.Drawing.Point(290, 185);
            this.btn_CriarConta.Name = "btn_CriarConta";
            this.btn_CriarConta.Size = new System.Drawing.Size(53, 33);
            this.btn_CriarConta.TabIndex = 4;
            this.btn_CriarConta.UseVisualStyleBackColor = true;
            this.btn_CriarConta.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btn_confirma
            // 
            this.btn_confirma.BackColor = System.Drawing.SystemColors.Window;
            this.btn_confirma.BackgroundImage = global::telaLogin.Properties.Resources.confirme__1_;
            this.btn_confirma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_confirma.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_confirma.FlatAppearance.BorderSize = 0;
            this.btn_confirma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_confirma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.btn_confirma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirma.Location = new System.Drawing.Point(432, 181);
            this.btn_confirma.Name = "btn_confirma";
            this.btn_confirma.Size = new System.Drawing.Size(53, 42);
            this.btn_confirma.TabIndex = 1;
            this.btn_confirma.UseVisualStyleBackColor = false;
            this.btn_confirma.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::telaLogin.Properties.Resources.user__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(40, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 147);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_CriarConta);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.btn_confirma);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life boot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_confirma;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Button btn_CriarConta;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

