namespace ExampleSQLApp
{
    partial class AdminPanel
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
            this.hostelDataSet = new ExampleSQLApp.hostelDataSet();
            this.adminsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminsTableAdapter = new ExampleSQLApp.hostelDataSetTableAdapters.adminsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hostelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placesInRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetBindingSource)).BeginInit();
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
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // hostelDataSetBindingSource
            // 
            this.hostelDataSetBindingSource.DataSource = this.hostelDataSet;
            this.hostelDataSetBindingSource.Position = 0;
            // 
            // id
            // 
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
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private hostelDataSet hostelDataSet;
        private System.Windows.Forms.BindingSource adminsBindingSource;
        private hostelDataSetTableAdapters.adminsTableAdapter adminsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource hostelDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomsCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn placesInRoom;
        private System.Windows.Forms.DataGridViewLinkColumn Delete;
    }
}