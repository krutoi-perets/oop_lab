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
            MessageBox.Show("(название)\n" +
                "(ваши фамилии) 23ВП1\nВариант 8. Фирма грузоперевозок", "Лабораторная работа 5");
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

                if (deliveryMethod.SelectedIndex == -1)
                    throw new MyException("Выберите метод доставки");

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
                firm.RecalculateEfficiency();
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
                dataGridView1.Rows[rowIndex].Cells[7].Value = company.GetDeliveryInfo();
                dataGridView1.Rows[rowIndex].Cells[8].Value = company.efficiencyStrategy.Description();
                dataGridView1.Rows[rowIndex].Cells[9].Value = company.efficiency;
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                var transportCompanies = companies.GetTransportCompanies().Reverse().ToList();
                if (i >= transportCompanies.Count)
                    break;

                TransportCompany company = transportCompanies[i];

                string selectedStrategy = dataGridView1.Rows[i].Cells[8].Value.ToString();
                if (selectedStrategy == "По массе и времени")
                    company.efficiencyStrategy = new MassTimeEfficiency();
                else if (selectedStrategy == "По возрасту и цене")
                    company.efficiencyStrategy = new AgePriceEfficiency();
                else if (selectedStrategy == "Сбалансированная")
                    company.efficiencyStrategy = new BalancedEfficiency();
                company.RecalculateEfficiency();

                string selectedMethod = dataGridView1.Rows[i].Cells[7].Value.ToString();
                if (selectedMethod == new RoadDelivery().GetDeliveryType())
                    company.deliveryType = new RoadDelivery();
                else if (selectedMethod == new AirDelivery().GetDeliveryType())
                    company.deliveryType = new AirDelivery();
                else if (selectedMethod == new SeaDelivery().GetDeliveryType())
                    company.deliveryType = new SeaDelivery();
            }

            ShowAll();
            MessageBox.Show("Все изменения сохранены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
