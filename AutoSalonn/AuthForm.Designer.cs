namespace AutoSalonn
{
    partial class AuthForm
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
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.InputBtn = new System.Windows.Forms.Button();
            this.RegistrBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите логин";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(62, 36);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(131, 20);
            this.LoginTB.TabIndex = 1;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Location = new System.Drawing.Point(62, 96);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.Size = new System.Drawing.Size(131, 20);
            this.PasswordTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Введите пороль";
            // 
            // InputBtn
            // 
            this.InputBtn.Location = new System.Drawing.Point(12, 122);
            this.InputBtn.Name = "InputBtn";
            this.InputBtn.Size = new System.Drawing.Size(105, 23);
            this.InputBtn.TabIndex = 4;
            this.InputBtn.Text = "Войти";
            this.InputBtn.UseVisualStyleBackColor = true;
            this.InputBtn.Click += new System.EventHandler(this.InputBtn_Click);
            // 
            // RegistrBtn
            // 
            this.RegistrBtn.Location = new System.Drawing.Point(124, 122);
            this.RegistrBtn.Name = "RegistrBtn";
            this.RegistrBtn.Size = new System.Drawing.Size(122, 23);
            this.RegistrBtn.TabIndex = 5;
            this.RegistrBtn.Text = "Зарегистрироваться";
            this.RegistrBtn.UseVisualStyleBackColor = true;
            this.RegistrBtn.Click += new System.EventHandler(this.RegistrBtn_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 163);
            this.Controls.Add(this.RegistrBtn);
            this.Controls.Add(this.InputBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.label1);
            this.Name = "AuthForm";
            this.Text = "AuthForm";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button InputBtn;
        private System.Windows.Forms.Button RegistrBtn;
    }
}