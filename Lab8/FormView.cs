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
    public partial class FormView : Form, IView
    {
        public event Add AddClicked;
        public event Remove RemoveClicked;
        public event GetAll GetAllClicked;
        public event SaveChanges SaveChangesClicked;

        public string NameCompany => nameInput.Text;
        public int Price => (int)priceInput.Value;
        public float Time => (float)avgtimeInput.Value;
        public string Number => phonenumberInput.Text;
        public int Year => (int)yearInput.Value;
        public float Mass => (float)massInput.Value;
        public float Rating => (float)ratingInput.Value;

        public FormView()
        {
            InitializeComponent();
            var presenter = new Presenter(this);
        }

        private void create_Click(object sender, EventArgs e)
        {
            try
            {

                AddClicked.Invoke(NameCompany, Price, Time, Number, Year, Mass, Rating);
                objCount.Text = TransportCompany.countObj.ToString();
                ShowAll();

            }
            catch (MyException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            ShowAll();
            TransportCompany.countObj--;
            MessageBox.Show(RemoveClicked.Invoke());
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; ++i)
            {
                string selectedStrategy = dataGridView1.Rows[i].Cells[8].Value.ToString();
                string selectedMethod = dataGridView1.Rows[i].Cells[7].Value.ToString();
                SaveChangesClicked.Invoke(i, selectedStrategy, selectedMethod);
            }
            ShowAll();
            MessageBox.Show("Изменения успешно сохранены", "Сохранить");
        }

        private void ShowAll()
        {
            dataGridView1.Rows.Clear();

            foreach (var company in GetAllClicked.Invoke().Reverse())
            {
                int rowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[rowIndex].Cells[0].Value = company.name;
                dataGridView1.Rows[rowIndex].Cells[1].Value = company.pricePerKilometer.ToString();
                dataGridView1.Rows[rowIndex].Cells[2].Value = company.averageDeliveryTime.ToString();
                dataGridView1.Rows[rowIndex].Cells[3].Value = company.yearFounded.ToString();
                dataGridView1.Rows[rowIndex].Cells[4].Value = company.transportedMass.ToString();
                dataGridView1.Rows[rowIndex].Cells[5].Value = company.rating.ToString();
                dataGridView1.Rows[rowIndex].Cells[6].Value = company.phoneNumber;
                dataGridView1.Rows[rowIndex].Cells[7].Value = company.deliveryType.GetDeliveryType();
                dataGridView1.Rows[rowIndex].Cells[8].Value = company.efficiencyStrategy.Description();
                dataGridView1.Rows[rowIndex].Cells[9].Value = company.efficiency.ToString();
            }
        }
    }
}
