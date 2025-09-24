namespace Oop_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Inheritance person1 = new Inheritance();
            person1.PrintInfo();

            Student student1 = new Student();
            student1.PrintInfo();

            Swimmer swimmer1 = new Swimmer();
            swimmer1.PrintInfo();


        }
    }



}
