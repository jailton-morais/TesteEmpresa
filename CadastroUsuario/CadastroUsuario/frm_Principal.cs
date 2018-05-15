using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroUsuario
{
    public partial class frm_Principal : Form
    {
       

        public frm_Principal()
        {
            InitializeComponent();
            this.toolStripStatusLabel.Text = "STATUS: Desconectado";
            this.usuarioToolStripMenuItem.Enabled = false;
           
        }


        public void AlterarStatus()
        {
            this.usuarioToolStripMenuItem.Enabled = true;
            this.toolStripAberto.Visible = true;
            this.toolStripFechado.Visible = false;
            this.toolStripStatusLabel.Text = "STATUS: Conectado";
        }

     
        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form filha = new frm_Consulta();
            filha.MdiParent = this;
            filha.Show();
        }

        private void inseriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form filha = new frm_Inseri();
            filha.MdiParent = this;
            filha.Show();
        }

        private void alteraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form filha = new frm_Altera();
            filha.MdiParent = this;
            filha.Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form filha = new frm_Remove();
            filha.MdiParent = this;
            filha.Show();
        }

        private void sobreOSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form filha = new frm_Sobre();
            filha.MdiParent = this;
            filha.Show();
        }

        private void toolStripFechado_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_Login>().Count() > 0)
            {

            }
            else
            {
                Form filho = new frm_Login();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void toolStripAberto_Click(object sender, EventArgs e)
        {
            this.usuarioToolStripMenuItem.Enabled = false;
            this.toolStripAberto.Visible = false;
            this.toolStripFechado.Visible = true;
            FecharFormulariosFilhos();
            this.toolStripStatusLabel.Text = "STATUS: Desconectado";
        }


        private void FecharFormulariosFilhos()
        {
         
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
             
                if (Application.OpenForms[i].IsMdiChild)
                {
               
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void frm_Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
