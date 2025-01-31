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
        public int  ID { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public int Tamanho { get; set; }

        public static Fazenda Get(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConnection.CONNECTION_STRING))
                {
                    conn.Open();
                    var query = "SELECT ID, NOME, ENDERECO, TAMANHO FROM FAZENDA WHERE ID = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Fazenda
                                {
                                    ID = reader.GetInt32("ID"),
                                    Nome = reader.GetString("NOME"),
                                    Endereco = reader.GetString("ENDERECO"),
                                    Tamanho = reader.GetInt32("TAMANHO")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar fazenda: {ex.Message}");
            }

            return null;
        }

        public static List<Fazenda> GetAll()
        {
            var result = new List<Fazenda>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConnection.CONNECTION_STRING))
                {
                    conn.Open();
                    var query = "SELECT ID, NOME, ENDERECO, TAMANHO FROM FAZENDA";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(new Fazenda
                                {
                                    ID = reader.GetInt32("ID"),
                                    Nome = reader.GetString("NOME"),
                                    Endereco = reader.GetString("ENDERECO"),
                                    Tamanho = reader.GetInt32("TAMANHO")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar todas as fazendas: {ex.Message}");
            }

            return result;
        }
    }
}