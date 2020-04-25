using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Pagina
    {
        public int idPagina { get; set; }

        public String url { get; set; }

        public String descricao { get; set; }
    }
}
