using AutoSalonn.Properties;
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
    public struct Mouse
    {
        public string name;
        public string ves;
        public string sens;
        public string G;
        public string form;
        public int price;
        public Button btn;
        public PictureBox pb;

        public Mouse(string _name, string _ves, string _sens, string _G, string _form, int _price)
        {
            name = _name;
            ves = _ves;
            sens = _sens;
            G = _G;
            form = _form;
            price = _price;
            btn = new Button();
            btn.Text = name;
            pb = new PictureBox();
            try
            {
                pb.Load("../../Pictures/" + name + ".jpg");
            }
            catch (Exception) { }
        }
    }

    public partial class FiltrForm : Form
    {
        public static List<Mouse> Mouse_list = new List<Mouse>();

        public FiltrForm()
        {
            InitializeComponent();

            int x = 10;
            int y = 10;

            for (int i = 0; i < Mouse_list.Count; i++)
            {
                Mouse_list[i].btn.Font = new Font("Microsoft Sans Serif", 12F);
                Mouse_list[i].btn.Location = new Point(x, y);
                Mouse_list[i].btn.Size = new Size(200, 30);
                Mouse_list[i].btn.Click += new EventHandler(carClick);
                CarsPanel.Controls.Add(Mouse_list[i].btn);

                Mouse_list[i].pb.Location = new Point(x, y);
                Mouse_list[i].pb.Size = new Size(200, 200);
                Mouse_list[i].pb.SizeMode = PictureBoxSizeMode.Zoom;
                CarsPanel.Controls.Add(Mouse_list[i].pb);

                x += 210;
                if (x + 200 > CarsPanel.Width)
                {
                    x = 10;
                    y += 210;
                }
            }
        }

        private void FiltrForm_Load(object sender, EventArgs e)
        {

        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 10;
            for (int i = 0; i < Mouse_list.Count; i++)
            {
                Mouse_list[i].btn.Visible = true;
                Mouse_list[i].pb.Visible = true;

                
                if (priceTextBox.Text != "" &&
                    Convert.ToInt32(priceTextBox.Text) < Mouse_list[i].price)
                {
                    Mouse_list[i].btn.Visible = false;
                    Mouse_list[i].pb.Visible = false;
                }

                if (Mouse_list[i].btn.Visible)
                {
                    Mouse_list[i].btn.Location = new Point(x, y);
                    Mouse_list[i].pb.Location = new Point(x, y);

                    x += 210;
                    if (x + 200 > CarsPanel.Width)
                    {
                        x = 10;
                        y += 210;
                    }
                }
            }
        }

        public static void carClick(object sender, EventArgs e)
        {
            for (int i = 0; i < Mouse_list.Count; i++)
            {
                if (((Button)sender).Text == Mouse_list[i].btn.Text)
                {
                    MouseForm mouse = new MouseForm(Mouse_list[i]);
                    mouse.ShowDialog();
                }
            }
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void priceTextBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void CarsPanel_Resize(object sender, EventArgs e)
        {
            FindButton_Click(null, null);
        }

        private void HideButton_Click(object sender, EventArgs e)
        {

        }
    }
}
