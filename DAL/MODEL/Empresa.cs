using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Empresa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string CGC { get; set; }
        public string IE { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string CodigoUF { get; set; }
        public string CodigoIBGE { get; set; }
        public string CNAE { get; set; }
        public decimal PisPC { get; set; }
        public decimal CofinsPC { get; set; }
        public string TipoEmissor { get; set; }
        public string Serie { get; set; }
        public string Ambiente { get; set; }
        public string VersaoLayout { get; set; }
        public string RegimeTributario { get; set; }
        public string PermitirCreditoICMS { get; set; }
        public decimal CreditoICMSPC { get; set; }
        public string Email { get; set; }
        public string CaminhoNfePastaEnvio { get; set; }
        public string CaminhoNfePastaRetorno { get; set; }
    }
}
