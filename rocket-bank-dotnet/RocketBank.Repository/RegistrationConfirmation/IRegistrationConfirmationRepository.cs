using RocketBank.Domain.Models.DTO.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBank.Repository.RegistrationConfirmation
{
   public interface IRegistrationConfirmationRepository
   {
      Task<string> Add(AddRegistrationCommand addRegistrationCommand);
   }
}
