public class Ex09
{
    public string[] OrdenacaoDeNomes(string[] nomes)
    {
        for (int i = 0; i < nomes.Length - 1; i++)
        {
            int indiceMenor = i;

            for (int j = i + 1; j < nomes.Length; j++)
            {
                if (string.Compare(nomes[j], nomes[indiceMenor], StringComparison.Ordinal) < 0)
                {
                    indiceMenor = j;
                }
            }

            if (indiceMenor != i)
            {
                string temporaria = nomes[i];
                nomes[i] = nomes[indiceMenor];
                nomes[indiceMenor] = temporaria;
            }
        }
        
        return nomes;
    }
}
