using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoSalonn
{
    public partial class DelCarForm : Form
    {
        public DelCarForm()
        {
            InitializeComponent();
            for(int i=0; i<FiltrForm.cars_list.Count; i++)
            {
                comboBox1.Items.Add(FiltrForm.cars_list[i].name);
            }
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы точно желаете удалить объект???", "Внимание!!!", MessageBoxButtons.YesNo );
            if (result == DialogResult.Yes)
            {
                File.Delete("cars.txt");
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
                                        FiltrForm.cars_list[i].price +
                                        Environment.NewLine);
                    }
                    MessageBox.Show("Удаление прошло успешно");
                    Close();
                }
            }   
                
           
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NameBox.Text = comboBox1.Text;
        }
    }
}
