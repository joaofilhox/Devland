namespace Exercicios
{
    public class Ex05
    {
        public int[] OrdenacaoDeArray(int[] numeros)
        {
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - 1 - i; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temporaria = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temporaria;
                    }
                }
            }

            return numeros;
        }
    }
}
