using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            label10.Text = " ";

        }

        private void button1_Click(object sender, EventArgs e)
        {



            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0 && textBox5.TextLength >= 10)
            {

            label5.Text = textBox1.Text;
            label6.Text = textBox2.Text;
            label7.Text = textBox3.Text;
            label8.Text = textBox4.Text;
            string save = textBox5.Text,save2;
                if(textBox5.TextLength==10)
                {
                    save=textBox5.Text.Remove(0, 1);
                    save2 = "09" + save;
                    label12.Text = save2;
                }
                else
                {
                    if (textBox5.TextLength == 11)
                    {
                        save = textBox5.Text.Remove(0,2);
                        save2 = "09" + save;
                        label12.Text = save2;
                    }
                }
                    
                


            }
            else
            {
                label10.Text="فیلد ها را کامل و درست پر کنید";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label10.Text = " ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            label10.Text = " ";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label10.Text = " ";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";
            label12.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0)
            {
                int a, b=1402;
                a = int.Parse(textBox4.Text);
                a = b - a;
                label9.Text = a.ToString();
            }
            else
            {
                label10.Text = "فیلد ها را کامل و درست پر کنید";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
