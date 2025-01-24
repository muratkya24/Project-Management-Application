namespace ProjePilot.Forms
{
    partial class TaskPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskPage));
            this.label6 = new System.Windows.Forms.Label();
            this.addEmployeeToTask = new System.Windows.Forms.ComboBox();
            this.addTaskBeginDate = new System.Windows.Forms.DateTimePicker();
            this.addTaskEndDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addTaskName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searcByTaskName = new System.Windows.Forms.TextBox();
            this.taskList = new System.Windows.Forms.DataGridView();
            this.addTask = new System.Windows.Forms.Button();
            this.turnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.addManDayValue = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.addTaskState = new System.Windows.Forms.ComboBox();
            this.deleteTask = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.updateTaskState = new System.Windows.Forms.ComboBox();
            this.updateManDayValue = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.updateTaskEndDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.updateTask = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addManDayValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateManDayValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Info;
            this.label6.Location = new System.Drawing.Point(109, 169);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 29;
            this.label6.Text = "Çalısan Ekle";
            // 
            // addEmployeeToTask
            // 
            this.addEmployeeToTask.FormattingEnabled = true;
            this.addEmployeeToTask.Location = new System.Drawing.Point(212, 171);
            this.addEmployeeToTask.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployeeToTask.Name = "addEmployeeToTask";
            this.addEmployeeToTask.Size = new System.Drawing.Size(137, 21);
            this.addEmployeeToTask.TabIndex = 28;
            this.addEmployeeToTask.SelectedIndexChanged += new System.EventHandler(this.addEmployeeToTask_SelectedIndexChanged);
            // 
            // addTaskBeginDate
            // 
            this.addTaskBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addTaskBeginDate.Location = new System.Drawing.Point(212, 77);
            this.addTaskBeginDate.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskBeginDate.Name = "addTaskBeginDate";
            this.addTaskBeginDate.Size = new System.Drawing.Size(138, 20);
            this.addTaskBeginDate.TabIndex = 27;
            this.addTaskBeginDate.ValueChanged += new System.EventHandler(this.addTaskBeginDate_ValueChanged);
            // 
            // addTaskEndDate
            // 
            this.addTaskEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addTaskEndDate.Location = new System.Drawing.Point(212, 123);
            this.addTaskEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskEndDate.Name = "addTaskEndDate";
            this.addTaskEndDate.Size = new System.Drawing.Size(137, 20);
            this.addTaskEndDate.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(91, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 28);
            this.label5.TabIndex = 25;
            this.label5.Text = "Yeni Görev Kaydı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(70, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 24;
            this.label4.Text = "Gorev Bitiş Tarihi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(79, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "Başlangıç Tarihi";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(125, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Görev Adı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addTaskName
            // 
            this.addTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addTaskName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addTaskName.Location = new System.Drawing.Point(212, 52);
            this.addTaskName.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskName.Name = "addTaskName";
            this.addTaskName.Size = new System.Drawing.Size(137, 21);
            this.addTaskName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(7, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Görev Ara";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // searcByTaskName
            // 
            this.searcByTaskName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searcByTaskName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searcByTaskName.Location = new System.Drawing.Point(95, 225);
            this.searcByTaskName.Margin = new System.Windows.Forms.Padding(2);
            this.searcByTaskName.Name = "searcByTaskName";
            this.searcByTaskName.Size = new System.Drawing.Size(552, 21);
            this.searcByTaskName.TabIndex = 19;
            this.searcByTaskName.TextChanged += new System.EventHandler(this.searcByTaskName_TextChanged);
            // 
            // taskList
            // 
            this.taskList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.taskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taskList.Location = new System.Drawing.Point(11, 256);
            this.taskList.Margin = new System.Windows.Forms.Padding(2);
            this.taskList.Name = "taskList";
            this.taskList.RowHeadersWidth = 51;
            this.taskList.RowTemplate.Height = 24;
            this.taskList.Size = new System.Drawing.Size(758, 216);
            this.taskList.TabIndex = 18;
            this.taskList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.taskList_CellEnter);
            // 
            // addTask
            // 
            this.addTask.BackColor = System.Drawing.Color.MediumTurquoise;
            this.addTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addTask.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTask.ForeColor = System.Drawing.SystemColors.Info;
            this.addTask.Location = new System.Drawing.Point(357, 146);
            this.addTask.Margin = new System.Windows.Forms.Padding(2);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(94, 46);
            this.addTask.TabIndex = 17;
            this.addTask.Text = "Kaydet";
            this.addTask.UseVisualStyleBackColor = false;
            this.addTask.Click += new System.EventHandler(this.addTask_Click);
            // 
            // turnBack
            // 
            this.turnBack.BackColor = System.Drawing.Color.ForestGreen;
            this.turnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnBack.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnBack.ForeColor = System.Drawing.Color.Snow;
            this.turnBack.Location = new System.Drawing.Point(-1, 1);
            this.turnBack.Margin = new System.Windows.Forms.Padding(2);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(80, 31);
            this.turnBack.TabIndex = 16;
            this.turnBack.Text = "Geri";
            this.turnBack.UseVisualStyleBackColor = false;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(65, 102);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 30;
            this.label7.Text = "Adam Gün Değeri";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // addManDayValue
            // 
            this.addManDayValue.Location = new System.Drawing.Point(212, 100);
            this.addManDayValue.Margin = new System.Windows.Forms.Padding(2);
            this.addManDayValue.Name = "addManDayValue";
            this.addManDayValue.Size = new System.Drawing.Size(137, 20);
            this.addManDayValue.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Info;
            this.label8.Location = new System.Drawing.Point(147, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 34;
            this.label8.Text = "Durum";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // addTaskState
            // 
            this.addTaskState.FormattingEnabled = true;
            this.addTaskState.Items.AddRange(new object[] {
            "devam ediyor",
            "tamamlandi",
            "tamamlanacak"});
            this.addTaskState.Location = new System.Drawing.Point(212, 146);
            this.addTaskState.Margin = new System.Windows.Forms.Padding(2);
            this.addTaskState.Name = "addTaskState";
            this.addTaskState.Size = new System.Drawing.Size(137, 21);
            this.addTaskState.TabIndex = 33;
            // 
            // deleteTask
            // 
            this.deleteTask.BackColor = System.Drawing.Color.Maroon;
            this.deleteTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteTask.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteTask.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteTask.Location = new System.Drawing.Point(605, 133);
            this.deleteTask.Margin = new System.Windows.Forms.Padding(2);
            this.deleteTask.Name = "deleteTask";
            this.deleteTask.Size = new System.Drawing.Size(44, 31);
            this.deleteTask.TabIndex = 35;
            this.deleteTask.Text = "SİL";
            this.deleteTask.UseVisualStyleBackColor = false;
            this.deleteTask.Click += new System.EventHandler(this.deleteTask_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(88, 192);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(19, 20);
            this.textBox3.TabIndex = 36;
            this.textBox3.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Info;
            this.label9.Location = new System.Drawing.Point(540, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 19);
            this.label9.TabIndex = 50;
            this.label9.Text = "Durum";
            // 
            // updateTaskState
            // 
            this.updateTaskState.FormattingEnabled = true;
            this.updateTaskState.Items.AddRange(new object[] {
            "devam ediyor",
            "tamamlandi",
            "tamamlanacak"});
            this.updateTaskState.Location = new System.Drawing.Point(606, 103);
            this.updateTaskState.Margin = new System.Windows.Forms.Padding(2);
            this.updateTaskState.Name = "updateTaskState";
            this.updateTaskState.Size = new System.Drawing.Size(137, 21);
            this.updateTaskState.TabIndex = 49;
            // 
            // updateManDayValue
            // 
            this.updateManDayValue.Location = new System.Drawing.Point(607, 55);
            this.updateManDayValue.Margin = new System.Windows.Forms.Padding(2);
            this.updateManDayValue.Name = "updateManDayValue";
            this.updateManDayValue.Size = new System.Drawing.Size(136, 20);
            this.updateManDayValue.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Info;
            this.label10.Location = new System.Drawing.Point(463, 54);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(142, 19);
            this.label10.TabIndex = 47;
            this.label10.Text = "Adam Gün Değeri";
            // 
            // updateTaskEndDate
            // 
            this.updateTaskEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateTaskEndDate.Location = new System.Drawing.Point(606, 79);
            this.updateTaskEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.updateTaskEndDate.Name = "updateTaskEndDate";
            this.updateTaskEndDate.Size = new System.Drawing.Size(138, 20);
            this.updateTaskEndDate.TabIndex = 43;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Info;
            this.label13.Location = new System.Drawing.Point(463, 80);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 19);
            this.label13.TabIndex = 41;
            this.label13.Text = "Görev Bitiş Tarihi";
            // 
            // updateTask
            // 
            this.updateTask.BackColor = System.Drawing.Color.MediumOrchid;
            this.updateTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateTask.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateTask.ForeColor = System.Drawing.SystemColors.Info;
            this.updateTask.Location = new System.Drawing.Point(653, 133);
            this.updateTask.Margin = new System.Windows.Forms.Padding(2);
            this.updateTask.Name = "updateTask";
            this.updateTask.Size = new System.Drawing.Size(92, 31);
            this.updateTask.TabIndex = 37;
            this.updateTask.Text = "GÜNCELLE";
            this.updateTask.UseVisualStyleBackColor = false;
            this.updateTask.Click += new System.EventHandler(this.updateTask_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Info;
            this.label12.Location = new System.Drawing.Point(547, 9);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(186, 28);
            this.label12.TabIndex = 42;
            this.label12.Text = "Görev Güncelle";
            // 
            // TaskPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(783, 483);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.updateTaskState);
            this.Controls.Add(this.updateManDayValue);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.updateTaskEndDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.updateTask);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.deleteTask);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.addTaskState);
            this.Controls.Add(this.addManDayValue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addEmployeeToTask);
            this.Controls.Add(this.addTaskBeginDate);
            this.Controls.Add(this.addTaskEndDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addTaskName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searcByTaskName);
            this.Controls.Add(this.taskList);
            this.Controls.Add(this.addTask);
            this.Controls.Add(this.turnBack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TaskPage";
            this.Text = "GÖREVLER";
            this.Load += new System.EventHandler(this.TaskPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.taskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addManDayValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateManDayValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addEmployeeToTask;
        private System.Windows.Forms.DateTimePicker addTaskBeginDate;
        private System.Windows.Forms.DateTimePicker addTaskEndDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addTaskName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searcByTaskName;
        private System.Windows.Forms.DataGridView taskList;
        private System.Windows.Forms.Button addTask;
        private System.Windows.Forms.Button turnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown addManDayValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox addTaskState;
        private System.Windows.Forms.Button deleteTask;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox updateTaskState;
        private System.Windows.Forms.NumericUpDown updateManDayValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker updateTaskEndDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button updateTask;
        private System.Windows.Forms.Label label12;
    }
}