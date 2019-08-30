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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bilimselToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
            toolStripLabel1.Text = "Bilimsel";
        }

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            toolStripLabel1.Text = "Standart";
        }
        bool islembutonu, sabit, eks = true;
        double hesap = 0;
        string temp = "";
        private void ortakclick(object sender, EventArgs e)
        {
            if (label1.Text == "0" || islembutonu || sabit)
                label1.Text = "";



            Button button = (Button)sender;
            label1.Text += button.Text;
            islembutonu = false;
        }

        private void islemclick(object sender, EventArgs e)
        {
            islembutonu = true;
            Button btn = (Button)sender;
            string newtemp = btn.Text;
            label2.Text += " " + label1.Text + " " + newtemp;
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

        private void Form2_Load(object sender, EventArgs e)
        {
            toolStripLabel1.Text = "Bilimsel";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double ussu = double.Parse(label1.Text);
            label1.Text = (Math.Pow(10, ussu)).ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double log = double.Parse(label1.Text);
            label1.Text = Math.Log10(log).ToString();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (eks)
            {

                double sin = ((double.Parse(label1.Text) * (Math.PI)) / 180);
                label1.Text = Math.Sin(sin).ToString();
            }
            else
            {

                double Asin = double.Parse(label1.Text);
                label1.Text = Math.Asin(Asin).ToString();
            }

        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (eks)
            {

                double cos = ((double.Parse(label1.Text) * (Math.PI)) / 180);
                label1.Text = Math.Acos(cos).ToString();
            }
            else
            {

                double Acos = double.Parse(label1.Text);
                label1.Text = Math.Acos(Acos).ToString();
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (eks)
            {

                double tan = ((double.Parse(label1.Text) * (Math.PI)) / 180);
                label1.Text = Math.Tan(tan).ToString();
            }
            else
            {

                double Atan = double.Parse(label1.Text);
                label1.Text = Math.Atan(Atan).ToString();
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double kök = double.Parse(label1.Text);
            kök = Math.Sqrt(kök);
            label1.Text = kök.ToString();
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
            listBox1.Items.Add(label2.Text + sonrakam.ToString() + "=" + hesap.ToString());
            temp = "";
            label2.Text = "";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            double tersi = double.Parse(label1.Text) * -1;
            label1.Text = tersi.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            islembutonu = false;
            temp = "";
            hesap = 0;
            label1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label1.Text = "0";
        }

        private void button32_Click(object sender, EventArgs e)
        {
            double xkare = double.Parse(label1.Text);
            xkare = Math.Pow(xkare, 2);
            label1.Text = xkare.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (button25.BackColor == Color.Gainsboro)
            {
                button25.Location = new Point(545, 0);
                this.Size = new Size(607, 456);
                button25.BackColor = Color.LightSteelBlue;
            }
            else
            {
                button25.Location = new Point(239, 0);
                this.Size = new Size(290, 453);
                button25.BackColor = Color.Gainsboro;
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += "(";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.Text == "0")
            {
                label1.Text = "";
            }

            label1.Text += ")";
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
        int i = 0;
        double m_toplam = 0;
        double[] m_Sayilari;


        private void button38_Click(object sender, EventArgs e)
        {
            i++;
            m_Sayilari= new double[i];
            m_Sayilari[i - 1] = double.Parse(label1.Text);
            foreach (var item in m_Sayilari)
            {
                m_toplam += item;
                
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            foreach (var item in m_Sayilari)
            {
                label2.Text += item.ToString()+"+";

            }
            label1.Text = m_toplam.ToString();
        }

        private void button27_Click(object sender, EventArgs e)
        {

            if (eks)
            {
                button34.Text = "Asin";
                button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                button35.Text = "Acos";
                button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                button36.Text = "Atan";
                button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
                button27.BackColor = Color.Silver;
                eks = false;

            }
            else
            {
                button34.Text = "sin";
                button34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                button35.Text = "cos";
                button35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                button36.Text = "tan";
                button36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
                button27.BackColor = Color.Gainsboro;
                eks = true;
            }

        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (islembutonu == true)
            {

                label1.Text += Math.PI;

            }
            else
            {
                label1.Text = "";
                label1.Text += Math.PI;

            }
            sabit = true;
        }
    }
}
