using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Estoque
    {
        public int Id { get; set; }
        public int EstoqueAtual { get; set; }
        public int EstoqueMinimo { get; set; }
        public int FK_ProdutoId { get; set; }
        public int FK_LocalId { get; set; }

        //public virtual <Produto> Produtos { get; set; }
    }
}
