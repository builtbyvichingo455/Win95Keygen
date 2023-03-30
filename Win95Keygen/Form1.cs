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
            //Generate day from 100 to 365
            Random rand;
            rand = new Random();
            int day = rand.Next(100,365);
            //Generate year
            rand = new Random();
            int i = rand.Next(1,9);
            string year = "95";
            if (i == 1)
            {
                year = "95";
            }
            else if (i == 2)
            {
                year = "96";
            }
            else if (i == 3)
            {
                year = "97";
            }
            else if (i == 4)
            {
                year = "98";
            }
            else if (i == 5)
            {
                year = "99";
            }
            else if (i == 6)
            {
                year = "00";
            }
            else if (i == 7)
            {
                year = "01";
            }
            else if (i == 8)
            {
                year = "02";
            }
            else if (i == 9)
            {
                year = "03";
            }
            //Static numbers divisible by 7
            string divisibleby7 = "00007";
            //Random numbers
            rand = new Random();
            int randomnumbers = rand.Next(10000,99999);
            //Make the windows 95 key output
            return day.ToString() + year + "-OEM-" + "00" + divisibleby7 + "-" + randomnumbers.ToString();
        }
    }
}
