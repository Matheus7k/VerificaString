internal class Program
{
    private static void Main(string[] args)
    {
        string texto1, texto2;

        Console.Write("Digite a primeira palavra: ");
        texto1 = Console.ReadLine();

        Console.Write("Digite a segunda palavra: ");
        texto2 = Console.ReadLine();

        if (comparaString(texto1, texto2))
        {
            Console.WriteLine("As palavras são iguais!");
        }
        else
        {
            Console.WriteLine("As palavras não são iguais!");
        }

        bool comparaString(string texto1, string texto2)
        {
            return texto1.Equals(texto2);
        }
    }
}