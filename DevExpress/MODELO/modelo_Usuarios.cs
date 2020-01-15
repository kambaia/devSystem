using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
    public class modelo_Usuarios
    {
        private int id; 
        private string nome;
        private string senha;
        private string email;
        private string foto;
        private string tipo;
        private string data;
        private int id_instituicao;


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
       
        public string Email
        {
            get { return this.email; }

            set { this.email = value; }
        }
     
        public string Senha
        {
            get { return this.senha; }

            set { this.senha = value; }
        }
        
        public string Tipo
        {
            get { return this.tipo; }

            set { this.tipo = value; }
        }
        public string Foto
        {
            get { return this.foto; }

            set { this.foto = value; }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public int Id_instituicao
        {
            get
            {
                return id_instituicao;
            }

            set
            {
                id_instituicao = value;
            }
        }
    }
}
