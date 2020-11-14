namespace ExampleSQLApp
{
    partial class addResidents
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelGroupRank = new System.Windows.Forms.Label();
            this.adminsTableAdapter1 = new ExampleSQLApp.hostelDataSetTableAdapters.adminsTableAdapter();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxRankGroup = new System.Windows.Forms.TextBox();
            this.dateTimePickerIn = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerOut = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.numericUpDownId = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRoomId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер заявки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер комнаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Статус";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Дата заселения";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата выселения";
            // 
            // labelGroupRank
            // 
            this.labelGroupRank.AutoSize = true;
            this.labelGroupRank.Location = new System.Drawing.Point(12, 202);
            this.labelGroupRank.Name = "labelGroupRank";
            this.labelGroupRank.Size = new System.Drawing.Size(42, 13);
            this.labelGroupRank.TabIndex = 6;
            this.labelGroupRank.Text = "Группа";
            // 
            // adminsTableAdapter1
            // 
            this.adminsTableAdapter1.ClearBeforeFill = true;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(116, 69);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // textBoxRankGroup
            // 
            this.textBoxRankGroup.Location = new System.Drawing.Point(116, 199);
            this.textBoxRankGroup.Name = "textBoxRankGroup";
            this.textBoxRankGroup.Size = new System.Drawing.Size(100, 20);
            this.textBoxRankGroup.TabIndex = 10;
            // 
            // dateTimePickerIn
            // 
            this.dateTimePickerIn.Location = new System.Drawing.Point(116, 134);
            this.dateTimePickerIn.Name = "dateTimePickerIn";
            this.dateTimePickerIn.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerIn.TabIndex = 12;
            // 
            // dateTimePickerOut
            // 
            this.dateTimePickerOut.Location = new System.Drawing.Point(116, 167);
            this.dateTimePickerOut.Name = "dateTimePickerOut";
            this.dateTimePickerOut.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerOut.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Студент",
            "Сотрудник"});
            this.comboBoxStatus.Location = new System.Drawing.Point(116, 101);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(100, 21);
            this.comboBoxStatus.TabIndex = 15;
            this.comboBoxStatus.Text = "Студент";
            this.comboBoxStatus.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // numericUpDownId
            // 
            this.numericUpDownId.Location = new System.Drawing.Point(116, 7);
            this.numericUpDownId.Name = "numericUpDownId";
            this.numericUpDownId.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownId.TabIndex = 16;
            // 
            // numericUpDownRoomId
            // 
            this.numericUpDownRoomId.Location = new System.Drawing.Point(116, 39);
            this.numericUpDownRoomId.Name = "numericUpDownRoomId";
            this.numericUpDownRoomId.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownRoomId.TabIndex = 17;
            // 
            // addResidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDownRoomId);
            this.Controls.Add(this.numericUpDownId);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePickerOut);
            this.Controls.Add(this.dateTimePickerIn);
            this.Controls.Add(this.textBoxRankGroup);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelGroupRank);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "addResidents";
            this.Text = "Добавление проживающего";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRoomId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelGroupRank;
        private hostelDataSetTableAdapters.adminsTableAdapter adminsTableAdapter1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxRankGroup;
        private System.Windows.Forms.DateTimePicker dateTimePickerIn;
        private System.Windows.Forms.DateTimePicker dateTimePickerOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.NumericUpDown numericUpDownId;
        private System.Windows.Forms.NumericUpDown numericUpDownRoomId;
    }
}