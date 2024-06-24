using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Диагностика автомобиля - 2 500,00 ₽");
            listBox1.Items.Add("Диагностика двигателя - 1 499,00 ₽");
            listBox1.Items.Add("Замена масла и фильтров - 1 999,00 ₽");
            listBox1.Items.Add("Ремонт системы охлаждения - 4 500,00 ₽");
            listBox1.Items.Add("Замена подшипников - 2 350,00 ₽");
            listBox1.Items.Add("Покраска - 5 000,00 ₽");
            listBox1.Items.Add("Удаление вмятин - 1 200,00 ₽");
            listBox1.Items.Add("Диагностика трансмиссии - 1 500,00 ₽");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получение значений из текстовых полей на форме 2
            MessageBox.Show("Вы были записаны на ремонт!!!");
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;
            string text3 = textBox3.Text;
            string text4 = textBox4.Text;
            string combinedText = $"{text4}, {text1}, {text2}, {text3}";

            // Передача данных в форму 1
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                form1.AddToListBox(combinedText);
            }
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ваш номер: №1");
        }
    }
}
