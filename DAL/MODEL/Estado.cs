using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Estado
    {
        public Estado()
        {
            this.CidadeX = new List<Cidade>();
        }

        public int EstadoId { get; set; }
        public string Nome { get; set; }

        public virtual ICollection<Cidade> CidadeX { get; set; }
    }
}
