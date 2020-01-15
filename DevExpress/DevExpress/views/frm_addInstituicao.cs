using DAL;
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
    public partial class frm_addInstituicao : Form
    {
        int idInst;

        public frm_addInstituicao()
        {
            InitializeComponent();
        }

        private void Limpar()
        {
            txtNome_Inst.Text = "";
            txtEmail.Text = "";
            txtURL.Text = "";
            txt_provincia.Text = "";
            txt_rua.Text = "";
            txt_bairro.Text = "";
            txt_tel1.Text = "";
            txt_tel2.Text = "";
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddOrEditInstituicao", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_instituicao", idInst);
                mySqlCmd.Parameters.AddWithValue("_nome", txtNome_Inst.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_email", txtEmail.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_logo", txtURL.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_provincia", txt_provincia.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_rua", txt_rua.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_bairro", txt_bairro.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_tel1", txt_tel1.Text.Trim());
                mySqlCmd.Parameters.AddWithValue("_tel2", txt_tel2.Text.Trim());
                mySqlCmd.ExecuteNonQuery();
                CarregarInstituicao();
                MessageBox.Show("Instituição Cadastrada Successfully");
                Limpar();
            }
        }

        private void CarregarInstituicao()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("visualizarInstituicao", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtblUser = new DataTable();
                sqlDa.Fill(dtblUser);
                dgv_dados.DataSource = dtblUser;
            }
        }

        private void frm_addInstituicao_Load(object sender, EventArgs e)
        {
            CarregarInstituicao();
        }

        private void dgv_dados_DoubleClick(object sender, EventArgs e)
        {
            if (dgv_dados.CurrentRow.Index != -1)
            {
                idInst = Convert.ToInt32(dgv_dados.CurrentRow.Cells[0].Value.ToString());
                txtNome_Inst.Text = dgv_dados.CurrentRow.Cells[1].Value.ToString();
                txtEmail.Text = dgv_dados.CurrentRow.Cells[2].Value.ToString();
                txtURL.Text = dgv_dados.CurrentRow.Cells[3].Value.ToString();
                txt_provincia.Text = dgv_dados.CurrentRow.Cells[4].Value.ToString();
                txt_rua.Text = dgv_dados.CurrentRow.Cells[5].Value.ToString();
                txt_bairro.Text = dgv_dados.CurrentRow.Cells[6].Value.ToString();
                txt_tel1.Text = dgv_dados.CurrentRow.Cells[7].Value.ToString();
                txt_tel2.Text = dgv_dados.CurrentRow.Cells[8].Value.ToString();
                btn_salvar.Text = "Atualizar";
                btn_delete.Enabled = Enabled;
            }
        }

        private void txt_pesquisar_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("PesqInstituicao", mysqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("_pesquisar", txt_pesquisar.Text);
                DataTable dtblUser = new DataTable();
                sqlDa.Fill(dtblUser);
                dgv_dados.DataSource = dtblUser;
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteInstituicao", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_intituicao", idInst);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Instituição deletada");
                CarregarInstituicao();
            }
        }
    }
}

