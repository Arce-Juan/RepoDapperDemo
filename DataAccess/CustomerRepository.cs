using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CustomerRepository
    {
        public List<Customer> GetByName(string lastname)
        {
            using (var connection = DataBase.GetSqlConnection())
            {
                string sql = $"" +
                    "Select [Id]," + "\n" +
                    "[Lastname]," + "\n" +
                    "[Name]," + "\n" +
                    "[Address]," + "\n" +
                    "[DateBirth]," + "\n" +
                    "[Country]" + "\n" +
                    "From [dbo].[Customer]" + "\n" +
                    "Where Lastname like '%" + lastname + "%'";

                var customers = connection.Query<Customer>(sql).ToList();

                return customers;
            }
        }

        public Customer GetById(int id)
        {
            using (var connection = DataBase.GetSqlConnection())
            {
                string sql = $"" +
                    "Select [Id]," + "\n" +
                    "[Lastname]," + "\n" +
                    "[Name]," + "\n" +
                    "[Address]," + "\n" +
                    "[DateBirth]," + "\n" +
                    "[Country]" + "\n" +
                    "From [dbo].[Customer]" + "\n" +
                    "Where Id = @customerId";

                var customer = connection.QueryFirstOrDefault<Customer>(sql, new { customerId = id });
                return customer;
            }
        }

        public List<Customer> GetAll()
        {
            using (var connection = DataBase.GetSqlConnection())
            {
                string sql = "" +
                    "Select [Id]," + "\n" +
                    "[Lastname]," + "\n" +
                    "[Name]," + "\n" +
                    "[Address]," + "\n" +
                    "[DateBirth]," + "\n" +
                    "[Country]" + "\n" +
                    "From [dbo].[Customer]";

                var customers = connection.Query<Customer>(sql).ToList();

                return customers;
            }
        }

        public int Add(Customer customer)
        {
            using (var connection = DataBase.GetSqlConnection())
            {
                string sql = "" + "\n" +
                    "Insert Into [dbo].[Customer]" + "\n" +
                    "([Lastname]," + "\n" +
                    "[Name]," + "\n" +
                    "[Address]," + "\n" +
                    "[DateBirth]," + "\n" +
                    "[Country])" + "\n" +
                    "values" + "\n" +
                    "(@customerLastname," + "\n" +
                    "@customerName," + "\n" +
                    "@customerAddress," + "\n" +
                    "@customerDateBirth," + "\n" +
                    "@customerCustomer)";

                var parameters = new
                {
                    customerLastname = customer.Lastname,
                    customerName = customer.Name,
                    customerAddress = customer.Address,
                    customerDateBirth = customer.DateBirth,
                    customerCustomer = customer.Country
                };

                var command = connection.Execute(sql, parameters);
                return command;
            }
        }

        public ExecuteResponse Update(Customer customer)
        {
            var response = new ExecuteResponse();
            try
            {
                using (var connection = DataBase.GetSqlConnection())
                {
                    string sql = "" + "\n" +
                        "Update [dbo].[Customer] set " + "\n" +
                        "[Lastname] = @customerLastname," + "\n" +
                        "[Name] = @customerName," + "\n" +
                        "[Address] = @customerAddress," + "\n" +
                        "[DateBirth] = @customerDateBirth," + "\n" +
                        "[Country] = @customerCustomer" + "\n" +
                        "Where [Id] = @customerId";

                    var parameters = new
                    {
                        customerId = customer.Id,
                        customerLastname = customer.Lastname,
                        customerName = customer.Name,
                        customerAddress = customer.Address,
                        customerDateBirth = customer.DateBirth,
                        customerCustomer = customer.Country
                    };

                    connection.Execute(sql, parameters);

                    response.Type = TypeExecuteResponse.SUCCESS;
                }
            }
            catch (Exception ex)
            {
                response.Type = TypeExecuteResponse.FAULT;
                response.Details = ex.Message;
            }

            return response;
        }

        public ExecuteResponse Delete(int idCustomer)
        {
            var response = new ExecuteResponse();
            try
            {
                using (var connection = DataBase.GetSqlConnection())
                {
                    string sql = "" + "\n" +
                        "Delete from [dbo].[Customer]" + "\n" +
                        "Where [Id] = @customerId";

                    var parameters = new
                    {
                        customerId = idCustomer
                    };

                    connection.Execute(sql, parameters);

                    response.Type = TypeExecuteResponse.SUCCESS;
                }
            }
            catch (Exception ex)
            {
                response.Type = TypeExecuteResponse.FAULT;
                response.Details = ex.Message;
            }

            return response;
        }
    }
}
