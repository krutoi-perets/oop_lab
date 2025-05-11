using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class ConsoleView
    {
        private Controller controller;

        public string NameCompany { get; private set; }
        public int Price { get; private set; }
        public float Time { get; private set; }

        public string Number { get; private set; }
        public int Year { get; private set; }
        public float Mass { get; private set; }
        public float Rating { get; private set; }

        public void Run()
        {
            controller = new Controller();
            while (true)
            {
                Console.WriteLine("\nМеню:");
                Console.WriteLine("1. Добавить компанию");
                Console.WriteLine("2. Удалить последнюю компанию");
                Console.WriteLine("3. Показать все компании");
                Console.WriteLine("4. Изменить стратегию расчета эффективности и метод доставки");
                Console.WriteLine("0. Выход");

                Console.Write("Выбор: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        try
                        {
                            ReadCompanyInput();
                            controller.CreateCompany(Price, NameCompany, Time, Number, Year, Mass, Rating);
                            Console.WriteLine("Компания добавлена.");
                            break;
                        }
                        catch (MyException ex)
                        {
                            Console.WriteLine(ex.Message);
                            break;
                        }
                    case "2":
                        Console.WriteLine(controller.DeleteCompany());
                        break;
                    case "3":
                        var companies = controller.GetAll();
                        PrintCompanies(companies);
                        break;
                    case "4":
                        Console.Write("Введите индекс компании (0 — первая): ");
                        int index = int.Parse(Console.ReadLine());

                        Console.Write("Выберите стратегию рассчета эффективности (По массе и времени / По возрасту и цене / Баланс): ");
                        string strategy = Console.ReadLine();

                        Console.Write("Выберите метод доставки (По земле / По воде / По воздуху): ");
                        string methodInput = Console.ReadLine();
                        string method = null;
                        switch (methodInput)
                        {
                            case "По земле":
                                method = new RoadDelivery().GetDeliveryType();
                                break;
                            case "По воде":
                                method = new SeaDelivery().GetDeliveryType();
                                break;
                            case "По воздуху":
                                method = new AirDelivery().GetDeliveryType();
                                break;
                            default:
                                Console.WriteLine("Неверный ввод");
                                break;
                        }
                        controller.SaveChanges(index, strategy, method);
                        Console.WriteLine("Изменения сохранены.");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Неверный ввод.");
                        break;
                }
            }
        }

        private void ReadCompanyInput()
        {
            Console.Write("Название компании: ");
            NameCompany = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(NameCompany))
                throw new MyException("Название компании не может быть пустым.");

            Console.Write("Цена за километр: ");
            if (!int.TryParse(Console.ReadLine(), out int price) || price < 0)
                throw new MyException("Некоррект. цена.");
            Price = price;

            Console.Write("Ср. время доставки: ");
            if (!float.TryParse(Console.ReadLine(), out float time) || time < 0)
                throw new MyException("Некорректн. время");
            Time = time;

            Console.Write("Год основания: ");
            if (!int.TryParse(Console.ReadLine(), out int year) || year < 2000 || year > 2025)
                throw new MyException("Ограничения на год основания - с 2000 по 2025");
            Year = year;

            Console.Write("Масса перевезенного груза: ");
            if (!int.TryParse(Console.ReadLine(), out int mass) || mass < 0)
                throw new MyException("Некорректн. масса");
            Mass = mass;

            Console.Write("Номер компании:");
            Number = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(Number) || Number.Length != 11 || !Number.All(char.IsDigit))
                throw new MyException("Некорректн. номер телефона.");

            Console.Write("Рейтинг:");
            if (!float.TryParse(Console.ReadLine(), out float rating) || rating < 0 || rating > 10)
                throw new MyException("Некрректн. рейтинг");
            Rating = rating;
        }


        private void PrintCompanies(Stack<TransportCompany> companies)
        {
            if (companies == null || companies.Count == 0)
            {
                Console.WriteLine("\nСписок компаний пуст.");
                return;
            }

            Console.WriteLine("\nСписок компаний:");
            var list = companies.Reverse().ToList();
            for (int i = 0; i < list.Count; i++)
            {
                var c = list[i];
                Console.WriteLine($"[{i}] {c.name} | Цена: {c.pricePerKilometer} | Ср.время доставки: {c.yearFounded} | Год основания: {c.yearFounded} | Масса перевезенного груза: {c.transportedMass} | Рейтинг: {c.rating} | Номер телефона: {c.phoneNumber} | Доставка: {c.GetDeliveryInfo()} | Стратегия эффективности: {c.efficiencyStrategy.Description()}| Эффективность:{c.efficiency}|");
            }
        }
    }
}
