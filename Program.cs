using System;
using CSharpCrash;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Reflection;

//https://youtu.be/KMsggpCaS10

class Program
{
    static void Main()
    {
        PrintToConsole();
        VariablesAndDataTypes();
        MathOperators();
        ComparisonOperators();
        LogicalOperators();
        ConditionalStatements();
        Loops();
        Arrays();
        Collections();
        Methods();
        Classes();
        ExceptionHandling();
    }

    static void PrintToConsole()
    {
        Console.WriteLine("Hello world");
    }

    static void VariablesAndDataTypes()
    {
        int age = 30;
        Console.WriteLine(age);

        float temperature = 20.4f;
        Console.WriteLine(temperature);

        double interest = 5.53;
        Console.WriteLine("Interest : " + interest);

        decimal stockPrice = 4.7538165M;
        Console.WriteLine("Stock Price : " + stockPrice);

        char grade = 'A';
        Console.WriteLine(grade);

        string name = "Ryan";
        Console.WriteLine($"My name is {name}.");

        bool isStudent = true;
        Console.WriteLine(isStudent);

        int quantity;
        string product;

        quantity = 5;
        product = "bananas";
        Console.WriteLine($"the quantity of the {product} is {quantity}.");

        const double Pi = 3.14;
        Console.WriteLine(Pi);
    }

    static void MathOperators()
    {
        int num1 = 10;
        int num2 = 5;

        int addition = num1 + num2;
        Console.WriteLine(addition);

        int subtraction = num1 - num2;
        Console.WriteLine(subtraction);

        int multiplication = num1 * num2;
        Console.WriteLine(multiplication);

        int division = num1 / num2;
        Console.WriteLine(division);

        int modulus = 11 % 5;
        Console.WriteLine(modulus);

        int num3 = 5;
        int num4 = 0;

        try
        {
            int quotient = num3 / num4;
            Console.WriteLine(quotient);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"An error occured: " + ex.Message);

        }

        int num5 = 105;
        double num5AsDouble = (Double)num5;
        Console.WriteLine(num5AsDouble);


    }

    static void ComparisonOperators()
    {
        int a = 10;
        int b = 5;

        bool isEqual = (a == b);
        Console.WriteLine(isEqual);

        bool isNotEqual = (a != b);
        Console.WriteLine(isNotEqual);

        bool isGreater = (a > b);
        Console.WriteLine(isGreater);

        bool isLess = (a < b);
        Console.WriteLine(isLess);

        bool isGreaterThanOrEqual = (a >= b);
        Console.WriteLine(isGreaterThanOrEqual);

        bool isLessThanOrEqual = (a <= b);
        Console.WriteLine(isLessThanOrEqual);

    }

    static void LogicalOperators()
    {

        bool x = true;
        bool y = false;

        bool andResult = (x && y);
        Console.WriteLine(andResult);

        bool orResult = (x || y);
        Console.WriteLine(orResult);

        bool notResult1 = (x && !y);
        Console.WriteLine(notResult1);

        bool notResult2 = !x;
        Console.WriteLine(notResult2);


    }

    static void ConditionalStatements()
    {
        int age = 100;

        if (age < 18)
        {
            Console.WriteLine("You are a minor");
        }
        else if (age >= 18 && age <= 65)
        {
            Console.WriteLine("You are an adult ");
        }
        else
        {
            Console.WriteLine("You are a senior ");

        }

        /**
       * SWITCH STATEMENTS
       */
        int day = 3;
        string dayName;

        switch (day)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            default:
                dayName = "Weekend";
                break;
        }

        Console.WriteLine("Today is " + dayName);

    }

    static void Loops()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Number : " + i);
        }

        int count = 0;

        while (count < 5)
        {
            Console.WriteLine("While Count : " + count);
            count++;
        }

        count = 0;

        do
        {
            Console.WriteLine("Do-While Count : " + count);
            count++;
        } while (count < 10);

        int[] numbers = { 1, 2, 3, 4, 5 };

        foreach (int number in numbers)
        {
            Console.WriteLine("Number in array:" + number);

        }

        for (int i = 0; i < numbers.Length; i++)
            Console.WriteLine("Standard Loop - numbers: " + numbers[i]);
    }

    static void Arrays()
    {
        string[] names = new string[3];
        names[0] = "Ryan";
        names[1] = "Bob";
        names[2] = "Jamie";

        Console.WriteLine(names.Length);
        Console.WriteLine(names[1]);

    }

    static void Collections()
    {
        List<string> cities = new List<string>();
        cities.Add("Auckland");
        cities.Add("Hamilton");
        cities.Add("Wellington");
        cities.Add("Taupo");

        Console.WriteLine(cities[2]);
        Console.WriteLine(cities.Count);

        foreach (string city in cities)
        {
            Console.WriteLine(city);
        }

        // HashSets do not allow duplicates
        HashSet<string> countries = new HashSet<string>();
        countries.Add("NZ");
        countries.Add("AUS");
        countries.Add("ENG");
        countries.Add("SA");
        countries.Add("SA");

        Console.WriteLine("countries count : " + countries.Count);

        foreach (string country in countries)
        {
            Console.WriteLine(country);

        }

        Dictionary<string, int> ageDict = new Dictionary<string, int>();
        string dictKey = "Ryan";
        ageDict[dictKey] = 25; // {"Ryan": 25 , "Bob": 30}
        ageDict["Bob"] = 35;
        ageDict["Jamie"] = 24;

        if (ageDict.ContainsKey(dictKey))
        {
            Console.WriteLine($"{dictKey}'s age: {ageDict[dictKey]}");
        }

        foreach (var entry in ageDict)
        {
            Console.WriteLine("Key: " + entry.Key);
            Console.WriteLine("Value: " + entry.Value);
        }

        Queue<string> queue = new Queue<string>();
        queue.Enqueue("First");
        queue.Enqueue("Second");
        queue.Enqueue("Third");

        while (queue.Count > 0)
        {
            string item = queue.Dequeue();
            Console.WriteLine($"Queue Item: " + item);

        }

        Stack<string> stack = new Stack<string>();
        stack.Push("First");
        stack.Push("Second");
        stack.Push("Third");

        while (stack.Count > 0)
        {
            string item = stack.Pop();
            Console.WriteLine("Stack item: " + item);

        }

    }

    static void Methods()
    {
        SayHello();

        int a = 10;
        int b = 20;
        int sum = Add(a, b);
        Console.WriteLine("Sum: " + sum);

    }

    private static void SayHello()
    {
        Console.WriteLine("Hello there!");

    }

    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static void Classes()
    {
        Person p = new Person("Ryan", 25);
        p.Greet();
    }

    static void ExceptionHandling()
    {
        int a = 10;
        int b = 0;

        try
        {
            int result = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);

        }

        List<string> shapes = new List<string> { "square", "rectangle", "circle", };

        try
        {
            Console.WriteLine(shapes[0]);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"This index does not exits : " + ex.Message);

        }
        finally
        {
            Console.WriteLine("All code has been run");

        }

        // We can also create custom exception classes
        bool isStudent = false;

        try
        {
            if (isStudent)
            {
                Console.WriteLine("This is a student");
            }
            else
            {
                throw new CustomException("You cannot enroll for this course because you are not a student.");
            }
        }
        catch (CustomException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}