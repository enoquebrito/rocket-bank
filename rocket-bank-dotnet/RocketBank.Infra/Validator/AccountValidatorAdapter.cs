using FluentValidation;
using RocketBank.Application.Validator;
using RocketBank.Application.Validator.ApplicationRules;
using RocketBank.Domain.Models.DTO.Commands;
using System;

namespace RocketBank.Infra.Validator
{
   public class AccountValidatorAdapter : AbstractValidator<AddAccountCommand>, ICommandValidator<AddAccountCommand>
   {
      public AccountValidatorAdapter()
      {
         RuleFor(account => account.Nome).NotEmpty().Length(3, 30);
         RuleFor(account => account.NomeMae).NotEmpty().Length(3, 30);
         RuleFor(account => account.CPF).Must(cpf => CustomValidation.BeCPF(cpf)).WithMessage("CPF inválido");
         RuleFor(account => account.Email).NotEmpty().EmailAddress();
         RuleFor(account => account.DataNascimento).NotNull().Must(data => data.Year <= (DateTime.Now.Year - 18)).WithMessage("Ano de nascimento inválido");
         RuleFor(account => account.Telefone).NotEmpty().Must(telefone => CustomValidation.BePhone(telefone)).WithMessage("Telefone inválido");
      }

      public bool IsValid { get; private set; }
      public string Errors { get; private set; }

      public new void Validate(AddAccountCommand addAccount)
      {
         var result = base.Validate(addAccount);

         IsValid = result.IsValid;
         Errors = result.ToString(",");
      }
   }
}
