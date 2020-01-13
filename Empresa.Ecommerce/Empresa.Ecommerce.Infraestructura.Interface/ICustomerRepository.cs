using System;
using System.Collections.Generic;
using System.Text;
using Empresa.Ecommerce.Dominio.Entity;
using System.Threading.Tasks;

namespace Empresa.Ecommerce.Infraestructura.Interface
{
    public interface ICustomerRepository
    {
        #region Métodos sincronos
        bool Insertar(Customeres customers);
        bool Update(Customeres customers);
        bool Delete(string customerId);
        Customeres Get(string customerId);
        IEnumerable<Customeres> GetAll();
        #endregion

        #region Métodos asincronos
        Task<bool> InsertarAsync(Customeres customeres);
        Task<bool> UpdateAsync(Customeres customeres);
        Task<bool> DeleteAsync(string customerId);
        Task<Customeres> GetAsync(string customerId);
        Task<IEnumerable<Customeres>> GetAllAsync();
        #endregion

    }
}
