using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public delegate void Add(string name, int price, float time, string phoneNumber, int year, float mass, float rating);
    public delegate string Remove();
    public delegate Stack<TransportCompany> GetAll();
    public delegate void SaveChanges(int index, string selectedStrategy, string selectedMethod);
    public interface IView
    {
        string NameCompany { get; }
        int Price { get; }

        float Time { get; }

        string Number { get; }

        int Year { get; }

        float Mass { get; }

        float Rating { get; }

        event Add AddClicked;

        event Remove RemoveClicked;

        event GetAll GetAllClicked;

        event SaveChanges SaveChangesClicked;
    }

}
