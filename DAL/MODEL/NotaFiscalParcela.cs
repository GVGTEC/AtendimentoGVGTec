using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class NotaFiscalParcela
    {
        public int Id { get; set; }
        public DateTime DataVencimentoParcela { get; set; }
        public Decimal ValorParcela { get; set; }

        public int NotaFiscalId { get; set; }

        public virtual NotaFiscal NotaFiscalX { get; set; }
    }
}
