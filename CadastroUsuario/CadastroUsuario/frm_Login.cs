using CadastroUsuario.DTO;
using CadastroUsuario.BLL;
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
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void bt_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioDTO usuario = new UsuarioDTO();
                usuario.Usu_login = tb_login.Text;
                usuario.Usu_senha = tb_senha.Text;
                bool retorno = UsuarioBLL.AutenticaUsuario(usuario);
                if (retorno == true)
                {
                    MessageBox.Show("Seja bem vindo!");
                    Form f = new frm_Principal();
                    f.Show();
                }
                else
                {
                    MessageBox.Show("Usuario e/ou Senha Invalido!");
                }
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
