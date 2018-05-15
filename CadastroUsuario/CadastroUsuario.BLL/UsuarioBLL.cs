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

        public IList<UsuarioDTO> ConsultaUsuario()
        {
            try
            {
                IList<UsuarioDTO> consulta  = new UsuarioDAL().ConsultaUsuario();
                return consulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int InsereUsuario(UsuarioDTO usuario)
        {
            try
            {
                int retorno = new UsuarioDAL().InseriUsuario(usuario);
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int AlteraUsuario(UsuarioDTO usuario)
        {
            try
            {
                int retorno = new UsuarioDAL().AlteraUsuario(usuario);
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        
        public int RemoveUsuario(UsuarioDTO usuario)
        {
            try
            {
                int retorno = new UsuarioDAL().RemoveUsuario(usuario);
                return retorno;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
