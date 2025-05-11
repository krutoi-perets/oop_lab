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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Lab1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Diagnostics;
using System.Xml.Linq;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private TransportCompany prototype = null;
        private StackTransportCompany companies;
        private StackListener stackListener;

        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Порождающие паттерны. Паттерн Прототип\n" +
                "Рейимов М. 23ВП1\nВариант 8. Фирма грузоперевозок", "Лабораторная работа 3");
            companies = new StackTransportCompany();
            stackListener = new StackListener(companies, dataGridView1, objCount);
        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nameInput.Text))
                    throw new MyException("Фирма должна иметь название");

                if (string.IsNullOrWhiteSpace(phonenumberInput.Text))
                    throw new MyException("Фирма должна иметь номер");
                if (!Regex.IsMatch(phonenumberInput.Text.Trim(), @"^\d{11}$"))
                    throw new MyException("Номер должен состоять из 11 цифр и не содержать буквы или символы");
                TransportCompany firm = new TransportCompany();
                if (prototype == null)
                {
                    prototype = new TransportCompany(nameInput.Text,
                        (int)priceInput.Value,
                        (float)avgtimeInput.Value,
                        (int)yearInput.Value,
                        (float)massInput.Value,
                        (float)ratingInput.Value,
                        phonenumberInput.Text);
                }
                firm = (TransportCompany)prototype.Clone();
                objCount.Text = TransportCompany.countObj.ToString();

                companies.AddCompany(firm);
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                TransportCompany.countObj--;
                companies.DeleteCompany();
            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void showAll_Click(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void ShowAll()
        {
            dataGridView1.Rows.Clear();

            foreach (var company in companies.GetTransportCompanies())
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = company.name;
                dataGridView1.Rows[rowIndex].Cells[1].Value = company.pricePerKilometer.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = company.averageDeliveryTime.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = company.yearFounded.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = company.transportedMass.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = company.rating.ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = company.phoneNumber;
            }
        }

        private void generator_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int elementCount = 5000;

            TransportCompany baseCompany = new TransportCompany();
            baseCompany.averageDeliveryTime = (float)rand.NextDouble() * 99 + 1;
            baseCompany.transportedMass = (float)rand.NextDouble() * 100;
            baseCompany.name = "BaseCompany";
            baseCompany.pricePerKilometer = rand.Next(1000, 10000);
            baseCompany.phoneNumber = "8999" + rand.Next(1000000, 9999999);
            baseCompany.rating = (float)rand.NextDouble() * 10;
            baseCompany.yearFounded = rand.Next(1950, 2025);

            int start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                TransportCompany clonedCompany = (TransportCompany)baseCompany.Clone();
                clonedCompany.averageDeliveryTime = (float)rand.NextDouble() * 99 + 1;
                clonedCompany.transportedMass = (float)rand.NextDouble() * 100;
                clonedCompany.name = "Company" + i;
                clonedCompany.pricePerKilometer = rand.Next(1000, 10000);
                clonedCompany.phoneNumber = "8999" + rand.Next(1000000, 9999999);
                clonedCompany.rating = (float)rand.NextDouble() * 10;
                clonedCompany.yearFounded = rand.Next(1950, 2025);

                companies.AddCompany(clonedCompany);
            }
            int insertionTimeCollection = Environment.TickCount - start;

            start = Environment.TickCount;
            foreach (var company in companies.GetTransportCompanies())
            {
                var temp = company.pricePerKilometer;
            }
            int sequentialReadTimeCollection = Environment.TickCount - start;

            var allCompanies = companies.GetTransportCompanies().ToArray();
            start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                var temp = allCompanies[rand.Next(0, elementCount)].pricePerKilometer;
            }
            int randomReadTimeCollection = Environment.TickCount - start;

            TransportCompany[] companyArray = new TransportCompany[elementCount];

            start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                TransportCompany arrCompany = new TransportCompany();
                arrCompany.averageDeliveryTime = (float)rand.NextDouble() * 99 + 1;
                arrCompany.transportedMass = (float)rand.NextDouble() * 100;
                arrCompany.name = "Company" + i;
                arrCompany.pricePerKilometer = rand.Next(1000, 10000);
                arrCompany.phoneNumber = "8999" + rand.Next(1000000, 9999999);
                arrCompany.rating = (float)rand.NextDouble() * 10;
                arrCompany.yearFounded = rand.Next(1950, 2025);
                companyArray[i] = arrCompany;
            }
            int insertionTimeArray = Environment.TickCount - start;

            start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                var temp = companyArray[i].pricePerKilometer;
            }
            int sequentialReadTimeArray = Environment.TickCount - start;

            start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                var temp = companyArray[rand.Next(0, elementCount)].pricePerKilometer;
            }
            int randomReadTimeArray = Environment.TickCount - start;

            dataGridView1.Rows.Clear();

            string results = "Результаты для StackTransportCompany:\n" +
                 $"Вставка: {insertionTimeCollection} мс\n" +
                 $"Последоват. выборка: {sequentialReadTimeCollection} мс\n" +
                 $"Случайная выборка: {randomReadTimeCollection} мс\n\n" +

                 "Результаты для Array:\n" +
                 $"Вставка: {insertionTimeArray} мс\n" +
                 $"Последоват. выборка: {sequentialReadTimeArray} мс\n" +
                 $"Случайная выборка: {randomReadTimeArray} мс";

            objCount.Text = TransportCompany.countObj.ToString();

            MessageBox.Show(results, "Результаты тестирования", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
