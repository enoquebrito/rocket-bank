using RocketBank.Application.Protocols.CloudFileStorage;
using RocketBank.Application.Protocols.EmailSender;
using RocketBank.Application.Protocols.PDFGenerator;
using RocketBank.Domain.Models.DTO.Commands;
using RocketBank.Domain.Usecases.Account;
using RocketBank.Repository.Account;
using RocketBank.Repository.RegistrationConfirmation;
using RocketBank.Utils.Helpers;
using System;
using System.Threading.Tasks;

namespace RocketBank.Application.Usecases
{
   public class AddAccount : IAddAccount
   {
      private readonly IAccountRepository _accountRepository;
      private readonly IRegistrationConfirmationRepository _registrationRepository;
      private readonly IEmailSender _emailSender;
      private readonly IPDFGenerator _pdfGenerator;
      private readonly ICloudFileStorage _cloudFileStorage;

      public AddAccount(
         IAccountRepository accountRepository,
         IEmailSender emailSender,
         IPDFGenerator pdfGenerator,
         ICloudFileStorage cloudFileStorage,
         IRegistrationConfirmationRepository registrationRepository)
      {
         _accountRepository = accountRepository;
         _emailSender = emailSender;
         _pdfGenerator = pdfGenerator;
         _cloudFileStorage = cloudFileStorage;
         _registrationRepository = registrationRepository;
      }

      public async Task<int> Add(AddAccountCommand addAccount)
      {
         var accountId = await _accountRepository.Add(addAccount);

         var pdfBytes = await GeneratePDFWithAccountData(addAccount);

         //var deuCertoAposTresTentativas = await EnviaEmailComTentativas(addAccount, 3);
         //if (deuCertoAposTresTentativas)
         //{
         //   return accountId;
         //}

         throw new Exception("Falha no envio de e-mail após três tentativas.");
      }

      private async Task<bool> EnviaEmailComTentativas(AddAccountCommand account, int tentativas)
      {
         for (int i = 0; i < tentativas; i++)
         {
            var sent = await _emailSender.SendSuccessful(account);

            if (sent)
            {
               return sent;
            }
         }

         return false;
      }

      private async Task<byte[]> GeneratePDFWithAccountData(AddAccountCommand addAccount)
      {
         var html = HtmlHelper.GenerateCreatedAccountData(addAccount);
         var pdfBytes = await _pdfGenerator.GenerateFrom(html);

         return pdfBytes;
      }
   }
}
