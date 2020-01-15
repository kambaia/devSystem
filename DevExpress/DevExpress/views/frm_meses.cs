using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;
using MODELO;

namespace DevExpress.views
{
    public partial class frm_meses : Form
    {
        public frm_meses()
        {
            InitializeComponent();
        }
        public string mes = "";
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ClasseId.Id = "";
        }

       

        private void checkFevereiro_CheckedChanged(object sender, EventArgs e)
        {
            if (checkFevereiro.Checked == true)
            {
                mes = "tem";
                MessageBox.Show(ClasseId.aMes);

                btn_cancelar.Enabled = false;
                DialogResult dialogResult = MessageBox.Show(string.Format("Será adicionado o mês de "+ checkFevereiro.Text + "No aluno que pertence este id" + ClasseId.Id),
                     "Cadastar o mês de " + checkFevereiro.Text, MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                { // pode salvar
                    using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
                    {

                        int idAluno = Convert.ToInt32(ClasseId.Id);
                        mysqlCon.Open();
                       
                        //Query SQL
                        MySqlCommand command = new MySqlCommand("INSERT INTO tb_meses (mes, id_aluno)" +
                        "VALUES('" + checkFevereiro.Text + "','" + idAluno + "')", mysqlCon);

                        //Executa a Query SQL
                        command.ExecuteNonQuery();

                        // Fecha a conexão
                       mysqlCon.Close();
                        MessageBox.Show("Mês adicionado");
                        checkFevereiro.Enabled = false;
                    }
                }
                else
                { // cancela a operação
                    checkFevereiro.Checked = false;
                  
                }

            }
            else
            {
                btn_cancelar.Enabled = true;
               
            }
            
        }

       

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(!this.mes.Equals(""))
            {
                frm_addPagamento pagar = new frm_addPagamento();
                pagar.mesacesso = mes;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Selecona qualquer mese para continuar!");
            }
        }
    }
}
