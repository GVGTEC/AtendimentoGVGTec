using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class ContasReceberParcela
    {
        public int ContasPagarParcelaId { get; set; }
        public int? FK_ContasPagarId { get; set; }
        public int Item { get; set; }
        public DateTime DataVencimento {get; set; }
        public DateTime DataPagamento { get; set; }
        public Decimal Valor { get; set; }
        public Decimal Desconto { get; set; }
        public Decimal Acrescimo { get; set; }
        public string  Descricao { get; set; }

        public virtual ContasReceber ContasReceber { get; set; }
    }
}
