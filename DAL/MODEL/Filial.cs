using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Filial
    {
        public Filial()
        {
            this.SolicitanteX = new List<Solicitante>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string AtivoInativo { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente ClienteX { get; set; }

        public virtual ICollection<Solicitante> SolicitanteX { get; set; }
    }
}
