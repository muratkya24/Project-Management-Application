namespace ProjePilot.Forms
{
    partial class ProjectPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectPage));
            this.turnBack = new System.Windows.Forms.Button();
            this.projectList = new System.Windows.Forms.DataGridView();
            this.searchByProjectName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteProject = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.changeTask = new System.Windows.Forms.ComboBox();
            this.updateProjectEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.updateProject = new System.Windows.Forms.Button();
            this.updateProjectName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addProjectEndDate = new System.Windows.Forms.DateTimePicker();
            this.addProjectBeginDate = new System.Windows.Forms.DateTimePicker();
            this.addProjectName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addProject = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.addTask = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.taskId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // turnBack
            // 
            this.turnBack.BackColor = System.Drawing.Color.DarkRed;
            this.turnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnBack.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.turnBack.Location = new System.Drawing.Point(13, 12);
            this.turnBack.Margin = new System.Windows.Forms.Padding(2);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(83, 31);
            this.turnBack.TabIndex = 0;
            this.turnBack.Text = "Geri";
            this.turnBack.UseVisualStyleBackColor = false;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // projectList
            // 
            this.projectList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.projectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectList.Location = new System.Drawing.Point(4, 298);
            this.projectList.Margin = new System.Windows.Forms.Padding(2);
            this.projectList.Name = "projectList";
            this.projectList.RowHeadersWidth = 51;
            this.projectList.RowTemplate.Height = 24;
            this.projectList.Size = new System.Drawing.Size(758, 167);
            this.projectList.TabIndex = 2;
            this.projectList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.projectList_CellEnter);
            // 
            // searchByProjectName
            // 
            this.searchByProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchByProjectName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchByProjectName.Location = new System.Drawing.Point(147, 263);
            this.searchByProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.searchByProjectName.Name = "searchByProjectName";
            this.searchByProjectName.Size = new System.Drawing.Size(546, 21);
            this.searchByProjectName.TabIndex = 3;
            this.searchByProjectName.TextChanged += new System.EventHandler(this.searchByProjectName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(51, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proje Ara";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // deleteProject
            // 
            this.deleteProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteProject.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProject.ForeColor = System.Drawing.SystemColors.Info;
            this.deleteProject.Location = new System.Drawing.Point(609, 197);
            this.deleteProject.Margin = new System.Windows.Forms.Padding(2);
            this.deleteProject.Name = "deleteProject";
            this.deleteProject.Size = new System.Drawing.Size(47, 31);
            this.deleteProject.TabIndex = 16;
            this.deleteProject.Text = "SİL";
            this.deleteProject.UseVisualStyleBackColor = false;
            this.deleteProject.Click += new System.EventHandler(this.deleteProject_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(472, 161);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Gorev Degistir";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // changeTask
            // 
            this.changeTask.FormattingEnabled = true;
            this.changeTask.Location = new System.Drawing.Point(609, 161);
            this.changeTask.Margin = new System.Windows.Forms.Padding(2);
            this.changeTask.Name = "changeTask";
            this.changeTask.Size = new System.Drawing.Size(138, 21);
            this.changeTask.TabIndex = 26;
            this.changeTask.SelectedIndexChanged += new System.EventHandler(this.changeTask_SelectedIndexChanged);
            // 
            // updateProjectEndDate
            // 
            this.updateProjectEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateProjectEndDate.Location = new System.Drawing.Point(609, 134);
            this.updateProjectEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.updateProjectEndDate.Name = "updateProjectEndDate";
            this.updateProjectEndDate.Size = new System.Drawing.Size(139, 20);
            this.updateProjectEndDate.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Location = new System.Drawing.Point(605, 67);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "Proje Güncelleme";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(472, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 19);
            this.label9.TabIndex = 22;
            this.label9.Text = "Proje Bitiş Tarihi";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // updateProject
            // 
            this.updateProject.BackColor = System.Drawing.Color.Teal;
            this.updateProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateProject.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateProject.ForeColor = System.Drawing.SystemColors.Info;
            this.updateProject.Location = new System.Drawing.Point(659, 196);
            this.updateProject.Margin = new System.Windows.Forms.Padding(2);
            this.updateProject.Name = "updateProject";
            this.updateProject.Size = new System.Drawing.Size(89, 31);
            this.updateProject.TabIndex = 18;
            this.updateProject.Text = "GÜNCELLE";
            this.updateProject.UseVisualStyleBackColor = false;
            this.updateProject.Click += new System.EventHandler(this.updateProject_Click);
            // 
            // updateProjectName
            // 
            this.updateProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateProjectName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateProjectName.Location = new System.Drawing.Point(609, 104);
            this.updateProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.updateProjectName.Name = "updateProjectName";
            this.updateProjectName.ReadOnly = true;
            this.updateProjectName.Size = new System.Drawing.Size(138, 21);
            this.updateProjectName.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label11.Location = new System.Drawing.Point(520, 106);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 19);
            this.label11.TabIndex = 20;
            this.label11.Text = "Proje Ismi";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(13, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Proje Başlangıç Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(48, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Proje Bitiş Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(92, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proje Ismi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addProjectEndDate
            // 
            this.addProjectEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addProjectEndDate.Location = new System.Drawing.Point(189, 110);
            this.addProjectEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.addProjectEndDate.Name = "addProjectEndDate";
            this.addProjectEndDate.Size = new System.Drawing.Size(137, 20);
            this.addProjectEndDate.TabIndex = 12;
            // 
            // addProjectBeginDate
            // 
            this.addProjectBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.addProjectBeginDate.Location = new System.Drawing.Point(189, 77);
            this.addProjectBeginDate.Margin = new System.Windows.Forms.Padding(2);
            this.addProjectBeginDate.Name = "addProjectBeginDate";
            this.addProjectBeginDate.Size = new System.Drawing.Size(137, 20);
            this.addProjectBeginDate.TabIndex = 13;
            // 
            // addProjectName
            // 
            this.addProjectName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addProjectName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProjectName.Location = new System.Drawing.Point(189, 43);
            this.addProjectName.Margin = new System.Windows.Forms.Padding(2);
            this.addProjectName.Name = "addProjectName";
            this.addProjectName.Size = new System.Drawing.Size(137, 21);
            this.addProjectName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(92, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Gorev Ekle";
            // 
            // addProject
            // 
            this.addProject.BackColor = System.Drawing.Color.SteelBlue;
            this.addProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addProject.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProject.ForeColor = System.Drawing.Color.White;
            this.addProject.Location = new System.Drawing.Point(340, 110);
            this.addProject.Margin = new System.Windows.Forms.Padding(2);
            this.addProject.Name = "addProject";
            this.addProject.Size = new System.Drawing.Size(114, 50);
            this.addProject.TabIndex = 1;
            this.addProject.Text = "Kaydet";
            this.addProject.UseVisualStyleBackColor = false;
            this.addProject.Click += new System.EventHandler(this.addProject_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(185, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Yeni Proje Kaydı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // addTask
            // 
            this.addTask.FormattingEnabled = true;
            this.addTask.Location = new System.Drawing.Point(189, 142);
            this.addTask.Margin = new System.Windows.Forms.Padding(2);
            this.addTask.Name = "addTask";
            this.addTask.Size = new System.Drawing.Size(137, 21);
            this.addTask.TabIndex = 14;
            this.addTask.SelectedIndexChanged += new System.EventHandler(this.addTask_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.addTask);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.taskId);
            this.panel1.Controls.Add(this.addProject);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.addProjectName);
            this.panel1.Controls.Add(this.addProjectBeginDate);
            this.panel1.Controls.Add(this.addProjectEndDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 189);
            this.panel1.TabIndex = 28;
            // 
            // taskId
            // 
            this.taskId.HideSelection = false;
            this.taskId.Location = new System.Drawing.Point(12, 156);
            this.taskId.Margin = new System.Windows.Forms.Padding(2);
            this.taskId.Name = "taskId";
            this.taskId.ReadOnly = true;
            this.taskId.Size = new System.Drawing.Size(18, 20);
            this.taskId.TabIndex = 17;
            this.taskId.TabStop = false;
            this.taskId.Visible = false;
            this.taskId.TextChanged += new System.EventHandler(this.taskId_TextChanged);
            // 
            // ProjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(773, 470);
            this.Controls.Add(this.turnBack);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.changeTask);
            this.Controls.Add(this.updateProjectEndDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.updateProjectName);
            this.Controls.Add(this.updateProject);
            this.Controls.Add(this.deleteProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchByProjectName);
            this.Controls.Add(this.projectList);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ProjectPage";
            this.Text = "Projeler";
            this.Load += new System.EventHandler(this.ProjectPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button turnBack;
        private System.Windows.Forms.DataGridView projectList;
        private System.Windows.Forms.TextBox searchByProjectName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteProject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox changeTask;
        private System.Windows.Forms.DateTimePicker updateProjectEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button updateProject;
        private System.Windows.Forms.TextBox updateProjectName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker addProjectEndDate;
        private System.Windows.Forms.DateTimePicker addProjectBeginDate;
        private System.Windows.Forms.TextBox addProjectName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox addTask;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox taskId;
    }
}