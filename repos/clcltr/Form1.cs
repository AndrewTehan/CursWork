using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;

namespace clcltr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        ArrayList arr = new ArrayList();
        private void button2_Click(object sender, EventArgs e)
        {
            arr.Add(textBox3.Text);
            int cnt = arr.Count;

            if (cnt > 3)
            {
                arr.RemoveAt(0);
                cnt = arr.Count;
            }
            comboBox2.Items.Clear();
            for (int i = 0; i < cnt; i++)
            {
                comboBox2.Items.Add(arr[i]);
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int q = comboBox2.SelectedIndex;//указываем индекс
            //comboBox2.Items.RemoveAt(q);//удаляем
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            arr.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int number = e.KeyChar;
            if (number <= 47 || number >= 58)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (e.KeyChar <= 47 || e.KeyChar >= 58)
            {
                e.Handled = true;
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.BlueViolet;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.FromArgb(0, 192, 0);
        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            this.button3.BackColor = Color.Red;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackColor = Color.White;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                textBox1.BackColor = textBox2.BackColor = Color.White;
                double arg1, arg2;
                arg1 = Convert.ToDouble(textBox1.Text);
                arg2 = Convert.ToDouble(textBox2.Text);

                switch (comboBox1.Text)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(arg1 + arg2);
                        break;
                    case "-":
                        textBox3.Text = Convert.ToString(arg1 - arg2);
                        break;
                    case "*":
                        textBox3.Text = Convert.ToString(arg1 * arg2);
                        break;
                    case "/":
                        try
                        {
                            textBox3.Text = Convert.ToString(arg1 / arg2);
                        }
                        finally
                        {
                            MessageBox.Show("НА 0 ДЕЛИТЬ НЕЛЬЗЯ");
                        }
                        break;
                    case "%":
                        textBox3.Text = Convert.ToString(arg1 % arg2);
                        break;
                    case "Целая часть деления":
                        textBox3.Text = Convert.ToString((int)(arg1 / arg2));
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Введите данные");
                textBox1.BackColor = textBox2.BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}