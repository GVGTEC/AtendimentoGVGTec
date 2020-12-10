using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Entity Framework Code First – Migrations
//https://msdn.microsoft.com/pt-br/library/jj856238.aspx

namespace DAL.MODEL
{
    public class PedidoSecundario
    {
        public PedidoSecundario()
        {
            this.PedidoSecundarioItemX = new List<PedidoSecundarioItem>();
        }

        public int Id { get; set; }
        public DateTime DataEmissao { get; set; }
        public Decimal DescontoVR { get; set; }
        public Decimal DescontoPC { get; set; }
        public Decimal SubTotal { get; set; }
        public Decimal Total { get; set; }
        public string ChaveAcessoSAT { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente ClienteX { get; set; }
        public virtual ICollection<PedidoSecundarioItem> PedidoSecundarioItemX { get; set; }
    }
}

