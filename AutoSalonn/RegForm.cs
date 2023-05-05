using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            if (NameTB.Text == "" && SecondNameTB.Text == "" && LoginTB.Text == "" && PasTB.Text == "" && Pas2TB.Text == "")
            {
                MessageBox.Show("Всё на этой старнице, обезательно к заполнению!");
            }
            else
            { 
            if (PasTB.Text == Pas2TB.Text)
            {


                File.AppendAllText("users.txt",
                                NameTB.Text + ", " +
                                SecondNameTB.Text + ", " +
                                LoginTB.Text + ", " +
                                PasTB.Text + ", 0" +
                                Environment.NewLine);

                MessageBox.Show("Регистрация прошла успешно");
                Close();
            }
            else MessageBox.Show("Пароли не совпадают");
            }
        }
    }
}
