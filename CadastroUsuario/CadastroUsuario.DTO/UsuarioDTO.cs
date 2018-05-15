using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroUsuario.DTO
{
    public class UsuarioDTO
    {
        public int Usu_id { get; set; }
        public string Usu_nome { get; set; }
        public string Usu_sexo { get; set; }
        public string Usu_login { get; set; }
        public string Usu_senha { get; set; }
        public DateTime Usu_dataNascimento { get; set; }
    }
}
