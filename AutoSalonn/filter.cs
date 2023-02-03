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
        public PictureBox pic;

        

        public Keybrd(string _name, string _keycap, string _typpodc, int _price, Button _btn, PictureBox _pic)
        {
            name = _name;
            keycap = _keycap;
            typpodc = _typpodc;
            price = _price;
            btn = _btn;
            pic = _pic;
        }
    }
    public partial class filter : Form
    {
        Keybrd[] cars_list = new Keybrd[3];
        public filter()
        {
            InitializeComponent();
            cars_list[0] = new Keybrd("G300", "Red", "Беспроводная", 3000, button1, pictureBox1);
            cars_list[1] = new Keybrd("R400", "Grey", "Проводная", 4000, button3, pictureBox2);
            cars_list[2] = new Keybrd("S233", "Blue", "Bluetooth", 6000, button2, pictureBox3);
        }

        private void filter_Load(object sender, EventArgs e)
        {
            

        }

        private void find_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                cars_list[i].btn.Visible = true;
                cars_list[i].pic.Visible = true;

                if (name_comboBox.Text != "" &&
                    name_comboBox.Text != cars_list[i].name)
                {
                    cars_list[i].btn.Visible = false;
                    cars_list[i].pic.Visible = false;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            CarForm car = new CarForm(btn.Text);
            car.Show();
        }

       
    }
}
