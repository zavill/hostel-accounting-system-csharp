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
    class Residents
    {

        public DataTable GetResidents()
        {
            DataBase db = new DataBase();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * from `residents`", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }
        public bool Add(int Id, int roomId, string name, string status, string datein, string dateout, string rankgroup)
        {
            try
            {
                if (!checkFieldsAdd(name, status, datein, dateout, rankgroup))
                    return false;

                DataBase db = new DataBase();

                DataTable table = new DataTable();

                MySqlDataAdapter adapter = new MySqlDataAdapter();

                db.openConnection();

                MySqlCommand command = new MySqlCommand("INSERT INTO `residents`(`id`, `roomId`, `fullName`, `status`, `dateIn`, `dateOut`, `groupStudent`, `rankStaff`) VALUES (@id, @rid, @name, @st, @di, @do, @gS, @rS)", db.getConnection());

                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
                command.Parameters.Add("@rid", MySqlDbType.Int32).Value = roomId;
                command.Parameters.Add("@name", MySqlDbType.String).Value = name;
                command.Parameters.Add("@st", MySqlDbType.String).Value = status;
                command.Parameters.Add("@di", MySqlDbType.String).Value = datein;
                command.Parameters.Add("@do", MySqlDbType.String).Value = dateout;

                if (status == "Студент")
                {
                    command.Parameters.Add("@gS", MySqlDbType.String).Value = rankgroup;
                    command.Parameters.Add("@rS", MySqlDbType.String).Value = "";
                }
                else
                {
                    command.Parameters.Add("@rS", MySqlDbType.String).Value = rankgroup;
                    command.Parameters.Add("@gS", MySqlDbType.String).Value = "";
                }

                command.ExecuteNonQuery();

                db.closeConnection();

                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }

        private bool checkFieldsAdd (string name, string status, string datein, string dateout, string rankgroup)
        {

            if(name == "" || status == "" || datein == "" || dateout == "" || rankgroup == "")
            {
                MessageBox.Show("Удостоверьтесь что все данные введены правильно и попробуйте еще раз!");
                return false;
            }

            return true;
        }

    }
}
