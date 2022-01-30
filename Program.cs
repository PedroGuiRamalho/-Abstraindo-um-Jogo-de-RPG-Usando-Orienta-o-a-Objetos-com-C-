
using dotnet___poo.src.Entities;

namespace dotnet___poo
{
    class Program 
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "knight");
            Wizard wizard = new Wizard("Jennica", 23, "White wizard");

        
            Console.WriteLine(arus.Attack(1));
            Console.WriteLine(Wizard.Attack(7));
        }
    }
}
