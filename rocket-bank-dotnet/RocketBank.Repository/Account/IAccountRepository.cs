using RocketBank.Domain.Models.DTO.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBank.Repository.Account
{
   public interface IAccountRepository
   {
      Task<int> Add(AddAccountCommand accountCommand);
   }
}
