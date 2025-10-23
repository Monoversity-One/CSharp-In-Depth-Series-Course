using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VehicleLogisticsManager
{
    public partial class FindCustomer : Form
    {
        public FindCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("infocustomers.dat", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = "";
            string[] list;
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            while ((s = sr.ReadLine()) != null)
            {
                list = s.Split(',');
                if (list[0] == textBox1.Text)
                {
                    textBox2.Text = list[1];
                    textBox3.Text = list[2];
                    textBox4.Text = list[3];
                }
            }
            sr.Close();
            fs.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
