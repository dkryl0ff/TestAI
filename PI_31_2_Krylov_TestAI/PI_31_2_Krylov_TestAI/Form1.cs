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
using PI_31_2_Krylov_TestAI.NeuroNet;

namespace PI_31_2_Krylov_TestAI
{
    public partial class Form1 : Form
    {
        public double[] inputPixels;
        private Network network;
        public Form1()
        {
            InitializeComponent();

            inputPixels = new double[15];
            network = new Network();
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
        private void button_SaveSample_Click(object sender, EventArgs e)
        {
            string name = ((Button)sender).Name == "SaveTrainSample" ? "train.txt" : "test.txt";
            string path = AppDomain.CurrentDomain.BaseDirectory + name;
            string tmpStr = numericUpDown_NecessaryOutput.Value.ToString();

            for (int i = 0; i < inputPixels.Length; i++)
            {
                tmpStr += " " + inputPixels[i].ToString();
            }
            tmpStr += "\n";

            File.AppendAllText(path, tmpStr);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void recongnizebutton_Click(object sender, EventArgs e)
        {
            network.ForwardPass(network, inputPixels);
            label_output.Text = network.Fact.ToList().IndexOf(network.Fact.Max()).ToString();
            label_Probability.Text = (100 * network.Fact.Max()).ToString("0.00") + " %";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Training_Click(object sender, EventArgs e)
        {


            network.Train(network);

            for (int i = 0; i < network.E_error_avr.Length; i++)
            {
                chart_Eavr.Series[0].Points.AddY(network.E_error_avr[i]);
            }

            MessageBox.Show("Обучение успешно завершено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
