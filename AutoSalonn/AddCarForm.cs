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
            File.AppendAllText("cars.txt", Environment.NewLine +
                NameTB.Text + ", " +
                KuzovTB.Text + ", " +
                KppCB.Text + ", " +
                PriceTB.Text);
            MessageBox.Show("Сохранено");
        }
    }
}
