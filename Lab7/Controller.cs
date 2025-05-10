using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab1
{
    public class Controller
    {
        private StackTransportCompany companies;

        public Controller()
        {
            companies = new StackTransportCompany();
        }

        public void CreateCompany(int pricePerKilometer, string name, float avrgDeliveryTime, string phoneNumber, 
            int yearFounded, float transportedMass, float rating)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new MyException("Фирма должна иметь название");

            if (!Regex.IsMatch(phoneNumber.Trim(), @"^\d{11}$"))
                throw new MyException("Номер должен состоять из 11 цифр");

                TransportCompany firm = new ExpressCompany(
                        name,
                        pricePerKilometer,
                        avrgDeliveryTime,
                        yearFounded,
                        transportedMass,
                        rating,
                        phoneNumber,
                        new RoadDelivery()
                    );
            firm.RecalculateEfficiency();
            companies.AddCompany(firm);
        }

        public string DeleteCompany()
        {
            try
            {
                companies.DeleteCompany();
                return "Компания успешно удалена";
            }
            catch (MyException ex)
            {
                return ex.Message;
            }
        }

        public Stack<TransportCompany> GetAll()
        {
            return companies.GetTransportCompanies();
        }

        public void SaveChanges(int index, string selectedStrategy, string selectedMethod)
        {
            var transportCompanies = companies.GetTransportCompanies().Reverse().ToList();

            TransportCompany company = transportCompanies[index];

            if (selectedStrategy == "По массе и времени")
                company.efficiencyStrategy = new MassTimeEfficiency();
            else if (selectedStrategy == "По возрасту и цене")
                company.efficiencyStrategy = new AgePriceEfficiency();
            else if (selectedStrategy == "Сбалансированная")
                company.efficiencyStrategy = new BalancedEfficiency();
            company.RecalculateEfficiency();

            if (selectedMethod == "По воздуху")
                company.deliveryType = new AirDelivery();
            else if (selectedMethod == "По воде")
                company.deliveryType = new SeaDelivery();
            else if (selectedMethod == "По земле")
                company.deliveryType = new RoadDelivery();
        }
    }
}
