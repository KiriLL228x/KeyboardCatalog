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
    public partial class AddMouseForm : Form
    {
        public AddMouseForm()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            int a;
            if(!Int32.TryParse(PriceTB.Text, out a))
            {
                MessageBox.Show("Цена не число!");
                return;
            }

            if (NameTB.Text == "" || VesCB.Text == "" || SensCB.Text == "" || Gcb.Text == "" || FormCB.Text == "")
            {
                MessageBox.Show("Название обязательно для ввода");
                return;
            }

            File.AppendAllText("mouse.txt",
                NameTB.Text + ", " +
                VesCB.Text + ", " +
                SensCB.Text + ", " +
                Gcb.Text + ", " +
                FormCB.Text + ", " +
                PriceTB.Text +
                Environment.NewLine);
           

            if (FileNme != "")
            {
                File.Copy(FileNme, "../../Pictures/" + NameTB.Text + ".jpg");
            }

            File.AppendAllText("../../Pictures/" + NameTB.Text + ".txt", InfoTextBox.Text);


            MessageBox.Show("Сохранено");
            Close();
        }

       
        string FileNme = "";
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
            FileNme = openFileDialog1.FileName;
            pictureBox1.Load(FileNme);
            }
        }

        private void AddCarForm_Load(object sender, EventArgs e)
        {

        }
    }
}
