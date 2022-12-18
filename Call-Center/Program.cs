using System.Collections;
using System;
namespace Call_Center
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            Console.WriteLine("Bun venit la Call-Center. Cu ce va putem ajuta? \n\n" +
                    "1. Adaugati o noua problema a clientilor in coada.\n" +
                    "2. Afiseaza numarul problemei care trebuie rezolvata. \n" +
                    "3. Elimina problema curenta din coada, caci a fost rezolvata. \n" +
                    "4. Afiseaza toate problemele nerezolvate ale clientilor. \n");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Introduceti comanda:");
            Console.ForegroundColor = ConsoleColor.White;
            string input = Console.ReadLine();
            while (!string.IsNullOrEmpty(input))
            {

                switch (input)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Introduceti in coada numarul de inregistrare al problemei: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        input = Console.ReadLine();
                        if (!string.IsNullOrEmpty(input))
                        {
                            if (!queue.Contains(input))
                            {
                                queue.Enqueue(input);
                                
                                Console.WriteLine("Ati introdus elementul: {0}", input);
                            }
                            else
                                Console.WriteLine("Numarul este deja in coada");
                        }
                        else
                            Console.WriteLine("Anulare comanda");
                        break;
                    case "2":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (queue.Count > 0)
                            Console.WriteLine("Trebuie rezolvata problema: {0}", queue.Peek());
                        else
                            Console.WriteLine("Nu exista probleme in asteptare");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "3":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (queue.Count > 0)
                            Console.WriteLine("Ati revolvat problema: {0}", queue.Dequeue());
                        else
                            Console.WriteLine("Nu exista probleme in asteptare");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        if (queue.Count > 0)
                        {
                            Console.WriteLine("Coada contine urmatoarele probleme:");
                            foreach (string elem in queue)
                                Console.WriteLine(elem);
                        }
                        else
                            Console.WriteLine("Nu exista probleme in asteptare");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.WriteLine("Comanda incorecta");
                        break;

                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\nIntroduceti comanda: ");
                Console.ForegroundColor = ConsoleColor.White;
                input = Console.ReadLine();
            }
        }
    }
}