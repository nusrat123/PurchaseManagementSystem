using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PurchaseManagementSystem
{
    public partial class purchase : Form
    {
       // char st;
        public purchase()
        {
            InitializeComponent();
        }

        public purchase(String value1, String value2)
        {
            InitializeComponent();
            // label1.Text = value;
            this.Value1 = value1;
            this.Value2 = value2;
        }

        public String Value1 { get; set; }
        public String Value2 { get; set; }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void purchase_Load(object sender, EventArgs e)
        {
            textBox12.Text = Value1;
            textBox13.Text = Value2;
        }

        private void textbox_key(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (!Char.IsDigit(c) && c != 8)
            {
                e.Handled = true;

            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            int u1, a1, u2, a2, u3, a3, u4, a4, u5, a5, sum_price;
            double sum= 0.00;

            try
            {
                u1 = int.Parse(textBox1.Text);
                u2 = int.Parse(textBox2.Text);
                u3 = int.Parse(textBox3.Text);
                u4 = int.Parse(textBox4.Text);
                u5 = int.Parse(textBox5.Text);
                a1 = int.Parse(textBox6.Text);
                a2 = int.Parse(textBox7.Text);
                a3 = int.Parse(textBox8.Text);
                a4 = int.Parse(textBox9.Text);
                a5 = int.Parse(textBox10.Text);

                if ((u1 <= 100 && u2 <= 100 && u3 <= 100 && u4 <= 100 && u5 <= 100) && (a1 <= 10 && a2 <= 10 && a3 <= 10 && a4 <= 10 && a5 <= 10))
                {
                    sum_price = (u1 * a1) + (u2 * a2) + (u3 * a3) + (u4 * a4) + (u5 * a5);

                    //  sum = 100.75;
                    //  textBox11.Text = sum.ToString();

                    if (sum_price <= 1000)
                    {
                        textBox11.Text = sum_price.ToString();
                    }
                    else if (sum_price > 1000 && sum_price < 2000)
                    {
                        sum = Convert.ToDouble(sum_price);
                        sum = sum + sum * 0.05;

                        textBox11.Text = sum.ToString();
                    }
                    else if (sum_price >= 2000 && sum_price < 3500)
                    {
                        sum = Convert.ToDouble(sum_price);
                        sum = sum + sum * 0.10;

                        textBox11.Text = sum.ToString();
                    }
                    else if (sum_price >= 3500)
                    {
                        sum = Convert.ToDouble(sum_price);
                        sum = sum + sum * 0.15;

                        textBox11.Text = sum.ToString();
                    }


                }
                else
                {
                    MessageBox.Show("you have exceeded the number of Unit Price or Amount");
                }
            }
            catch(Exception )
            {
                MessageBox.Show(" Input field may be empty !");
            }

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int a = textBox1.Text.Length;
            if(a>2)
            {
                if(textBox1.Text != "100")
                {
                    MessageBox.Show("you have exceeded the number of Unit Price. Unit Price can be at most 100 ");
                }
               
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            int a = textBox2.Text.Length;
            if (a > 2)
            {
                if (textBox2.Text != "100")
                {
                    MessageBox.Show("you have exceeded the number of Unit Price. Unit Price can be at most 100 ");
                }

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int a = textBox3.Text.Length;
            if (a > 2)
            {
                if (textBox3.Text != "100")
                {
                    MessageBox.Show("you have exceeded the number of Unit Price. Unit Price can be at most 100 ");
                }

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            int a = textBox4.Text.Length;
            if (a > 2)
            {
                if (textBox4.Text != "100")
                {
                    MessageBox.Show("you have exceeded the number of Unit Price. Unit Price can be at most 100 ");
                }

            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            int a = textBox5.Text.Length;
            if (a > 2)
            {
                if (textBox5.Text != "100")
                {
                    MessageBox.Show("you have exceeded the number of Unit Price. Unit Price can be at most 100 ");
                }

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            int a = textBox6.Text.Length;
            if (a > 1)
            {
                if (textBox6.Text != "10")
                {
                    MessageBox.Show("you have exceeded the number of Amount . Amount can be at most 10 ");
                }

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            int a = textBox7.Text.Length;
            if (a > 1)
            {
                if (textBox7.Text != "10")
                {
                    MessageBox.Show("you have exceeded the number of Amount . Amount can be at most 10 ");
                }

            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int a = textBox8.Text.Length;
            if (a > 1)
            {
                if (textBox8.Text != "10")
                {
                    MessageBox.Show("you have exceeded the number of Amount . Amount can be at most 10 ");
                }

            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            int a = textBox9.Text.Length;
            if (a > 1)
            {
                if (textBox9.Text != "10")
                {
                    MessageBox.Show("you have exceeded the number of Amount . Amount can be at most 10 ");
                }

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            int a = textBox10.Text.Length;
            if (a > 1)
            {
                if (textBox10.Text != "10")
                {
                    MessageBox.Show("you have exceeded the number of Amount . Amount can be at most 10 ");
                }

            }
        }
    }
}
