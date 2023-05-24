namespace AutoSalonn
{
    partial class AddMouseForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.VesCB = new System.Windows.Forms.TextBox();
            this.SensCB = new System.Windows.Forms.TextBox();
            this.Gcb = new System.Windows.Forms.TextBox();
            this.FormCB = new System.Windows.Forms.TextBox();
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Location = new System.Drawing.Point(32, 42);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(57, 13);
            this.NameLB.TabIndex = 0;
            this.NameLB.Text = "Название";
            // 
            // KppLB
            // 
            this.KppLB.AutoSize = true;
            this.KppLB.Location = new System.Drawing.Point(32, 94);
            this.KppLB.Name = "KppLB";
            this.KppLB.Size = new System.Drawing.Size(44, 13);
            this.KppLB.TabIndex = 1;
            this.KppLB.Text = "Сенсор";
            // 
            // KuzovLB
            // 
            this.KuzovLB.AutoSize = true;
            this.KuzovLB.Location = new System.Drawing.Point(32, 69);
            this.KuzovLB.Name = "KuzovLB";
            this.KuzovLB.Size = new System.Drawing.Size(26, 13);
            this.KuzovLB.TabIndex = 2;
            this.KuzovLB.Text = "Вес";
            // 
            // PriceLB
            // 
            this.PriceLB.AutoSize = true;
            this.PriceLB.Location = new System.Drawing.Point(32, 174);
            this.PriceLB.Name = "PriceLB";
            this.PriceLB.Size = new System.Drawing.Size(33, 13);
            this.PriceLB.TabIndex = 3;
            this.PriceLB.Text = "Цена";
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(148, 167);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(201, 20);
            this.PriceTB.TabIndex = 4;
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(148, 39);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(201, 20);
            this.NameTB.TabIndex = 7;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(12, 390);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(414, 23);
            this.SaveBtn.TabIndex = 8;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "Загрузить картинку";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(148, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 104);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Добавить описание";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ускорение";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Размер";
            // 
            // VesCB
            // 
            this.VesCB.Location = new System.Drawing.Point(148, 62);
            this.VesCB.Name = "VesCB";
            this.VesCB.Size = new System.Drawing.Size(201, 20);
            this.VesCB.TabIndex = 19;
            // 
            // SensCB
            // 
            this.SensCB.Location = new System.Drawing.Point(148, 87);
            this.SensCB.Name = "SensCB";
            this.SensCB.Size = new System.Drawing.Size(201, 20);
            this.SensCB.TabIndex = 20;
            // 
            // Gcb
            // 
            this.Gcb.Location = new System.Drawing.Point(148, 113);
            this.Gcb.Name = "Gcb";
            this.Gcb.Size = new System.Drawing.Size(201, 20);
            this.Gcb.TabIndex = 21;
            // 
            // FormCB
            // 
            this.FormCB.Location = new System.Drawing.Point(148, 142);
            this.FormCB.Name = "FormCB";
            this.FormCB.Size = new System.Drawing.Size(201, 20);
            this.FormCB.TabIndex = 22;
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Location = new System.Drawing.Point(148, 313);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(201, 20);
            this.InfoTextBox.TabIndex = 23;
            // 
            // AddMouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 426);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.FormCB);
            this.Controls.Add(this.Gcb);
            this.Controls.Add(this.SensCB);
            this.Controls.Add(this.VesCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.PriceTB);
            this.Controls.Add(this.PriceLB);
            this.Controls.Add(this.KuzovLB);
            this.Controls.Add(this.KppLB);
            this.Controls.Add(this.NameLB);
            this.Name = "AddMouseForm";
            this.Text = "AddCarForm";
            this.Load += new System.EventHandler(this.AddCarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox VesCB;
        private System.Windows.Forms.TextBox SensCB;
        private System.Windows.Forms.TextBox Gcb;
        private System.Windows.Forms.TextBox FormCB;
        private System.Windows.Forms.TextBox InfoTextBox;
    }
}