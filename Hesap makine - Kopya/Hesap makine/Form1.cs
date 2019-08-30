using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_makine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool islembutonu;
        double hesap = 0;
        string temp = "";
        private void OrtkClick(object sender, EventArgs e)
        {
            if (label1.Text == "0" || islembutonu)
                label1.Text = "";



            Button button = (Button)sender;
            label1.Text += button.Text;
            islembutonu = false;
        }

        private void Islemclick(object sender, EventArgs e)
        {
            islembutonu = true;
            Button btn = (Button)sender;
            string newtemp = btn.Text;
            label2.Text = label2.Text + " " + label1.Text + " " + newtemp;
            if (temp == "+")
            {
                label1.Text = (hesap + Double.Parse(label1.Text)).ToString();
            }
            else if (temp == "-")
            {
                label1.Text = (hesap - Double.Parse(label1.Text)).ToString();
            }
            else if (temp == "x")
            {
                label1.Text = (hesap * Double.Parse(label1.Text)).ToString();
            }
            else if (temp == "÷")
            {
                label1.Text = (hesap / Double.Parse(label1.Text)).ToString();
            }
            hesap = double.Parse(label1.Text);
            label1.Text = hesap.ToString();
            temp = newtemp;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            islembutonu = false;
            temp = "";
            hesap = 0;
            label1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double sonrakam = double.Parse(label1.Text);
            islembutonu = true;
            if (temp == "+")
            {
                label1.Text = (hesap + Double.Parse(label1.Text)).ToString();
            }
            else if (temp == "-")
            {
                label1.Text = (hesap - Double.Parse(label1.Text)).ToString();
            }
            else if (temp == "x")
            {
                label1.Text = (hesap * Double.Parse(label1.Text)).ToString();
            }
            else if (temp == "÷")
            {
                label1.Text = (hesap / Double.Parse(label1.Text)).ToString();
            }
            hesap = double.Parse(label1.Text);
            label1.Text = hesap.ToString();
            listBox1.Items.Add(label2.Text+sonrakam.ToString()+ "=" + hesap.ToString());
            temp = "";
            label2.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "0";
            }
            else if (islembutonu)
            {
                label1.Text = "0";
            }

            if (!label1.Text.Contains(","))
            {
                label1.Text += ",";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double tersi = double.Parse(label1.Text) * -1;
            label1.Text = tersi.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (label1.Text.Length > 1)
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
            }
            else
            {
                label1.Text = "0";
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            double xkare = double.Parse(label1.Text);
            xkare = Math.Pow(xkare, 2);
            label1.Text = xkare.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double kök = double.Parse(label1.Text);
            kök = Math.Sqrt(kök);
            label1.Text = kök.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double bolu = double.Parse(label1.Text);
            label1.Text = (1 / bolu).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double yuzde = double.Parse(label1.Text);
            label1.Text = (yuzde / 100).ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.Gainsboro)
            {
                button25.Location = new Point(602, 0);
                this.Size = new Size(656, 554);
                button25.BackColor = Color.LightSteelBlue;
            }
            else
            {
                button25.Location = new Point(242, 0);
                this.Size = new Size(295, 552);
                button25.BackColor = Color.Gainsboro;
            }

            }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
       
        }

        private void bilimselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Standart";
        }
    }
    }

