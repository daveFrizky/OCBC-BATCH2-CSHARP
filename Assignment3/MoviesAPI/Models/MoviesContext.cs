using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System;
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

        public JsonResult AddMovies(MoviesItem item)
        {
            string result;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO movies VALUES ({item.Id},'{item.Name}','{item.Genre}','{item.Duration}" +
                    $"','{item.ReleaseDate.ToString("yyyy-MM-dd HH:mm:ss")}')", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        result = "Data Added!";
                    }
                    else
                    {
                        result = "Something Went Wrong";
                    }
                }
            }
            return new JsonResult(result);
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

        public JsonResult UpdateById(string id,MoviesItem item)
        {
            string result;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    $"UPDATE movies SET  Id={item.Id},Name='{item.Name}',Genre='{item.Genre}',Duration='{item.Duration}" +
                    $"',ReleaseDate='{item.ReleaseDate.ToString("yyyy-MM-dd HH:mm:ss")}'  WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        result = "Data Updated!";
                    }
                    else
                    {
                        result = "Something Went Wrong";
                    }
                }
            }
            return new JsonResult(result);
        }

        public JsonResult DeleteById(string id)
        {
            string result;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM movies WHERE Id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader != null)
                    {
                        result = "Data Deleted!";
                    }
                    else
                    {
                        result = "Something Went Wrong!";
                    }
                }
            }
            return new JsonResult(result);
        }
    }
}
