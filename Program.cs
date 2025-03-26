 namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            cat mycat= new cat();
            Dog mydog = new Dog();
            mydog.Eat();
            mydog.Bark();

        }
    }
}
