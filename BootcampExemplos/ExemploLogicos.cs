using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bootcamp_dotnet_qa.Exemplos
{
    public class ExemploLogicos
    {
        public void ExemploOR()
        {
            bool ehMaiorDeIdade = true;
            bool possuiAutorizacao = false;

            if (ehMaiorDeIdade || possuiAutorizacao) 
            {
                Console.WriteLine("Entrada liberada");
            }
            else 
            {
                Console.WriteLine("Entrada negada");
            }
        }

        public void ExemploAnd()
        {
            bool possuiPresencaMinima = true;
            double media = 7.0;

            if (possuiPresencaMinima && media >= 7.0)
            {
                Console.WriteLine("Aprovado!");
            }
            else 
            {
                Console.WriteLine("Reprovado");
            }
        }

        public void ExemploNot()
        {
            bool choveu = true;
            bool estaTarde = true;

            if (!choveu && !estaTarde)
            {
                Console.WriteLine("Vou pedalar!");
            }
            else
            {
                Console.WriteLine("Vou pedalar outro dia");
            }
        }
    }
}