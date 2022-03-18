
namespace telaLogin
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txt_criar_usuario = new System.Windows.Forms.TextBox();
            this.txt_criar_senha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_icon = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_voltar_tela_inicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_criar_usuario
            // 
            this.txt_criar_usuario.Location = new System.Drawing.Point(256, 111);
            this.txt_criar_usuario.Name = "txt_criar_usuario";
            this.txt_criar_usuario.Size = new System.Drawing.Size(251, 20);
            this.txt_criar_usuario.TabIndex = 2;
            this.txt_criar_usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_criar_senha
            // 
            this.txt_criar_senha.Location = new System.Drawing.Point(256, 156);
            this.txt_criar_senha.Name = "txt_criar_senha";
            this.txt_criar_senha.Size = new System.Drawing.Size(251, 20);
            this.txt_criar_senha.TabIndex = 3;
            this.txt_criar_senha.TextChanged += new System.EventHandler(this.txt_criar_senha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(199, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(190, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuário";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(290, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crie sua conta ";
            // 
            // btn_icon
            // 
            this.btn_icon.BackgroundImage = global::telaLogin.Properties.Resources.adicionar_usuario__4_;
            this.btn_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_icon.FlatAppearance.BorderSize = 0;
            this.btn_icon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_icon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_icon.Location = new System.Drawing.Point(25, 53);
            this.btn_icon.Name = "btn_icon";
            this.btn_icon.Size = new System.Drawing.Size(138, 135);
            this.btn_icon.TabIndex = 7;
            this.btn_icon.UseVisualStyleBackColor = true;
            this.btn_icon.Click += new System.EventHandler(this.btn_icon_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::telaLogin.Properties.Resources.confirme__1_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Honeydew;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(400, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 47);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_voltar_tela_inicial
            // 
            this.btn_voltar_tela_inicial.BackColor = System.Drawing.Color.White;
            this.btn_voltar_tela_inicial.BackgroundImage = global::telaLogin.Properties.Resources.entrar__3_;
            this.btn_voltar_tela_inicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_voltar_tela_inicial.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_voltar_tela_inicial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaShell;
            this.btn_voltar_tela_inicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltar_tela_inicial.Location = new System.Drawing.Point(296, 195);
            this.btn_voltar_tela_inicial.Name = "btn_voltar_tela_inicial";
            this.btn_voltar_tela_inicial.Size = new System.Drawing.Size(67, 45);
            this.btn_voltar_tela_inicial.TabIndex = 0;
            this.btn_voltar_tela_inicial.UseVisualStyleBackColor = false;
            this.btn_voltar_tela_inicial.Click += new System.EventHandler(this.btn_voltar_tela_inicial_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(564, 311);
            this.Controls.Add(this.btn_icon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_criar_senha);
            this.Controls.Add(this.txt_criar_usuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_voltar_tela_inicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Life Boot";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_voltar_tela_inicial;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_criar_usuario;
        private System.Windows.Forms.TextBox txt_criar_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_icon;
    }
}