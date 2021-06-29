using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBank.Domain.Models.DTO.Commands
{
   public class AddAccountCommand
   {
      public string Nome { get; set; }
      public string Email { get; set; }
      public DateTime DataNascimento { get; set; }
      public string NomeMae { get; set; }
      public string Telefone { get; set; }
      public string CPF { get; set; }
   }
}
