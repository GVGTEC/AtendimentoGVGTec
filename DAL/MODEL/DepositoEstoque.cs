using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class DepositoEstoque
    {
        public DepositoEstoque()
        {
            this.EstoqueX = new List<Estoque>();
        }
        public int DepositoId { get; set; }
        public String Descricao { get; set; }

        public virtual ICollection<Estoque> EstoqueX { get; set; }
    }
}

