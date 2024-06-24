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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dBDataSet.DB". При необходимости она может быть перемещена или удалена.
            this.dBTableAdapter.Fill(this.dBDataSet.DB);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text;

            // Выполняем поиск в каждом DataGridView
            SearchInDataGridView(dataGridView1, searchTerm);
        }
        private void SearchInDataGridView(DataGridView dataGridView, string searchTerm)
        {
            dataGridView.ClearSelection();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(searchTerm))
                    {
                        // Если найдено совпадение, выделяем строку в DataGridView
                        dataGridView.Rows[row.Index].Selected = true;
                        break;
                    }
                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedItem = GetSelectedListBoxItem();

            // Отображение сообщения
            MessageBox.Show($"Вы были записаны на ремонт: \n{selectedItem}", "Подведение итогов", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private string GetSelectedListBoxItem()
        {
            if (listBox1.SelectedIndex != -1)
            {
                return listBox1.SelectedItem.ToString();
            }
            else
            {
                return "Нет выбранных элементов в ListBox1";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            // Устанавливаем положение формы по центру экрана
            form2.StartPosition = FormStartPosition.CenterScreen;
            

            // Показываем форму form2
            form2.Show();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Обработка выбора элементов в ListBox
            
            if (listBox1.SelectedIndex != -1)
            {
                // Здесь вы можете выводить выбранные данные в соответствующие элементы управления на форме 1
                string selectedItem = listBox1.SelectedItem.ToString();
            }
        }
        public void AddToListBox(string item)
        {
            // Добавление данных в ListBox
            listBox1.Items.Add(item);
        }
    }
}
