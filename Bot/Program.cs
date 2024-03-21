using Bot._Testobot;

namespace Bot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bot = new Testobot();
            bot.Initialize();
            bot.Run();
            Console.ReadKey();
        }
    }
}
