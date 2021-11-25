using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sesi7
{
    public class Config
    {
        string ConnectionString = "";
        public MySqlConnection connection= null;
        public string server = "127.0.0.1";
        public string user = "root";
        public string password ="12345";
        DataSet ds;
        DataTable dt;
        public string table = "user_info";
        public string ConnectionType = "";
        string RecordSource = "";
        DataGridView tempdata;

        public Config() 
        {
            
        }

        public void Connect(string db_name)
        {
            try
            {
                ConnectionString = "SERVER="+server+";DATABASE="+db_name+";UID="+user+";PASSWORD="+password+";";
                connection= new MySqlConnection(ConnectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void ExecuteSql(string sql_command)
        {
            nowquiee(sql_command);
        }

        public void nowquiee(string sql_conn)
        {
            try
            {
                MySqlConnection cs = new MySqlConnection(ConnectionString) ;
                cs.Open();
                MySqlCommand myc = new MySqlCommand(sql_conn,cs);
                myc.ExecuteNonQuery();
                cs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Execute(string sql_command)
        {
            RecordSource = sql_command;
            ConnectionType = table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                MySqlDataAdapter da2 = new MySqlDataAdapter(RecordSource,connection);
                DataSet tempds = new DataSet();
                da2.Fill(tempds,ConnectionType);
                //da2.Fill(tempds);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public string Results(int ROW,string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }

        public void ExecuteSelect(string sql_command)
        {
            RecordSource = sql_command;
            ConnectionType = table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command =RecordSource.ToUpper();
                MySqlDataAdapter da = new MySqlDataAdapter(RecordSource,connection);
                ds = new DataSet();
                da.Fill(ds,ConnectionType);
                da.Fill(dt);
                tempdata = new DataGridView();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public int Count()
        {
            return dt.Rows.Count;
        }
    }
}
