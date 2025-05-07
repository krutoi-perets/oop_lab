using Lab1;
using System;
using System.Windows.Forms;

namespace Lab2
{
    internal class StackListener
    {
        private ListView listView;
        private TextBox objCount;

        public StackListener(StackTransportCompany stack, ListView listView, TextBox objCount)
        {
            this.listView = listView;
            this.objCount = objCount;

            stack.StackAdded += (TransportCompany company) =>
            {
                var listItem = new ListViewItem(company.name);
                listItem.SubItems.Add(company.pricePerKilometer.ToString());
                listItem.SubItems.Add(company.averageDeliveryTime.ToString());
                listItem.SubItems.Add(company.yearFounded.ToString());
                listItem.SubItems.Add(company.transportedMass.ToString());
                listItem.SubItems.Add(company.rating.ToString());
                listItem.SubItems.Add(company.phoneNumber.ToString());
                listView.Items.Add(listItem);
                objCount.Text = TransportCompany.countObj.ToString();
            };
            stack.StackRemoved += () =>
            {
                if (listView.Items.Count > 0)
                    listView.Items.RemoveAt(listView.Items.Count - 1);

                objCount.Text = TransportCompany.countObj.ToString();
            };
        }
    }
}
