using System;

namespace ConsoleProgram
{
    class Program
    {
        static void Main(string[] args)
        {
	    Person salamPerson = new Person { Id = 1, Name = "AbdoSalam Salehpour" };

            Console.WriteLine(salamPerson.Name);

	    Console.WriteLine("Press any key ...");
        }
    }
}
