using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CadastroUsuario.DTO;
using System.Data.SqlClient;
using System.Data;

namespace CadastroUsuario.DAL
{
    public class UsuarioDAL
    {
        
        public static bool AutenticaUsuario(UsuarioDTO usuario)
        {
            bool retorno = false;
            SqlConnection conexao = new SqlConnection(@"server=jailton-pc;database=Cadastro; User id=sa; pwd=citrix");
         
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT * FROM USUARIO WHERE USU_LOGIN=@USU_LOGIN AND USU_SENHA=@USU_SENHA ";
                cmd.Parameters.AddWithValue("@USU_LOGIN", SqlDbType.VarChar).Value = usuario.Usu_login;
                cmd.Parameters.AddWithValue("@USU_SENHA", SqlDbType.VarChar).Value = usuario.Usu_senha;

                conexao.Open();

                SqlDataReader lendo = cmd.ExecuteReader();

                if (lendo.HasRows)
                {
                    retorno = true;
                }
               
                return retorno;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public IList<UsuarioDTO> ConsultaUsuario()
        {
           
            SqlConnection conexao = new SqlConnection(@"server=jailton-pc;database=Cadastro; User id=sa; pwd=citrix");

            try
            {
                IList<UsuarioDTO> usu = new List<UsuarioDTO>();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "SELECT * FROM USUARIO ";
                conexao.Open();

                SqlDataReader lendo = cmd.ExecuteReader();
                if (lendo.HasRows)
                {
                    while (lendo.Read())
                    {
                        UsuarioDTO usuario = new UsuarioDTO();
                        usuario.Usu_id = Convert.ToInt32(lendo["USU_ID"]);
                        usuario.Usu_login = Convert.ToString(lendo["USU_LOGIN"]);
                        usuario.Usu_nome = Convert.ToString(lendo["USU_NOME"]);
                        usuario.Usu_senha = Convert.ToString(lendo["USU_SENHA"]);
                        usuario.Usu_sexo = Convert.ToString(lendo["USU_SEXO"]);
                        usuario.Usu_dataNascimento = Convert.ToDateTime(lendo["USU_DATANASCIMENTO"]);
                        usu.Add(usuario);
                    }
                }

                return usu;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public int InseriUsuario(UsuarioDTO usuario)
        {
            int retorno = 0;
            UsuarioDAL usu = new UsuarioDAL();
            SqlConnection conexao = new SqlConnection(@"server=jailton-pc;database=Cadastro; User id=sa; pwd=citrix");

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "INSERT INTO USUARIO ( usu_nome,usu_sexo,usu_login,usu_senha,usu_datanascimento ) " +
                                             " VALUES ( @usu_nome,@usu_sexo,@usu_login,@usu_senha,@usu_datanascimento )";

                cmd.Parameters.Add("@usu_nome", SqlDbType.VarChar).Value = usuario.Usu_nome;
                cmd.Parameters.Add("@usu_sexo", SqlDbType.VarChar).Value = usuario.Usu_sexo;
                cmd.Parameters.Add("@usu_login", SqlDbType.VarChar).Value = usuario.Usu_login;
                cmd.Parameters.Add("@usu_senha", SqlDbType.VarChar).Value = usuario.Usu_senha;
                cmd.Parameters.Add("@usu_datanascimento", SqlDbType.DateTime).Value = usuario.Usu_dataNascimento;
                conexao.Open();

                retorno = cmd.ExecuteNonQuery();

                return retorno;
        
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public int AlteraUsuario(UsuarioDTO usuario)
        {
            int retorno = 0;
            UsuarioDAL usu = new UsuarioDAL();
            SqlConnection conexao = new SqlConnection(@"server=jailton-pc;database=Cadastro; User id=sa; pwd=citrix");

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText =
    " UPDATE Usuario " +
   "    SET usu_nome = @usu_nome " +
   "   ,usu_sexo = @usu_sexo " +
   "   ,usu_login = @usu_login " +
   "   ,usu_senha = @usu_senha " +
   "   ,usu_dataNascimento = @usu_dataNascimento " +
   " WHERE usu_id=@usu_id ";

                cmd.Parameters.Add("@usu_datanascimento", SqlDbType.DateTime).Value = usuario.Usu_dataNascimento;
                cmd.Parameters.Add("@usu_nome", SqlDbType.VarChar).Value = usuario.Usu_nome;
                cmd.Parameters.Add("@usu_sexo", SqlDbType.VarChar).Value = usuario.Usu_sexo;
                cmd.Parameters.Add("@usu_login", SqlDbType.VarChar).Value = usuario.Usu_login;
                cmd.Parameters.Add("@usu_senha", SqlDbType.VarChar).Value = usuario.Usu_senha;
                cmd.Parameters.Add("@usu_id", SqlDbType.Int).Value = usuario.Usu_id;
 
                conexao.Open();
                retorno = cmd.ExecuteNonQuery();

                return retorno;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }

        public int RemoveUsuario(UsuarioDTO usuario)
        {
            int retorno = 0;
            SqlConnection conexao = new SqlConnection(@"server=jailton-pc;database=Cadastro; User id=sa; pwd=citrix");

            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexao;
                cmd.CommandText = "DELETE USUARIO  WHERE USU_ID = @USU_ID";
                cmd.Parameters.Add("@USU_ID", SqlDbType.VarChar).Value = usuario.Usu_id;
                conexao.Open();
                retorno = cmd.ExecuteNonQuery();

                return retorno ;

               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexao.Close();
            }
        }
        


      
        }
    }
