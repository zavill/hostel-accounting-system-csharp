namespace ExampleSQLApp
{
    partial class studentsPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.корпусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обзорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обзорToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обзорToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rankStaff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.change = new System.Windows.Forms.DataGridViewLinkColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.корпусыToolStripMenuItem,
            this.местаToolStripMenuItem,
            this.заявкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // корпусыToolStripMenuItem
            // 
            this.корпусыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обзорToolStripMenuItem});
            this.корпусыToolStripMenuItem.Name = "корпусыToolStripMenuItem";
            this.корпусыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.корпусыToolStripMenuItem.Text = "Корпусы";
            // 
            // обзорToolStripMenuItem
            // 
            this.обзорToolStripMenuItem.Name = "обзорToolStripMenuItem";
            this.обзорToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.обзорToolStripMenuItem.Text = "Обзор";
            this.обзорToolStripMenuItem.Click += new System.EventHandler(this.обзорToolStripMenuItem_Click);
            // 
            // местаToolStripMenuItem
            // 
            this.местаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обзорToolStripMenuItem1});
            this.местаToolStripMenuItem.Name = "местаToolStripMenuItem";
            this.местаToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.местаToolStripMenuItem.Text = "Места";
            // 
            // обзорToolStripMenuItem1
            // 
            this.обзорToolStripMenuItem1.Name = "обзорToolStripMenuItem1";
            this.обзорToolStripMenuItem1.Size = new System.Drawing.Size(109, 22);
            this.обзорToolStripMenuItem1.Text = "Обзор";
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обзорToolStripMenuItem2,
            this.добавитьToolStripMenuItem});
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.заявкиToolStripMenuItem.Text = "Студенты";
            // 
            // обзорToolStripMenuItem2
            // 
            this.обзорToolStripMenuItem2.Name = "обзорToolStripMenuItem2";
            this.обзорToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.обзорToolStripMenuItem2.Text = "Обзор";
            this.обзорToolStripMenuItem2.Click += new System.EventHandler(this.обзорToolStripMenuItem2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.roomId,
            this.fullName,
            this.status,
            this.dateIn,
            this.dateOut,
            this.groupStudent,
            this.rankStaff,
            this.change});
            this.dataGridView1.Location = new System.Drawing.Point(1, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1005, 466);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // id
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.id.DefaultCellStyle = dataGridViewCellStyle3;
            this.id.HeaderText = "Номер заявки";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // roomId
            // 
            this.roomId.HeaderText = "Номер комнаты";
            this.roomId.Name = "roomId";
            this.roomId.ReadOnly = true;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "ФИО";
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // status
            // 
            this.status.HeaderText = "Статус";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // dateIn
            // 
            dataGridViewCellStyle4.Format = "d";
            dataGridViewCellStyle4.NullValue = null;
            this.dateIn.DefaultCellStyle = dataGridViewCellStyle4;
            this.dateIn.HeaderText = "Дата заселения";
            this.dateIn.Name = "dateIn";
            this.dateIn.ReadOnly = true;
            // 
            // dateOut
            // 
            this.dateOut.HeaderText = "Дата выселения";
            this.dateOut.Name = "dateOut";
            this.dateOut.ReadOnly = true;
            // 
            // groupStudent
            // 
            this.groupStudent.HeaderText = "Группа студента";
            this.groupStudent.Name = "groupStudent";
            this.groupStudent.ReadOnly = true;
            // 
            // rankStaff
            // 
            this.rankStaff.HeaderText = "Должность сотрудника";
            this.rankStaff.Name = "rankStaff";
            this.rankStaff.ReadOnly = true;
            // 
            // change
            // 
            this.change.HeaderText = "Изменить";
            this.change.Name = "change";
            // 
            // studentsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 507);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "studentsPanel";
            this.Text = "studentsPanel";
            this.Load += new System.EventHandler(this.studentsPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem корпусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обзорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обзорToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обзорToolStripMenuItem2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn rankStaff;
        private System.Windows.Forms.DataGridViewLinkColumn change;
    }
}