using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RocketBank.Application.Validator;
using RocketBank.Domain.Models.DTO.Commands;
using RocketBank.Domain.Usecases.Account;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RocketBank.Api.Controller
{
   [Route("api/[controller]")]
   [ApiController]
   public class AccountController : ControllerBase
   {
      private readonly IAddAccount _addAccount;
      private readonly ICommandValidator<AddAccountCommand> _validator;

      public AccountController(IAddAccount addAccount, ICommandValidator<AddAccountCommand> validator)
      {
         _addAccount = addAccount;
         _validator = validator;
      }

      [HttpPost]
      public async Task<IActionResult> Add([FromBody] AddAccountCommand addAccount)
      {
         try
         {
            _validator.Validate(addAccount);

            if (!_validator.IsValid)
            {
               return BadRequest($"Erro na requisição. Um ou mais parâmetros estão inválidos: {_validator.Errors}");
            }

            var result = await _addAccount.Add(addAccount);

            return Ok(result);
         }

         catch (Exception ex)
         {
            //Logar na AWS / MongoDB
            return Problem(ex.Message);
         }
      }
   }
}
