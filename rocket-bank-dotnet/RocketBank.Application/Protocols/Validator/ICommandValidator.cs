using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBank.Application.Validator
{
    public interface ICommandValidator<T> where T : class
   {
      bool IsValid { get; }
      string Errors { get; }

      void Validate(T obj);
   }
}
