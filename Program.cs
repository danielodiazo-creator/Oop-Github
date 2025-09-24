namespace Oop_Github
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo");

            Inheritance person1 = new Inheritance();
            person1.PrintInfo();

            Student student1 = new Student();
            student1.PrintInfo();

            Swimmer swimmer1 = new Swimmer();
            swimmer1.PrintInfo();

            Competiror competiror1 = new Competiror();
            competiror1.Score();                            //Build errors. Jag kunde inte köra denna biten med kompilatorn

            Encapsulation encapsulation1 = new Encapsulation("Daniel"); //Här har jag skrivit en parameter med hjälp av konstruktören. 

        }
    }



}
