using RocketBank.Domain.Models.DTO.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketBank.Utils.Helpers
{
   public static class HtmlHelper
   {
      public static string GenerateCreatedAccountData(AddAccountCommand account)
      {
         string html = $@"<h1 style=""color: #5e9ca0;""><span style=""color: #ff0000;"">Sua ContaRocket foi criada!</span></h1>
                         <h2 style=""color: #2e6c80;""><span style=""color: #000080;"">Abaixo os dados cadastrados:</span></h2>
                         <ul style=""list-style-type: circle;"">
                           <li><span style=""color: #000000;""> Nome: {account.Nome}</span></li>
                           <li><span style=""color: #000000;""> Telefone: {account.Telefone}</span></li>
                           <li><span style=""color: #000000;""> Email: {account.Email}</span></li>
                           <li><span style=""color: #000000;""> CPF: {account.CPF}</span></li>
                           <li><span style=""color: #000000;""> Data de Nascimento: {account.DataNascimento}</span></li>
                           <li><span style=""color: #000000;""> Nome da M&atilde;e: {account.NomeMae}</span></li>
                         </ul>
                         <p>Caso tenha alguma d&uacute;vida entre em contato com o seu Officer.</p>
                         <p><span style=""color: #000000;"">Att,</span></p>
                         <p><span style=""color: #000000;"">Rocket Bank Onboarding Team &nbsp;&nbsp;</span>&nbsp;</p>
                         <p>&nbsp;</p>
                         <p><strong>&nbsp;</strong></p>";

         return html;
      }

      public static string GenerateWelcomeText(string name)
      {
         string html = $@"<h1 style=""color: #5e9ca0;""><span style=""color: #ff0000;"">Welcome aboard!</span></h1>
                          <h2 style=""color: #2e6c80;""><span style=""color: #000080;"">Ol&aacute;, {name}:</span></h2>
                          <p><span style=""color: #000080;"">Estamos muito contente em t&ecirc;-lo conosco!</span></p>
                          <p><span style=""color: #000080;"">Estamos enviando em anexo as informa&ccedil;&otilde;es de sua conta rec&eacute;m-criada.</span></p>
                          <p><span style=""color: #000080;"">Caso tenha alguma d&uacute;vida sobre como utilizar sua conta ou queira conhecer nossos produtos, entre em contato com o seu Officer.</span></p>
                          <p><span style=""color: #000000;"">Att,</span></p>
                          <p><span style=""color: #000000;"">Rocket Bank Onboarding Team &nbsp;&nbsp;</span>&nbsp;</p>
                          <p>&nbsp;</p>
                          <p><strong>&nbsp;</strong></p>";

         return html;
      }
   }
}
