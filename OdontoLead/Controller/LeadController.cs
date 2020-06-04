using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class LeadController
    {
        public void incluir(Lead objEntrada)
        {
            if (String.IsNullOrEmpty(objEntrada.nome_lead))
            {
                throw new ConsistenciaException("Por favor, digite o Nome do Contato.");
            }
            else
            {
                if (String.IsNullOrEmpty(objEntrada.fone_lead))
                {
                    throw new ConsistenciaException("Por favor, digite o Telefone do Lead.");
                }
                else
                {
                    if (String.IsNullOrEmpty(objEntrada.data_lead.ToString()))
                    {
                        throw new ConsistenciaException("Por favor, digite a data de Contato.");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(objEntrada.origem_lead))
                        {
                            throw new ConsistenciaException("Por favor, digite a origem do Lead.");
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(objEntrada.sexo_lead))
                            {
                                throw new ConsistenciaException("Por favor, digite o genero do Lead");
                            }
                        }
                    }
                }
            }

            MySqlCommand cmd = new MySqlCommand(@"select * from lead where telefone_lead = @tel");

            cmd.Parameters.Add(new MySqlParameter("tel", objEntrada.fone_lead));

            Conexao c = new Conexao();

            c.Abrir();

            MySqlDataReader reader = c.Pesquisar(cmd);

            bool verificar = reader.Read();

            c.Fechar();

            if (!verificar)
            {

                cmd = new MySqlCommand("insert into lead values(default, @nome, @tel, @sexo, @data, @descricao, @clinica, @origem)");

                cmd.Parameters.Add(new MySqlParameter("nome", objEntrada.nome_lead));
                cmd.Parameters.Add(new MySqlParameter("tel", objEntrada.fone_lead));
                cmd.Parameters.Add(new MySqlParameter("sexo", objEntrada.sexo_lead));
                cmd.Parameters.Add(new MySqlParameter("data", objEntrada.data_lead));
                cmd.Parameters.Add(new MySqlParameter("descricao", objEntrada.descricao_lead));
                cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));
                cmd.Parameters.Add(new MySqlParameter("origem", objEntrada.origem_lead));

                c.Abrir();
                c.Executar(cmd);
                c.Fechar();
            }
            else
            {
                throw new ConsistenciaException("Esse Telefone já está cadastrado, entre na aba de pesquisa para alterar o Contato.");
            }
        }

        public List<Lead> Listar(Lead objEntrada)
        {

            MySqlCommand cmd = null;

            if (!String.IsNullOrEmpty(objEntrada.fone_lead))
            {
                cmd = new MySqlCommand("select lead.nome_lead, lead.telefone_lead, lead.sexo, lead.data_lead, lead.descricao_lead, lead.origem_lead from lead where lead.telefone_lead = @tel and lead.idclinica = @clinica");


                cmd.Parameters.Add(new MySqlParameter("tel", objEntrada.fone_lead));
                cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));

            }
            else
            {
                cmd = new MySqlCommand("select lead.nome_lead, lead.telefone_lead, lead.sexo, lead.data_lead, lead.descricao_lead, lead.origem_lead from lead where lead.idclinica = @clinica");
                cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));
            }

            Conexao c = new Conexao();

            c.Abrir();

            MySqlDataReader reader = c.Pesquisar(cmd);

            List<Lead> lstRetorno = new List<Lead>();

            while (reader.Read())
            {
                Lead lead = new Lead();

                lead.nome_lead = reader.GetString(0);
                lead.fone_lead = reader.GetString(1);
                lead.sexo_lead = reader.GetString(2);
                lead.data_lead = reader.GetDateTime(3);
                lead.descricao_lead = reader.GetString(4);
                lead.origem_lead = reader.GetString(5);

                lstRetorno.Add(lead);

            }

            c.Fechar();

            return lstRetorno;

        }
    }
}
