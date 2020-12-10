using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Solicitante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string AtivoInativo { get; set; }

        public int ClienteId { get; set; }
        public virtual Cliente ClienteX { get; set; }

        public int FilialId { get; set; }
        public virtual Filial FilialX { get; set; }
    }
}
