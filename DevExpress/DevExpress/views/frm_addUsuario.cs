using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using MODELO;
using MySql.Data.MySqlClient;

namespace DevExpress.views
{
    public partial class frm_addUsuario : Form
    {
        int idUser;

        public frm_addUsuario()
        {
            InitializeComponent();
        }

        private void frm_addUsuario_Load(object sender, EventArgs e)
        {
            CarregarUser();
            CarregarInstituicao();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddOrEditUsuario", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_usuario", idUser);
                mySqlCmd.Parameters.AddWithValue("_nome", txtNomeUser.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_email", txtEmail.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_senha", txtSenha.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_id_instituicao", Convert.ToInt32(combInstituicao.SelectedValue.ToString().Trim()));
                mySqlCmd.Parameters.AddWithValue("_data", DateTime.Now.ToString("dd-MM-yyy :HH: mm : ss"));
                mySqlCmd.Parameters.AddWithValue("_niveldeacesso", txtNivelAcesso.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_foto", txtURL.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                CarregarUser();
                MessageBox.Show("Cadastrado com Sucesso");
               
            }
            
        }

        private void Limpar()
        {
            txtNomeUser.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            combInstituicao.Text= "";
            txtNivelAcesso.Text = "";
            txtURL.Text = "";
        }

        public void CarregarUser()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("VisualizarUser", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblUser = new DataTable();
                sqlDa.Fill(dtblUser);
                dgv_visuUser.DataSource = dtblUser;
            }
        }

        

        private void txt_pesquisa_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PesqUser", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_pesquisar", txt_pesquisa.Text);
                DataTable dtblUser = new DataTable();
                sqlDa.Fill(dtblUser);
                dgv_visuUser.DataSource = dtblUser;
                dgv_visuUser.Columns[0].Visible = false;
            }
        }

        private void dgv_visuUser_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_visuUser.CurrentRow.Index != -1)
            {
                idUser = Convert.ToInt32(dgv_visuUser.CurrentRow.Cells[0].Value.ToString());
                txtNomeUser.Text = dgv_visuUser.CurrentRow.Cells[1].Value.ToString();
                txtEmail.Text = dgv_visuUser.CurrentRow.Cells[2].Value.ToString();
                txtNivelAcesso.Text = dgv_visuUser.CurrentRow.Cells[4].Value.ToString();
                combInstituicao.Text = Convert.ToString(dgv_visuUser.CurrentRow.Cells[3].Value.ToString());
                btn_salvar.Text = "Atualizar";
                btn_delete.Enabled = Enabled;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteUser", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_usuario", idUser);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Usuário deletado");
                CarregarUser();
            }
        }

        private void CarregarInstituicao()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand com = new MySqlCommand();
                    com.Connection = mysqlCon;
                    com.CommandText = "SELECT * FROM tb_instituicao";
                    MySqlDataReader dr = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    combInstituicao.DataSource = dt;
                    combInstituicao.DisplayMember = "nome";
                    combInstituicao.ValueMember = "id_instituicao";
                    mysqlCon.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }
            }
        }

        private void combInstituicao_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
