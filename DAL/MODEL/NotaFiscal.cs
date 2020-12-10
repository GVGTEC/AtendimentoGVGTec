using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Entity Framework Code First – Migrations
//https://msdn.microsoft.com/pt-br/library/jj856238.aspx

namespace DAL.MODEL
{
    public class NotaFiscal
    {
        public NotaFiscal()
        {
            this.NotaFiscalItemX = new List<NotaFiscalItem>();
        }

        public int Id { get; set; }
        public int NumeroNotaFiscal { get; set; }
        public DateTime DataEmissao { get; set; }
        public DateTime DataSaida { get; set; }
        public Decimal TotalProdutos { get; set; }
        public Decimal TotalNota { get; set; }
        public Decimal FreteVR { get; set; }
        //public Decimal SeguroVR { get; set; }
        public Decimal DescontoVR { get; set; }
        public Decimal OutrasDespesasVR { get; set; }
        public Decimal IcmsBC { get; set; }
        public Decimal IcmsVR { get; set; }
        public Decimal IcmsBC_ST { get; set; }
        public Decimal IcmsVR_ST { get; set; }        
        public string Quantidade { get; set; }
        public string Especie { get; set; }
        public string Marca { get; set; }
        public string Numero { get; set; }
        public string PesoBruto { get; set; }
        public string PesoLiquido { get; set; }       
        public string MeioPagamento { get; set; }
        public string FormaPagamento { get; set; }  //FALTOU NO BANCO
        public string NumeroParcelas { get; set; }
        public string ChaveAcessoNFE { get; set; }
        public string FretePagoPor { get; set; }

        public string CfopId { get; set; }
        public virtual Cfop CfopX { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente ClienteX { get; set; }

        public int FornecedorId { get; set; }
        public virtual Fornecedor FornecedorX { get; set; }

        public int TransportadoraId { get; set; }
        public virtual Transportadora TransportadoraX { get; set; }

        public virtual ICollection<NotaFiscalItem> NotaFiscalItemX { get; set; }

    }
}
