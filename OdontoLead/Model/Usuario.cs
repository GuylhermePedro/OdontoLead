using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public class Usuario
    {
        public int idUsuario { get; set; }
        public String Nome { get; set; }
        public String Cpf { get; set; }

        public String Email { get; set; }

        public String Telefone_usuario { get; set; }

        public String Senha { get; set; }

        public Clinica clinica { get; set; }

    }
}
