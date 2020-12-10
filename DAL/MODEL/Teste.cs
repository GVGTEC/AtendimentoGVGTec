using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Teste
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Tempo { get; set; }
        public int ClienteId { get; set; }

        public virtual Cliente ClienteX { get; set; }
    }
}
