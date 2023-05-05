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
    public partial class AddCarForm : Form
    {
        public AddCarForm()
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

            if (NameTB.Text == "" || KuzovCB.Text == "" || KppCB.Text == "")
            {
                MessageBox.Show("Название обезательно для ввода");
                return;
            }

            File.AppendAllText("cars.txt",
                NameTB.Text + ", " +
                KuzovCB.Text + ", " +
                KppCB.Text + ", " +
                PriceTB.Text +
                Environment.NewLine);
           

            if (FileNme != "")
            {
                File.Copy(FileNme, "../../Pictures/" + NameTB + ".jpg");
            }

            File.AppendAllText("../../Pictures/" + NameTB + ".txt",Inftb.Text);
                

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

       
    }
}
