using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBank.Application.Protocols.CloudFileStorage
{
   public interface ICloudFileStorage
   {
      Task<FileStream> Download(string key); 
      Task<string> Upload(string key); 
   }
}
