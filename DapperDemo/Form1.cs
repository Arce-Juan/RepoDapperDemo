using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperDemo
{
    public partial class Form1 : Form
    {
        public CustomerRepository _customerRepository = new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnGetAllCustomers_Click(object sender, EventArgs e)
        {
            var customers = _customerRepository.GetAll();
            dataGridCustomer.DataSource = customers;
        }

        private void BtnGetCustomer_Click(object sender, EventArgs e)
        {
            var lastname = txtFilter.Text;
            var customers = _customerRepository.GetByName(lastname);
            dataGridCustomer.DataSource = customers;
        }

        private void BtnGetById_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtId.Text);
            var customer = _customerRepository.GetById(id);
            var listcustomer = new List<Customer>();
            listcustomer.Add(customer);
            dataGridCustomer.DataSource = listcustomer;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            var newCustomer = new Customer()
            {
                Lastname = txtLastname.Text,
                Name = txtName.Text,
                Address = txtAddress.Text,
                Country = txtCountry.Text,
                DateBirth = DateTime.Parse(dateTimeDateBirth.Text)
            };

            var result = _customerRepository.Add(newCustomer);
            if (result > 0)
                MessageBox.Show("Cliente Agregado");
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            //string valorPrimerCelda = dataGridCustomer.Rows[].Cells[0].Value.ToString();

        }

        private void dataGridCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idCustomer = int.Parse(dataGridCustomer.Rows[e.RowIndex].Cells[0].Value.ToString());
            var customer = _customerRepository.GetById(idCustomer);

            txtIdCustomer.Text = customer.Id.ToString();
            txtLastname.Text = customer.Lastname;
            txtName.Text = customer.Name;
            txtAddress.Text = customer.Address;
            txtCountry.Text = customer.Country;
            dateTimeDateBirth.Text = customer.DateBirth.ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            int idCustomer = int.Parse(txtIdCustomer.Text);
            var customer = _customerRepository.GetById(idCustomer);

            customer.Lastname = txtLastname.Text;
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.Country = txtCountry.Text;
            customer.DateBirth = DateTime.Parse(dateTimeDateBirth.Text);

            var response = _customerRepository.Update(customer);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Esta seguro de eliminar el cliente?", "Elimiar Cliente", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                int idCustomer = int.Parse(txtIdCustomer.Text);
                _customerRepository.Delete(idCustomer);
            }
        }
    }
}
