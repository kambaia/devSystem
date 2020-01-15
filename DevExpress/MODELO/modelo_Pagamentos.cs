using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODELO
{
   public class modelo_Pagamentos
    {
        private int id;

        private int idMatricula;
        private int idInstituicao;
        
        private string mesApagar;
        private string dataPamento;
        private string formaPagamento;
        private double quantPaga;
        private double totalPago;
        private double multa;

        private int numeroRecibo;
        private int troco;

        private string tipoBanco;
        private string emitidopor;

        private DateTime dataEmissao;
       



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

        /**************************Dados do pagamento**************************/

        public string MesApagar
        {
            get { return this.mesApagar; }

            set { this.mesApagar = value; }
        }
     
        public string DataPagamento
        {
            get
            {
                return dataPamento;
            }

            set
            {
                dataPamento = value;
            }
        }


        public string FormaPagamento
        {
            get { return this.formaPagamento; }

            set { this.formaPagamento = value; }
        }
     
        public double QuantPaga
        {
            get { return this.quantPaga; }

            set { this.quantPaga = value; }
        }


      
        public int NumeroRecibo
        {
            get { return this.numeroRecibo; }

            set { this.numeroRecibo = value; }
        }
     
        public int Troco
        {
            get { return this.troco; }

            set { this.troco = value; }
        }

        public DateTime DataEmissao
        {
            get
            {
                return dataEmissao;
            }

            set
            {
                dataEmissao = value;
            }
        }
        
        public int IdMatricula
        {
            get
            {
                return idMatricula;
            }

            set
            {
                idMatricula = value;
            }
        }

        public int IdInstituicao
        {
            get
            {
                return idInstituicao;
            }

            set
            {
                idInstituicao = value;
            }
        }

       
    }
}
