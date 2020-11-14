using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class housingPanel : Form
    {
        public housingPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {

            Housing housing = new Housing();
            DataTable table = housing.GetHousings();

            for(int i = 0; i < table.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                linkCell.Value = "Delete";
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = table.Rows[i][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = table.Rows[i][1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = table.Rows[i][2].ToString();
                dataGridView1.Rows[i].Cells[3] = linkCell;
            }

        }

        private void AdminPanel_Reload()
        {
            Housing housing = new Housing();
            DataTable table = housing.GetHousings();

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                linkCell.Value = "Delete";
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = table.Rows[i][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = table.Rows[i][1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = table.Rows[i][2].ToString();
                dataGridView1.Rows[i].Cells[3] = linkCell;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 3)
                {
                    if (MessageBox.Show("Удалить данный корпус?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Housing housing = new Housing();

                        int idHousing = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());


                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                        housing.DeleteHouse(idHousing);

                    }
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveHousingGridData_Click(object sender, EventArgs e)
        {

            if (!checkHousingData())
                return;

            Housing housing = new Housing();

            housing.SaveHouses(dataGridView1.Rows);

            AdminPanel_Reload();
        }

        private bool checkHousingData()
        {
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                for (int a = 0; a < dataGridView1.Rows[i].Cells.Count-1; a++)
                {
                    if (dataGridView1.Rows[i].Cells[a].Value == null || dataGridView1.Rows[i].Cells[a].Value.Equals(""))
                    {
                        MessageBox.Show("Ошибка! Проверьте что все ячейки заполнены!");
                        return false;
                    }
                }
            }

            return true;
        }

        private void dataGridView1_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void обзорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            housingPanel hp = new housingPanel();
            hp.Show();
        }

        private void обзорToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();

            studentsPanel sp = new studentsPanel();
            sp.Show();
        }
    }
}
