using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class addResidents : Form
    {
        public addResidents()
        {
            InitializeComponent();
        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = (string)comboBoxStatus.SelectedItem;

            if(value == "Студент")
            {
                labelGroupRank.Text = "Группа";
            }
            else
            {
                labelGroupRank.Text = "Должность";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Residents residents = new Residents();

            if(dateTimePickerIn.Value > dateTimePickerOut.Value)
            {
                MessageBox.Show("Дата выселения должна быть позже, чем дата заселения");
                return;
            }

            if(residents.Add(int.Parse(numericUpDownId.Value.ToString()), int.Parse(numericUpDownRoomId.Value.ToString()), textBoxName.Text, comboBoxStatus.SelectedItem.ToString(), dateTimePickerIn.Value.ToString(), dateTimePickerOut.Value.ToString(), textBoxRankGroup.Text))
            {
                studentsPanel sp = new studentsPanel();
                this.Hide();
                sp.Show();
            }

        }
    }
}
