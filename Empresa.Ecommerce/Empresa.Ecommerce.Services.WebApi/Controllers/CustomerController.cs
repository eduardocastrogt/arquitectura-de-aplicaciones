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
        }
        #endregion
    }
}