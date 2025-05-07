using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public interface IDeliveryType
    {
        string GetDeliveryType();
    }

    public class SeaDelivery : IDeliveryType
    {
        public string GetDeliveryType()
        {
            return "Доставка по морю";
        }
    }

    public class RoadDelivery : IDeliveryType
    {
        public string GetDeliveryType()
        {
            return "Доставка по автодороге";
        }
    }

    public class AirDelivery : IDeliveryType
    {
        public string GetDeliveryType()
        {
            return "Доставка по воздуху";
        }
    }

    public interface IEfficiencyStrategy
    {
        float CalculateEfficiency(TransportCompany company);
        string Description();
    }

    public class MassTimeEfficiency : IEfficiencyStrategy
    {
        public float CalculateEfficiency(TransportCompany company)
        {
            if (company.averageDeliveryTime == 0)
                return 0;

            return (float)Math.Round(company.transportedMass / company.averageDeliveryTime, 2);
        }

        public string Description() => "По массе и времени";
    }
    public class AgePriceEfficiency : IEfficiencyStrategy
    {
        public float CalculateEfficiency(TransportCompany company)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - company.yearFounded;

            if (company.pricePerKilometer == 0)
                return 0;

            return (float)Math.Round(age / (float)company.pricePerKilometer, 2);
        }

        public string Description() => "По возрасту и цене";
    }

    public class BalancedEfficiency : IEfficiencyStrategy
    {
        public float CalculateEfficiency(TransportCompany company)
        {
            float massEff = company.transportedMass / (company.averageDeliveryTime + 1);
            float priceEff = 100f / (company.pricePerKilometer + 1);

            return (float)Math.Round(0.6f * massEff + 0.4f * priceEff, 2);
        }

        public string Description() => "Сбалансированная";
    }

    public abstract class TransportCompany
    {
        public string name { get; set; }
        public int pricePerKilometer { get; set; }
        public float averageDeliveryTime { get; set; }
        public int yearFounded { get; set; }
        public float transportedMass { get; set; }
        public float rating { get; set; }
        public string phoneNumber { get; set; }

        public float efficiency { get; set; }

        public IDeliveryType deliveryType { get; set; }
        public IEfficiencyStrategy efficiencyStrategy { get; set; }

        public static int countObj = 0;

        public TransportCompany()
        {
            name = "";
            pricePerKilometer = 0;
            averageDeliveryTime = 0;
            yearFounded = 2000;
            transportedMass = 0;
            rating = 0;
            phoneNumber = "";
            countObj++;
            deliveryType = null;
        }

        public TransportCompany(string name) : this()
        {
            this.name = name;
        }

        public TransportCompany(string name, int pricePerKilometer) : this(name)
        {
            this.pricePerKilometer = pricePerKilometer;
        }

        public TransportCompany(string name, int pricePerKilometer, float averageDeliveryTime, 
            int yearFounded, float transportedMass, float rating, string phoneNumber, IDeliveryType deliveryType) : this(name, pricePerKilometer)
        {
            this.averageDeliveryTime = averageDeliveryTime;
            this.yearFounded = yearFounded;
            this.transportedMass = transportedMass;
            this.rating = rating;
            this.phoneNumber = phoneNumber;
            this.deliveryType = deliveryType;
            efficiencyStrategy = new BalancedEfficiency();
        }

        public virtual string GetDeliveryInfo()
        {
            return deliveryType.GetDeliveryType();
        }
        
        public virtual void RecalculateEfficiency()
        {
            efficiency = efficiencyStrategy.CalculateEfficiency(this);
        }
    }
    public class ExpressCompany : TransportCompany
    {
        public ExpressCompany(string name,
        int pricePerKilometer,
        float averageDeliveryTime,
        int yearFounded,
        float transportedMass,
        float rating,
        string phoneNumber,
        IDeliveryType deliveryType) : base(name, pricePerKilometer, averageDeliveryTime, yearFounded, transportedMass, rating, phoneNumber, deliveryType) { }
        public override string GetDeliveryInfo()
        {
            return base.GetDeliveryInfo() + "(экспресс)";
        }



    }

}

