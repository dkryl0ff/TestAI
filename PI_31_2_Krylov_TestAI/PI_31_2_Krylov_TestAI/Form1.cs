using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PI_31_2_Krylov_TestAI
{
    public partial class Form1 : Form
    {
        public double[] inputPixels;
        //Конструктор
        public Form1()
        {
            InitializeComponent();

            inputPixels = new double[15];
        }
        private void Changing_State_Pixel_Button_Click(object sender, EventArgs e)
        {
            if (((Button)sender).BackColor == Color.White)
            {
                ((Button)sender).BackColor = Color.Black;
                inputPixels[((Button)sender).TabIndex] = 1d;
            }
            else
            {
                ((Button)sender).BackColor = Color.White;
                inputPixels[((Button)sender).TabIndex] = 0d;
            }
        }
        private void button_SaveTrainSample_Click(object sender)
    }

}
