using System;
using System.Collections.Generic;
using System.Text;
using Empresa.Ecommerce.Dominio.Entity;
using System.Threading.Tasks;

namespace Empresa.Ecommerce.Dominio.Interface
{
    public interface ICustomerDomain
    {
        #region Métodos sincronos
        bool Insertar(Customers customers);
        bool Update(Customers customers);
        bool Delete(string customerId);
        Customers Get(string customerId);
        IEnumerable<Customers> GetAll();
        #endregion

        #region Métodos asincronos
        Task<bool> InsertarAsync(Customers customeres);
        Task<bool> UpdateAsync(Customers customeres);
        Task<bool> DeleteAsync(string customerId);
        Task<Customers> GetAsync(string customerId);
        Task<IEnumerable<Customers>> GetAllAsync();
        #endregion
    }
}
