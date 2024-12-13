using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Runtime.CompilerServices;

namespace _045_Mesa_F2
{
    public class Database
    {

        string conn_str = "";
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbDataAdapter adp;

        public Database()
        {
            conn_str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\Khester Mesa\\Downloads\\dpPirates.accdb\"";
            conn = new OleDbConnection(conn_str);
        }

        public OleDbConnection Connection
        {
            get { return conn; }
        }


        public void OpenConnection()
        {
            if (this.Connection.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (this.Connection.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }


        // query function

        public DataTable get_pirate_group()
        {
            string query = "SELECT DISTINCT pirategroup as [PIRATE GROUP] FROM pirates";
            DataTable dt;
            OpenConnection();
            using (adp = new OleDbDataAdapter(query, conn))
            {
                dt = new DataTable();
                adp.Fill(dt);
                CloseConnection();
                return dt;
            }
        }
        public DataTable get_information()
        {
            string query = "SELECT ID, piratename as [ALIAS], givenname as [GIVEN NAME], age, pirategroup as [PIRATE GROUP], bounty as [BOUNTY] FROM pirates";
            DataTable dt;
            OpenConnection();
            using (adp = new OleDbDataAdapter(query, conn))
            {
                dt = new DataTable();
                adp.Fill(dt);
                CloseConnection();
                return dt;
            }
        }

        public DataTable search_information(string keyword, string group)
        {
            string query = "SELECT ID, piratename as [ALIAS], givenname as [GIVEN NAME], age, pirategroup as [PIRATE GROUP], bounty as [BOUNTY] FROM pirates" +
                            " WHERE piratename like @keyword or givenname like @keyword1 AND pirategroup = @group";

            OpenConnection();

            using (cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@keyword", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("@keyword1", "%" + keyword + "%");
                cmd.Parameters.AddWithValue("@group", group);

                using (adp = new OleDbDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    CloseConnection();
                    return dt;
                }
            }
        }

        public DataTable display_selected_information(int ID)
        {
            string query = "SELECT ID, piratename as [ALIAS], givenname as [GIVEN NAME], age, pirategroup as [PIRATE GROUP], bounty as [BOUNTY] FROM pirates WHERE ID = @id";
            OpenConnection();
            using (cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", ID);
                using (adp = new OleDbDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    CloseConnection();
                    return dt;
                }
            }
        }

        public int insert_record(string alias, string name, int age, string group, double bounty)
        {
            string query = "INSERT INTO pirates (piratename, givenname, age, pirategroup, bounty) VALUES (@alias, @name, @age, @group, @bounty)";
            OpenConnection();
            using (cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@alias", alias);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@group", group);
                cmd.Parameters.AddWithValue("@bounty", bounty);
                int result = cmd.ExecuteNonQuery();
                CloseConnection();
                return result;
            }
        }

        public int remove_record(int id)
        {
            string query = "DELETE FROM pirates WHERE ID = @id";
            OpenConnection();
            using (cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                CloseConnection();
                return result;
            }
        }

        public int update_record(int id, string alias, string name, int age, string group, double bounty)
        {
            string query = "UPDATE pirates SET piratename = @alias, givenname = @name, age = @age, pirategroup = @group, bounty = @bounty WHERE ID = @id";
            OpenConnection();
            using (cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@alias", alias);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@group", group);
                cmd.Parameters.AddWithValue("@bounty", bounty);
                cmd.Parameters.AddWithValue("@id", id);
                int result = cmd.ExecuteNonQuery();
                CloseConnection();
                return result;
            }
        }


    }
}
