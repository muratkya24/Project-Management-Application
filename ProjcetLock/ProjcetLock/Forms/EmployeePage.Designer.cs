using System;

namespace ProjePilot.Forms
{
    partial class EmployeePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeePage));
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searcByEmplyeeFirstName = new System.Windows.Forms.TextBox();
            this.newEmployee = new System.Windows.Forms.Button();
            this.turnBack = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.addEmployeeLastName = new System.Windows.Forms.TextBox();
            this.deleteEmployee = new System.Windows.Forms.Button();
            this.employeeList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.updateEmployeeLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.updateEmployeeFirstName = new System.Windows.Forms.TextBox();
            this.updateEmployee = new System.Windows.Forms.Button();
            this.goToEmployeeDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Location = new System.Drawing.Point(97, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 26);
            this.label5.TabIndex = 25;
            this.label5.Text = "Yeni Çalışan Kaydı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(52, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Çalışan İsmi";
            // 
            // addEmployeeFirstName
            // 
            this.addEmployeeFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmployeeFirstName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addEmployeeFirstName.Location = new System.Drawing.Point(175, 66);
            this.addEmployeeFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployeeFirstName.Name = "addEmployeeFirstName";
            this.addEmployeeFirstName.Size = new System.Drawing.Size(148, 21);
            this.addEmployeeFirstName.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(59, 404);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 26);
            this.label1.TabIndex = 20;
            this.label1.Text = "Çalışan Ara";
            // 
            // searcByEmplyeeFirstName
            // 
            this.searcByEmplyeeFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searcByEmplyeeFirstName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searcByEmplyeeFirstName.Location = new System.Drawing.Point(175, 408);
            this.searcByEmplyeeFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.searcByEmplyeeFirstName.Name = "searcByEmplyeeFirstName";
            this.searcByEmplyeeFirstName.Size = new System.Drawing.Size(531, 21);
            this.searcByEmplyeeFirstName.TabIndex = 19;
            this.searcByEmplyeeFirstName.TextChanged += new System.EventHandler(this.searcByEmplyeeFirstName_TextChanged);
            // 
            // newEmployee
            // 
            this.newEmployee.BackColor = System.Drawing.Color.DarkKhaki;
            this.newEmployee.Font = new System.Drawing.Font("Nirmala Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newEmployee.Location = new System.Drawing.Point(175, 137);
            this.newEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.newEmployee.Name = "newEmployee";
            this.newEmployee.Size = new System.Drawing.Size(148, 31);
            this.newEmployee.TabIndex = 17;
            this.newEmployee.Text = "KAYDET";
            this.newEmployee.UseVisualStyleBackColor = false;
            this.newEmployee.Click += new System.EventHandler(this.newEmployee_Click);
            // 
            // turnBack
            // 
            this.turnBack.BackColor = System.Drawing.Color.DarkGreen;
            this.turnBack.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.turnBack.Location = new System.Drawing.Point(11, 444);
            this.turnBack.Margin = new System.Windows.Forms.Padding(2);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(94, 33);
            this.turnBack.TabIndex = 16;
            this.turnBack.Text = "Geri";
            this.turnBack.UseVisualStyleBackColor = false;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Location = new System.Drawing.Point(15, 101);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 26);
            this.label7.TabIndex = 31;
            this.label7.Text = "Çalışan  Soyismi";
            // 
            // addEmployeeLastName
            // 
            this.addEmployeeLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmployeeLastName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addEmployeeLastName.Location = new System.Drawing.Point(175, 101);
            this.addEmployeeLastName.Margin = new System.Windows.Forms.Padding(2);
            this.addEmployeeLastName.Name = "addEmployeeLastName";
            this.addEmployeeLastName.Size = new System.Drawing.Size(148, 21);
            this.addEmployeeLastName.TabIndex = 30;
            // 
            // deleteEmployee
            // 
            this.deleteEmployee.BackColor = System.Drawing.Color.DarkRed;
            this.deleteEmployee.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.deleteEmployee.Location = new System.Drawing.Point(691, 137);
            this.deleteEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.deleteEmployee.Name = "deleteEmployee";
            this.deleteEmployee.Size = new System.Drawing.Size(66, 31);
            this.deleteEmployee.TabIndex = 32;
            this.deleteEmployee.Text = "Sil";
            this.deleteEmployee.UseVisualStyleBackColor = false;
            this.deleteEmployee.Click += new System.EventHandler(this.deleteEmployee_Click);
            // 
            // employeeList
            // 
            this.employeeList.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.employeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeList.Location = new System.Drawing.Point(11, 180);
            this.employeeList.Margin = new System.Windows.Forms.Padding(2);
            this.employeeList.Name = "employeeList";
            this.employeeList.RowHeadersWidth = 51;
            this.employeeList.RowTemplate.Height = 24;
            this.employeeList.Size = new System.Drawing.Size(763, 212);
            this.employeeList.TabIndex = 18;
            this.employeeList.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeList_CellEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(435, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 26);
            this.label3.TabIndex = 38;
            this.label3.Text = "Çalışan Soyismi";
            // 
            // updateEmployeeLastName
            // 
            this.updateEmployeeLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmployeeLastName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateEmployeeLastName.Location = new System.Drawing.Point(440, 147);
            this.updateEmployeeLastName.Margin = new System.Windows.Forms.Padding(2);
            this.updateEmployeeLastName.Name = "updateEmployeeLastName";
            this.updateEmployeeLastName.Size = new System.Drawing.Size(147, 21);
            this.updateEmployeeLastName.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(517, 20);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 26);
            this.label4.TabIndex = 36;
            this.label4.Text = "Çalışan Güncelle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label6.Location = new System.Drawing.Point(453, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 26);
            this.label6.TabIndex = 35;
            this.label6.Text = "Çalışan İsmi";
            // 
            // updateEmployeeFirstName
            // 
            this.updateEmployeeFirstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.updateEmployeeFirstName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateEmployeeFirstName.Location = new System.Drawing.Point(440, 86);
            this.updateEmployeeFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.updateEmployeeFirstName.Name = "updateEmployeeFirstName";
            this.updateEmployeeFirstName.Size = new System.Drawing.Size(147, 21);
            this.updateEmployeeFirstName.TabIndex = 34;
            // 
            // updateEmployee
            // 
            this.updateEmployee.BackColor = System.Drawing.Color.MidnightBlue;
            this.updateEmployee.Font = new System.Drawing.Font("Nirmala Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateEmployee.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateEmployee.Location = new System.Drawing.Point(610, 137);
            this.updateEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.updateEmployee.Name = "updateEmployee";
            this.updateEmployee.Size = new System.Drawing.Size(77, 31);
            this.updateEmployee.TabIndex = 33;
            this.updateEmployee.Text = "Güncelle";
            this.updateEmployee.UseVisualStyleBackColor = false;
            this.updateEmployee.Click += new System.EventHandler(this.updateEmployee_Click);
            // 
            // goToEmployeeDetails
            // 
            this.goToEmployeeDetails.BackColor = System.Drawing.Color.LightSeaGreen;
            this.goToEmployeeDetails.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goToEmployeeDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.goToEmployeeDetails.Location = new System.Drawing.Point(610, 75);
            this.goToEmployeeDetails.Margin = new System.Windows.Forms.Padding(2);
            this.goToEmployeeDetails.Name = "goToEmployeeDetails";
            this.goToEmployeeDetails.Size = new System.Drawing.Size(147, 52);
            this.goToEmployeeDetails.TabIndex = 39;
            this.goToEmployeeDetails.Text = "Seçili Çalışan Detaylarına Git";
            this.goToEmployeeDetails.UseVisualStyleBackColor = false;
            this.goToEmployeeDetails.Click += new System.EventHandler(this.goToEmployeeDetails_Click);
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(785, 488);
            this.Controls.Add(this.goToEmployeeDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updateEmployeeLastName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.updateEmployeeFirstName);
            this.Controls.Add(this.updateEmployee);
            this.Controls.Add(this.deleteEmployee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addEmployeeLastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addEmployeeFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searcByEmplyeeFirstName);
            this.Controls.Add(this.employeeList);
            this.Controls.Add(this.newEmployee);
            this.Controls.Add(this.turnBack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EmployeePage";
            this.Text = "ÇALIŞANLAR";
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addEmployeeFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searcByEmplyeeFirstName;
        private System.Windows.Forms.Button newEmployee;
        private System.Windows.Forms.Button turnBack;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addEmployeeLastName;
        private System.Windows.Forms.Button deleteEmployee;
        private System.Windows.Forms.DataGridView employeeList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox updateEmployeeLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox updateEmployeeFirstName;
        private System.Windows.Forms.Button updateEmployee;
        private System.Windows.Forms.Button goToEmployeeDetails;
    }
}