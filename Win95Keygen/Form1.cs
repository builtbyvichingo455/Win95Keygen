using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Win95Keygen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GenerateKey();
        }
        private static string GenerateKey()
        {
            //Generate day from 100 to 366
            Random rand;
            rand = new Random();
            int day = rand.Next(100, 366);

            //Generate year
            string[] yeararray = { "95", "96", "97", "98", "99", "00", "01", "02", "03" };
            int index = rand.Next(yeararray.Length);
            string year = yeararray[index];

            //Static numbers divisible by 7
            string divisibleby7 = RandomDivisibleBy7();
            //Random numbers
            rand = new Random();
            int randomnumbers = rand.Next(10000, 99999);
            //Make the windows 95 key output

            //TODO: Use "0XXXXXX" instead of "00XXXXX"
            return day.ToString() + year + "-OEM-" + "00" + divisibleby7 + "-" + randomnumbers.ToString();
        }
        public static string RandomDivisibleBy7()
        {
            Random rand = new Random();
            int i = rand.Next(1,3);
            string output = "31584"; //By fallback or else VS 2008 errors out
            if (i == 1)
            {
                output = "31584";
            }
            else if (i == 2)
            {
                output = "39207";
            }
            else if (i == 3)
            {
                output = "77777";
            }
            return output;
        }
    }
}
