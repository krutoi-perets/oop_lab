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
                int rowIndex = dataGridView.Rows.Add();
                dataGridView.Rows[rowIndex].Cells[0].Value = company.name;
                dataGridView.Rows[rowIndex].Cells[1].Value = company.pricePerKilometer;
                dataGridView.Rows[rowIndex].Cells[2].Value = company.averageDeliveryTime;
                dataGridView.Rows[rowIndex].Cells[3].Value = company.yearFounded;
                dataGridView.Rows[rowIndex].Cells[4].Value = company.transportedMass;
                dataGridView.Rows[rowIndex].Cells[5].Value = company.rating;
                dataGridView.Rows[rowIndex].Cells[6].Value = company.phoneNumber;
                dataGridView.Rows[rowIndex].Cells[7].Value = company.GetDeliveryInfo();
                dataGridView.Rows[rowIndex].Cells[8].Value = company.efficiencyStrategy.Description();
                dataGridView.Rows[rowIndex].Cells[9].Value = company.efficiency;
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
