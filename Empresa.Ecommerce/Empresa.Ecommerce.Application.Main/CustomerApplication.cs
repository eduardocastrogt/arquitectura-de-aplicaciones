using System;
using AutoMapper;
using Empresa.Ecommerce.Application.DTO;
using Empresa.Ecommerce.Application.Interface;
using Empresa.Ecommerce.Dominio.Entity;
using Empresa.Ecommerce.Dominio.Interface;
using Empresa.Ecommerce.Transversal.Common;
using System.Threading.Tasks;
using System.Collections.Generic;



namespace Empresa.Ecommerce.Application.Main
{
    public class CustomerApplication: ICustomerApplication
    {
        private readonly ICustomerDomain _customerDomain;
        private readonly IMapper _mapper;
        public CustomerApplication(ICustomerDomain customerDomain, IMapper mapper)
        {
            _customerDomain = customerDomain;
            _mapper = mapper;
        }

        #region Métodos sincronos
        public Response<bool> Insertar(CustomersDTO customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = _customerDomain.Insertar(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        public Response<bool> Update(CustomersDTO customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = _customerDomain.Update(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        public Response<bool> Delete(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = _customerDomain.Delete(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        public Response<CustomersDTO> Get(string customerId)
        {
            var response = new Response<CustomersDTO>();
            try
            {
                var customer = _customerDomain.Get(customerId);
                response.Data = _mapper.Map<CustomersDTO>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        public Response<IEnumerable<CustomersDTO>> GetAll()
        {
            var response = new Response<IEnumerable<CustomersDTO>>();
            try
            {
                var customer = _customerDomain.GetAll();
                response.Data = _mapper.Map<IEnumerable<CustomersDTO>>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        #endregion

        #region Métodos asincronos
        public async Task<Response<bool>> InsertarAsync(CustomersDTO customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = await _customerDomain.InsertarAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Registro exitoso";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        public async Task<Response<bool>> UpdateAsync(CustomersDTO customersDto)
        {
            var response = new Response<bool>();
            try
            {
                var customer = _mapper.Map<Customers>(customersDto);
                response.Data = await _customerDomain.UpdateAsync(customer);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Actualización exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        public async Task<Response<bool>> DeleteAsync(string customerId)
        {
            var response = new Response<bool>();
            try
            {
                response.Data = await _customerDomain.DeleteAsync(customerId);
                if (response.Data)
                {
                    response.IsSuccess = true;
                    response.Message = "Eliminación exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        public async Task<Response<CustomersDTO>> GetAsync(string customerId)
        {
            var response = new Response<CustomersDTO>();
            try
            {
                var customer = await _customerDomain.GetAsync(customerId);
                response.Data = _mapper.Map<CustomersDTO>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        public async Task<Response<IEnumerable<CustomersDTO>>> GetAllAsync()
        {
            var response = new Response<IEnumerable<CustomersDTO>>();
            try
            {
                var customer = await _customerDomain.GetAllAsync();
                response.Data = _mapper.Map<IEnumerable<CustomersDTO>>(customer);
                if (response.Data != null)
                {
                    response.IsSuccess = true;
                    response.Message = "Consulta exitosa";
                }
            }
            catch (Exception ex)
            {
                response.Message = ex.Message;

            }

            return response;
        }
        #endregion
    }
}
