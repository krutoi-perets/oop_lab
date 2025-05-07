using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        TransportCompany firm;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Класс. Статические члены класса. Обработка исключений.\n" +
                "(ваши фамилии) 23ВП1\nВариант 8. Фирма грузоперевозок", "Лабораторная работа 1");
        }

        private void enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameInput.Text))
                    throw new MyException("Фирма должна иметь название");

                if (string.IsNullOrWhiteSpace(phonenumberInput.Text))
                    throw new MyException("Фирма должна иметь номер");
                if (!Regex.IsMatch(phonenumberInput.Text.Trim(), @"^\d{11}$"))
                    throw new MyException("Номер должен состоять из 11 цифр и не содержать буквы или символы");

                firm = new TransportCompany(nameInput.Text,
                    (int)priceInput.Value,
                    (float)avgtimeInput.Value,
                    (int)yearInput.Value,
                    (float)massInput.Value,
                    (float)ratingInput.Value,
                    phonenumberInput.Text);

                info.Text = firm.ToString();

                dataGridView1.Rows.Clear();
                dataGridView1.RowCount = 1;
                dataGridView1.Rows[0].Cells[0].Value = nameInput.Text;
                dataGridView1.Rows[0].Cells[1].Value = priceInput.Value;
                dataGridView1.Rows[0].Cells[2].Value = avgtimeInput.Value;
                dataGridView1.Rows[0].Cells[3].Value = yearInput.Value;
                dataGridView1.Rows[0].Cells[4].Value = massInput.Value;
                dataGridView1.Rows[0].Cells[5].Value = ratingInput.Value;
                dataGridView1.Rows[0].Cells[6].Value = phonenumberInput.Text;


                objCount.Text = TransportCompany.countObj.ToString();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }            
        }

        private void nameShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (firm == null)
                    throw new MyException("Объект класса не создан");
                info.Text = firm.PrintName();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void priceHex_Click(object sender, EventArgs e)
        {
            try
            {
                if (firm == null)
                    throw new MyException("Объект класса не создан");
                info.Text = "Цена за километр\nв шестнадцатиричном представлении: " + firm.PriceToHex();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }
    }
}
