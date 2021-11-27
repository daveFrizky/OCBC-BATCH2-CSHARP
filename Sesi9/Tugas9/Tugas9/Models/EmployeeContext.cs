using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace Tugas9.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }

        public EmployeeContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jeniskelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")

                        });
                    }
                }
            }
            return list;
        }

        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee where id = @id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            nama = reader.GetString("nama"),
                            jeniskelamin = reader.GetString("jenis_kelamin"),
                            alamat = reader.GetString("alamat")

                        });
                    }
                }
            }
            return list;
        }

        public JsonResult AddEmployee(EmployeeItem item)
        {
            string result;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();

                MySqlCommand cmd = new MySqlCommand(
                    $"INSERT INTO employee VALUES ({item.id},'{item.nama}','{item.jeniskelamin}','{item.alamat}')", conn);
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

        public JsonResult UpdateById(string id, EmployeeItem item)
        {
            string result;
            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    $"UPDATE employee SET Id={item.id},Nama='{item.nama}',jenis_kelamin='{item.jeniskelamin}',Alamat='{item.alamat}' WHERE Id = @id", conn);
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
                MySqlCommand cmd = new MySqlCommand("DELETE FROM employee WHERE Id = @id", conn);
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
