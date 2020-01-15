using System;
using Empresa.Ecommerce.Dominio.Entity;
using Empresa.Ecommerce.Dominio.Interface;
using Empresa.Ecommerce.Infraestructura.Interface;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace Empresa.Ecommerce.Dominio.Core
{
    public class CustomersDomain: ICustomerDomain
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomersDomain(ICustomerRepository customer)
        {
            _customerRepository = customer;
        }

        #region Métodos sincronos
        public bool Insertar(Customers customers)
        {
            return _customerRepository.Insertar(customers);
        }

        public bool Update(Customers customers)
        {
            return _customerRepository.Update(customers);
        }

        public bool Delete(string idcustomer)
        {
            return _customerRepository.Delete(idcustomer);
        }

        public Customers Get(string idcustomer)
        {
            return _customerRepository.Get(idcustomer);
        }

        public IEnumerable<Customers> GetAll()
        {
            return _customerRepository.GetAll();
        }
        #endregion

        #region Métodos Aincronos
        public async Task<bool> InsertarAsync(Customers customers)
        {
            return await _customerRepository.InsertarAsync(customers);
        }

        public async Task<bool> UpdateAsync(Customers customers)
        {
            return await _customerRepository.UpdateAsync(customers);
        }

        public async Task<bool> DeleteAsync(string idcustomer)
        {
            return await _customerRepository.DeleteAsync(idcustomer);
        }

        public async Task<Customers> GetAsync(string idcustomer)
        {
            return await _customerRepository.GetAsync(idcustomer);
        }

        public async Task<IEnumerable<Customers>> GetAllAsync()
        {
            return await _customerRepository.GetAllAsync();
        }
        #endregion
    }
}
