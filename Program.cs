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

        Console.WriteLine("Hello\nWorld!"); // \n for new line
        Console.WriteLine("Hello\tWorld!"); // \t for tab
        Console.WriteLine("Hello \"World\"!"); // \ for escape
        Console.WriteLine("c:\\source\\repos"); // \\ since one is for escape
        Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");

        string firstName = "Bob";
        string message = "Hello " + firstName;
        Console.WriteLine(message);

        string projectName = "ACME";
        string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

        Console.WriteLine($@"View English output:    
        c:\Exercise\{projectName}\data.txt");

        Console.WriteLine($@"View English output:    
        c:\Exercise\{russianMessage}\data.txt");
    }
}
