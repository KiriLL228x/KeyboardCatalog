namespace AutoSalonn
{
    partial class AddCarForm
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
            this.NameLB = new System.Windows.Forms.Label();
            this.KppLB = new System.Windows.Forms.Label();
            this.KuzovLB = new System.Windows.Forms.Label();
            this.PriceLB = new System.Windows.Forms.Label();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.KppCB = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Location = new System.Drawing.Point(25, 38);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(83, 13);
            this.NameLB.TabIndex = 0;
            this.NameLB.Text = "Название авто";
            // 
            // KppLB
            // 
            this.KppLB.AutoSize = true;
            this.KppLB.Location = new System.Drawing.Point(25, 86);
            this.KppLB.Name = "KppLB";
            this.KppLB.Size = new System.Drawing.Size(96, 13);
            this.KppLB.TabIndex = 1;
            this.KppLB.Text = "Тип трансмиссии";
            // 
            // KuzovLB
            // 
            this.KuzovLB.AutoSize = true;
            this.KuzovLB.Location = new System.Drawing.Point(25, 64);
            this.KuzovLB.Name = "KuzovLB";
            this.KuzovLB.Size = new System.Drawing.Size(64, 13);
            this.KuzovLB.TabIndex = 2;
            this.KuzovLB.Text = "Тип кузова";
            // 
            // PriceLB
            // 
            this.PriceLB.AutoSize = true;
            this.PriceLB.Location = new System.Drawing.Point(25, 109);
            this.PriceLB.Name = "PriceLB";
            this.PriceLB.Size = new System.Drawing.Size(33, 13);
            this.PriceLB.TabIndex = 3;
            this.PriceLB.Text = "Цена";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(148, 106);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(201, 20);
            this.PriceTB.TabIndex = 4;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(148, 35);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(201, 20);
            this.NameTB.TabIndex = 7;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 132);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(414, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // KppCB
            // 
            this.KppCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KppCB.FormattingEnabled = true;
            this.KppCB.Items.AddRange(new object[] {
            "акпп",
            "мкпп"});
            this.KppCB.Location = new System.Drawing.Point(148, 83);
            this.KppCB.Name = "KppCB";
            this.KppCB.Size = new System.Drawing.Size(196, 21);
            this.KppCB.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Седан ",
            "Универсал ",
            "Хэтчбек.",
            "Лифтбек",
            "Купе",
            "Лимузин",
            "Кабриолет"});
            this.comboBox1.Location = new System.Drawing.Point(148, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(196, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // AddCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.KppCB);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.PriceLB);
            this.Controls.Add(this.KuzovLB);
            this.Controls.Add(this.KppLB);
            this.Controls.Add(this.NameLB);
            this.Name = "AddCarForm";
            this.Text = "AddCarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Label KppLB;
        private System.Windows.Forms.Label KuzovLB;
        private System.Windows.Forms.Label PriceLB;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox KppCB;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}