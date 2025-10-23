using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EmployeePayrollDemo
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Darsadi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RdoDarsadi_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoDarsadi.Checked)
            {
                LblDarsadForosh.Visible = true;
                TxtSales.Visible = true;
            }
        }

        private void RdoGarardadi_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoGarardadi.Checked)
            {
                LblDarsadForosh.Visible = false;
                TxtSales.Visible = false;
            }
        }

        private void RdoRasmi_CheckedChanged(object sender, EventArgs e)
        {
            if (RdoRasmi.Checked)
            {
                LblDarsadForosh.Visible = false;
                TxtSales.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RdoGarardadi.Checked)
            {
                PriceEmployee pemployee = new PriceEmployee();
                pemployee.Add(TxtName.Text, TxtHireDate.Text, int.Parse(TxtSalary.Text));
                listBox1.Items.Add(pemployee.GetInfo());
            }
            else if (RdoRasmi.Checked)
            {
                SalariedEmployee semployee = new SalariedEmployee();
                semployee.Add(TxtName.Text, TxtHireDate.Text, int.Parse(TxtSalary.Text));
                listBox1.Items.Add(semployee.GetInfo());
            }
            else if (RdoDarsadi.Checked)
            {
                CommissionEmployee cemployee = new CommissionEmployee();
                cemployee.Add(TxtName.Text, TxtHireDate.Text, int.Parse(TxtSalary.Text), int.Parse(TxtSales.Text));
                listBox1.Items.Add(cemployee.GetInfo());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TxtName.Text = "";
            TxtHireDate.Text = "";
            RdoGarardadi.Checked = true;
            TxtSalary.Text = "";
            TxtSales.Text = "";

        }
    }
}
