namespace AutoSalonn
{
    partial class SendMailForm
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
            this.ExitBbutton = new System.Windows.Forms.Button();
            this.SendButton = new System.Windows.Forms.Button();
            this.AdressTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ExitBbutton
            // 
            this.ExitBbutton.Location = new System.Drawing.Point(256, 107);
            this.ExitBbutton.Name = "ExitBbutton";
            this.ExitBbutton.Size = new System.Drawing.Size(180, 45);
            this.ExitBbutton.TabIndex = 5;
            this.ExitBbutton.Text = "Отмена";
            this.ExitBbutton.UseVisualStyleBackColor = true;
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(32, 107);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(180, 45);
            this.SendButton.TabIndex = 4;
            this.SendButton.Text = "Отправить";
            this.SendButton.UseVisualStyleBackColor = true;
            // 
            // AdressTextBox
            // 
            this.AdressTextBox.Location = new System.Drawing.Point(32, 40);
            this.AdressTextBox.Name = "AdressTextBox";
            this.AdressTextBox.Size = new System.Drawing.Size(404, 20);
            this.AdressTextBox.TabIndex = 3;
            // 
            // SendMailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 199);
            this.Controls.Add(this.ExitBbutton);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.AdressTextBox);
            this.Name = "SendMailForm";
            this.Text = "SendMailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitBbutton;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox AdressTextBox;
    }
}