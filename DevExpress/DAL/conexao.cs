using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class conexao
    {


        public static string servidor = "localhost";
        public static string basedados = "teste_dev";
        public static string usuario = "root";
        public static string senha = "";
        public static string connectionString = @"Server=" + servidor + ";Database=" + basedados + ";Uid=" + usuario + ";Pwd=" + senha + ";";
        
        /*
        //  string connString = 
        MySqlConnection con = new MySqlConnection();
        public String mensagem = "";

        public conexao()
        {
            con.ConnectionString = "Server=localhost;Database=teste_dev;Uid=root;Pwd=";

        }

        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    con.Open();
                    this.mensagem = "Sucesso";
                }
                catch
                {
                    this.mensagem = "Erro";
                }

            }

            return con;
        }
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();

            }
        }
        */
    }
}
