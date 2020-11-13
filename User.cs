using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleSQLApp
{
    class User
    {
        public bool Authorize(String login, String password)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * from `admins` WHERE `user`= @lu AND `password`=@pu", db.getConnection());
            command.Parameters.Add("@lu", MySqlDbType.String).Value = login;
            command.Parameters.Add("@pu", MySqlDbType.String).Value = password;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
