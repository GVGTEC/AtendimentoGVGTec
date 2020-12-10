using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Compra
    {
        public int Id { get; set; }
        public String Descricao { get; set; }
        public DateTime Data { get; set; }
        public String Fornecedor { get; set; }
        public String Endereco { get; set; }
        public String Telefone { get; set; }
        public String Contato { get; set; }
        public String Email { get; set; }
        public String Site { get; set; }
        public Decimal ValorUnitario { get; set; }
        public Decimal ValorTotal { get; set; }
        public Decimal Quantidade { get; set; }
        public String Garantia { get; set; }
        public String Observacao { get; set; }
    }
}
