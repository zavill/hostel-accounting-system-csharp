using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    class Housing
    {

        public DataTable GetHousings()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * from `housing`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }

        public bool DeleteHouse(int id)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE from `housing` WHERE id = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;           

            command.ExecuteNonQuery();

            db.closeConnection();

            return true;

        }

        public void SaveHouses(DataGridViewRowCollection rows)
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            db.openConnection();

            foreach (DataGridViewRow row in rows)
            {
                if (row.Cells[0].Value == null)
                    continue;

                MySqlCommand command = new MySqlCommand("INSERT INTO `housing` (`id`,`roomsCount`,`placesInRoom`) VALUES (@id,@rc,@pl) ON DUPLICATE KEY UPDATE `roomsCount` = @rc, `placesInRoom` = @pl;", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = int.Parse(row.Cells[0].Value.ToString());
                command.Parameters.Add("@rc", MySqlDbType.Int32).Value = int.Parse(row.Cells[1].Value.ToString());
                command.Parameters.Add("@pl", MySqlDbType.Int32).Value = int.Parse(row.Cells[2].Value.ToString());

                command.ExecuteNonQuery();
            }

            db.closeConnection();
        }

    }
}
