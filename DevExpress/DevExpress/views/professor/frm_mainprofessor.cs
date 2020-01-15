using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MODELO;
using MySql.Data.MySqlClient;
using DAL;

namespace DevExpress.views.professor
{
    public partial class frm_mainprofessor : MetroFramework.Forms.MetroForm
    {
        public frm_mainprofessor()
        {
            InitializeComponent();
        }

        private void frm_mainprofessor_Load(object sender, EventArgs e)
        {
          

            using (MySqlConnection Con = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    Con.Open();
                    MessageBox.Show(login.IdProf);
                    MySqlCommand cmd = new MySqlCommand("SELECT s.id_usuario, s.nome, s.email, p.id_professor, p.nome_prof from professor p INNER JOIN usuario s on p.id_usuario = s.id_usuario WHERE p.id_usuario= @idusuario", Con);
                    cmd.Parameters.Add("@idusuario", MySqlDbType.VarChar).Value = Convert.ToInt32(login.Id);
                    MySqlDataReader rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        login.Nome = rd.GetString("nome_prof");
                        login.Nome = rd.GetString("email");
                        login.Id = rd.GetString("id_professor");
                        s.Text = login.Email;
                    }
                    else
                    {
                        MessageBox.Show("Usuário não foi encontrado");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }

            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_principal.Controls.Add(childForm);
            pnl_principal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_provas());
        }

        private void intituiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_avalicao());
        }
    }
}
