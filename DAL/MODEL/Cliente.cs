using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Cliente
    {
        public Cliente()
        {
            this.SolicitanteX = new List<Solicitante>();
            this.FilialX = new List<Filial>();
            this.AtendimentoX = new List<Atendimento>();

            List<Cliente> listaclientes = new List<Cliente>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Pessoa { get; set; }
        public string CGC { get; set; }
        public string CPF { get; set; }
        public string IE { get; set; }
        public string RG { get; set; }
        public string Endereco { get; set; }
        public int NumeroEnd { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Contato { get; set; }
        public DateTime DataCadastro { get; set; }

        public IEnumerable<Cliente> ToList()
        {
            throw new NotImplementedException();
        }

        public virtual ICollection<Solicitante> SolicitanteX { get; set; }
        public virtual ICollection<Filial> FilialX { get; set; }
        public virtual ICollection<Atendimento> AtendimentoX { get; set; }
    }
}
