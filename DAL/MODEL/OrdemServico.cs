using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class OrdemServico
    {
        public int Id { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public string NomeSolicitante { get; set; }
        public string Descricao { get; set; }
        public string Observacao { get; set; }
        public string CobrarServico { get; set; }
        public double ValorServico { get; set; }
        public int TempoServico { get; set; }
        public string LoteCobranca { get; set; }

        public int ClienteId { get; set; }
        public int AtendenteId { get; set; }
        public int SolicitanteId { get; set; }

        public virtual Cliente ClienteX { get; set; }
        public virtual Atendente AtendenteX { get; set; }
    }
}
