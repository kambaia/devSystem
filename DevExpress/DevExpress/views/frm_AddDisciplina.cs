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

namespace DevExpress.views
{
    public partial class frm_AddDisciplina : Form
    {
        int idDiscilina;
        public frm_AddDisciplina()
        {
            InitializeComponent();
        }

        private void frm_AddDisciplina_Load(object sender, EventArgs e)
        {
            CarregarTodasDisciplina();
            CarregarProfessorId();
            CarregarClasseId();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddOrEditDisciplina", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_disciplina", idDiscilina);
                mySqlCmd.Parameters.AddWithValue("_disciplina", txtDisciplina.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_id_classe", Convert.ToInt32(cbClasse.SelectedValue.ToString().Trim()));
                mySqlCmd.Parameters.AddWithValue("_id_professor", Convert.ToInt32(cbProf.SelectedValue.ToString().Trim()));
                mySqlCmd.Parameters.AddWithValue("_id_instituicao", Convert.ToInt32(login.idInstituicao));
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Cadastrado com Sucesso");

            }
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
                    com.CommandText = "SELECT d.id_disciplina, d.disciplina, c.id_classe, c.classe, c.curso, p.id_professor, p.nome_prof from disciplina d INNER JOIN professor p on d.id_professor = p.id_professor INNER JOIN classe c on d.id_classe = c.id_classe";
                    MySqlDataReader dr = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgv_visuDisciplina.DataSource = dt;
                    mysqlCon.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }
            }
        }
        private void CarregarProfessorId()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand com = new MySqlCommand();
                    com.Connection = mysqlCon;
                    com.CommandText = "SELECT * FROM  professor";
                    MySqlDataReader dr = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                   
                    cbProf.DisplayMember = "nome_prof";
                    cbProf.DataSource = dt;
                    cbProf.ValueMember = "id_professor";
                    MessageBox.Show(cbProf.SelectedValue.ToString());
                    mysqlCon.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }
            }
        }
        private void CarregarClasseId()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand com = new MySqlCommand();
                    com.Connection = mysqlCon;
                    com.CommandText = "SELECT * FROM  classe";

                    MySqlDataReader dr = com.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cbClasse.DisplayMember = "classe";
                    cbClasse.DataSource = dt;
                    cbClasse.ValueMember = "id_classe";



                    MessageBox.Show(cbClasse.SelectedValue.ToString());

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
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    MySqlCommand cmd = new MySqlCommand("SELECT * FROM  classe WHERE id_classe=@classe", mysqlCon);
                    cmd.Parameters.Add("@classe", MySqlDbType.VarChar).Value = cbClasse.SelectedValue.ToString();
                    mysqlCon.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtCurso.Text= reader.GetString("curso");
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

        private void dgv_visuDisciplina_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_visuDisciplina.CurrentRow.Index != -1)
            {
                idDiscilina = Convert.ToInt32(dgv_visuDisciplina.CurrentRow.Cells[0].Value.ToString());
                txtDisciplina.Text = dgv_visuDisciplina.CurrentRow.Cells[1].Value.ToString();
                cbClasse.Text = dgv_visuDisciplina.CurrentRow.Cells[3].Value.ToString();
                cbProf.Text = dgv_visuDisciplina.CurrentRow.Cells[5].Value.ToString();
                txtCurso.Enabled = false;
               
                btnSalvar.Text = "Atualizar";
                btnDeletar.Enabled = Enabled;
            }
        }
    }
}
