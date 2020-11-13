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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
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
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = table.Rows[i][0].ToString();
                dataGridView1.Rows[i].Cells[1].Value = table.Rows[i][1].ToString();
                dataGridView1.Rows[i].Cells[2].Value = table.Rows[i][2].ToString();
                dataGridView1.Rows[i].Cells[3] = linkCell;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
