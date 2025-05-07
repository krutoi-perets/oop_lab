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
            listView1.Columns.Add("Метод доставки");
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

                string type = deliveryMethod.SelectedItem.ToString();
                IDeliveryType delivery = null;
                switch (type)
                {
                    case "По воздуху":
                        delivery = new AirDelivery();
                        break;
                    case "По воде":
                        delivery = new SeaDelivery();
                        break;
                    case "По земле":
                        delivery = new RoadDelivery();
                        break;
                }
                TransportCompany firm = new ExpressCompany(nameInput.Text,
                        (int)priceInput.Value,
                        (float)avgtimeInput.Value,
                        (int)yearInput.Value,
                        (float)massInput.Value,
                        (float)ratingInput.Value,
                        phonenumberInput.Text, delivery);
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

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeListView();
        }
    }
}
