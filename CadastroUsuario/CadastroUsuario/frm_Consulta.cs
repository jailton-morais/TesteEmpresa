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
    public partial class frm_Consulta : Form
    {
        public frm_Consulta()
        {
            InitializeComponent();
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


        private void bt_atualizar_Click(object sender, EventArgs e)
        {
            CarregaConsulta();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sel = dataGridView1.CurrentRow.Index;
            tb_nome.Text = Convert.ToString(dataGridView1["NOME", sel].Value);
            cb_sexo.Text = Convert.ToString(dataGridView1["SEXO", sel].Value);
            tb_login.Text = Convert.ToString(dataGridView1["LOGIN", sel].Value);
            tb_senha.Text = Convert.ToString(dataGridView1["SENHA", sel].Value);
            tb_data_nascimento.Text = Convert.ToString(dataGridView1["DATA_NASCIMENTO", sel].Value);
       
        }
    }
}
