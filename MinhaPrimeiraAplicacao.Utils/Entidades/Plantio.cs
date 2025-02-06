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
    public class Plantio
    {
        public int Id { get; set; }
        public int Plantacao_Id { get; set; }
        public DateTime Data_Plantio { get; set; }
        public string Tipo_Milho { get; set; }
        public int Quantidade_Sementes { get; set; }
        public int Hectares_Plantados { get; set; }

        public static Plantio Get(int id)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConnection.CONNECTION_STRING))
                {
                    conn.Open();
                    var query = "SELECT ID, Plantacao_Id, Data_Plantio, Tipo_Milho, Quantidade_Sementes, Hectares_Plantados FROM PLANTIO WHERE ID = @id";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Plantio
                                {
                                    Id = reader.GetInt32("ID"),
                                    Plantacao_Id = reader.GetInt32("Plantação ID"),
                                    Data_Plantio = reader.GetDateTime("Data de Plantio"),
                                    Tipo_Milho = reader.GetString("Tipo do Milho"),
                                    Quantidade_Sementes = reader.GetInt32("Quantidade de sementes plantadas"),
                                    Hectares_Plantados = reader.GetInt32("Hectares Plantados")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar plantio: {ex.Message}");
            }

            return null;
        }

        public static List<Plantio> GetAll()
        {
            var result = new List<Plantio>();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DBConnection.CONNECTION_STRING))
                {
                    conn.Open();
                    var query = "SELECT ID, Plantacao_Id, Data_Plantio, Tipo_Milho, Quantidade_Sementes, Hectares_Plantados FROM PLANTIO";


                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(new Plantio
                                {
                                    Id = reader.GetInt32("ID"),
                                    Plantacao_Id = reader.GetInt32("Plantação ID"),
                                    Data_Plantio = reader.GetDateTime("Data de Plantio"),
                                    Tipo_Milho = reader.GetString("Tipo do Milho"),
                                    Quantidade_Sementes = reader.GetInt32("Quantidade de sementes plantadas"),
                                    Hectares_Plantados = reader.GetInt32("Hectares Plantados")
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao buscar todos os plantios: {ex.Message}");
            }

            return result;
        }
    }
}