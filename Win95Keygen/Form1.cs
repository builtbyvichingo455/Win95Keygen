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
            string[] yeararray = { "31584", "39207", "77777", "13811", "97408", "65908", "34421", "96526", "82121" };
            int index = rand.Next(yeararray.Length);
            string output = yeararray[index];
            return output;
        }
    }
}
