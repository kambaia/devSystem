using DAL;
using MODELO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DevExpress.views.professor
{
    public partial class frm_provas : Form
    {
        public frm_provas()
        {
            InitializeComponent();
        }

        private void frm_provas_Load(object sender, EventArgs e)
        {
            CarregarTodasDisciplina();
            CarregarAlunos();
            CarregarTodasEstudantes();


        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void CarregarTodasDisciplina()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                   
                    mysqlCon.Open();
                    MySqlCommand com = new MySqlCommand();
                    com.Connection = mysqlCon;
                    com.CommandText = "SELECT d.id_disciplina, d.disciplina, p.nome_prof from disciplina d INNER JOIN professor p on d.id_professor = p.id_professor WHERE p.id_professor = @id_user";
                    com.Parameters.Add("@id_user", MySqlDbType.VarChar).Value = Convert.ToInt32(login.Id);
                    MySqlDataReader dr = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    
                    cbDisciplina.DisplayMember = "disciplina";
                    cbDisciplina.ValueMember = "id_disciplina";
                    cbDisciplina.DataSource = dt;
                    

                    mysqlCon.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }

            }
        }

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM  disciplina WHERE id_disciplina=@disciplina", mysqlCon);
                    cmd.Parameters.Add("@disciplina", MySqlDbType.VarChar).Value = cbDisciplina.SelectedValue.ToString();
                    mysqlCon.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtDis1.Text = reader.GetString("disciplina");
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show(string.Format("Não foi encontrado nenhum curso nesta classe! Deseja continuar!"),
                    "Alerta", MessageBoxButtons.YesNo);

                        MessageBox.Show("");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }
            }
        }

        public void CarregarAlunos()
        {

            using (MySqlConnection Con = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    Con.Open();
                   
                    MySqlCommand cmd = new MySqlCommand("select al.nome_aluno, m.num_estudante, c.curso, m.turma, m.turno, c.classe from tb_matricula m INNER JOIN aluno al on m.id_aluno = al.id_aluno INNER JOIN classe c on m.id_classe = c.id_classe WHERE c.classe = @classe AND al.id_instituicao = @idInstituicao", Con);
                    cmd.Parameters.Add("@classe", MySqlDbType.VarChar).Value = "10ª Classe";
                    cmd.Parameters.Add("@idInstituicao", MySqlDbType.VarChar).Value = Convert.ToInt32(login.idInstituicao);
                    MySqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgAlunos.DataSource = dt;

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }

            }
            //select al.nome_aluno, m.num_estudante, c.curso, m.turma, m.turno, c.classe from tb_matricula m INNER JOIN aluno al on m.id_aluno = al.id_aluno INNER JOIN classe c on m.id_classe = c.id_classe WHERE c.classe = "10ª Classe" AND al.id_instituicao = 1
        }

        private void CarregarTodasEstudantes()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                  
                    mysqlCon.Open();
                    MySqlCommand com = new MySqlCommand();
                    com.Connection = mysqlCon;
                    com.CommandText = "SELECT c.id_classe, c.classe, c.curso, m.turma, m.turma from tb_matricula m INNER JOIN classe c on m.id_classe = c.id_classe";
                  
                    MySqlDataReader dr = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cbClasse.DisplayMember = "classe";
                    cbClasse.ValueMember = "id_classe";
                    cbClasse.DataSource = dt;

                    cbTurma.DisplayMember = "turma";
                    cbTurma.DataSource = dt;

                   cbTurno.DisplayMember = "curso";
                    cbTurno.ValueMember = "id_classe";
                    cbTurno.DataSource = dt;

                    mysqlCon.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }

            }
        }

        private void cbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (MySqlConnection Con = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    Con.Open();

                    MySqlCommand cmd = new MySqlCommand("select al.nome_aluno, m.num_estudante, c.curso, m.turma, m.turno, c.classe from tb_matricula m INNER JOIN aluno al on m.id_aluno = al.id_aluno INNER JOIN classe c on m.id_classe = c.id_classe WHERE c.classe = @classe AND al.id_instituicao = @idInstituicao", Con);
                    cmd.Parameters.Add("@classe", MySqlDbType.VarChar).Value = cbClasse.Text;
                    cmd.Parameters.Add("@idInstituicao", MySqlDbType.VarChar).Value = Convert.ToInt32(login.idInstituicao);
                    MySqlDataReader rd = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(rd);
                    dgAlunos.DataSource = dt;
                    CarregarAlunos();

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }

            }
        }

        ////////////////
    }
}
