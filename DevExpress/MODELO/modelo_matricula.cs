using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
 public   class modelo_matricula
    {
        private int id;

        /// Dados de nascimento do estudante***********************************

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

      
       
        private string classe_aluno;
        private string curso;
        private string turma;
        private string turno;
        private string tipo_estudante;
        private int numeroMatricula;
        private double propina;
        private int id_aluno;

        public string Classe_Aluno
        {
            get { return this.classe_aluno; }

            set { this.classe_aluno = value; }
        }

        public string Curso
        {
            get { return this.curso; }

            set { this.curso = value; }
        }

        public string Turma
        {
            get { return this.turma; }

            set { this.turma = value; }
        }

        public string Turno
        {
            get { return this.turno; }

            set { this.turno = value; }
        }
        public int NumeroMatricula
        {
            get
            {
                return numeroMatricula;
            }

            set
            {
                numeroMatricula = value;
            }
        }

        public double Propina
        {
            get
            {
                return propina;
            }

            set
            {
                propina = value;
            }
        }

        public int Id_aluno
        {
            get
            {
                return id_aluno;
            }

            set
            {
                id_aluno = value;
            }
        }
    }
}
