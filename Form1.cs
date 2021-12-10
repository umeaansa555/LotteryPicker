using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotteryPicker
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        List<int> numbers = new List<int>();
        int randTemp;
        int MaxValue = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputLabel.Text = "Your Number: ";
            //num1 = randGen.Next(1, 8);
            //num2 = randGen.Next(1, 8);
            //num3 = randGen.Next(1, 8);
            //num4 = randGen.Next(1, 8);
            //num5 = randGen.Next(1, 8);
            //num6 = randGen.Next(1, 8);


            //while (num2 == num1)
            //{
            //    num2 = randGen.Next(1, 8);
            //}
            //while (num3 == num1 || num3 == num2)
            //{
            //    num3 = randGen.Next(1, 8);
            //}
            //while (num4 == num1 || num4 == num2 || num4 == num3)
            //{
            //    num4 = randGen.Next(1, 8);
            //}
            //while (num5 == num1 || num5 == num2 || num5 == num3 || num5 == num4)
            //{
            //    num5 = randGen.Next(1, 8);
            //}
            //while (num6 == num1 || num6 == num2 || num6 == num3 || num6 == num4 || num6 == num5)
            //{
            //    num6 = randGen.Next(1, 8);
            //}

            //outputLabel.Text += $"{num1} {num2} {num3} {num4} {num5} {num6}";


            for (int i = 0; i > numbers.Count; i++)
            {
                randTemp = randGen.Next(1,7);
                    while(numbers.Contains(randTemp))
                {
                    randTemp = randGen.Next(1,7);
                }
                numbers.Add(randTemp);

            }
            outputLabel.Text += numbers + "\n";
        }
    }
}