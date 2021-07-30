using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm1
{
    public partial class Form2 : Form
    {
        public int QuantityMadden;
        public int Quantity2K20;
        public int QuantityTutleBeaches;

        public Order MyOrder = new Order();// creates an instance of the order variable
        public Form2()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            
        }

        public void UpdateFields()//creates the function for total
        {
            textBox4.Text = (MyOrder.Total).ToString();
            DateTime delivery = new DateTime();
            delivery = DateTime.Now;
            delivery = delivery.AddDays(2);
            dateTimePicker1.Value = delivery;

            foreach(Product P in MyOrder.Prods)
            {
                listBox1.Items.Add(P.ProductName +" $" + P.ProductPrice.ToString());
            }


        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            MessageBox.Show("thank you for your purchase, please wait 2-3 business days for all delivery's to arrive. Pickups are to be picked up within store hours. OPENED M-F 9AM-5PM, CLOSED Sat-Sun. ", "Shopping Cart") ;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
