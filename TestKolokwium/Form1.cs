using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestKolokwium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonPrac.Checked)
            {
                Pracownik_Dzialu pracownik = new Pracownik_Dzialu(Convert.ToDouble(textBox6.Text), textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToDouble(textBox5.Text));
                richTextBox1.Text = pracownik.DaneWiew();
                
            }
            else if(radioButtonKier.Checked) 
            {
                Kierownik_Dzialu kierownik = new Kierownik_Dzialu(Convert.ToInt32(textBox7.Text), textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text), Convert.ToDouble(textBox5.Text));
                richTextBox1.Text = kierownik.KierownikWiew();
            }
        }

        private void radioButtonPrac_CheckedChanged(object sender, EventArgs e)
        {
            textBox7.Visible = false;
            textBox6.Visible = true;
        }

        private void radioButtonKier_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Visible = false;
            textBox7 .Visible = true;
        }
    }
}
