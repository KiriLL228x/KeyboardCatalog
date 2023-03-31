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
    public partial class SelectedForm : Form
    {
        public static Dictionary<Car, int> MyCars = new Dictionary<Car, int>();

        public SelectedForm()
        {
            InitializeComponent();
            ReDraw();
        }
        void ReDraw()
        {
            Controls.Clear();

            int x = 10;
            int y = 10;

            foreach (KeyValuePair<Car, int> myCar in MyCars)
            {
                Car car = myCar.Key;
                #region
                PictureBox pb = new PictureBox();
                pb.Image = car.pb.Image;
                pb.Location = new Point(x, y + AutoScrollPosition.Y);
                pb.Size = new Size(200, 200);
                pb.SizeMode = PictureBoxSizeMode.Zoom;
                Controls.Add(pb);

                Label lbl_name = new Label();
                lbl_name.Text = "Модель: " + car.name;
                lbl_name.Font = new Font("Microsoft Sans Serif", 12F);
                lbl_name.Location = new Point(x + 220, y + AutoScrollPosition.Y);
                lbl_name.Size = new Size(200, 30);
                Controls.Add(lbl_name);
                #endregion

                #region
                Button btn = new Button();
                btn.Text = car.btn.Text;
                btn.Font = new Font("Microsoft Sans Serif", 12F);
                btn.Location = new Point(x + 440, y + 100 + AutoScrollPosition.Y);
                btn.Size = new Size(200, 30);
                btn.Click += new EventHandler(FiltrForm.carClick);
                Controls.Add(btn);
                #endregion

                #region
                Button btndelete = new Button();
                btndelete.Text = "Удалить";
                btndelete.Font = new Font("Microsoft Sans Serif", 12F);
                btndelete.Location = new Point(x + 660, y + AutoScrollPosition.Y);
                btndelete.Size = new Size(200, 30);
                btndelete.Click += new EventHandler(DeleteClick);
                Controls.Add(btndelete);
                #endregion

                y += 210;
            }
        }

        void DeleteClick(object sender, EventArgs e)
        {
            int i = 0;
            Button btn = (Button)sender;
            Dictionary<Car, int> MyCars1 = new Dictionary<Car, int>();
                foreach (KeyValuePair<Car, int> myCar in MyCars)
                {
                    if(btn.Location == new Point(670, 210*i + 10 + AutoScrollPosition.Y))
                    {

                    }
                    else
                    {
                    MyCars1[myCar.Key] = myCar.Value;
                    }
                    i++;
                }
            MyCars = MyCars1;
            ReDraw();
        }

        private void SelectedForm_Load(object sender, EventArgs e)
        {

        }
    }
}
