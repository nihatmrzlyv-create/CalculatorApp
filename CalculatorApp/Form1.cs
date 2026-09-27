using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(textBox1.Text);
                double num2 = Convert.ToDouble(textBox2.Text);

                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Zəhmət olmasa bir əməliyyat seçin (+, -, *, /)!");
                    return;
                }

                string command = comboBox1.SelectedItem.ToString();
                double result = 0;

                if (command == "+")
                {
                    result = num1 + num2;
                }
                else if (command == "-")
                {
                    result = num1 - num2;
                }
                else if (command == "*")
                {
                    result = num1 * num2;
                }
                else if (command == "/")
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("Sıfıra bölmək olmaz!");
                        return;
                    }
                    result = num1 / num2;
                }

                label4.Text = "Answer: " + result;
            }
            catch
            {
                MessageBox.Show("Məlumatları düzgün daxil edin!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            comboBox1.SelectedIndex = -1;
            label4.Text = "Answer: 0";
        }
    }
}