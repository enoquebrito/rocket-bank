using System.Threading.Tasks;

namespace RocketBank.Application.Protocols.EmailSender
{
   public interface IEmailSender
   {
      Task<bool> SendSuccessful<T>(T obj);
   }
}
