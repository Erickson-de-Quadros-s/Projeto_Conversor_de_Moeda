
namespace Projeto_Conversor_de_Moeda
{
    class Calculadora
    {

        public static double cotacao = 6.0 / 100;

        public static double Qtd_reais(double cotacao_dolar, double qtd_compra_dolar)
        {
            double total = cotacao_dolar * qtd_compra_dolar;
            return (total + total * cotacao );

        }
    }
}