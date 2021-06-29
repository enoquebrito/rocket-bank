using RocketBank.Application.Protocols.PDFGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPdf;

namespace RocketBank.Infra.PDFGenerator
{
   public class IronPDFAdapter : IPDFGenerator
   {
      public async Task<string> GenerateFrom(string html)
      {
         throw new NotImplementedException();
      }
   }
}
