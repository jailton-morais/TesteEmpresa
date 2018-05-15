namespace CadastroUsuario
{
    partial class frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inseriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alteraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreOSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripAberto = new System.Windows.Forms.ToolStripButton();
            this.toolStripFechado = new System.Windows.Forms.ToolStripButton();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.inseriToolStripMenuItem,
            this.alteraToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.usuarioToolStripMenuItem.Enabled = false;
            this.usuarioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(67, 21);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // inseriToolStripMenuItem
            // 
            this.inseriToolStripMenuItem.Name = "inseriToolStripMenuItem";
            this.inseriToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.inseriToolStripMenuItem.Text = "Inseri";
            this.inseriToolStripMenuItem.Click += new System.EventHandler(this.inseriToolStripMenuItem_Click);
            // 
            // alteraToolStripMenuItem
            // 
            this.alteraToolStripMenuItem.Name = "alteraToolStripMenuItem";
            this.alteraToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.alteraToolStripMenuItem.Text = "Altera";
            this.alteraToolStripMenuItem.Click += new System.EventHandler(this.alteraToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreOSistemaToolStripMenuItem});
            this.ajudaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(56, 21);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // sobreOSistemaToolStripMenuItem
            // 
            this.sobreOSistemaToolStripMenuItem.Name = "sobreOSistemaToolStripMenuItem";
            this.sobreOSistemaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.sobreOSistemaToolStripMenuItem.Text = "Sobre o Sistema";
            this.sobreOSistemaToolStripMenuItem.Click += new System.EventHandler(this.sobreOSistemaToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAberto,
            this.toolStripFechado});
            this.toolStrip.Location = new System.Drawing.Point(0, 25);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(784, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripAberto
            // 
            this.toolStripAberto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripAberto.Image = global::CadastroUsuario.Properties.Resources.aberto;
            this.toolStripAberto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripAberto.Name = "toolStripAberto";
            this.toolStripAberto.Size = new System.Drawing.Size(23, 22);
            this.toolStripAberto.Text = "toolStripButton1";
            this.toolStripAberto.ToolTipText = "Clique aqui para fechar o Sistema";
            this.toolStripAberto.Visible = false;
            this.toolStripAberto.Click += new System.EventHandler(this.toolStripAberto_Click);
            // 
            // toolStripFechado
            // 
            this.toolStripFechado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripFechado.Image = global::CadastroUsuario.Properties.Resources.fechado;
            this.toolStripFechado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripFechado.Name = "toolStripFechado";
            this.toolStripFechado.Size = new System.Drawing.Size(23, 22);
            this.toolStripFechado.Text = "toolStripButton2";
            this.toolStripFechado.ToolTipText = "Clique aqui para acessar o Sistema";
            this.toolStripFechado.Click += new System.EventHandler(this.toolStripFechado_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 539);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(784, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Principal_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inseriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alteraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreOSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripAberto;
        private System.Windows.Forms.ToolStripButton toolStripFechado;
    }
}



