using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System;

namespace RestaurantBill
{
    public partial class Form1 : Form
    {
        double subtotal = 0, tax = 0, total = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "$0.00";
            textBox4.Text = "$0.00";
            textBox5.Text = "$0.00";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        subtotal += 1.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 1:
                    {
                        subtotal += 1.5;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 2:
                    {
                        subtotal += 1.25;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 3:
                    {
                        subtotal += 2.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 4:
                    {
                        subtotal += 2.5;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 5:
                    {
                        subtotal += 1.5;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
            }
            textBox3.Text = "$" + Math.Floor(subtotal * 100) / 100;
            textBox4.Text = "$" + tax.ToString();
            textBox5.Text = "$" + Math.Floor(total * 1000) / 1000;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        subtotal += 5.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 1:
                    {
                        subtotal += 6.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 2:
                    {
                        subtotal += 8.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 3:
                    {
                        subtotal += 8.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 4:
                    {
                        subtotal += 10.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 5:
                    {
                        subtotal += 12.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 6:
                    {
                        subtotal += 6.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
            }
            textBox3.Text = "$" + Math.Floor(subtotal * 100) / 100;
            textBox4.Text = "$" + tax.ToString();
            textBox5.Text = "$" + Math.Floor(total * 1000) / 1000;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox3.SelectedIndex)
            {
                case 0:
                    {
                        subtotal += 15.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 1:
                    {
                        subtotal += 13.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 2:
                    {
                        subtotal += 13.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 3:
                    {
                        subtotal += 11.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 4:
                    {
                        subtotal += 19.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 5:
                    {
                        subtotal += 20.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 6:
                    {
                        subtotal += 18.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 7:
                    {
                        subtotal += 13.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 8:
                    {
                        subtotal += 14.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
            }
            textBox3.Text = "$" + Math.Floor(subtotal * 100) / 100;
            textBox4.Text = "$" + tax.ToString();
            textBox5.Text = "$" + Math.Floor(total * 1000) / 1000;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox4.SelectedIndex)
            {
                case 0:
                    {
                        subtotal += 5.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 1:
                    {
                        subtotal += 3.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 2:
                    {
                        subtotal += 5.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 3:
                    {
                        subtotal += 4.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
                case 4:
                    {
                        subtotal += 5.95;
                        tax = subtotal * (0.16);
                        total = subtotal + tax;
                        break;
                    }
            }
            textBox3.Text = "$" + Math.Floor(subtotal * 100) / 100;
            textBox4.Text = "$" + tax.ToString();
            textBox5.Text = "$" + Math.Floor(total * 1000) / 1000;
        }
    }
}
