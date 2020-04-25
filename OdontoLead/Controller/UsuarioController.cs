using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class UsuarioController
    {
        public Usuario logar (Usuario objEntrada)
        {
            if (String.IsNullOrEmpty(objEntrada.Cpf))
                throw new ConsistenciaException("Por favorm preencha o campo cpf!");

            if (String.IsNullOrEmpty(objEntrada.Senha))
                throw new ConsistenciaException("Por favor, prencha o campo senha!");

            Conexao conx = new Conexao();

            MySqlCommand cmd = new MySqlCommand(@"
                select idusuario,
                       nome_usuario,
                       cpf_usuario,
                       email,
                       telefone_usuario,
                       senha
                from usuario
                where cpf_usuario = @cpf
                and senha = md5('@senha') ");

            conx.Abrir();

            cmd.Parameters.Add(new MySqlParameter("cpf", objEntrada.Cpf));
            cmd.Parameters.Add(new MySqlParameter("senha", objEntrada.Senha));

            MySqlDataReader reader = conx.Pesquisar(cmd);

            if (!reader.Read())
            {
                conx.Fechar();
                throw new ConsistenciaException("Usuario ou senha inválido!");
            }

            Usuario us = new Usuario();

            us.idUsuario = reader.GetInt32(0);
            us.Nome = reader.GetString(1);
            us.Email = reader.GetString(2);
            us.Telefone_usuario = reader.GetString(3);
            us.Senha = reader.GetString(4);

            reader.Close();

            conx.Fechar();

            return us;
        }

        public void incluir (Usuario objEntrada)
        {
            if (String.IsNullOrEmpty(objEntrada.Nome))
            {
                throw new ConsistenciaException("Por favor, digite o Nome.");
            }
            else
            {
                if (String.IsNullOrEmpty(objEntrada.Cpf))
                {
                    throw new ConsistenciaException("Por favor, digite o Cpf.");
                }
                else
                {
                    if (String.IsNullOrEmpty(objEntrada.Email))
                    {
                        throw new ConsistenciaException("Por favor, digite o Email.");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(objEntrada.Telefone_usuario))
                        {
                            throw new ConsistenciaException("Por favor, digite o Telefone.");
                        }
                        else
                        {
                            if (String.IsNullOrEmpty(objEntrada.Senha))
                            {
                                throw new ConsistenciaException("Por favor, digite a Senha.");
                            }
                        }
                    }
                }
            }

            MySqlCommand cmd = new MySqlCommand(@"select * from usuario where cpf_usuario = @cpf");

            cmd.Parameters.Add(new MySqlParameter("cpf", objEntrada.Cpf));

            Conexao c = new Conexao();

            c.Abrir();

            MySqlDataReader reader = c.Pesquisar(cmd);

            bool verificar = reader.Read();

            c.Fechar();

            if (!verificar)
            {

                cmd = new MySqlCommand("insert into usuario values(default, @nome, @cpf, @email, @tel, MD5('@senha'), null)");

                cmd.Parameters.Add(new MySqlParameter("nome", objEntrada.Nome));
                cmd.Parameters.Add(new MySqlParameter("cpf", objEntrada.Cpf));
                cmd.Parameters.Add(new MySqlParameter("email", objEntrada.Email));
                cmd.Parameters.Add(new MySqlParameter("tel", objEntrada.Telefone_usuario));
                cmd.Parameters.Add(new MySqlParameter("senha", objEntrada.Senha));

                c.Abrir();
                c.Executar(cmd);
                c.Fechar();
            }
            else
            {
                throw new ConsistenciaException("Esse Cpf já está cadastrado");
            }
        }
    }
}
