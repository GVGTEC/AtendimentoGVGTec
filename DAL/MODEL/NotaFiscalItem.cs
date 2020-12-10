using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class NotaFiscalItem
    {
        //public int PedidoItemId { get; set; }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string CFOP { get; set; }
        public string CST { get; set; }
        //public string NCM { get; set; }
        public string Unidade { get; set; }
        public int Quantidade { get; set; }
        public Decimal PrecoUnitario { get; set; }
        public Decimal PrecoTotal { get; set; }
        public Decimal Desconto { get; set; }

        public string CST_ICMS { get; set; }
        public Decimal ICMS_BC { get; set; }
        public Decimal ICMS_VR { get; set; }
        public Decimal ICMS_PC { get; set; }

        public string CST_ICMS_ST { get; set; }
        public Decimal ICMS_ST_BC { get; set; }
        public Decimal ICMS_ST_VR { get; set; }
        public Decimal ICMS_ST_PC { get; set; }

        public string CST_PIS { get; set; }
        public Decimal PIS_BC { get; set; }
        public Decimal PIS_VR { get; set; }
        public Decimal PIS_PC { get; set; }

        public string  CST_COFINS { get; set; }
        public Decimal COFINS_BC { get; set; }
        public Decimal COFINS_VR { get; set; }
        public Decimal COFINS_PC { get; set; }

        public int ProdutoId { get; set; }
        public int NotaFiscalId { get; set; }

        public virtual Produto ProdutoX { get; set; }
        public virtual NotaFiscal NotaFiscalX { get; set; }
    }
}
