using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Lead
    {
        public int idlead { get; set; }

        public String nome_lead { get; set; }

        public int fone_lead { get; set; }

        public DateTime data_lead { get; set; }

        public Origem origem { get; set; }
    }
}
