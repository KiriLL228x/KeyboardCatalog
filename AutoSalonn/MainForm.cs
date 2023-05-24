using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            HelpForm hf = new HelpForm();
            hf.ShowDialog();
        }

        private void CarClick(object sender, EventArgs e)
        {
            FiltrForm.carClick(sender, e);
        }

        private void FiltrButton_Click(object sender, EventArgs e)
        {
            FiltrForm filtr = new FiltrForm();
            filtr.ShowDialog();
        }

        private void SelectedButton_Click(object sender, EventArgs e)
        {
            SelectedForm select = new SelectedForm();
            select.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            FiltrForm.Mouse_list.Clear();
            string[] strs = File.ReadAllLines("mouse.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                Mouse mouse = new Mouse(parts[0], parts[1], parts[2], parts[3], parts[4], Convert.ToInt32(parts[3]));
                FiltrForm.Mouse_list.Add(mouse);
            }
        }

        private void добавитьОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthForm.isAdmin)
            {
                AddMouseForm addMouse = new AddMouseForm();
                addMouse.ShowDialog();
            }
            else
            {
                MessageBox.Show("Изменения может производить только админитсратор");
            }

            MainForm_Load(null, null);
        }

        private void удалитьОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AuthForm.isAdmin)
            {
                DelMouseForm delMouse = new DelMouseForm();
                delMouse.ShowDialog();
            }
            else
            {
                MessageBox.Show("Изменения может производить только админитсратор");
            }

            MainForm_Load(null, null);
        }




        private void input_Click(object sender, EventArgs e)
        {
            if (AuthForm.name == "")
            {
                AuthForm auth = new AuthForm();
                auth.ShowDialog();
            }
            else
            {
                AuthForm.name = "";
            }

            if (AuthForm.name == "")
            {
                label1.Text = "";
                input.Text = "Войти";
            }
            else
            {
                label1.Text = "Вы авторизовались как  " + AuthForm.name + " " + AuthForm.secname;
                input.Text = "Выйти";
            }

        }

        private void FeedBackButton_Click(object sender, EventArgs e)
        {
            FeedBackForm feedBack = new FeedBackForm();
            feedBack.ShowDialog();
        }
    }

       
    
}

