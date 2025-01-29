using MinhaPrimeiraAplicacao.Utils.Database;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraAplicacao.Utils.Entidades
{
    public class Fazenda
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Tamanho { get; set; }

        public static Fazenda Get(int id)
        {

            using (MySqlConnection conn = new MySqlConnection(DBConnection.CONNECTION_STRING))
            {
                conn.Open();
                var query = $"SELECT ID, NOME, ENDERECO, TAMANHO FROM FAZENDA WHERE ID = {id}";
                var cmd = new MySqlCommand(query, conn);

                var reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new Fazenda()
                    {
                        ID = reader.GetInt32("ID"),
                        Nome = reader.GetString("NOME"),
                        Endereco = reader.GetString("ENDERECO"),
                        Tamanho = reader.GetInt32("TAMANHO")
                    };
                }
            }

            return null;
        }

        public static List<Fazenda> GetAll()
        {
            var result = new List<Fazenda>();

            using (MySqlConnection conn = new MySqlConnection(DBConnection.CONNECTION_STRING))
            {
                conn.Open();
                var query = "SELECT ID, NOME, ENDERECO, TAMANHO FROM FAZENDA";
                var cmd = new MySqlCommand(query, conn);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    result.Add(new Fazenda { 
                        ID = reader.GetInt32("ID"), 
                        Nome = reader.GetString("NOME"),
                        Endereco = reader.GetString("ENDERECO"),
                        Tamanho = reader.GetInt32("TAMANHO")
                    });
                }
            }

            return result;
        }
    }
}
