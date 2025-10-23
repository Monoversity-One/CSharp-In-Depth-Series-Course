using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VehicleLogisticsManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void CustomerManagementMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NewCustomerMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCustomer fadd =new  FrmAddCustomer();
            fadd.ShowDialog();
            fadd.Dispose();
        }

        private void CustomerListMenuItem_Click(object sender, EventArgs e)
        {
            FrmListCustomers flist = new FrmListCustomers();
            flist.ShowDialog();
            flist.Dispose();
        }

        private void FindCustomerMenuItem_Click(object sender, EventArgs e)
        {
            FindCustomer ffind = new FindCustomer();
            ffind.ShowDialog();
            ffind.Dispose();
        }

        private void AddVehicleMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddCar fadd = new FrmAddCar();
            fadd.ShowDialog();
            fadd.Dispose();
        }

        private void VehicleListMenuItem_Click(object sender, EventArgs e)
        {
            FrmListCars flist = new FrmListCars();
            flist.ShowDialog();
            flist.Dispose();
        }

        private void ServiceListMenuItem_Click(object sender, EventArgs e)
        {
            FrmListServices flist = new FrmListServices();
            flist.ShowDialog();
            flist.Dispose();
        }
    }
}
