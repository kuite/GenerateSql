using System;

namespace GenerateSql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var app = new Application("Context name from input folder");
            app.Run();
        }
    }


}
// program main bedzie tylkko wywyloluwal apke
// uturz klase aplikacja ktora bedzie 