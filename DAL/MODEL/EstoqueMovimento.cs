using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class EstoqueMovimento
    {
        public int EstoqueMovimentoId { get; set; }
        public int FK_ProdutoId { get; set; }
        public decimal EstoqueInicial { get; set; }
        public decimal EstoqueFinal { get; set; }
        public decimal Quantidade { get; set; }
        public DateTime DataEmissao { get; set; }
        public int Origem { get; set; }

        public virtual Produto Produtos { get; set; }
    }
}
