using System;
using System.Collections.Generic;
using System.Text;
using Empresa.Ecommerce.Application.DTO;
using Empresa.Ecommerce.Transversal.Common;
using System.Threading.Tasks;

namespace Empresa.Ecommerce.Application.Interface
{
    public interface ICustomerApplication
    {
        #region Métodos sincronos
        Response<bool> Insertar(CustomersDTO customersDto);
        Response<bool> Update(CustomersDTO customersDto);
        Response<bool> Delete(string customerId);
        Response<CustomersDTO> Get(string customerId);
        Response<IEnumerable<CustomersDTO>> GetAll();
        #endregion

        #region Métodos asincronos
        Task<Response<bool>> InsertarAsync(CustomersDTO customersDto);
        Task<Response<bool>> UpdateAsync(CustomersDTO customersDto);
        Task<Response<bool>> DeleteAsync(string customerId);
        Task<Response<CustomersDTO>> GetAsync(string customerId);
        Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync();
        #endregion
    }
}
