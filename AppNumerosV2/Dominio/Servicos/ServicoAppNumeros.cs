using AppNumerosV2.Dominio.Argumentos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AppNumerosV2.Dominio.Servicos
{
    public class ServicoAppNumeros
    {
        public static AppNumerosResponse Calcula(string dado)
        {
            AppNumerosResponse retorno = new AppNumerosResponse();

            // Validação
            if (!Int32.TryParse(dado, out Int32 numero))
            {
                retorno.Mensagem = "O dado informado é inválido, digite um número inteiro!";
                return retorno;
            }
            
            // Lista de números divisores
            List<int> divisores = new List<int>();
            for (int i = 1; i <= numero; i++)
            {
                if ((numero % i) == 0)
                {
                    divisores.Add(i);
                }
            }

            // Lista de números divisores primos
            List<int> divisoresPrimos = new List<int>();
            foreach (int item in divisores.Distinct())
            {
                bool primo = true;
                int contador = item - 1;
                while (contador > 2)
                {
                    if (item % contador == 0)
                    {
                        primo = false;
                        break;
                    }
                    contador--;
                }

                if (primo == true)
                {
                    divisoresPrimos.Add(item);
                }
            }

            retorno.NumerosDivisores = String.Join(", ", divisores.Distinct());
            retorno.DivisoresPrimos = String.Join(", ", divisoresPrimos.Distinct());
            return retorno;
        }
    }
}
