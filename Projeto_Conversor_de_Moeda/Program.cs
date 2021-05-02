using System;
using System.Globalization;

namespace Conversor_Moeda
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Qual eh a cotacao do dolar?");
            double cotacao_dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantos dolares voce vai comprar?");
            double qtd_compra_dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            double Qtd_reais = Projeto_Conversor_de_Moeda.Calculadora.Qtd_reais(cotacao_dolar, qtd_compra_dolar);


            Console.WriteLine("A Quantidade em reais eh \n" + Qtd_reais.ToString("F2", CultureInfo.InvariantCulture));

            /* double volume = Calculadora.Volume(raio);
            Console.WriteLine("O Volume eh \n" + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Valor de PI eh \n" + Calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
*/
        }
    }

}
