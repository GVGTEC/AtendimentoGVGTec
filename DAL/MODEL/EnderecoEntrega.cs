using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class EnderecoEntrega
    {
        public int EnderecoEntregaId { get; set; }
        public string EnderecoEnt { get; set; }
        public string BairroEnt { get; set; }
        public string CidadeEnt { get; set; }
        public string EstadoEnt { get; set; }
        public string CEPEnt { get; set; }
        public string ContatoEnt { get; set; }
        public string TelefoneEnt { get; set; }
        public string EmailEnt { get; set; }

        public int? FK_ClienteId { get; set; }

        public virtual Cliente Clientes { get; set; }

        public ICollection<Locacao> Locacaos { get; set; }
    }
}
