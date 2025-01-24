using System;

namespace ProjePilot.Forms
{
    partial class LoginPage
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
        private void LoginPage_Load(object sender, EventArgs e)
        {
            // İlgili kodları buraya ekleyin veya bu metodun içeriğini kullanmadığınız için silebilirsiniz.
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.login = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.loginUserName = new System.Windows.Forms.TextBox();
            this.loginUserPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hideShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.SystemColors.Desktop;
            this.login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.login.ForeColor = System.Drawing.Color.White;
            this.login.Location = new System.Drawing.Point(305, 298);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(264, 41);
            this.login.TabIndex = 0;
            this.login.Text = "GİRİŞ YAP";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // register
            // 
            this.register.BackColor = System.Drawing.SystemColors.ControlText;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Muli SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.Info;
            this.register.Location = new System.Drawing.Point(432, 385);
            this.register.Margin = new System.Windows.Forms.Padding(2);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(137, 35);
            this.register.TabIndex = 1;
            this.register.Text = "KAYIT OL!";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // loginUserName
            // 
            this.loginUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginUserName.Location = new System.Drawing.Point(305, 154);
            this.loginUserName.Margin = new System.Windows.Forms.Padding(2);
            this.loginUserName.Name = "loginUserName";
            this.loginUserName.Size = new System.Drawing.Size(264, 35);
            this.loginUserName.TabIndex = 2;
            // 
            // loginUserPassword
            // 
            this.loginUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginUserPassword.Location = new System.Drawing.Point(305, 237);
            this.loginUserPassword.Margin = new System.Windows.Forms.Padding(2);
            this.loginUserPassword.Name = "loginUserPassword";
            this.loginUserPassword.Size = new System.Drawing.Size(264, 35);
            this.loginUserPassword.TabIndex = 3;
            this.loginUserPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(300, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(300, 210);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Parola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(293, 394);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hesabın yok mu ?";
            // 
            // hideShow
            // 
            this.hideShow.AutoSize = true;
            this.hideShow.BackColor = System.Drawing.Color.Black;
            this.hideShow.Font = new System.Drawing.Font("Lucida Sans Unicode", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hideShow.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.hideShow.Location = new System.Drawing.Point(461, 272);
            this.hideShow.Margin = new System.Windows.Forms.Padding(2);
            this.hideShow.Name = "hideShow";
            this.hideShow.Size = new System.Drawing.Size(82, 22);
            this.hideShow.TabIndex = 7;
            this.hideShow.Text = "Göster";
            this.hideShow.UseVisualStyleBackColor = false;
            this.hideShow.CheckedChanged += new System.EventHandler(this.hideShow_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 530);
            this.Controls.Add(this.hideShow);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginUserPassword);
            this.Controls.Add(this.loginUserName);
            this.Controls.Add(this.register);
            this.Controls.Add(this.login);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginPage";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.TextBox loginUserName;
        private System.Windows.Forms.TextBox loginUserPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox hideShow;
    }
}