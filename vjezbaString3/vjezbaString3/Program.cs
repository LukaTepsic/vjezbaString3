using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Unesite rečenicu (ili 'izlaz' za prekid):");
            string input = Console.ReadLine();

            if (input.ToLower() == "izlaz")
            {
                break;
            }

            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (words.Length > 0)
            {
                Console.WriteLine($"Prva riječ: {words[0]}");
                Console.WriteLine($"Zadnja riječ: {words[words.Length - 1]}");
            }
            else
            {
                Console.WriteLine("Niste unijeli nijednu riječ.");
                Console.ReadKey();
            }
        }
    }
}
