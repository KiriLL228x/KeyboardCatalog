using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AutoSalonn
{
    public partial class CarForm : Form
    {
        public CarForm(string carName)
        {
            InitializeComponent();

            Text = carName;
            label1.Text = carName;
            try
            {
                pictureBox1.Load("../../Pictures/" + carName + ".jpg");
                textBox1.Text = File.ReadAllText("../../Pictures/" + carName + ".txt");
            }
            catch (Exception) { }
        /*
            if (carName == "G300")
            {
                textBox1.Text = "Модель - G300" +
                                System.Environment.NewLine +
                                "Кейкапы - Red" +
                                System.Environment.NewLine +
                                "Тип подключения - беспроводная";         
            }

            if (carName == "R400")
            {
                textBox1.Text = "Модель - R400" +
                                 System.Environment.NewLine +
                                 "Кейкапы - Blue" +
                                 System.Environment.NewLine +
                                 "Тип подключения - проводная";
            }

            if (carName == "S233")
            {
                textBox1.Text = "Модель - S233" +
                                System.Environment.NewLine +
                                "Кейкапы - Gray" +
                                System.Environment.NewLine +
                                "Тип подключения - Bluetooth";
            }
          */
        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
