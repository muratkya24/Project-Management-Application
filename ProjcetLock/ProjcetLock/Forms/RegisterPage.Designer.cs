namespace ProjePilot.Forms
{
    partial class RegisterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterPage));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.turnBack = new System.Windows.Forms.Button();
            this.newUserFirstName = new System.Windows.Forms.TextBox();
            this.newUserLastName = new System.Windows.Forms.TextBox();
            this.newUserName = new System.Windows.Forms.TextBox();
            this.newUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.register = new System.Windows.Forms.Button();
            this.hideShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // turnBack
            // 
            this.turnBack.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.turnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.turnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnBack.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnBack.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.turnBack.Location = new System.Drawing.Point(11, 395);
            this.turnBack.Margin = new System.Windows.Forms.Padding(2);
            this.turnBack.Name = "turnBack";
            this.turnBack.Size = new System.Drawing.Size(109, 37);
            this.turnBack.TabIndex = 0;
            this.turnBack.Text = "Geri";
            this.turnBack.UseVisualStyleBackColor = false;
            this.turnBack.Click += new System.EventHandler(this.turnBack_Click);
            // 
            // newUserFirstName
            // 
            this.newUserFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserFirstName.Location = new System.Drawing.Point(231, 86);
            this.newUserFirstName.Margin = new System.Windows.Forms.Padding(2);
            this.newUserFirstName.Name = "newUserFirstName";
            this.newUserFirstName.Size = new System.Drawing.Size(171, 26);
            this.newUserFirstName.TabIndex = 1;
            // 
            // newUserLastName
            // 
            this.newUserLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserLastName.Location = new System.Drawing.Point(231, 147);
            this.newUserLastName.Margin = new System.Windows.Forms.Padding(2);
            this.newUserLastName.Name = "newUserLastName";
            this.newUserLastName.Size = new System.Drawing.Size(171, 26);
            this.newUserLastName.TabIndex = 2;
            // 
            // newUserName
            // 
            this.newUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserName.Location = new System.Drawing.Point(231, 204);
            this.newUserName.Margin = new System.Windows.Forms.Padding(2);
            this.newUserName.Name = "newUserName";
            this.newUserName.Size = new System.Drawing.Size(171, 26);
            this.newUserName.TabIndex = 3;
            // 
            // newUserPassword
            // 
            this.newUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newUserPassword.Location = new System.Drawing.Point(231, 264);
            this.newUserPassword.Margin = new System.Windows.Forms.Padding(2);
            this.newUserPassword.Name = "newUserPassword";
            this.newUserPassword.Size = new System.Drawing.Size(169, 26);
            this.newUserPassword.TabIndex = 4;
            this.newUserPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(229, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(227, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Soyadı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(227, 181);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(227, 237);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Parola";
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.Color.BlueViolet;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.register.ForeColor = System.Drawing.SystemColors.Info;
            this.register.Location = new System.Drawing.Point(252, 300);
            this.register.Margin = new System.Windows.Forms.Padding(2);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(116, 41);
            this.register.TabIndex = 11;
            this.register.Text = "KAYIT OL";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // hideShow
            // 
            this.hideShow.AutoSize = true;
            this.hideShow.BackColor = System.Drawing.Color.Black;
            this.hideShow.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideShow.ForeColor = System.Drawing.SystemColors.Control;
            this.hideShow.Location = new System.Drawing.Point(325, 237);
            this.hideShow.Margin = new System.Windows.Forms.Padding(2);
            this.hideShow.Name = "hideShow";
            this.hideShow.Size = new System.Drawing.Size(75, 23);
            this.hideShow.TabIndex = 12;
            this.hideShow.Text = "Göster";
            this.hideShow.UseVisualStyleBackColor = false;
            this.hideShow.CheckedChanged += new System.EventHandler(this.hideShow_CheckedChanged);
            // 
            // RegisterPage
            // 
            this.AcceptButton = this.turnBack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.turnBack;
            this.ClientSize = new System.Drawing.Size(659, 443);
            this.Controls.Add(this.hideShow);
            this.Controls.Add(this.register);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newUserPassword);
            this.Controls.Add(this.newUserName);
            this.Controls.Add(this.newUserLastName);
            this.Controls.Add(this.newUserFirstName);
            this.Controls.Add(this.turnBack);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegisterPage";
            this.Text = "KAYIT OL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button turnBack;
        private System.Windows.Forms.TextBox newUserFirstName;
        private System.Windows.Forms.TextBox newUserLastName;
        private System.Windows.Forms.TextBox newUserName;
        private System.Windows.Forms.TextBox newUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.CheckBox hideShow;
    }
}