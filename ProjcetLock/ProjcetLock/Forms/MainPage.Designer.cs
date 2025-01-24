namespace ProjePilot.Forms
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.logOut = new System.Windows.Forms.Button();
            this.projects = new System.Windows.Forms.Button();
            this.tasks = new System.Windows.Forms.Button();
            this.employees = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.BackColor = System.Drawing.Color.Navy;
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logOut.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logOut.Location = new System.Drawing.Point(524, 357);
            this.logOut.Margin = new System.Windows.Forms.Padding(2);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(366, 90);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Çıkış Yap";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // projects
            // 
            this.projects.BackColor = System.Drawing.SystemColors.ControlText;
            this.projects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.projects.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.projects.ForeColor = System.Drawing.SystemColors.Info;
            this.projects.Location = new System.Drawing.Point(524, 217);
            this.projects.Margin = new System.Windows.Forms.Padding(2);
            this.projects.Name = "projects";
            this.projects.Size = new System.Drawing.Size(366, 90);
            this.projects.TabIndex = 1;
            this.projects.Text = "PROJELER";
            this.projects.UseMnemonic = false;
            this.projects.UseVisualStyleBackColor = false;
            this.projects.Click += new System.EventHandler(this.projects_Click);
            // 
            // tasks
            // 
            this.tasks.BackColor = System.Drawing.SystemColors.ControlText;
            this.tasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tasks.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tasks.ForeColor = System.Drawing.SystemColors.Info;
            this.tasks.Location = new System.Drawing.Point(78, 217);
            this.tasks.Margin = new System.Windows.Forms.Padding(2);
            this.tasks.Name = "tasks";
            this.tasks.Size = new System.Drawing.Size(366, 90);
            this.tasks.TabIndex = 2;
            this.tasks.Text = "GÖREVLER";
            this.tasks.UseMnemonic = false;
            this.tasks.UseVisualStyleBackColor = false;
            this.tasks.Click += new System.EventHandler(this.tasks_Click);
            // 
            // employees
            // 
            this.employees.BackColor = System.Drawing.SystemColors.Desktop;
            this.employees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.employees.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employees.ForeColor = System.Drawing.SystemColors.Info;
            this.employees.Location = new System.Drawing.Point(78, 357);
            this.employees.Margin = new System.Windows.Forms.Padding(2);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(366, 90);
            this.employees.TabIndex = 3;
            this.employees.Text = "ÇALIŞANLAR";
            this.employees.UseMnemonic = false;
            this.employees.UseVisualStyleBackColor = false;
            this.employees.Click += new System.EventHandler(this.employees_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.logOut;
            this.ClientSize = new System.Drawing.Size(964, 589);
            this.Controls.Add(this.employees);
            this.Controls.Add(this.tasks);
            this.Controls.Add(this.projects);
            this.Controls.Add(this.logOut);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "ANASAYFA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button projects;
        private System.Windows.Forms.Button tasks;
        private System.Windows.Forms.Button employees;
    }
}