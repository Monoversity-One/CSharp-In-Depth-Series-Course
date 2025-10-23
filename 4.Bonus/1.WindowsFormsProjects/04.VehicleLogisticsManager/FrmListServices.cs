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
    public partial class FrmListServices : Form
    {
        private void getlist()
        {
            FileStream fs = new FileStream("infoservice.dat", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = "";
            string[] list;
            listBox1.Items.Clear();
            while ((s = sr.ReadLine()) != null)
            {
                list = s.Split(',');
                listBox1.Items.Add("Driver Name:" + list[0] + "\t\t" + "Subscription ID:" + list[1] + "\t\t" + "Customer Name:" + list[2] + "\t\t" + "Address:" + list[3] + "\t\t");
            }
            sr.Close();
            fs.Close();
        }
        public FrmListServices()
        {
            InitializeComponent();
        }

        private void FrmListServis_Load(object sender, EventArgs e)
        {
            getlist();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("infoservice.dat", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(textBox1.Text + "," + textBox2.Text + "," + textBox3.Text + "," + textBox4.Text);
            sw.Close();
            fs.Close();
            MessageBox.Show("New service registered");
            getlist();
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
