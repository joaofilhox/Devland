namespace Exercicios
{
    class Program
    {
        static void Main()
        {
            Ex01 ex01 = new Ex01();
            Console.WriteLine(ex01.SomarDeDoisNumeros(10,2));

            Ex02 ex02 = new Ex02();
            Console.WriteLine(ex02.VerificarSeNumeroParOuImpar(11));

            Ex03 ex03 = new Ex03();
            Console.WriteLine(ex03.VerificarNumeroPrimo(2));

            Ex04 ex04 = new Ex04();
            Console.WriteLine(ex04.InversaoDeString("abacaxi"));

            Ex05 ex05 = new Ex05();
            int[] numeros = { 2, 3, 1, 8, 4, 5 };
            Console.WriteLine(string.Join(", ", ex05.OrdenacaoDeArray(numeros)));

            Ex06 ex06 = new Ex06();
            Console.WriteLine(ex06.ContagemDeCaracteres("abacaxi"));

            Ex07 ex07 = new Ex07();
            Console.WriteLine(ex07.MaiorElementoDoArray([1,2,5,8,11]));

            Ex08 ex08 = new Ex08();
            Console.WriteLine(ex08.SomaDosElementosDoArray([2,3,10,50,100]));
            
            Ex09 ex09 = new Ex09();
            string[] nomes = {"camila","tulio","antonio","ananias","breno"};
            Console.WriteLine(string.Join(", ", ex09.OrdenacaoDeNomes(nomes)));
            }
    }
}