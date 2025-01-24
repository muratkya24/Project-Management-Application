using System.Windows.Forms;

namespace ProjcetLock.Forms
{
    partial class EmployeeDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDetail));
            this.employeeTaskList = new System.Windows.Forms.DataGridView();
            this.turnBack = new System.Windows.Forms.Button();
            this.updateEmployeeNumberOfTasksCompleted = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.updateTasks = new System.Windows.Forms.Button();
            this.updateEmployeeNumberOngoingTasks = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTaskList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEmployeeNumberOfTasksCompleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEmployeeNumberOngoingTasks)).BeginInit();
            this.SuspendLayout();
            // 
            // employeeTaskList
            // 
            this.employeeTaskList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.employeeTaskList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTaskList.Location = new System.Drawing.Point(11, 11);
            this.employeeTaskList.Margin = new System.Windows.Forms.Padding(2);
            this.employeeTaskList.Name = "employeeTaskList";
            this.employeeTaskList.RowHeadersWidth = 51;
            this.employeeTaskList.RowTemplate.Height = 24;
            this.employeeTaskList.Size = new System.Drawing.Size(712, 242);
            this.employeeTaskList.TabIndex = 0;
            // 
            // turnBack
            // 
            this.turnBack.BackColor = System.Drawing.Color.DarkGreen;
            this.turnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnBack.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.turnBack.Location = new System.Drawing.Point(11, 458);
            this.turnBack.Margin = new System.Windows.Forms.Padding(2);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(90, 45);
            this.turnBack.TabIndex = 1;
            this.turnBack.Text = "Geri Dön";
            this.turnBack.UseVisualStyleBackColor = false;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // updateEmployeeNumberOfTasksCompleted
            // 
            this.updateEmployeeNumberOfTasksCompleted.Location = new System.Drawing.Point(400, 327);
            this.updateEmployeeNumberOfTasksCompleted.Margin = new System.Windows.Forms.Padding(2);
            this.updateEmployeeNumberOfTasksCompleted.Name = "updateEmployeeNumberOfTasksCompleted";
            this.updateEmployeeNumberOfTasksCompleted.Size = new System.Drawing.Size(136, 20);
            this.updateEmployeeNumberOfTasksCompleted.TabIndex = 56;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(122, 327);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(244, 21);
            this.label10.TabIndex = 55;
            this.label10.Text = "Biten Proje Sayısı Güncelle";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Black;
            this.label12.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(67, 269);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(564, 32);
            this.label12.TabIndex = 53;
            this.label12.Text = "Biten/Devam Eden Proje Sayısı Güncelleme";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Black;
            this.label13.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(69, 360);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(311, 21);
            this.label13.TabIndex = 52;
            this.label13.Text = "Devam Eden Proje Adedi Güncelle";
            // 
            // updateTasks
            // 
            this.updateTasks.BackColor = System.Drawing.Color.DarkKhaki;
            this.updateTasks.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateTasks.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateTasks.Location = new System.Drawing.Point(567, 327);
            this.updateTasks.Margin = new System.Windows.Forms.Padding(2);
            this.updateTasks.Name = "updateTasks";
            this.updateTasks.Size = new System.Drawing.Size(96, 42);
            this.updateTasks.TabIndex = 51;
            this.updateTasks.Text = "Güncelle";
            this.updateTasks.UseVisualStyleBackColor = false;
            this.updateTasks.Click += new System.EventHandler(this.updateTasks_Click);
            // 
            // updateEmployeeNumberOngoingTasks
            // 
            this.updateEmployeeNumberOngoingTasks.Location = new System.Drawing.Point(400, 364);
            this.updateEmployeeNumberOngoingTasks.Margin = new System.Windows.Forms.Padding(2);
            this.updateEmployeeNumberOngoingTasks.Name = "updateEmployeeNumberOngoingTasks";
            this.updateEmployeeNumberOngoingTasks.Size = new System.Drawing.Size(136, 20);
            this.updateEmployeeNumberOngoingTasks.TabIndex = 57;
            // 
            // EmployeeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 514);
            this.Controls.Add(this.updateEmployeeNumberOngoingTasks);
            this.Controls.Add(this.updateEmployeeNumberOfTasksCompleted);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.updateTasks);
            this.Controls.Add(this.turnBack);
            this.Controls.Add(this.employeeTaskList);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeeDetail";
            this.Text = "ÇALIŞAN DETAYLARI";
            this.Load += new System.EventHandler(this.EmployeeDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTaskList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEmployeeNumberOfTasksCompleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updateEmployeeNumberOngoingTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeeTaskList;
        private System.Windows.Forms.Button turnBack;
        private NumericUpDown updateEmployeeNumberOfTasksCompleted;
        private Label label10;
        private Label label12;
        private Label label13;
        private Button updateTasks;
        private NumericUpDown updateEmployeeNumberOngoingTasks;
    }
}