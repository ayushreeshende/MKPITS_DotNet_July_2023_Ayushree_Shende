using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class car
{
    public void carstart()
    {
        Console.WriteLine("car is starting"); 
    }
}
class scorpio : car
{
    public void startmusic()
    {
        Console.WriteLine("music is start");
    }





    internal class Program
    {
        static void Main(string[] args)
        {
            scorpio s = new scorpio();
            s.startmusic();
            s.carstart();
            Console.ReadKey();

        }
    }
}