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
    public partial class frm_Matricula : Form
    {
        int idMAtricula;
        int idAluno;

        public frm_Matricula()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddOrEditMatricula", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_matricula", idMAtricula);
                mySqlCmd.Parameters.AddWithValue("_num_estudante", txt_numEstud.Text);
                mySqlCmd.Parameters.AddWithValue("_classe", cb_classe.Text);
                mySqlCmd.Parameters.AddWithValue("_curso", cb_curso.Text);
                mySqlCmd.Parameters.AddWithValue("_turma", cb_turma.Text);
                mySqlCmd.Parameters.AddWithValue("_turno", cb_turno.Text);
                mySqlCmd.Parameters.AddWithValue("_tipo_estudante", cb_tipoEst.Text);
                mySqlCmd.Parameters.AddWithValue("_num_matricula", txt_matricula.Text);
                mySqlCmd.Parameters.AddWithValue("_propina", txt_propina.Text);
                mySqlCmd.Parameters.AddWithValue("_id_aluno", idAluno);
                mySqlCmd.ExecuteNonQuery();
                CarregarMatricula();
                MessageBox.Show("Matricula Feita com Sucesso");
            }
        }

        private void CarregarMatricula()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand com = new MySqlCommand();
                    com.Connection = mysqlCon;
                    com.CommandText = "SELECT * FROM aluno where id_instituicao=@id_instituicao";
                    com.Parameters.Add("@id_instituicao", MySqlDbType.VarChar).Value = login.idInstituicao;
                    MySqlDataReader dr = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgv_dados.DataSource = dt;
                    mysqlCon.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }
            }
        }

        private void frm_Matricula_Load(object sender, EventArgs e)
        {
            CarregarMatricula();
        }

        private void dgv_dados_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_dados.CurrentRow.Index != -1)
            {
                idAluno = Convert.ToInt32(dgv_dados.CurrentRow.Cells[0].Value.ToString());
                txt_nomeAluno.Text = dgv_dados.CurrentRow.Cells[1].Value.ToString();
                txt_BIaluno.Text = dgv_dados.CurrentRow.Cells[2].Value.ToString();
               // txt_NascAluno.Text = dgv_dados.CurrentRow.Cells[3].Value.ToString();
                txt_Telefone.Text = dgv_dados.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

        }
    }
}
