using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Nivel_Acesso
    {
        public int idnivel_acesso { get; set; }

        public Tipo_Usuario tipo_Usuario { get; set; }

        public Pagina pagina { get; set; }

    }
}
