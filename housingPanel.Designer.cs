namespace ExampleSQLApp
{
    partial class housingPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.hostelDataSet = new ExampleSQLApp.hostelDataSet();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new ExampleSQLApp.hostelDataSetTableAdapters.adminsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesInRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.hostelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saveHousingGridData = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.корпусыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обзорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обзорToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.заявкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обзорToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hostelDataSet
            // 
            this.hostelDataSet.DataSetName = "hostelDataSet";
            this.hostelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminsBindingSource
            // 
            this.adminsBindingSource.DataMember = "admins";
            this.adminsBindingSource.DataSource = this.hostelDataSet;
            // 
            // adminsTableAdapter
            // 
            this.adminsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.roomsCount,
            this.placesInRoom,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(799, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing_1);
            // 
            // id
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "Корпус";
            this.id.Name = "id";
            // 
            // roomsCount
            // 
            this.roomsCount.HeaderText = "Количество комнат";
            this.roomsCount.Name = "roomsCount";
            // 
            // placesInRoom
            // 
            this.placesInRoom.HeaderText = "Количество мест в комнате";
            this.placesInRoom.Name = "placesInRoom";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Удалить";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "Delete";
            // 
            // hostelDataSetBindingSource
            // 
            this.hostelDataSetBindingSource.DataSource = this.hostelDataSet;
            this.hostelDataSetBindingSource.Position = 0;
            // 
            // saveHousingGridData
            // 
            this.saveHousingGridData.Location = new System.Drawing.Point(586, 403);
            this.saveHousingGridData.Name = "saveHousingGridData";
            this.saveHousingGridData.Size = new System.Drawing.Size(202, 35);
            this.saveHousingGridData.TabIndex = 1;
            this.saveHousingGridData.Text = "Сохранить";
            this.saveHousingGridData.UseVisualStyleBackColor = true;
            this.saveHousingGridData.Click += new System.EventHandler(this.saveHousingGridData_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.корпусыToolStripMenuItem,
            this.местаToolStripMenuItem,
            this.заявкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.обзорToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.обзорToolStripMenuItem1.Text = "Обзор";
            // 
            // заявкиToolStripMenuItem
            // 
            this.заявкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обзорToolStripMenuItem2});
            this.заявкиToolStripMenuItem.Name = "заявкиToolStripMenuItem";
            this.заявкиToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.заявкиToolStripMenuItem.Text = "Заявки";
            // 
            // обзорToolStripMenuItem2
            // 
            this.обзорToolStripMenuItem2.Name = "обзорToolStripMenuItem2";
            this.обзорToolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.обзорToolStripMenuItem2.Text = "Обзор";
            this.обзорToolStripMenuItem2.Click += new System.EventHandler(this.обзорToolStripMenuItem2_Click);
            // 
            // housingPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveHousingGridData);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "housingPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private hostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private hostelDataSetTableAdapters.adminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hostelDataSetBindingSource;
        private System.Windows.Forms.Button saveHousingGridData;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn placesInRoom;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem корпусыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обзорToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обзорToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem заявкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обзорToolStripMenuItem2;
    }
}