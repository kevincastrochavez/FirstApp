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

        string firstName = "Bob";
        int messages = 3;
        double temperature = 34.4; // or decimal temperature = 34.4m;
        Console.WriteLine($"Hello, {firstName}! You have {messages} messages in your inbox. The temperature is {temperature} celsius.");
    }
}
