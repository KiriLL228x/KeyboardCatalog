﻿namespace AutoSalonn
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.HelpButton = new System.Windows.Forms.Button();
            this.FiltrButton = new System.Windows.Forms.Button();
            this.SelectedButton = new System.Windows.Forms.Button();
            this.AddcontextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьОбъектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddcontextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpButton
            // 
            this.HelpButton.BackColor = System.Drawing.Color.Purple;
            this.HelpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HelpButton.ForeColor = System.Drawing.SystemColors.Info;
            this.HelpButton.Location = new System.Drawing.Point(11, 255);
            this.HelpButton.Margin = new System.Windows.Forms.Padding(2);
            this.HelpButton.Name = "HelpButton";
            this.HelpButton.Size = new System.Drawing.Size(170, 53);
            this.HelpButton.TabIndex = 8;
            this.HelpButton.Text = "Помощь";
            this.HelpButton.UseVisualStyleBackColor = false;
            this.HelpButton.Click += new System.EventHandler(this.HelpButton_Click);
            // 
            // FiltrButton
            // 
            this.FiltrButton.BackColor = System.Drawing.Color.Navy;
            this.FiltrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FiltrButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FiltrButton.Location = new System.Drawing.Point(11, 144);
            this.FiltrButton.Margin = new System.Windows.Forms.Padding(2);
            this.FiltrButton.Name = "FiltrButton";
            this.FiltrButton.Size = new System.Drawing.Size(137, 36);
            this.FiltrButton.TabIndex = 15;
            this.FiltrButton.Text = "Варианты";
            this.FiltrButton.UseVisualStyleBackColor = false;
            this.FiltrButton.Click += new System.EventHandler(this.FiltrButton_Click);
            // 
            // SelectedButton
            // 
            this.SelectedButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedButton.ForeColor = System.Drawing.SystemColors.Info;
            this.SelectedButton.Location = new System.Drawing.Point(11, 184);
            this.SelectedButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedButton.Name = "SelectedButton";
            this.SelectedButton.Size = new System.Drawing.Size(170, 67);
            this.SelectedButton.TabIndex = 24;
            this.SelectedButton.Text = "Избранное";
            this.SelectedButton.UseVisualStyleBackColor = false;
            this.SelectedButton.Click += new System.EventHandler(this.SelectedButton_Click);
            // 
            // AddcontextMenu
            // 
            this.AddcontextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьОбъектToolStripMenuItem});
            this.AddcontextMenu.Name = "AddcontextMenu";
            this.AddcontextMenu.Size = new System.Drawing.Size(181, 48);
            // 
            // добавитьОбъектToolStripMenuItem
            // 
            this.добавитьОбъектToolStripMenuItem.Name = "добавитьОбъектToolStripMenuItem";
            this.добавитьОбъектToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьОбъектToolStripMenuItem.Text = "добавить объект";
            this.добавитьОбъектToolStripMenuItem.Click += new System.EventHandler(this.добавитьОбъектToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::AutoSalonn.Properties.Resources.W8tnZ2g;
            this.ClientSize = new System.Drawing.Size(861, 609);
            this.ContextMenuStrip = this.AddcontextMenu;
            this.Controls.Add(this.SelectedButton);
            this.Controls.Add(this.FiltrButton);
            this.Controls.Add(this.HelpButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AddcontextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button HelpButton;
        private System.Windows.Forms.Button FiltrButton;
        private System.Windows.Forms.Button SelectedButton;
        private System.Windows.Forms.ContextMenuStrip AddcontextMenu;
        private System.Windows.Forms.ToolStripMenuItem добавитьОбъектToolStripMenuItem;
    }
}

