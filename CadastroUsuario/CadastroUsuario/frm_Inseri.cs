using CadastroUsuario.BLL;
using CadastroUsuario.DTO;
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
    public partial class frm_Inseri : Form
    {
        public frm_Inseri()
        {
            InitializeComponent();
            cb_sexo.SelectedIndex = 0;

            CarregaConsulta();
        }

        public void CarregaConsulta()
        {
            try
            {
                IList<UsuarioDTO> listaUsuarioDTO = new List<UsuarioDTO>();
                listaUsuarioDTO = new UsuarioBLL().ConsultaUsuario();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = listaUsuarioDTO;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO usuario = new UsuarioDTO();
                usuario.Usu_nome = tb_nome.Text;
                usuario.Usu_sexo = cb_sexo.Text;
                usuario.Usu_login = tb_login.Text;
                usuario.Usu_senha = tb_senha.Text;
                usuario.Usu_dataNascimento = Convert.ToDateTime(tb_data_nascimento.Text);

                int x = new UsuarioBLL().InsereUsuario(usuario);
                if (x > 0)
                {
                    MessageBox.Show("Gravado com sucesso!");
                    desabilitaCampos();
                    limpaCampos();
                    bt_novo.Enabled = true;
                    bt_inserir.Enabled = false;
                    CarregaConsulta();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro inesperado: " + ex.Message);
            }
        }


        
        private void habilitaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox) (c as Control).Enabled = true;
            }

        }

        private void desabilitaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is ComboBox) (c as Control).Enabled = false;
            }

        }


        private void limpaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox) (c as TextBox).Text = "";
            }

        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            habilitaCampos();
            bt_novo.Enabled = false;
            bt_inserir.Enabled = true;
            tb_nome.Focus();
        }

       


    }
}
