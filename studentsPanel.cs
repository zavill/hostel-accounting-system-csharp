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
    public partial class studentsPanel : Form
    {
        public studentsPanel()
        {
            InitializeComponent();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void studentsPanel_Load(object sender, EventArgs e)
        {
            Residents housing = new Residents();
            DataTable table = housing.GetResidents();

            for (int i = 0; i < table.Rows.Count; i++)
            {
                dataGridView1.Rows.Add();
                for(int a = 0; a < table.Columns.Count; a ++)
                    dataGridView1.Rows[i].Cells[a].Value = table.Rows[i][a].ToString();

                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                linkCell.Value = "Изменить";
                dataGridView1.Rows[i].Cells[table.Columns.Count] = linkCell;
            }
         
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addResidents ar = new addResidents();
            this.Hide();
            ar.Show();
        }
    }
}
