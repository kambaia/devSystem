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
    public partial class frm_AddProfessor : Form
    {
        int idProfessor;
        public frm_AddProfessor()
        {
            InitializeComponent();
        }
        private void frm_AddProfessor_Load(object sender, EventArgs e)
        {
            CarregarUserProfessores();
            CarregarProfessores();

        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddOrEditProfessor", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_professor", idProfessor);
                mySqlCmd.Parameters.AddWithValue("_nome_prof", txt_nome_prof.Text);
                mySqlCmd.Parameters.AddWithValue("_numero_BI", txt_BIProf.Text);
                mySqlCmd.Parameters.AddWithValue("_data_nasc", txt_NascProf.Text);
                mySqlCmd.Parameters.AddWithValue("_telefone1", txt_Telefone1.Text);
                mySqlCmd.Parameters.AddWithValue("_telefone2", txt_Telefone2.Text);
                mySqlCmd.Parameters.AddWithValue("_nacionalidade", txt_Nacionalidade.Text);
                mySqlCmd.Parameters.AddWithValue("_genero", cb_genero.Text);
                mySqlCmd.Parameters.AddWithValue("_provincia", txt_provincia.Text);
                mySqlCmd.Parameters.AddWithValue("_bairro", txt_Bairro.Text);
                mySqlCmd.Parameters.AddWithValue("_rua", txt_Rua.Text);
                mySqlCmd.Parameters.AddWithValue("_id_usuario", cbUserprofessor.SelectedValue.ToString());
                mySqlCmd.Parameters.AddWithValue("_id_instituicao", login.idInstituicao);
                CarregarProfessores();
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Aluno Cadastrado com Sucesso");
            }
        }

        private void dgv_dados_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_dados.CurrentRow.Index != -1)
            {
                idProfessor = Convert.ToInt32(dgv_dados.CurrentRow.Cells[0].Value.ToString());
                txt_nome_prof.Text = dgv_dados.CurrentRow.Cells[1].Value.ToString();
                txt_BIProf.Text = dgv_dados.CurrentRow.Cells[2].Value.ToString();
                txt_NascProf.Text = dgv_dados.CurrentRow.Cells[3].Value.ToString();
                txt_Telefone1.Text = dgv_dados.CurrentRow.Cells[6].Value.ToString();
                txt_Telefone2.Text = dgv_dados.CurrentRow.Cells[7].Value.ToString();
                txt_Nacionalidade.Text = dgv_dados.CurrentRow.Cells[4].Value.ToString();
                cb_genero.Text = dgv_dados.CurrentRow.Cells[5].Value.ToString();
                txt_provincia.Text = dgv_dados.CurrentRow.Cells[8].Value.ToString();
                txt_Bairro.Text = dgv_dados.CurrentRow.Cells[9].Value.ToString();
                txt_Rua.Text = dgv_dados.CurrentRow.Cells[10].Value.ToString();
                cbUserprofessor.Text = dgv_dados.CurrentRow.Cells[11].Value.ToString();
                btn_salvar.Text = "Atualizar";
                btn_delete.Enabled = Enabled;
            }
        }

        private void CarregarProfessores()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand com = new MySqlCommand();
                    com.Connection = mysqlCon;
                    com.CommandText = "SELECT p.id_professor, p.nome_prof,p.numero_BI,p.data_nasc, p.nacionalidade, p.genero, p.telefone1,p.telefone2, p.provincia, p.bairro, p.rua, us.id_usuario, us.nome, i.id_instituicao, i.nome FROM professor p inner join usuario us on p.id_usuario = us.id_usuario INNER JOIN tb_instituicao i on us.id_instituicao = i.id_instituicao";
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

                //SELECT * FROM aluno where id_instituicao=@id_instituicao
            }

        }

        public void CarregarUserProfessores()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand com = new MySqlCommand();
                    com.Connection = mysqlCon;
                    com.CommandText = "SELECT * FROM  usuario where niveldeacesso=@niveldeacesso";
                    com.Parameters.Add("@niveldeacesso", MySqlDbType.VarChar).Value = "Professor";
                    MySqlDataReader dr = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    cbUserprofessor.DataSource = dt;
                    cbUserprofessor.DisplayMember = "nome";
                    cbUserprofessor.ValueMember = "id_usuario";
                    MessageBox.Show(cbUserprofessor.SelectedValue.ToString());
                    mysqlCon.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }

                //SELECT * FROM aluno where id_instituicao=@id_instituicao
            }

        }

        
    }
}
