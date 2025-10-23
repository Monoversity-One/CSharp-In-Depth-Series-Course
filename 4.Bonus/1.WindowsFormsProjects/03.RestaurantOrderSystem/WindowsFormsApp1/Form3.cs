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
    public partial class Form3 : Form
    {

        public List<int> orderIds = orderFuncs.CurrentOrderIds();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Select Food Please...");
            }
            else
            {
                
                dynamic food = comboBox1.Items[comboBox1.SelectedIndex];

                bool canAdd = orderFuncs.CanAddFood(food.Value, 
                    int.Parse(numericUpDown1.Value.ToString()));

                if (canAdd)
                {
                    int rowId = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowId];

                    row.Cells["foodid"].Value = food.Value;
                    row.Cells["foodname"].Value = food.Text;
                    row.Cells["foodcount"].Value = numericUpDown1.Value;

                    food fd = orderFuncs.GetFoodById(food.Value);
                    fd.Count = fd.Count - int.Parse(numericUpDown1.Value.ToString());
                    
                    foodFuncs.Update(fd.Id,fd.Name,fd.Count,fd.Price);

                    CalculateTotalPrice();
                }
                else
                {
                    MessageBox.Show("Food Count Is Not Available ...");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            button3.Enabled = false;

            CalculateTotalPrice();
        }

        public void CalculateTotalPrice()
        {
            List<food> foods = new List<food>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                food fd = new food()
                {
                    Id = int.Parse(row.Cells["foodid"].Value.ToString()),
                    Count = int.Parse(row.Cells["foodcount"].Value.ToString()),
                };

                foods.Add(fd);
            }


           label4.Text = orderFuncs.CalculateFoodsPrices(foods).ToString();
        }
      

        private void Form3_Load(object sender, EventArgs e)
        {
            List<food> foods = foodFuncs.Read();

            comboBox1.DisplayMember = "Text";
            comboBox1.ValueMember = "Value";

            foreach (var item in foods)
            {
                comboBox1.Items.Add(new { Text = item.Name, Value = item.Id });
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            order ord = new order();
            ord.foods = new List<food>();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                food fd = new food()
                {
                    Id = int.Parse(row.Cells["foodid"].Value.ToString()),
                    Count = int.Parse(row.Cells["foodcount"].Value.ToString())
                };

                ord.foods.Add(fd);
            }



            Random rand = new Random();

            int randId = rand.Next(1, int.MaxValue);
            while (orderIds.Contains(randId))
            {
                randId = rand.Next(1, int.MaxValue);
            }

            ord.Id = randId;

            orderFuncs.Add(ord);

            this.Close();
        }
    }
}
