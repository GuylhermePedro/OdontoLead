using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class StatusController
    {
        public List<Status> Listar(Status objEntrada)
        {

            MySqlCommand cmd = null;

                cmd = new MySqlCommand(" select status_lead.idstatus_lead, status_lead.descricao_status from status_lead");

            Conexao c = new Conexao();

            c.Abrir();

            MySqlDataReader reader = c.Pesquisar(cmd);

            List<Status> lstRetorno = new List<Status>();

            while (reader.Read())
            {
                Status status = new Status();

                status.idStatus = reader.GetInt32(0);
                status.Descricao_status = reader.GetString(1);

                lstRetorno.Add(status);

            }

            c.Fechar();

            return lstRetorno;

        }
    }
}
