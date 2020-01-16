using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Empresa.Ecommerce.Application.DTO;
using Empresa.Ecommerce.Application.Interface;

namespace Empresa.Ecommerce.Services.WebApi.Controllers
{
    [Route("api/[controller]/{action}")]
    [ApiController]
    public class CustomerController : Controller
    {
        private readonly ICustomerApplication _customerApplication;
        public CustomerController(ICustomerApplication customerApplication)
        {
            _customerApplication = customerApplication;
        }

        #region Métodos sincronos
        [HttpPost]
        public IActionResult Insert([FromBody] CustomersDTO customer)
        {
            if (customer == null)
                return BadRequest();

            var response = _customerApplication.Insertar(customer);
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpPut]
        public IActionResult Update([FromBody] CustomersDTO customer)
        {
            if (customer == null)
                return BadRequest();

            var response = _customerApplication.Update(customer);
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpPut("{customerId}")]
        public IActionResult Delete(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return BadRequest();

            var response = _customerApplication.Delete(customerId);
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpGet("{customerId}")]
        public IActionResult Get(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return BadRequest();

            var response = _customerApplication.Get(customerId);
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpGet]
        public IActionResult GetAll()
        {

            var response = _customerApplication.GetAll();
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }
        #endregion

        #region Métodos asincronos
        [HttpPost]
        public async Task<IActionResult> InsertAsync([FromBody] CustomersDTO customer)
        {
            if (customer == null)
                return BadRequest();

            var response = await _customerApplication.InsertarAsync(customer);
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync([FromBody] CustomersDTO customer)
        {
            if (customer == null)
                return BadRequest();

            var response = await _customerApplication.UpdateAsync(customer);
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpPut("{customerId}")]
        public async Task<IActionResult> DeleteAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return BadRequest();

            var response = await _customerApplication.DeleteAsync(customerId);
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpGet("{customerId}")]
        public async Task<IActionResult> GetAsync(string customerId)
        {
            if (string.IsNullOrEmpty(customerId))
                return BadRequest();

            var response = await _customerApplication.GetAsync(customerId);
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {

            var response = await _customerApplication.GetAllAsync();
            if (response.IsSuccess)
                return Ok(response.Data);

            return BadRequest(response.Message);
        }
        #endregion
    }
}