using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace СSARP_Калькулятор
{
   

    
    public partial class Form1 : Form
    {
        public class CALC
        {
            public double deystvie(double a,double b, int action){
                switch (action)
                {
                    case 1:
                        return a + b; 
                        break;
                    case 2:
                        return a - b;
                        break;
                    case 3:
                        return a * b;
                        break;
                    case 4:
                        return a/b;
                        break;
                    case 0:
                        return a;
                    default:
                       
                        return 0;
                }
            }
        }
        double result = 0, a = 0, b=0,MR=0;
        CALC C = new CALC();
        int action=0;
        public Form1()
        {
           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            action = 4;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(MR);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MR = MR + Convert.ToDouble(textBox1.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            action = 1;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            action = 2;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            action = 3;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MR = MR - Convert.ToDouble(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            MessageBox.Show("RED");
        }

        private void button21_Click(object sender, EventArgs e)
        {
             MessageBox.Show("Yellow");
        }

        private void Blue_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Blue");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            MessageBox.Show("purple");
            
        }

        private void button23_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Green");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            a = 0;
            b = 0;
            result = 0;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
         
            b = Convert.ToDouble(textBox1.Text);
            result = C.deystvie(a, b, action);
            textBox1.Text = Convert.ToString(result);
            a = 0;
            b = 0;
            result = 0;
        }
    }
}
