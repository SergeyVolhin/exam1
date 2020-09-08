using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Стоимость_телефонного_разговора
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBoxX.Text);
            double y = Convert.ToDouble(textBoxY.Text);
            double z = 1 * x;
            double percent = z * 0.2;
            if (y == 6 || y == 7) z = z - percent;
            MessageBox.Show("Ваш разговор длился " +x+ " минут. Вы говорили в " +y+ " день недели. Стоимость разговора " +z+
               " руб." );
        }
    }
}
