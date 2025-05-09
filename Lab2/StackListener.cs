using Lab1;
using System;
using System.Windows.Forms;

namespace Lab2
{
    internal class StackListener
    {
        private DataGridView dataGridView;
        private TextBox objCount;

        public StackListener(StackTransportCompany stack, DataGridView dataGridView, TextBox objCount)
        {
            this.dataGridView = dataGridView;
            this.objCount = objCount;

            stack.StackAdded += (TransportCompany company) =>
            {
                dataGridView.Rows.Clear();
                dataGridView.RowCount = 1;
                dataGridView.Rows[0].Cells[0].Value = company.name;
                dataGridView.Rows[0].Cells[1].Value = company.pricePerKilometer;
                dataGridView.Rows[0].Cells[2].Value = company.averageDeliveryTime;
                dataGridView.Rows[0].Cells[3].Value = company.yearFounded;
                dataGridView.Rows[0].Cells[4].Value = company.transportedMass;
                dataGridView.Rows[0].Cells[5].Value = company.rating;
                dataGridView.Rows[0].Cells[6].Value = company.phoneNumber;
                objCount.Text = TransportCompany.countObj.ToString();
            };
            stack.StackRemoved += () =>
            {
                if (dataGridView.RowCount > 0)
                    dataGridView.Rows.RemoveAt(dataGridView.RowCount - 1);

                objCount.Text = TransportCompany.countObj.ToString();
            };
        }
    }
}
