namespace Exercicios
{
    public class Ex04
    {
        public string InversaoDeString(string str)
        {
            string novaStr = "";
            for (var i = str.Length - 1; i >= 0; i--)
            {
                novaStr += str[i];
            }
            return novaStr;
        }
    }
}
