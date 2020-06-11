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
                            else
                            {
                                if (String.IsNullOrEmpty(objEntrada.status))
                                {
                                    throw new ConsistenciaException("Por favor, digite o Status do Lead");
                                }
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
                cmd = new MySqlCommand("insert into lead values(default, @nome, @tel, @sexo, @data, @clinica, @origem, @status)");

                cmd.Parameters.Add(new MySqlParameter("nome", objEntrada.nome_lead));
                cmd.Parameters.Add(new MySqlParameter("tel", objEntrada.fone_lead));
                cmd.Parameters.Add(new MySqlParameter("sexo", objEntrada.sexo_lead));
                cmd.Parameters.Add(new MySqlParameter("data", objEntrada.data_lead));
                cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));
                cmd.Parameters.Add(new MySqlParameter("origem", objEntrada.origem_lead));
                cmd.Parameters.Add(new MySqlParameter("status", objEntrada.status));


                c.Abrir();
                c.Executar(cmd);
                c.Fechar();

            }
            else
            {
                throw new ConsistenciaException("Esse Telefone já está cadastrado, entre na aba de pesquisa para alterar o Contato.");
            }
        }

            public void Atualizar(Lead objEntrada)
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
                            else
                            {
                                if (String.IsNullOrEmpty(objEntrada.status))
                                {
                                    throw new ConsistenciaException("Por favor, digite o Status do Lead");
                                }
                            }
                        }
                }

                MySqlCommand cmd = new MySqlCommand("update lead set nome_lead = @nome , telefone_lead = @fone, sexo= @sexo , origem_lead = @origem , status = @status where idclinica = @idclincia and lead.idlead = @id");

                cmd.Parameters.Add(new MySqlParameter("nome", objEntrada.nome_lead));
                cmd.Parameters.Add(new MySqlParameter("fone", objEntrada.fone_lead));
                cmd.Parameters.Add(new MySqlParameter("sexo", objEntrada.sexo_lead));
                cmd.Parameters.Add(new MySqlParameter("origem", objEntrada.origem_lead));
                cmd.Parameters.Add(new MySqlParameter("status", objEntrada.status));
                cmd.Parameters.Add(new MySqlParameter("idclincia", objEntrada.clinina.idclinica));
                cmd.Parameters.Add(new MySqlParameter("id", objEntrada.idlead));

                Conexao c = new Conexao();
                c.Abrir();
                c.Executar(cmd);
                c.Fechar();
            }
        }
            public List<Lead> Listar(Lead objEntrada)
            {

                MySqlCommand cmd = null;


            if (!String.IsNullOrEmpty(objEntrada.nome_lead))
            {
                cmd = new MySqlCommand("select lead.idlead, lead.nome_lead, lead.telefone_lead, lead.sexo, lead.data_lead, lead.origem_lead, lead.status from lead where lead.nome_lead like @nome and lead.idclinica = @clinica");

                cmd.Parameters.Add(new MySqlParameter("nome", "%" + objEntrada.nome_lead + "%"));
                cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));

            }
            else
            {
                cmd = new MySqlCommand("select lead.idlead, lead.nome_lead, lead.telefone_lead, lead.sexo, lead.data_lead, lead.origem_lead, lead.status from lead where lead.idclinica = @clinica");
                cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));
            }

                Conexao c = new Conexao();

                c.Abrir();

                MySqlDataReader reader = c.Pesquisar(cmd);

                List<Lead> lstRetorno = new List<Lead>();

                while (reader.Read())
                {
                    Lead lead = new Lead();

                    lead.idlead = reader.GetInt32(0);
                    lead.nome_lead = reader.GetString(1);
                    lead.fone_lead = reader.GetString(2);
                    lead.sexo_lead = reader.GetString(3);
                    lead.data_lead = reader.GetDateTime(4);
                    lead.origem_lead = reader.GetString(5);
                    lead.status = reader.GetString(6);


                    lstRetorno.Add(lead);

                }

                c.Fechar();

                return lstRetorno;

            }

            public void Excluir(Lead objEntrada)
            {

                MySqlCommand cmd = new MySqlCommand("delete from lead where idlead = @lead");

                cmd.Parameters.Add(new MySqlParameter("lead", objEntrada.idlead));

                Conexao c = new Conexao();
                c.Abrir();
                c.Executar(cmd);
                c.Fechar();

            }

            public List<Lead> Exportar(Lead objEntrada)
        {

            MySqlCommand cmd = null;


            if (!String.IsNullOrEmpty(objEntrada.origem_lead) && !String.IsNullOrEmpty(objEntrada.status))
            {
                cmd = new MySqlCommand("select lead.nome_lead, lead.telefone_lead, lead.sexo, lead.data_lead, lead.origem_lead, lead.status from lead where lead.origem_lead = @origem and lead.idclinica = @clinica and lead.status = @status");


                cmd.Parameters.Add(new MySqlParameter("origem", objEntrada.origem_lead));
                cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));
                cmd.Parameters.Add(new MySqlParameter("status", objEntrada.status));

            }
            else
            {
                if (!String.IsNullOrEmpty(objEntrada.origem_lead))
                {
                    cmd = new MySqlCommand("select lead.nome_lead, lead.telefone_lead, lead.sexo, lead.data_lead, lead.origem_lead, lead.status from lead where lead.origem_lead = @origem and lead.idclinica = @clinica");

                    cmd.Parameters.Add(new MySqlParameter("origem", objEntrada.origem_lead));
                    cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));

                }
                else
                {
                    if (!String.IsNullOrEmpty(objEntrada.status))
                    {
                        cmd = new MySqlCommand("select lead.nome_lead, lead.telefone_lead, lead.sexo, lead.data_lead, lead.origem_lead, lead.status from lead where lead.status = @status and lead.idclinica = @clinica");

                        cmd.Parameters.Add(new MySqlParameter("status", objEntrada.status));
                        cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));

                    }
                    else
                    {
                        cmd = new MySqlCommand("select lead.nome_lead, lead.telefone_lead, lead.sexo, lead.data_lead, lead.origem_lead, lead.status from lead where lead.idclinica = @clinica");
                        cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));
                    }
                }
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
                lead.origem_lead = reader.GetString(4);
                lead.status = reader.GetString(5);


                lstRetorno.Add(lead);

            }

            c.Fechar();

            return lstRetorno;

        }

            public List<Lead> ListarAlt(Lead objEntrada)
        {

            MySqlCommand cmd = null;


             cmd = new MySqlCommand("select lead.idlead, lead.nome_lead, lead.telefone_lead, lead.sexo, lead.data_lead, lead.origem_lead, lead.status from lead where lead.idclinica = @clinica and lead.idlead = @id");
             cmd.Parameters.Add(new MySqlParameter("clinica", objEntrada.clinina.idclinica));
             cmd.Parameters.Add(new MySqlParameter("id", objEntrada.idlead));



            Conexao c = new Conexao();

            c.Abrir();

            MySqlDataReader reader = c.Pesquisar(cmd);

            List<Lead> lstRetorno = new List<Lead>();

            while (reader.Read())
            {
                Lead lead = new Lead();

                lead.idlead = reader.GetInt32(0);
                lead.nome_lead = reader.GetString(1);
                lead.fone_lead = reader.GetString(2);
                lead.sexo_lead = reader.GetString(3);
                lead.data_lead = reader.GetDateTime(4);
                lead.origem_lead = reader.GetString(5);
                lead.status = reader.GetString(6);


                lstRetorno.Add(lead);

            }

            c.Fechar();

            return lstRetorno;

        }

    }
}