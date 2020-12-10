using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Cidade
    {
        public int CidadeId { get; set; }
        public string Nome { get; set; }

        public int FK_EstadoId { get; set; }
        public virtual Estado EstadoX { get; set; }
    }
}
