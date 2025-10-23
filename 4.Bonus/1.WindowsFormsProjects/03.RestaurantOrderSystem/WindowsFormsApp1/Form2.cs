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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public List<int> foodIds = foodFuncs.CurrentFoodIds();

        private void button1_Click(object sender, EventArgs e)
        {

            Random rand = new Random();

            int randId = rand.Next(1, int.MaxValue);
            while (foodIds.Contains(randId))
            {
                randId = rand.Next(1, int.MaxValue);
            }


            foodFuncs.Add(randId,textBox1.Text,
                int.Parse(numericUpDown1.Value.ToString()),
                float.Parse(textBox2.Text));

            PrintTable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foodFuncs.Update(int.Parse(textBox3.Text),
                                textBox1.Text,
                                int.Parse(numericUpDown1.Value.ToString()),
                                float.Parse(textBox2.Text));

            button2.Enabled = false;

            PrintTable();
        }


        public void PrintTable()
        {
            List<food> foods = foodFuncs.Read();



            dataGridView1.Rows.Clear();

            foreach (var item in foods)
            {
                int rowId = dataGridView1.Rows.Add();
                DataGridViewRow row = dataGridView1.Rows[rowId];


                row.Cells["id"].Value = item.Id;
                row.Cells["name"].Value = item.Name;
                row.Cells["count"].Value = item.Count;
                row.Cells["price"].Value = item.Price;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            PrintTable();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox1.Text = dataGridView1[1, dataGridView1.CurrentRow.Index].Value.ToString();
            textBox2.Text = dataGridView1[3, dataGridView1.CurrentRow.Index].Value.ToString();
            numericUpDown1.Value = decimal.Parse(dataGridView1[2, dataGridView1.CurrentRow.Index].Value.ToString());


            button2.Enabled = true;
        }

    }
}
