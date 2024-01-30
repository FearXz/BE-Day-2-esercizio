using System;

namespace BE_Day_2_esercizio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il tuo nome: ");
            string inputName = Console.ReadLine();
            Console.WriteLine("\nInserisci il tuo cognome: ");
            string inputCognome = Console.ReadLine();
            Console.WriteLine("\nInserisci la tua età: ");
            int inputEta;

            while (!int.TryParse(Console.ReadLine(), out inputEta))
            {
                Console.WriteLine("inserisci un numero non una stringa , SCEMO !");
            }
            Persona Hachim = new Persona(inputName, inputCognome, inputEta);
            Console.WriteLine(Hachim.getDettagli());

            Console.ReadKey();
        }
    }
}
