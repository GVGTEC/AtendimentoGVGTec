using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class FormaPagamento
    {
        public FormaPagamento()
        {
            this.PedidoPrincipalX = new List<PedidoPrincipal>();
        }

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string TipoCartao { get; set; }
        public int DiasCredito { get; set; }
        public decimal DescontoAdm { get; set; }
        public int ECF { get; set; }
        public string DescricaoECF { get; set; }
        public int Ordem { get; set; }

        public virtual ICollection<PedidoPrincipal> PedidoPrincipalX { get; set; }
    }
}
