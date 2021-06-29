using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBank.Application.Protocols.PDFGenerator
{
   public interface IPDFGenerator
   {
      Task<byte[]> GenerateFrom(string html);
   }
}
