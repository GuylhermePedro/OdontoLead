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

        public String fone_lead { get; set; }

        public DateTime data_lead { get; set; }

        public String sexo_lead { get; set; }

        public String origem_lead { get; set; }

        public String descricao_lead { get; set; }

        public String status { get; set; }

        public Clinica clinina { get; set; }


    }
}
