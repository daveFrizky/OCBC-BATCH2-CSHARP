using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace MoviesAPI.Models
{
    public class MoviesContext
    {
        public string ConnectionString { get; set; }

        public MoviesContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<MoviesItem> GetAllMovies()
        {
            List<MoviesItem> list = new List<MoviesItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movies", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MoviesItem()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetDateTime("ReleaseDate")

                        });
                    }
                }
            }
            return list;
        }

        public List<MoviesItem> GetMoviesById(string id)
        {
            List<MoviesItem> list = new List<MoviesItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM movies where Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new MoviesItem()
                        {
                            Id = reader.GetInt32("Id"),
                            Name = reader.GetString("Name"),
                            Genre = reader.GetString("Genre"),
                            Duration = reader.GetString("Duration"),
                            ReleaseDate = reader.GetDateTime("ReleaseDate")

                        });
                    }
                }
            }
            return list;
        }
    }
}
