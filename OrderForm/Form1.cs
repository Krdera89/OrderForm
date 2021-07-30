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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "1";
            }
            else
            {
                int val = Convert.ToInt32(textBox1.Text);
                val++;
                textBox1.Text = val.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "1";
            }
            else
            {
                int val = Convert.ToInt32(textBox2.Text);
                val++;
                textBox2.Text = val.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "1";
            }
            else
            {
                int val = Convert.ToInt32(textBox3.Text);
                val++;
                textBox3.Text = val.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();// creates an instance of form2 and opens new form2
            frm2.QuantityMadden = Convert.ToInt32(textBox1.Text); ///passes Quantity to madden.

            frm2.Quantity2K20 = Convert.ToInt32(textBox2.Text); ///passes Quantity to 2K.
            frm2.QuantityTutleBeaches = Convert.ToInt32(textBox3.Text); ///passes Quantity to TurtleBeaches .

            



            frm2.Show();//shows form 2 

            Product Madden = new Product();
            Product NBA2K20 = new Product();
            Product TurtleBeaches = new Product();

            Madden.ProductDescription = "A video game about football";
            NBA2K20.ProductDescription = "A video game about basketball";
            TurtleBeaches.ProductDescription = "A microphone for the game console";

            Madden.ProductPrice = 60.00;
            NBA2K20.ProductPrice = 60.00;
            TurtleBeaches.ProductPrice = 69.00;

            Madden.ProductName = "Madden 20";
            NBA2K20.ProductName = "NBA2K20";
            TurtleBeaches.ProductName = "TurtleBeaches";


            Madden.Quantity = Convert.ToInt32(textBox1.Text);//Converts a string to an integer.
            NBA2K20.Quantity = Convert.ToInt32(textBox2.Text);//Converts a string to an integer.
            TurtleBeaches.Quantity = Convert.ToInt32(textBox3.Text);//Converts a string to an integer.
            if (Madden.Quantity > 0)
            {
                frm2.MyOrder.Prods.Add(Madden);
            }
            if (NBA2K20.Quantity > 0)
            {
                frm2.MyOrder.Prods.Add(NBA2K20);
            }
            if (TurtleBeaches.Quantity > 0)
            {
                frm2.MyOrder.Prods.Add(TurtleBeaches);
            }//This only adds the product to the orderlist if it is greater than 0.
            
            frm2.UpdateFields();// creates instance updated fields for my total

        }
    }
    }
    

