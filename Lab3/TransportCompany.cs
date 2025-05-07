using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class TransportCompany: ICloneable
    {
        public string name { get; set; }
        public int pricePerKilometer { get; set; }
        public float averageDeliveryTime { get; set; }
        public int yearFounded { get; set; }
        public float transportedMass { get; set; }
        public float rating { get; set; }
        public string phoneNumber { get; set; }

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
        }

        public TransportCompany(string name) : this()
        {
            this.name = name;
        }

        public TransportCompany(string name, int pricePerKilometer) : this(name)
        {
            this.pricePerKilometer = pricePerKilometer;
        }

        public TransportCompany(string name, int pricePerKilometer, float averageDeliveryTime, int yearFounded, float transportedMass, float rating, string phoneNumber) : this(name, pricePerKilometer)
        {
            this.averageDeliveryTime = averageDeliveryTime;
            this.yearFounded = yearFounded;
            this.transportedMass = transportedMass;
            this.rating = rating;
            this.phoneNumber = phoneNumber;
        }

        public object Clone()
        {
            countObj++;
            return this.MemberwiseClone();
        }


    }
}
