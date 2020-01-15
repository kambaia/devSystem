using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.views;
using DAL;
using MODELO;

namespace DevExpress
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_user.Text = login.Nome;
            if (login.Tipo == NivelAcesso.Admin) ;
            {
                MessageBox.Show("Sr. Administrador " + login.Nome + ", Seja Bem Vindo.");
            }
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnl_principal.Controls.Add(childForm);
            pnl_principal.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void intituiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_addInstituicao());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_addInstituicao());
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Aluno());
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_addUsuario());
        }

        private void propinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_addPagamento());
        }

        private void efectuarMatrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Matricula());
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_AddProfessor());
        }

        private void classeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_Classe());
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frm_AddDisciplina());
        }
    }
}
