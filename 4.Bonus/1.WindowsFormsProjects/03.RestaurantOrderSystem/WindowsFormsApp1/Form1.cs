using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RestaurantOrderSystem.Functions;
using RestaurantOrderSystem.Models;

namespace RestaurantOrderSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrintTable();
        }


        public void PrintTable()
        {
            List<order> orders = orderFuncs.Read();

            dataGridView1.Rows.Clear();

            foreach (var item in orders)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];

                string foodsNames = string.Empty;
                foreach (var food in item.foods)
                {
                    foodsNames += food.Name + ",";
                }

                row.Cells["id"].Value = item.Id;
                row.Cells["foods"].Value = foodsNames;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PrintTable();
        }
    }
}
