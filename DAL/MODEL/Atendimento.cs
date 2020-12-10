using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public enum EnumNivelDificuldadeAtendimento
    {
        Baixo,
        Medio,
        Alto
    }

    public class Atendimento
    {
        public int Id { get; set; }
        public DateTime DataAtendimento { get; set; }       
        public DateTime DataLancamentoSistema { get; set; }
        public string NomeSolicitante { get; set; }
        public string SolicitacaoCliente { get; set; }
        public string ProcedimentoRealizado { get; set; }
        public string Observacao { get; set; }
        public string CobrarServico { get; set; }
        public double ValorServico { get; set; }
        public int TempoExecucao { get; set; }
        public string LoteCobranca { get; set; }
        public string VendaServico { get; set; }
        public string AtendimentoConcluido { get; set; }
        public DateTime DataConclusao { get; set; }
        public DateTime DataCobranca { get; set; }
        public string HouveFalhaCliente { get; set; }
        public string HouveFalhaNossa { get; set; }
        public string DescricaoFalha { get; set; }
        public EnumNivelDificuldadeAtendimento NivelDificuldadeAtendimento { get; set; }
        public string TempoDeAtendimento { get; set; }

        public int ClienteId { get; set; }
        public int AtendenteId { get; set; }
        public int SolicitanteId { get; set; }

        public virtual Cliente ClienteX { get; set; }
        public virtual Atendente AtendenteX { get; set; }
        //public virtual Solicitante SolicitanteX { get; set; }
    }
}
