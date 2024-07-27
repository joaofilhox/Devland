public class Ex07
{
    public int MaiorElementoDoArray(int[] numeros)
    {
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            for (int j = 0; j < numeros.Length - 1; j++)
            {
                if (numeros[j] > numeros[j + 1])
                {
                    int temporaria = numeros[j];
                    numeros[j] = numeros[j + 1];
                    numeros[j + 1] = temporaria;
                }
            }
        }
       
            return numeros[numeros.Length -1];
    }
}