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
using MODELO;

namespace DevExpress.views
{
    public partial class frm_addPagamento : Form
    {

        int idPagamento;
        public frm_addPagamento()
        {
            InitializeComponent();
        }
       public string mesacesso { get; set; }
        private void frm_addPagamento_Load(object sender, EventArgs e)
        {
            this.mesacesso = "";
            if (!this.mesacesso.Equals(""))
            {
                MessageBox.Show(mesacesso);
                btn_cancelar.Enabled = false;
                btn_delete.Enabled = false;
            }
            else
            {
                CarregarMatricula();
            }
           
        }
        private void btn_salvar_Click(object sender, EventArgs e)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                
                mysqlCon.Open();
                MySqlCommand mySqlCmd = new MySqlCommand("AddOrEditPagamento", mysqlCon);
                mySqlCmd.CommandType = CommandType.StoredProcedure;
                mySqlCmd.Parameters.AddWithValue("_id_pagamento", idPagamento);
                mySqlCmd.Parameters.AddWithValue("_quantidade", txt_preco.Text);
                mySqlCmd.Parameters.AddWithValue("_forma_pag", cb_formaPag.Text);
                mySqlCmd.Parameters.AddWithValue("_multa", txt_multa.Text);
                mySqlCmd.Parameters.AddWithValue("_total", txt_total.Text);
                mySqlCmd.Parameters.AddWithValue("_num_recibo", txt_reciboNum.Text);
                mySqlCmd.Parameters.AddWithValue("_troco", txt_troco.Text);
                mySqlCmd.Parameters.AddWithValue("_banco", cb_banco.Text);
                mySqlCmd.Parameters.AddWithValue("_emitente", login.Nome);
                mySqlCmd.Parameters.AddWithValue("_data_pagamento", DateTime.Now.ToString("dd-MM-yyy :HH: mm : ss"));
             //   mySqlCmd.Parameters.AddWithValue("_id_matricula", txt_TelefMae.Text);
                mySqlCmd.Parameters.AddWithValue("_id_instituicao", login.idInstituicao);
                mySqlCmd.ExecuteNonQuery();
                //CarregarAluno();
                MessageBox.Show("Aluno Cadastrado com Sucesso");
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
                    com.CommandText = "select al.id_aluno, al.nome_aluno, al.data_nasc, al.numero_BI, al.nacionalidade, m.tipo_estudante, m.curso, m.classe, m.turma, m.turno, m.propina from tb_matricula m  inner join aluno al where m.tipo_estudante=@normal and al.id_instituicao=@instituicao";
                    com.Parameters.Add("@normal", MySqlDbType.VarChar).Value = "Normal";
                    com.Parameters.Add("@instituicao", MySqlDbType.VarChar).Value = login.idInstituicao;
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
        private void dgv_dados_DoubleClick(object sender, EventArgs e)
        {

            ClasseId.Id = dgv_dados.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgv_dados.CurrentRow.Cells[1].Value.ToString();
            cb_classe.Text = dgv_dados.CurrentRow.Cells[6].Value.ToString();
            cb_curso.Text = dgv_dados.CurrentRow.Cells[7].Value.ToString();
            cb_turma.Text = dgv_dados.CurrentRow.Cells[8].Value.ToString();
            cb_turno.Text = dgv_dados.CurrentRow.Cells[9].Value.ToString();
        }

        private void btn_SelecionarMeses_Click(object sender, EventArgs e)
        {
            if(ClasseId.Id == "") {
                MessageBox.Show("Impossível selecionar os meses. Deves selecionar um estudante para poder marcar os meses!");
            }
            else
            {
                MessageBox.Show(ClasseId.Id);
                frm_meses addMese = new frm_meses();
                addMese.Show();
            }
        }
    }
}
