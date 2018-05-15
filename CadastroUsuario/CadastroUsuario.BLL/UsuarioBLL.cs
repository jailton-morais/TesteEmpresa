using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroUsuario.DAL;
using CadastroUsuario.DTO;

namespace CadastroUsuario.BLL
{
    public class UsuarioBLL
    {
        public static bool AutenticaUsuario(UsuarioDTO usuario)
        {
            try
            {
                bool retorno = UsuarioDAL.AutenticaUsuario(usuario);
                return retorno;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
