using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ClinicaController
    {
        public Clinica logar(Clinica objEntrada)
        {
            if (String.IsNullOrEmpty(objEntrada.cnpj))
                throw new ConsistenciaException("Por favorm preencha o campo cnpj!");

            if (String.IsNullOrEmpty(objEntrada.senha))
                throw new ConsistenciaException("Por favor, prencha o campo senha!");

            Conexao conx = new Conexao();

            MySqlCommand cmd = new MySqlCommand(@"
                select idclinica,
                       nome_clinica,
                       cnpj,
                       senha
                from clinica
                where cnpj = @cnpj
                and senha = md5(@senha)");

            conx.Abrir();

            cmd.Parameters.Add(new MySqlParameter("cnpj", objEntrada.cnpj));
            cmd.Parameters.Add(new MySqlParameter("senha", objEntrada.senha));

            MySqlDataReader reader = conx.Pesquisar(cmd);

            if (!reader.Read())
            {
                conx.Fechar();
                throw new ConsistenciaException("Cnpj ou senha inválido!");
            }

            Clinica cl = new Clinica();

            cl.idclinica = reader.GetInt32(0);
            cl.nome_clinica = reader.GetString(1);
            cl.cnpj = reader.GetString(2);
            cl.senha = reader.GetString(3);

            reader.Close();

            conx.Fechar();

            return cl;
        }

        public void incluir (Clinica objEntrada)
        {
            if (String.IsNullOrEmpty(objEntrada.nome_clinica))
            {
                throw new ConsistenciaException("Por favor, digite o Nome da Clínica.");
            }
            else
            {
                if (String.IsNullOrEmpty(objEntrada.cnpj))
                {
                    throw new ConsistenciaException("Por favor, digite o CNPJ.");
                }
                else
                {
                    if (String.IsNullOrEmpty(objEntrada.senha))
                    {
                        throw new ConsistenciaException("Por favor, digite a senha.");
                    }
                }
            }

            MySqlCommand cmd = new MySqlCommand(@"select * from clinica where cnpj = @cnpj");

            cmd.Parameters.Add(new MySqlParameter("cnpj", objEntrada.cnpj));

            Conexao c = new Conexao();

            c.Abrir();

            MySqlDataReader reader = c.Pesquisar(cmd);

            bool verificar = reader.Read();

            c.Fechar();

            if (!verificar)
            {

                cmd = new MySqlCommand("insert into clinica values(default, @nome_clinica, @cnpj, md5(@senha))");

                cmd.Parameters.Add(new MySqlParameter("nome_clinica", objEntrada.nome_clinica));
                cmd.Parameters.Add(new MySqlParameter("cnpj", objEntrada.cnpj));
                cmd.Parameters.Add(new MySqlParameter("senha", objEntrada.senha));

                c.Abrir();
                c.Executar(cmd);
                c.Fechar();
            }
            else
            {
                throw new ConsistenciaException("Esse CNPJ já está cadastrado, entre em contato com o Suporte para Recuperar sua Senha.");
            }
        }

    }
}
