using PolymorphismBasicExam.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphismBasicExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        German german = new German();
        Italian italian = new Italian();
        Turkish turkish = new Turkish();
        private void timer1_Tick(object sender, EventArgs e)
        {
            labelGermanCar.Left += german.Hizlan();
            labelItalianCar.Left += italian.Hizlan();
            labelTurkishCar.Left += turkish.Hizlan();
            if (labelGermanCar.Right>= labelFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("German Car Won!");
            }
            else if (labelItalianCar.Right>=labelFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("İtalian Car Won!");
            }
            else if (labelTurkishCar.Right>= labelFinish.Left)
            {
                timer1.Stop();
                MessageBox.Show("Turkish Car Won!");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
