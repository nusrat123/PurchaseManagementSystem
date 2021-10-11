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
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "nusrat" )
             {
                if(textBox2.Text == "101")
                {
                    label3.Text = "Access Granted !";

                    purchase p = new purchase(textBox1.Text, textBox2.Text);
                    p.ShowDialog();

                    textBox1.Clear();
                    textBox2.Clear();
                }
                else
                {
                    MessageBox.Show(" Incorrect password ! Try again !");

                    textBox1.Clear();
                    textBox2.Clear();
                }

             }
             else
             {
                 label3.Text = "** Access Denied ! Try again !!";
                 textBox1.Clear();
                 textBox2.Clear();
             }

        }
    }
}
