namespace FirstApp;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("This is the first line.");
        // Console.WriteLine("This is the second line.");
        // Console.WriteLine('a'); // For characters
        // Console.WriteLine('This will throw an error.');

        // Console.WriteLine(123); // For numbers
        // Console.WriteLine(0.25F); // For floats

        // Console.WriteLine(true);
        // Console.WriteLine(false);

        // string firstName;
        // char userOption;
        // int gameScore;
        // decimal particlesPerMillion;
        // bool processedCustomer;

        // string firstName;
        // firstName = "Bob";
        // string firstName = "Bob";
        // Console.WriteLine(firstName);

        // var message = "Hello world!"; // var is used for dynamic typing

        // string firstName = "Bob";
        // int messages = 3;
        // double temperature = 34.4; // or decimal temperature = 34.4m;
        // Console.WriteLine($"Hello, {firstName}! You have {messages} messages in your inbox. The temperature is {temperature} celsius.");

        // Console.WriteLine("Hello\nWorld!"); // \n for new line
        // Console.WriteLine("Hello\tWorld!"); // \t for tab
        // Console.WriteLine("Hello \"World\"!"); // \ for escape
        // Console.WriteLine("c:\\source\\repos"); // \\ since one is for escape
        // Console.WriteLine(@"    c:\source\repos    
        // (this is where your code goes)");

        // string firstName = "Bob";
        // string message = "Hello " + firstName;
        // Console.WriteLine(message);

        // string projectName = "ACME";
        // string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        // Console.WriteLine($@"View English output:    
        // c:\Exercise\{projectName}\data.txt");

        // Console.WriteLine($@"View English output:    
        // c:\Exercise\{russianMessage}\data.txt");

        // int firstNumber = 12;
        // int secondNumber = 7;
        // Console.WriteLine(firstNumber + secondNumber);

        // int sum = 7 + 5;
        // int difference = 7 - 5;
        // int product = 7 * 5;
        // int quotient = 7 / 5;

        // Console.WriteLine("Sum: " + sum);
        // Console.WriteLine("Difference: " + difference);
        // Console.WriteLine("Product: " + product);
        // Console.WriteLine("Quotient: " + quotient);

        // int first = 7;
        // int second = 5;
        // decimal quotient = (decimal)first / (decimal)second; // Explicit casting
        // Console.WriteLine(quotient);

        // int fahrenheit = 94;
        // decimal celsius = ((decimal)fahrenheit - 32) * 5 / 9;
        // // or decimal celsius = (fahrenheit - 32m) * (5m / 9m);
        // Console.WriteLine(celsius);

        int currentAssignments = 5;

        int sophia1 = 93;
        int sophia2 = 87;
        int sophia3 = 98;
        int sophia4 = 95;
        int sophia5 = 100;

        int nicolas1 = 80;
        int nicolas2 = 83;
        int nicolas3 = 82;
        int nicolas4 = 88;
        int nicolas5 = 85;

        int zahirah1 = 84;
        int zahirah2 = 96;
        int zahirah3 = 73;
        int zahirah4 = 85;
        int zahirah5 = 79;

        int jeong1 = 90;
        int jeong2 = 92;
        int jeong3 = 98;
        int jeong4 = 100;
        int jeong5 = 97;

        decimal sophiaAverage = (decimal)(sophia1 + sophia2 + sophia3 + sophia4 + sophia5) / currentAssignments;
        decimal nicolasAverage = (decimal)(nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5) / currentAssignments;
        decimal zahirahAverage = (decimal)(zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5) / currentAssignments;
        decimal jeongAverage = (decimal)(jeong1 + jeong2 + jeong3 + jeong4 + jeong5) / currentAssignments;

        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia\t\t" + sophiaAverage + "\tA");
        Console.WriteLine("Nicolas\t\t" + nicolasAverage + "\tB");
        Console.WriteLine("Zahirah\t\t" + zahirahAverage + "\tB");
        Console.WriteLine("Jeong\t\t" + jeongAverage + "\tA");
    }
}
