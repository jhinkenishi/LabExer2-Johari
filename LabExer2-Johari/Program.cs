using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabExer2_Johari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Johari Macapundag                        ICT");
            do
            {

                //I have no choice 
                Console.Write("x = ");
                string str = Console.ReadLine();
                //I must handle this exeption but no according to lab exercise
                int x = Convert.ToInt32(str);
                Console.Write("y = ");
                int y = Convert.ToInt32(Console.ReadLine());
                int sum = x + y;
                Console.WriteLine("Result: {0}", sum);
            } while (true);
        }
    }
}
