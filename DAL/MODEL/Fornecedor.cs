﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Fornecedor
    {
        public Fornecedor()
        {
            this.NotaFiscalX = new List<NotaFiscal>();
            //this.ContasPagarX = new List<ContasPagar>();
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
        public string ComplementoEnd { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public int CodCidade { get; set; }
        public int CodPais { get; set; }
        public int DDD_NFE { get; set; }
        public string TelefoneNFE { get; set; }
        public string Contato { get; set; }

        public virtual ICollection<NotaFiscal> NotaFiscalX { get; set; }
        //public virtual ICollection<ContasPagar> ContasPagarX { get; set; }
    }
}
