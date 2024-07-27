using System.Text;

public class Ex06
{
    public string ContagemDeCaracteres(string str)
    {
        StringBuilder resultado = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            bool jaContado = false;
            for (int k = 0; k < i; k++)
            {
                if (str[i] == str[k])
                {
                    jaContado = true;
                    break;
                }
            }

            if (!jaContado)
            {
                int numero = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        numero += 1;
                    }
                }
                 resultado.AppendLine($"{str[i]} aparece {numero} vez(es).");
            }
        }

         return resultado.ToString();
    }
}
