using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class PedidoPrincipalItem
    {
        //public int PedidoItemId { get; set; }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public Decimal PrecoUnitario { get; set; }
        public Decimal PrecoTotal { get; set; }
        public int QuantidadeEntregue { get; set; }

        public int ProdutoId { get; set; }
        public int PedidoPrincipalId { get; set; }

        public virtual Produto ProdutoX { get; set; }
        public virtual PedidoPrincipal PedidoPrincipalX { get; set; }
    }
}
