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
    public partial class FrmListCustomers : Form
    {
        public FrmListCustomers()
        {
            InitializeComponent();
        }

        private void FrmListCustomers_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("infocustomers.dat", FileMode.Open,FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = "";
            string[] list;
            while ((s = sr.ReadLine()) != null)
            {
                list = s.Split(',');
                listBox1.Items.Add("Subscription ID:" + list[0] + "\t\t" + "Name:" + list[1] + "\t\t" + "Phone:" + list[2] + "\t\t" + "Address:" + list[3] + "\t\t");
            }
            sr.Close();
            fs.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
