public class Ex08
{
    public int SomaDosElementosDoArray(int[] numeros)
    {   int soma = 0;
        foreach (int numero in numeros)
        {
         soma += numero;
        }
        return soma;
    }
}