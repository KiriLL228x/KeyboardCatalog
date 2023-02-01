using System;
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
    struct Keybrd
    {
        public string name;
        public string keycap;
        public string typpodc;
        public int price;
        public Button btn;

        

        public Keybrd(string _name, string _keycap, string _typpodc, int _price, _)
        {
            name = _name;
            keycap = _keycap;
            typpodc = _typpodc;
            price = _price;
        }
    }
    public partial class filter : Form
    {
        Keybrd[] cars_list = new Keybrd[3];
        public filter()
        {
            InitializeComponent();
            cars_list[0] = new Keybrd("G300", "Red", "Беспроводная", 3000);
            cars_list[1] = new Keybrd("R400", "Grey", "Проводная", 4000);
            cars_list[2] = new Keybrd("S233", "Blue", "Bluetooth", 6000);
        }

        private void filter_Load(object sender, EventArgs e)
        {

        }

        private void find_button_Click(object sender, EventArgs e)
        {
            for(int i=0; i<3; i++)
                if (comboBox1.Text == cars_list[i].typpodc)
                {
                    MessageBox.Show(cars_list[i].typpodc);
                }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
