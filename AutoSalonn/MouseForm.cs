using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace AutoSalonn
{
    public partial class MouseForm : Form
    {
        Mouse mouse;
        public MouseForm(Mouse _mouse)
        {
            mouse = _mouse;
            InitializeComponent();

            Text = mouse.name;
            label1.Text = mouse.name;
            try
            {
                pictureBox1.Load("../../Pictures/" + mouse.name + ".jpg");
            }
            catch (Exception) { }
            try
            {
                    textBox1.Text = File.ReadAllText("../../Pictures/" + mouse.name + ".txt");
            }
            catch (Exception) { } 

        }

        private void CarForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (SelectedForm.MyMouses.ContainsKey(mouse))
            {
                SelectedForm.MyMouses[mouse]++;
            }
            else
            {
                SelectedForm.MyMouses.Add(mouse, 1);
            }
        }

        
    }
}
