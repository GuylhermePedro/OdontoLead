using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Clinica
    {
        public int idclinica { get; set; }

        public String nome_clinica { get; set; }

        public String cidade_clinica { get; set; }

        public String cnpj { get; set; }

        public Estado estado { get; set; }
    }
}
