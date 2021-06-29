using RocketBank.Application.Protocols.EmailSender;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBank.Infra.EmailSender
{
   public class SmtpSenderAdapter : IEmailSender
   {
      public async Task<bool> SendSuccessful<T>(T obj)
      {
         throw new NotImplementedException();
      }
   }
}
