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
            string[] strs = File.ReadAllLines("cars.txt");

            foreach (string str in strs)
            {
                string[] parts = str.Split(new string[] { ", " }, StringSplitOptions.None);
                Car car = new Car(parts[0], parts[1], parts[2], Convert.ToInt32(parts[3]));
                FiltrForm.cars_list.Add(car);
            }
        }
        private void добавитьОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
        AddCarForm addCar = new AddCarForm();
                    addCar.ShowDialog();

                    MainForm_Load(null, null);
        }

        private void удалитьОбъектToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelCarForm addCar = new DelCarForm();
            addCar.ShowDialog();

            MainForm_Load(null, null);
        }
    }

       
    
}

