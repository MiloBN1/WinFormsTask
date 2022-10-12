using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restraunt2
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        ArrayList records = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) {
                label1.Text = "Введите свое имя";
                return;
            }
            
            if (!textBox2.Text.Contains(dayPicker.Text))
            {
                textBox2.Clear();
                string day = dayPicker.Text;
                string name = textBox1.Text;                
                records.Add(name + " " + day);
                foreach (string names in records)
                {
                    textBox2.Text += names + Environment.NewLine + " ---------------------------------------------------------------------" + Environment.NewLine;
                }
                label1.Text = "";
                textBox1.Clear();
            }
            else
            {
                label1.Text = "этот день забронирован";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
