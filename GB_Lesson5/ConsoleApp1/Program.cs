using System;



int Doo()
{
    var exception = new Exception("Hello from my error!!!!");
    throw exception;
}
int Foo()
{
    return Doo() + 1;
}

try
{
    Foo();
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

namespace ConsoleApp1
{

    class Program
    {


        static void Main(string[] args)
        {
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(a/b);

            
        }
    }
}
