using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Dynamic;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic newUser = new ExpandoObject();
            Console.WriteLine("Name>");
            newUser.Name = Console.ReadLine();
            Console.WriteLine("Age>");
            newUser.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Username>");
            newUser.Username = Console.ReadLine();

            Console.WriteLine("Your name is " + newUser.Name + ", you are " + newUser.Age + " years old.  Your username is " + newUser.Username );            
            Console.ReadKey();            
        }
    }
}
