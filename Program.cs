using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Program program = new Program();
            int i = 1;
            string x = "string";
            program.Output(i,x);
            program.Output(x, i);
            Console.ReadLine();

        }
        public void Output<T,A>(T value, A second) 
        {
            Console.WriteLine(value);
            Console.WriteLine(second);

            Console.WriteLine(2);
        }
      
        

    }
}
