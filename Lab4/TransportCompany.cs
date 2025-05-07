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

    public abstract class TransportCompany
    {
        public string name { get; set; }
        public int pricePerKilometer { get; set; }
        public float averageDeliveryTime { get; set; }
        public int yearFounded { get; set; }
        public float transportedMass { get; set; }
        public float rating { get; set; }
        public string phoneNumber { get; set; }

        public IDeliveryType deliveryType;

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

        public TransportCompany(string name, int pricePerKilometer, float averageDeliveryTime, int yearFounded, float transportedMass, float rating, string phoneNumber, IDeliveryType deliveryType) : this(name, pricePerKilometer)
        {
            this.averageDeliveryTime = averageDeliveryTime;
            this.yearFounded = yearFounded;
            this.transportedMass = transportedMass;
            this.rating = rating;
            this.phoneNumber = phoneNumber;
            this.deliveryType = deliveryType;
        }

        public virtual string GetDeliveryInfo()
        {
            return deliveryType.GetDeliveryType();
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

