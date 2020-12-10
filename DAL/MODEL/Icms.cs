using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.MODEL
{
    public class Icms
    {
        public Icms()
        {
        }

        public int Id { get; set; }
        public string UF { get; set; }
        public decimal AliquotaIcms { get; set; }
        public decimal AliquotaIcms_ST { get; set; }
        public decimal MVA { get; set; }
        public decimal FCP { get; set; }
    }
}
