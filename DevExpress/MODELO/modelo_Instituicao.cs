using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public class modelo_Instituicao
    {
        private int id;
        private string nome;
        private string logo;
        private string provincia;
        private string bairro;
        private string rua;
        private string tel1;
        private string tel;
        private string email;
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
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }
        public string Logo
        {
            get
            {
                return logo;
            }

            set
            {
                logo = value;
            }
        }
        public string Provincia
        {
            get
            {
                return provincia;
            }

            set
            {
                provincia = value;
            }
        }
        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }
        public string Rua
        {
            get
            {
                return rua;
            }

            set
            {
                rua = value;
            }
        }
        public string Tel1
        {
            get
            {
                return tel1;
            }

            set
            {
                tel1 = value;
            }
        }
        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
