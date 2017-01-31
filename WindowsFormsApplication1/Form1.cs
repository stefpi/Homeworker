using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int timeleft;

        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 

            timer1.Interval = 1000;

            

            int positive = rnd.Next(1, 3);

            if (positive == 1)
            {
                label10.Font = new Font("Consolas", 12);
                
                label10.Text = "If plan A doesn't work, the alphabet has 25 more letters! Stay Cool -- Anonymous Internet User";
            }

            else if (positive == 2)
            {
                label10.Font = new Font("Consolas", 16);
                label10.TextAlign = ContentAlignment.MiddleCenter;
                label10.Text = "Nothing worth having comes easy       -- Anonymous Internet user";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            int timechange = Convert.ToInt32(textBox8.Text);
            this.label1.Text = Convert.ToString(timechange * 60);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timeleft = Convert.ToInt32(label1.Text);
 //           timer1.Start();

            if (timer1.Enabled)
            {
                timer1.Stop();
            }
            else
            {
                timer1.Start();
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeleft > 0)
            {
                timeleft = timeleft - 1;
                this.label1.Text = timeleft.ToString();
            }
            else
            {
                timer1.Stop();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int reset = Convert.ToInt32(textBox8.Text);
            timeleft = Convert.ToInt32(reset * 60);
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.EndsWith("1", StringComparison.CurrentCultureIgnoreCase))
            {
                label3.Text = textBox2.Text.Replace("1", "");
            }

            else if (textBox2.Text.EndsWith("2", StringComparison.CurrentCultureIgnoreCase))
            {
                label4.Text = textBox2.Text.Replace("2", "");
            }

            else if (textBox2.Text.EndsWith("3", StringComparison.CurrentCultureIgnoreCase))
            {
                label5.Text = textBox2.Text.Replace("3", "");
            }

            else if (textBox2.Text.EndsWith("4", StringComparison.CurrentCultureIgnoreCase))
            {
                label6.Text = textBox2.Text.Replace("4", "");
            }

            else if (textBox2.Text.EndsWith("5", StringComparison.CurrentCultureIgnoreCase))
            {
                label7.Text = textBox2.Text.Replace("5", "");
            }

            else if (textBox2.Text.EndsWith("6", StringComparison.CurrentCultureIgnoreCase))
            {
                label8.Text = textBox2.Text.Replace("6", "");
            }

            else if (textBox2.Text.EndsWith("7", StringComparison.CurrentCultureIgnoreCase))
            {
                label9.Text = textBox2.Text.Replace("7", "");
            }


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
