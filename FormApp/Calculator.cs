using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormApp
{
    public partial class Calculator : Form
    {
        double prev;
        string operation;
        bool isReset = true;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void N1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "1";
                isReset = false;
            }
            else textBox1.Text += "1";
        }

        private void N2_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "2";
                isReset = false;
            }
            else textBox1.Text += "2";
        }

        private void N3_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "3";
                isReset = false;
            }
            else textBox1.Text += "3";
        }

        private void N4_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "4";
                isReset = false;
            }
            else textBox1.Text += "4";
        }

        private void N5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "5";
                isReset = false;
            }
            else textBox1.Text += "5";
        }

        private void N6_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "6";
                isReset = false;
            }
            else textBox1.Text += "6";
        }

        private void N7_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "7";
                isReset = false;
            }
            else textBox1.Text += "7";
        }

        private void N8_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "8";
                isReset = false;
            }
            else textBox1.Text += "8";
        }

        private void N9_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "9";
                isReset = false;
            }
            else textBox1.Text += "9";
        }

        private void N0_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0" && textBox1.Text != null) || isReset)
            {
                textBox1.Text = "0";
                isReset = false;
            }
            else textBox1.Text += "0";
        }

        private void Add_click(object sender, EventArgs e)
        {
            prev = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = "0";
            isReset = true;
            operation = "+";
        }

        private void Sub_click(object sender, EventArgs e)
        {
            prev = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = "0";
            isReset = true;
            operation = "-";
        }

        private void Mul_click(object sender, EventArgs e)
        {
            prev = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = "0";
            isReset = true;
            operation = "*";
        }

        private void Div_Click(object sender, EventArgs e)
        {
            prev = Convert.ToDouble(textBox1.Text);
            //textBox1.Text = "0";
            isReset = true;
            operation = "/";
        }

        private void Nc_click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            isReset = true;
        }

        private void Equal_click(object sender, EventArgs e)
        {
            double cur;

            cur = Convert.ToDouble(textBox1.Text);

            if(operation == "+")
            {
                cur = cur + prev;
                if (Math.Ceiling(cur) == Math.Floor(cur))
                {
                    textBox1.Text = ((int)cur).ToString();
                }
                else
                {
                    textBox1.Text = cur.ToString("G8");
                } 
            }
            if (operation == "-")
            {
                cur = prev - cur;
                if (Math.Ceiling(cur) == Math.Floor(cur))
                {
                    textBox1.Text = ((int)cur).ToString();
                }
                else
                {
                    textBox1.Text = cur.ToString("G8");
                }
            }
            if (operation == "/")
            {
                cur = prev / cur;
                if(Math.Ceiling(cur) == Math.Floor(cur))
                {
                    textBox1.Text = ((int)cur).ToString();
                }
                else
                {
                    textBox1.Text = cur.ToString("G8");
                }
            }
            if (operation == "*")
            {
                cur = cur * prev;
                if (Math.Ceiling(cur) == Math.Floor(cur))
                {
                    textBox1.Text = ((int)cur).ToString();
                }
                else
                {
                    textBox1.Text = cur.ToString("G8");
                }
            }
            isReset = true;
        }

        private void Change_Sign(object sender, EventArgs e)
        {
            if(Convert.ToDouble(textBox1.Text) != 0)
            {
                if (textBox1.Text[0] == '-')
                {
                    textBox1.Text = textBox1.Text.Remove(0, 1);
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;
                }
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
            isReset = false;
        }
    }
}
