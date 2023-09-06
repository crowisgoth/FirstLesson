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
           GeneriClass<int,int,string> generiClass = new GeneriClass<int, int,string>(1,2);
            generiClass.Value = "hello world";
            Console.WriteLine(generiClass.Value);
            generiClass.ConsoleOut(); 
            Program program = new Program();         
            Console.ReadLine();                      
    }
        public void Output<T,A>(T value, A second) 
        {
            Console.WriteLine(value);
            Console.WriteLine(second);
            Console.WriteLine(2);
        }           
    }
   class GeneriClass<T,A,Q>
    {
        public Q Value;
        public T value;
        public A second;
        public GeneriClass(T value,A second)
        {
            this.value = value;
            this.second = second;
        }
        public void ConsoleOut()
        {           
            Console.WriteLine(this.value);
            Console.Write(this.second);
            
        }
    }
   
}
