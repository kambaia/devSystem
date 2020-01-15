using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    class modelo_Aluno
    {
        private int id;
        private string nome;
        private string numero_bi;
        private string data_nascimento;
        private string nacionalidade;
        private string genero;
        private string telefone_aluno;
        private string foto;

        private string provincia;
        private string bairro;
        private string rua;
        private int numeroCasa;

        private string nome_mae;
        private string nome_pai;
        private string tel_pai;
        private string tel_mae;


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
        public string Nome
        {
            get { return this.nome; }

            set { this.nome = value; }
        }
       
        public string Numero_Bi
        {
            get { return this.numero_bi; }

            set { this.numero_bi = value; }
        }
       
        public string Datanasc
        {
            get { return this.data_nascimento; }

            set { this.data_nascimento = value; }
        }
      
        public string Sexo
        {
            get { return this.genero; }

            set { this.genero = value; }
        }
       
        public string Nascionalidade
        {
            get { return this.nacionalidade; }

            set { this.nacionalidade = value; }
        }

        public string Telefone_Aluno
        {
            get { return this.telefone_aluno; }

            set { this.telefone_aluno = value; }
        }
        public string Foto
        {
            get { return this.foto; }

            set { this.foto = value; }
        }

        /// <summary>
        /// Dados do estudante***********************************
        /// </summary>




        /*************Endereço**********/

        public string Provincia
        {
            get { return this.provincia; }
            set { this.provincia = value; }
        }
      
        public string Bairro
        {
            get { return this.bairro; }
            set { this.bairro = value; }
        }
       
        public string Rua
        {
            get { return this.rua; }
            set { this.rua = value; }
        }
      
        public int numerodeCasa
        {
            get { return this.numeroCasa; }
            set { this.numeroCasa = value; }
        }

        /***********Filiação************/
       
        public string Nome_mae
        {
            get { return this.nome_mae; }
            set { this.nome_mae = value; }
        }
       
        public string Tel_mae
        {
            get { return this.tel_mae; }
            set { this.tel_mae = value; }
        }
       
        public string Nome_Pai
        {
            get { return this.nome_pai; }
            set { this.nome_pai = value; }
        }
       
        public string Tel_Pai
        {
            get { return this.tel_pai; }
            set { this.tel_pai = value; }
        }

       
    }
}
