using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Produto
    {
        public Produto()
        {
            //this.PedidoPrincipalItemX = new List<PedidoPrincipalItem>();
            //this.PedidoSecundarioItemX = new List<PedidoSecundarioItem>();
            //this.EstoqueMovimentoX = new List<EstoqueMovimento>();
        }

        public int Id { get; set; }
        public String Descricao { get; set; }
        public String CodigoBarras { get; set; }
        public Decimal PrecoCusto { get; set; }
        public Decimal MargemLucro { get; set; }
        public Decimal PrecoVenda { get; set; }
        public Decimal EstoqueAtual { get; set; }
        public Decimal EstoqueMinimo { get; set; }

        //public virtual ICollection<PedidoPrincipalItem> PedidoPrincipalItemX { get; set; }
        //public virtual ICollection<PedidoSecundarioItem> PedidoSecundarioItemX { get; set; }

        //public virtual ICollection<EstoqueMovimento> EstoqueMovimentoX { get; set; }
    }

    class Long
    {
    }
}
