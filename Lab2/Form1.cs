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
        private StackTransportCompany companies;
        private StackListener stackListener;

        public Form1()
        {
            InitializeComponent();
            companies = new StackTransportCompany();
            stackListener = new StackListener(companies, listView1, objCount);
        }

        private void InitializeListView()
        {
            listView1.Columns.Add("Название");
            listView1.Columns.Add("Цена за километр");
            listView1.Columns.Add("Ср. время доставки");
            listView1.Columns.Add("Год основания");
            listView1.Columns.Add("Масса");
            listView1.Columns.Add("Рейтинг");
            listView1.Columns.Add("Номер телефона");
            listView1.View = View.Details;
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

                TransportCompany firm = new TransportCompany(nameInput.Text,
                    (int)priceInput.Value,
                    (float)avgtimeInput.Value,
                    (int)yearInput.Value,
                    (float)massInput.Value,
                    (float)ratingInput.Value,
                    phonenumberInput.Text);
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
            listView1.Items.Clear();

            foreach (var company in companies.GetTransportCompanies())
            {
                var listItem = new ListViewItem(company.name);
                listItem.SubItems.Add(company.pricePerKilometer.ToString());
                listItem.SubItems.Add(company.averageDeliveryTime.ToString());
                listItem.SubItems.Add(company.yearFounded.ToString());
                listItem.SubItems.Add(company.transportedMass.ToString());
                listItem.SubItems.Add(company.rating.ToString());
                listItem.SubItems.Add(company.phoneNumber);
                listView1.Items.Insert(0, listItem);
            }
        }

        private void generator_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Random rand = new Random();
            int elementCount = 10000;

            int start = Environment.TickCount;
            for (int i = 0; i < elementCount; i++)
            {
                TransportCompany clonedCompany = new TransportCompany();
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

            var collectionResultItem = new ListViewItem("StackTransportCompany");
            collectionResultItem.SubItems.Add("Вставка: " + insertionTimeCollection + " мс");
            collectionResultItem.SubItems.Add("Последоват. выборка: " + sequentialReadTimeCollection + " мс");
            listView1.Items.Add(collectionResultItem);

            var arrayResultItem = new ListViewItem("Array");
            arrayResultItem.SubItems.Add("Вставка: " + insertionTimeArray + " мс");
            arrayResultItem.SubItems.Add("Последоват. выборка: " + sequentialReadTimeArray + " мс");
            listView1.Items.Add(arrayResultItem);

            MessageBox.Show("Генерация и замеры завершены!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeListView();
        }
    }
}
