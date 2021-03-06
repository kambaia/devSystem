﻿using DAL;
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
    public partial class frm_Aluno : Form
    {
        int idAluno;

        public frm_Aluno()
        {
            InitializeComponent();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddOrEditAluno", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_aluno", idAluno);
                mySqlCmd.Parameters.AddWithValue("_nome_aluno", txt_nomeAluno.Text);
                mySqlCmd.Parameters.AddWithValue("_numero_BI", txt_BIaluno.Text);
                mySqlCmd.Parameters.AddWithValue("_data_nasc", txt_NascAluno.Text);
                mySqlCmd.Parameters.AddWithValue("_telefone", txt_Telefone.Text);
                mySqlCmd.Parameters.AddWithValue("_nacionalidade", txt_Nacionalidade.Text);
                mySqlCmd.Parameters.AddWithValue("_genero", cb_genero.Text);
                mySqlCmd.Parameters.AddWithValue("_provincia", txt_provincia.Text);
                mySqlCmd.Parameters.AddWithValue("_bairro", txt_Bairro.Text);
                mySqlCmd.Parameters.AddWithValue("_rua", txt_Rua.Text);
                mySqlCmd.Parameters.AddWithValue("_nome_mae", txt_NomeMae.Text);
                mySqlCmd.Parameters.AddWithValue("_tel", txt_TelefMae.Text);
                mySqlCmd.Parameters.AddWithValue("_Nome_pai", txt_NomePai.Text);
                mySqlCmd.Parameters.AddWithValue("_tel_pai", txt_TelefPai.Text);
                mySqlCmd.Parameters.AddWithValue("_id_instituicao", login.idInstituicao);
                mySqlCmd.ExecuteNonQuery();
                CarregarAluno();
                MessageBox.Show("Aluno Cadastrado com Sucesso");
            }
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
                txt_Nacionalidade.Text = dgv_dados.CurrentRow.Cells[4].Value.ToString();
                cb_genero.Text = dgv_dados.CurrentRow.Cells[5].Value.ToString();
                txt_provincia.Text = dgv_dados.CurrentRow.Cells[7].Value.ToString();
                txt_Bairro.Text = dgv_dados.CurrentRow.Cells[8].Value.ToString();
                txt_Rua.Text = dgv_dados.CurrentRow.Cells[9].Value.ToString();
                txt_NomeMae.Text = dgv_dados.CurrentRow.Cells[11].Value.ToString();
                txt_TelefMae.Text = dgv_dados.CurrentRow.Cells[13].Value.ToString();
                txt_NomePai.Text = dgv_dados.CurrentRow.Cells[10].Value.ToString();
                txt_TelefPai.Text = dgv_dados.CurrentRow.Cells[12].Value.ToString();
                btn_salvar.Text = "Atualizar";
                btn_delete.Enabled = Enabled;
            }
        }

        private void CarregarAluno()
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

                //SELECT * FROM aluno where id_instituicao=@id_instituicao
            }

        }

        private void frm_Aluno_Load(object sender, EventArgs e)
        {
            CarregarAluno();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("DeleteAluno", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_aluno", idAluno);
                mySqlCmd.ExecuteNonQuery();
                MessageBox.Show("Aluno deletado");
                btn_salvar.Text = "Salvar";
                CarregarAluno();
            }
        }
    }
}
