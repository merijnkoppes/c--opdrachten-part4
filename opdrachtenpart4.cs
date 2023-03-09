// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

public class Opdrachtenpart2
{
    private static string? userInput;

    public static void Main(string[] args)
    {
        callopdrachtenpart2();
    }
    public static void callopdrachtenpart2()
    {
        Console.WriteLine("");
        Console.WriteLine("------------------------------------------------------------");
        Console.WriteLine("");
        Console.Write("Welke opdracht moet uitgevoerd worden?\r\nDe opdrachten die je in dit bestand kan aanroepen zijn:\r\n4,\r\n8,\r\n11,\r\n17,\n20\r\nen\r\n21\r\nGeef de opdracht die je wilt aanroepen:");
        userInput = Console.ReadLine();                    // Assign new value to userInput
        double doubleValue = Convert.ToDouble(userInput);  // Convert string to double type
        if (doubleValue == 4)
        {
            Console.WriteLine("opdracht 2-4:");
            Console.WriteLine("");
            opdracht4();
        }
        else if (doubleValue == 8)
        {
            Console.WriteLine("opdracht 2-8:");
            Console.WriteLine("");
            opdracht8();

        }
        else if (doubleValue == 11)
        {
            Console.WriteLine("opdracht 2-11:");
            Console.WriteLine("");
            opdracht11();

        }
        else if (doubleValue == 17)
        {
            Console.WriteLine("opdracht 2-17:");
            Console.WriteLine("");
            opdracht17();

        }
        else if (doubleValue == 20)
        {
            Console.WriteLine("opdracht 2-20:");
            Console.WriteLine("");
            opdracht20();

        }
        else if (doubleValue == 21)
        {
            Console.WriteLine("opdracht 2-213:");
            Console.WriteLine("");
            opdracht21();

        }
        else
        {
            Console.WriteLine("Deze opdracht heb ik niet gemaakt. De opdrachten die je in dit bestand kan aanroepen zijn:\r\n4,\r\n8,\r\n11,\r\n17,\n20\r\nen\r\n21");
        }

    }

    // opdrachten
    static void opdracht4()
    {
        Console.WriteLine("Geef het eerste nummer:");
        userInput = Console.ReadLine();
        int nummer1 = Convert.ToInt32(userInput);
        Console.WriteLine("Geef het tweede nummer:");
        userInput = Console.ReadLine();
        int nummer2 = Convert.ToInt32(userInput);
        if (nummer1 == nummer2)
        {
           Console.WriteLine(nummer1 + " " + "en" + " " + nummer2 + " " + "zijn even groot");  
        }
        else if (nummer1 > nummer2)
        {
            Console.WriteLine(nummer1 + " " + "is groter dan" + " " + nummer2 );
        }
        else if (nummer1 < nummer2)
        {
            Console.WriteLine(nummer1 + " " + "is kleiner dan" + " " + nummer2);
        }
        callopdrachtenpart2();
    }
    static void opdracht8()
    {
        int optelsom = 0;
        int aantalnummers = 0;
        int evennummers = 0;
        int onevennummers = 0;
        Console.WriteLine("Geef nummers 1 voor 1. Geef -1 om te stop.");

        while (true)
        {
            Console.Write("Geef een nummer: ");
            int num = int.Parse(Console.ReadLine());

            if (num == -1)
            {
                break;
            }
            optelsom += num;
            aantalnummers++;

            if (num % 2 == 0)
            {
                evennummers++;
            }
            else
            {
                onevennummers++;
            }
        }

        // Print results
        Console.WriteLine("Thx! Bye!");
        Console.WriteLine("Sum of numbers: " + optelsom);
        Console.WriteLine("Number of numbers: " + aantalnummers);
        Console.WriteLine("Average of numbers: " + (double)optelsom / aantalnummers);
        Console.WriteLine("Number of even numbers: " + evennummers);
        Console.WriteLine("Number of odd numbers: " + onevennummers);
        callopdrachtenpart2();
    }
    static void opdracht11()
    {
        Console.Write("Geef een nummer: ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Nummers vanaf 1 tot " + num + ":");
        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + " ");
        }
        callopdrachtenpart2();
    }

    public static int Sum(int number1, int number2, int number3, int number4)
    {
        int sum = number1 + number2 + number3 + number4;
        return sum;
    }
    static void opdracht17()
    {
        Console.WriteLine("geef 4 nummers:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = Convert.ToInt32(Console.ReadLine());
        int number4 = Convert.ToInt32(Console.ReadLine());

        int answer = Sum(number1, number2, number3, number4);
        Console.WriteLine("Sum: " + answer);
        callopdrachtenpart2();
    }
    public static void PrintStars(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
    }

    public static void PrintSquare(int size)
    {
        for (int i = 0; i < size; i++)
        {
            PrintStars(size);
        }
    }

    public static void PrintRectangle(int width, int height)
    {
        for (int i = 0; i < height; i++)
        {
            PrintStars(width);
        }
    }

    public static void PrintTriangle(int size)
    {
        for (int i = 0; i < size; i++)
        {
            PrintStars(i + 1);
        }
    }
    static void opdracht20()
    {
        Console.Write("hoe groot moet het vierkant zijn?: ");
        int size = int.Parse(Console.ReadLine());
        PrintSquare(size);

        Console.Write("Hoe breed moet de rechthoek zijn?: ");
        int width = int.Parse(Console.ReadLine());
        Console.Write("Hoe hoog moet de rechthoek zijn?: ");
        int height = int.Parse(Console.ReadLine());
        PrintRectangle(width, height);

        Console.Write("hoe groot moet de driehoek zijn?: ");
        int triangleSize = int.Parse(Console.ReadLine());
        PrintTriangle(triangleSize);
        callopdrachtenpart2();
    }
    public static void PrintSpaces(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.Write(" ");
        }
    }
    static void opdracht21()
    {
        Console.Write("Hoe hoog moet de kerstboom zijn: ");
        int height = int.Parse(Console.ReadLine());
        if (height > 119)
        {
            Console.Write(height + "is te hoog, de maximale hoogte is 119.");
            Console.WriteLine("");
            height = 119;
        }

        // Print the top of the tree
        for (int i = 1; i <= height; i++)
        {
            PrintSpaces(height - i);
            PrintStars((i * 2) - 1);
        }

        // Print the base of the tree
        for (int i = 1; i <= 2; i++)
        {
            PrintSpaces(height - 1);
            PrintStars(2);
        }
        callopdrachtenpart2();
    }
















}
