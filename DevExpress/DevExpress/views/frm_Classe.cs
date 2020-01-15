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
    public partial class frm_Classe : Form
    {
        public frm_Classe()
        {
            InitializeComponent();
        }
        private void frm_Classe_Load(object sender, EventArgs e)
        {
            CarregarClasses();
        }
        private void txtSalvar_Click(object sender, EventArgs e)
        {
            // pode salvar
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {

                int id_instituicao = Convert.ToInt32(login.idInstituicao);
                mysqlCon.Open();
                //Query SQL
                MySqlCommand command = new MySqlCommand("INSERT INTO classe (classe, propina, curso, id_instituicao)" +
                "VALUES('" + txtClasse.Text + "','" + txtPropina.Text + "', '" + txtCurso.Text + "', '" + id_instituicao + "')", mysqlCon);
                //Executa a Query SQL
                command.ExecuteNonQuery();

                // Fecha a conexão
                mysqlCon.Close();
                MessageBox.Show("Classe adicionado");
            }
            //INSERT INTO `classe` (`id_classe`, `classe`, `propina`) VALUES(NULL, '10ª ', '15.100,00');
        }

        private void CarregarClasses()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(conexao.connectionString))
            {
                try
                {
                    mysqlCon.Open();
                    MySqlCommand com = new MySqlCommand();
                    com.Connection = mysqlCon;
                    com.CommandText = "SELECT c.id_classe, c.classe,c.propina,c.curso , i.nome FROM classe c inner join tb_instituicao i on c.id_instituicao = i.id_instituicao ";
                    MySqlDataReader dr = com.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dgv_visuClasse.DataSource = dt;
                    mysqlCon.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error: " + Convert.ToString(ex), "Aviso");
                }
            }
        }

        private void dgv_visuClasse_DoubleClick(object sender, EventArgs e)
        {
            txtClasse.Text = dgv_visuClasse.CurrentRow.Cells[1].Value.ToString();
            txtPropina.Text = dgv_visuClasse.CurrentRow.Cells[2].Value.ToString();
            txtCurso.Text = dgv_visuClasse.CurrentRow.Cells[3].Value.ToString();
        }
    } 
    }
