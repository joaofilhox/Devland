public class Ex03
{
    public string VerificarNumeroPrimo(int numero)
    {
        int divisor = 0;

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {

                divisor++;
            }
        }
        if (divisor == 2 )
        {
            return "É um número primo!";
        }
        else
        {
            return "Não é um número primo!";
        }
    }
}