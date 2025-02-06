using MySql.Data.MySqlClient;
using System;

namespace MinhaPrimeiraAplicacao.Utils.Database
{
    public class DBConnection
    {
        public const string CONNECTION_STRING = "Server=localhost; Database=cornmeals; User ID=root; Password=root";

        public bool TestarConexao()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CONNECTION_STRING))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (MySqlException ex)
            {
                // Logar ou exibir a mensagem detalhada do erro (opcional)
                Console.WriteLine($"Erro de conexão com o banco de dados: {ex.Message}");
                return false;
            }
            catch (Exception ex)
            {
                // Captura de outros erros que não sejam específicos do MySQL
                Console.WriteLine($"Erro inesperado: {ex.Message}");
                return false;
            }
        }
    }
}
