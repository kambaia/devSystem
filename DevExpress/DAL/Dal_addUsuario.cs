using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MODELO;

namespace DAL
{
    public class Dal_addUsuario
    {
        public string mensagem = "";
        conexao con = new conexao();
        int idUser;

        public void inserirUsuario(modelo_Usuarios mdUser)
        {/*
            con.conectar();
            MySqlCommand mySqlCmd = new MySqlCommand("AddOrEditUsuario", con.conectar());
            mySqlCmd.CommandType = CommandType.StoredProcedure;
            mySqlCmd.Parameters.AddWithValue("_id_usuario", idUser);
            mySqlCmd.Parameters.AddWithValue("_nome", mdUser.Nome);
            mySqlCmd.Parameters.AddWithValue("_email", mdUser.Email);
            mySqlCmd.Parameters.AddWithValue("_senha", mdUser.Senha);
            mySqlCmd.Parameters.AddWithValue("_id_intituicao", mdUser.Id_instituicao);
            mySqlCmd.Parameters.AddWithValue("_data", mdUser.Data);
            mySqlCmd.Parameters.AddWithValue("_tipo_aluno", mdUser.Tipo);
            mySqlCmd.Parameters.AddWithValue("_foto", mdUser.Foto);
            

            try
            {
                mySqlCmd.ExecuteNonQuery();
                this.mensagem = "Cadastro Efetuado com Sucesso :)";
                con.Desconectar();
            }
            catch (Exception)
            {

                this.mensagem = "Cadastro Efetuado sem Sucesso :(";
            }
           
            */
        }
    }
}
