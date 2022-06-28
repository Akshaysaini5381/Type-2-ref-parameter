using System;

namespace Type_2_ref_parameter
{
    class Program
    {
        public void show(ref int x, ref int y)
        {
           Console.WriteLine("Hello :"+x + " " + y);
            int z = x;
            x = y;
            y = z;
            Console.WriteLine(x + " " + y);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the  first number :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter the  secound number :");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("hi :"+a + " " + b);
            Program obj = new Program();
            obj.show(ref a,ref b);
            Console.WriteLine("Last: "+a + " " + b);

        }
    }
}
