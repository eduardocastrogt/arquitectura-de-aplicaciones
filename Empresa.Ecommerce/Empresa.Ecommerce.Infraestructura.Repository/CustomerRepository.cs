using System;
using Empresa.Ecommerce.Dominio.Entity;
using Empresa.Ecommerce.Infraestructura.Interface;
using Empresa.Ecommerce.Transversal.Common;
using Dapper;
using System.Data;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Empresa.Ecommerce.Infraestructura.Repository
{
    public class CustomerRepository: ICustomerRepository
    {
        private readonly IConnectionFactory _connectionFactory;

        public CustomerRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        #region Métodos sincronos
        public bool Insertar(Customers customers)
        {
            using(var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("@customerId", customers.CustomerId);
                parameters.Add("@customerId", customers.CompanyName);
                parameters.Add("@customerId", customers.ContactName);
                parameters.Add("@customerId", customers.ContactTitle);
                parameters.Add("@customerId", customers.Address);
                parameters.Add("@customerId", customers.City);
                parameters.Add("@customerId", customers.Region);
                parameters.Add("@customerId", customers.PostalCode);
                parameters.Add("@customerId", customers.Country);
                parameters.Add("@customerId", customers.Phone);
                parameters.Add("@customerId", customers.Fax);

                var result = context.
                    Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return result > 0;

            }
        }

        public bool Update(Customers customers)
        {
            using (var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("@customerId", customers.CustomerId);
                parameters.Add("@customerId", customers.CompanyName);
                parameters.Add("@customerId", customers.ContactName);
                parameters.Add("@customerId", customers.ContactTitle);
                parameters.Add("@customerId", customers.Address);
                parameters.Add("@customerId", customers.City);
                parameters.Add("@customerId", customers.Region);
                parameters.Add("@customerId", customers.PostalCode);
                parameters.Add("@customerId", customers.Country);
                parameters.Add("@customerId", customers.Phone);
                parameters.Add("@customerId", customers.Fax);

                var result = context.
                    Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return result > 0;

            }
        }

        public bool Delete(string customerId)
        {
            using(var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("@customerId", customerId);

                var result = context.
                    Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public Customers Get(string customerId)
        {
            using(var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "GetCustomerById";
                var parameters = new DynamicParameters();
                parameters.Add("@customerId", customerId);

                var customer = context.QuerySingle<Customers>
                    (storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return customer;
            }
        }

        public IEnumerable<Customers> GetAll()
        {
            using (var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "CustomerList";

                var customers = context.Query<Customers>
                    (storedProcedure, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }
        #endregion

        #region Métodos asincronos
        public async Task<bool> InsertarAsync(Customers customers)
        {
            using (var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "CustomerInsert";
                var parameters = new DynamicParameters();
                parameters.Add("@customerId", customers.CustomerId);
                parameters.Add("@customerId", customers.CompanyName);
                parameters.Add("@customerId", customers.ContactName);
                parameters.Add("@customerId", customers.ContactTitle);
                parameters.Add("@customerId", customers.Address);
                parameters.Add("@customerId", customers.City);
                parameters.Add("@customerId", customers.Region);
                parameters.Add("@customerId", customers.PostalCode);
                parameters.Add("@customerId", customers.Country);
                parameters.Add("@customerId", customers.Phone);
                parameters.Add("@customerId", customers.Fax);

                var result = await context.
                    ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return result > 0;

            }
        }

        public async Task<bool> UpdateAsync(Customers customeres)
        {
            using (var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "CustomerUpdate";
                var parameters = new DynamicParameters();
                parameters.Add("@customerId", customeres.CustomerId);
                parameters.Add("@customerId", customeres.CompanyName);
                parameters.Add("@customerId", customeres.ContactName);
                parameters.Add("@customerId", customeres.ContactTitle);
                parameters.Add("@customerId", customeres.Address);
                parameters.Add("@customerId", customeres.City);
                parameters.Add("@customerId", customeres.Region);
                parameters.Add("@customerId", customeres.PostalCode);
                parameters.Add("@customerId", customeres.Country);
                parameters.Add("@customerId", customeres.Phone);
                parameters.Add("@customerId", customeres.Fax);

                var result = await context.
                    ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return result > 0;

            }
        }

        public async Task<bool> DeleteAsync(string customerId)
        {
            using (var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "CustomerDelete";
                var parameters = new DynamicParameters();
                parameters.Add("@customerId", customerId);

                var result = await context.
                    ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return result > 0;
            }
        }

        public async Task<Customers> GetAsync(string customerId)
        {
            using (var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "GetCustomerById";
                var parameters = new DynamicParameters();
                parameters.Add("@customerId", customerId);

                var customer = await context.QuerySingleAsync<Customers>
                    (storedProcedure, parameters, commandType: CommandType.StoredProcedure);

                return customer;
            }
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            using (var context = _connectionFactory.GetConnection)
            {
                var storedProcedure = "CustomerList";

                var customers = await context.QueryAsync<Customers>
                    (storedProcedure, commandType: CommandType.StoredProcedure);

                return customers;
            }
        }
        #endregion
    }
}
