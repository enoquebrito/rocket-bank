using RocketBank.Domain.Models.DTO.Commands;
using System.Threading.Tasks;

namespace RocketBank.Domain.Usecases.Account
{
   public interface IAddAccount
   {
      Task<int> Add(AddAccountCommand addAccount);
   }
}
