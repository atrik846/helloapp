namespace helloapp_black;

class HelloApp
{
    static void Main(string[] args)
    {
        SayHello();
        GreetWhite();
        GreetBlack();
    }

    static void SayHello()
    {
        Console.WriteLine("Hello everyone");
    }
    
    static void GreetWhite()
    {
        Console.WriteLine("Hello white");
    }
    
    static void GreetBlack()
    {
        Console.WriteLine("Hello black");
    }
}