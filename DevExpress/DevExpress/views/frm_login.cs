using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.views.professor;
using DevExpress.views.Escola;
using DevExpress.views.Alunos;
using MODELO;
using MySql.Data.MySqlClient;
using DAL;

namespace DevExpress.views
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_acess_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM usuario WHERE email=@usuario and senha=@senha", mysqlCon);
                    cmd.Parameters.Add("@usuario", MySqlDbType.VarChar).Value = txt_email.Text;
                    cmd.Parameters.Add("@senha", MySqlDbType.VarChar).Value = txt_pass.Text;
                    mysqlCon.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        login.Id = reader.GetString("id_usuario");
                        login.IdProf = reader.GetString("id_usuario");
                        login.Nome = reader.GetString("email");
                        login.Email = reader.GetString("email");
                        login.Foto = reader.GetString("foto");
                        login.Tipo = reader.GetString("niveldeacesso");
                        login.idInstituicao = reader.GetString("id_instituicao");


                        if (login.Tipo == NivelAcesso.Admin)
                        {
                            Form1 lo = new Form1();
                            lo.Show();
                            this.Visible = false;
                        }
                        else if (login.Tipo == NivelAcesso.Admin_escola)
                        {
                            Form1 lo = new Form1();
                            lo.Show();
                            this.Visible = false;
                        }
                        else if (login.Tipo == NivelAcesso.Professor)
                        {
                           frm_mainprofessor p = new frm_mainprofessor();
                            p.Show();
                            this.Hide();         
                        }
                        else if (login.Tipo == NivelAcesso.Estudante)
                        {
                            frmMainEstudantes al = new frmMainEstudantes();
                            al.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario e/ou Senha invalido");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }
                mysqlCon.Close();
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
          
        }
    }
}
