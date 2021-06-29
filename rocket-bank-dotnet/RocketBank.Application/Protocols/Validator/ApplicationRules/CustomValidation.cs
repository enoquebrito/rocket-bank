﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RocketBank.Application.Validator.ApplicationRules
{
   public class CustomValidation
   {
      public static bool BeCPF(string cpf)
      {
         /* Código abaixo retirado carinhosamente de http://www.macoratti.net/11/09/c_val1.htm */

         int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 },
            multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
         string tempCpf, digito;
         int soma, resto;

         cpf = cpf.Trim();
         cpf = cpf.Replace(".", "").Replace("-", "").Replace(" ", "");

         if (cpf.Length != 11)
            return false;

         tempCpf = cpf.Substring(0, 9);
         soma = 0;

         for (int i = 0; i < 9; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

         resto = soma % 11;

         if (resto < 2)
            resto = 0;
         else
            resto = 11 - resto;

         digito = resto.ToString();
         tempCpf = tempCpf + digito;
         soma = 0;

         for (int i = 0; i < 10; i++)
            soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

         resto = soma % 11;

         if (resto < 2)
            resto = 0;
         else
            resto = 11 - resto;

         digito = digito + resto.ToString();

         return cpf.EndsWith(digito);
      }

      public static bool BePhone(string phone)
      {
         /* Regex descaradamente copiado de https://medium.com/@igorrozani/criando-uma-express%C3%A3o-regular-para-telefone-fef7a8f98828 */

         return Regex.IsMatch(phone, @"(\(?\d{2}\)?\s)?(\d{4,5}\-\d{4})");
      }
   }
}
