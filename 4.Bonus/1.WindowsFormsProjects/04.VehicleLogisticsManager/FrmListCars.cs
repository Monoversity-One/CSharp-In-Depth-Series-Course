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
    public partial class FrmListCars : Form
    {
        public FrmListCars()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmListCars_Load(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("infocar.dat", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string s = "";
            string[] list;
            while ((s = sr.ReadLine()) != null)
            {
                list = s.Split(',');
                listBox1.Items.Add("License Plate:" + list[0] + "\t\t" + "Driver Name:" + list[1] + "\t\t" + "Mobile Number:" + list[2] + "\t\t" + "Address:" + list[3] + "\t\t");
            }
            sr.Close();
            fs.Close();
        }
    }
}
