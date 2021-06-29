using RocketBank.Application.Protocols.PDFGenerator;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDev.HtmlRenderer.PdfSharp;

namespace RocketBank.Infra.PDFGenerator
{
   public class PdfSharpAdapter : IPDFGenerator
   {
      public Task<byte[]> GenerateFrom(string html)
      {
         byte[] res = null;

         Task.Run(() =>
         {
            using (MemoryStream ms = new MemoryStream())
            {
               var pdf = PdfGenerator.GeneratePdf(html, PdfSharp.PageSize.A4);
               pdf.Save(ms);
               res = ms.ToArray();
            }
         });

         return Task.FromResult(res);
      }
   }
}
