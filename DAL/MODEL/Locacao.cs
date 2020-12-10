using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Locacao
    {
        public int LocacaoId { get; set; }
        public DateTime? DataEmissao { get; set; }
        public DateTime? DataEntrega { get; set; }
        public DateTime? DataRemocao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public int Quantidade { get; set; }
        public Decimal PrecoUnitario { get; set; }
        public Decimal PrecoTotal { get; set; }
        public Decimal DescontoVR { get; set; }
        public Decimal DescontoPC { get; set; }

        public int? FK_ClienteId { get; set; }
        public int? FK_EnderecoEntregaId { get; set; }

        public virtual Cliente Clientes { get; set; }
        public virtual EnderecoEntrega EnderecoEntregas { get; set; }
    }
}
