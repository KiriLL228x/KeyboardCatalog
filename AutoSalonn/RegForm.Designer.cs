namespace AutoSalonn
{
    partial class RegForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasTB = new System.Windows.Forms.TextBox();
            this.Regbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SecondNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Pas2TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пороль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Логин";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(113, 11);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 20);
            this.NameTB.TabIndex = 4;
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(113, 58);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(100, 20);
            this.LoginTB.TabIndex = 5;
            // 
            // PasTB
            // 
            this.PasTB.Location = new System.Drawing.Point(113, 84);
            this.PasTB.Name = "PasTB";
            this.PasTB.Size = new System.Drawing.Size(100, 20);
            this.PasTB.TabIndex = 6;
            // 
            // Regbtn
            // 
            this.Regbtn.Location = new System.Drawing.Point(61, 148);
            this.Regbtn.Name = "Regbtn";
            this.Regbtn.Size = new System.Drawing.Size(115, 23);
            this.Regbtn.TabIndex = 7;
            this.Regbtn.Text = "Регистрация";
            this.Regbtn.UseVisualStyleBackColor = true;
            this.Regbtn.Click += new System.EventHandler(this.Regbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Имя";
            // 
            // SecondNameTB
            // 
            this.SecondNameTB.Location = new System.Drawing.Point(113, 35);
            this.SecondNameTB.Name = "SecondNameTB";
            this.SecondNameTB.Size = new System.Drawing.Size(100, 20);
            this.SecondNameTB.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Подвердите пороль";
            // 
            // Pas2TB
            // 
            this.Pas2TB.Location = new System.Drawing.Point(113, 110);
            this.Pas2TB.Name = "Pas2TB";
            this.Pas2TB.Size = new System.Drawing.Size(100, 20);
            this.Pas2TB.TabIndex = 11;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 183);
            this.Controls.Add(this.Pas2TB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SecondNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Regbtn);
            this.Controls.Add(this.PasTB);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasTB;
        private System.Windows.Forms.Button Regbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SecondNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Pas2TB;
    }
}