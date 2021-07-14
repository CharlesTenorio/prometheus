using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Prometheus.Domain{
    public class DomainExceptionValidation : Exception
	{
        public DomainExceptionValidation(string error): base(error)
        {
            
        }

        public static void When(bool hasError, string error){

            if(hasError)
               throw new DomainExceptionValidation(error);

        }


        public static bool IsCnpj(string cnpj)
		{
			int[] multiplicador1 = new int[12] {5,4,3,2,9,8,7,6,5,4,3,2};
			int[] multiplicador2 = new int[13] {6,5,4,3,2,9,8,7,6,5,4,3,2};
			int soma;
			int resto;
			string digito;
			string tempCnpj;

			cnpj = cnpj.Trim();
			cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

			if (cnpj.Length != 14)
			   return false;

			tempCnpj = cnpj.Substring(0, 12);

			soma = 0;
			for(int i=0; i<12; i++)
			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

			resto = (soma % 11);
			if ( resto < 2)
			   resto = 0;
			else
			   resto = 11 - resto;

			digito = resto.ToString();

			tempCnpj = tempCnpj + digito;
			soma = 0;
			for (int i = 0; i < 13; i++)
			   soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

			resto = (soma % 11);
			if (resto < 2)
			    resto = 0;
			else
			   resto = 11 - resto;

			digito = digito + resto.ToString();

			return cnpj.EndsWith(digito);
		}


        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool IsCpf(string cpf)
	    {
		int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
		int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
		string tempCpf;
		string digito;
		int soma;
		int resto;

		cpf = cpf.Trim();
		cpf = cpf.Replace(".", "").Replace("-", "");

		if (cpf.Length != 11)
		   return false;

		tempCpf = cpf.Substring(0, 9);
		soma = 0;

		for(int i=0; i<9; i++)
		    soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

		resto = soma % 11;
		if ( resto < 2 )
		    resto = 0;
		else
		   resto = 11 - resto;

		digito = resto.ToString();

		tempCpf = tempCpf + digito;

		soma = 0;
		for(int i=0; i<10; i++)
		    soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

		resto = soma % 11;
		if (resto < 2)
		   resto = 0;
		else
		   resto = 11 - resto;

		digito = digito + resto.ToString();

		return cpf.EndsWith(digito);
	  }

	   public static bool IsDataValida(DateTime dataEntrada)
	   {
		   DateTime dataAtual = DateTime.Now;
           int result = DateTime.Compare(dataAtual, dataEntrada);
	   }
	}

    }


