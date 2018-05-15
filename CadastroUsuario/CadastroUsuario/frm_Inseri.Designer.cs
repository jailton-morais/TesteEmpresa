namespace CadastroUsuario
{
    partial class frm_Inseri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SENHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_NASCIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_novo = new System.Windows.Forms.Button();
            this.bt_inserir = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_data_nascimento = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.LOGIN,
            this.SENHA,
            this.NOME,
            this.SEXO,
            this.DATA_NASCIMENTO});
            this.dataGridView1.Location = new System.Drawing.Point(20, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(645, 110);
            this.dataGridView1.TabIndex = 86;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "USU_ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // LOGIN
            // 
            this.LOGIN.DataPropertyName = "USU_LOGIN";
            this.LOGIN.HeaderText = "LOGIN";
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.ReadOnly = true;
            this.LOGIN.Visible = false;
            // 
            // SENHA
            // 
            this.SENHA.DataPropertyName = "USU_SENHA";
            this.SENHA.HeaderText = "SENHA";
            this.SENHA.Name = "SENHA";
            this.SENHA.ReadOnly = true;
            this.SENHA.Visible = false;
            // 
            // NOME
            // 
            this.NOME.DataPropertyName = "USU_NOME";
            this.NOME.HeaderText = "NOME";
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 200;
            // 
            // SEXO
            // 
            this.SEXO.DataPropertyName = "USU_SEXO";
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            // 
            // DATA_NASCIMENTO
            // 
            this.DATA_NASCIMENTO.DataPropertyName = "USU_DATANASCIMENTO";
            this.DATA_NASCIMENTO.HeaderText = "DATA_NASCIMENTO";
            this.DATA_NASCIMENTO.Name = "DATA_NASCIMENTO";
            this.DATA_NASCIMENTO.ReadOnly = true;
            this.DATA_NASCIMENTO.Width = 200;
            // 
            // bt_novo
            // 
            this.bt_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_novo.Location = new System.Drawing.Point(167, 321);
            this.bt_novo.Name = "bt_novo";
            this.bt_novo.Size = new System.Drawing.Size(91, 23);
            this.bt_novo.TabIndex = 6;
            this.bt_novo.Text = "Novo";
            this.bt_novo.UseVisualStyleBackColor = true;
            this.bt_novo.Click += new System.EventHandler(this.bt_novo_Click);
            // 
            // bt_inserir
            // 
            this.bt_inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_inserir.Location = new System.Drawing.Point(370, 321);
            this.bt_inserir.Name = "bt_inserir";
            this.bt_inserir.Size = new System.Drawing.Size(75, 23);
            this.bt_inserir.TabIndex = 7;
            this.bt_inserir.Text = "Inserir";
            this.bt_inserir.UseVisualStyleBackColor = true;
            this.bt_inserir.Click += new System.EventHandler(this.bt_inserir_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(108, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 83;
            this.label7.Text = "Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(108, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 82;
            this.label5.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 81;
            this.label4.Text = "Data Nascimento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "Sexo:";
            // 
            // cb_sexo
            // 
            this.cb_sexo.Enabled = false;
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_sexo.Location = new System.Drawing.Point(170, 52);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(64, 21);
            this.cb_sexo.TabIndex = 2;
            // 
            // tb_login
            // 
            this.tb_login.Enabled = false;
            this.tb_login.Location = new System.Drawing.Point(170, 91);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(229, 20);
            this.tb_login.TabIndex = 3;
            // 
            // tb_data_nascimento
            // 
            this.tb_data_nascimento.Enabled = false;
            this.tb_data_nascimento.Location = new System.Drawing.Point(167, 158);
            this.tb_data_nascimento.Name = "tb_data_nascimento";
            this.tb_data_nascimento.Size = new System.Drawing.Size(229, 20);
            this.tb_data_nascimento.TabIndex = 5;
            // 
            // tb_senha
            // 
            this.tb_senha.Enabled = false;
            this.tb_senha.Location = new System.Drawing.Point(167, 129);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(229, 20);
            this.tb_senha.TabIndex = 4;
            // 
            // tb_nome
            // 
            this.tb_nome.Enabled = false;
            this.tb_nome.Location = new System.Drawing.Point(170, 16);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(453, 20);
            this.tb_nome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 76;
            this.label2.Text = "Nome:";
            // 
            // frm_Inseri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_novo);
            this.Controls.Add(this.bt_inserir);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_sexo);
            this.Controls.Add(this.tb_login);
            this.Controls.Add(this.tb_data_nascimento);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.label2);
            this.Name = "frm_Inseri";
            this.Text = "Inseri Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SENHA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_NASCIMENTO;
        private System.Windows.Forms.Button bt_novo;
        private System.Windows.Forms.Button bt_inserir;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_data_nascimento;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Label label2;
    }
}