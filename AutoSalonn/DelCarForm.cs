using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public partial class DelCarForm : Form
    {
        public DelCarForm()
        {
            InitializeComponent();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < FiltrForm.cars_list.Count; i++)
            {
                    if (NameBox.Text == FiltrForm.cars_list[i].name)
                    {
                    }
                    else
                    {
                    File.AppendAllText("cars.txt",
                                       FiltrForm.cars_list[i].name + ", " +
                                       FiltrForm.cars_list[i].kuzov + ", " +
                                       FiltrForm.cars_list[i].kpp + ", " +
                                       FiltrForm.cars_list[i].price
                                       Environment.NewLine);

                    MessageBox.Show("Удалено!");
                    Close();
                }
             }
        }
    }
}
