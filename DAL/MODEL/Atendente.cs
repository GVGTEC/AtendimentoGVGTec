using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Atendente
    {
        public Atendente()
        {
            this.AtendimentoX = new List<Atendimento>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string AtivoInativo { get; set; }

        public virtual ICollection<Atendimento> AtendimentoX { get; set; }
    }
}
