using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> nums = new LinkedList<int>();
            nums.AddLast(1);
            nums.AddLast(2);
            nums.AddLast(33);
            nums.AddLast(43);
            nums.AddLast(55);
            nums.AddLast(23);
            nums.AddLast(67);

            LinkedListNode<int> node = nums.Find(23);
            nums.AddBefore(node,5);

            foreach (int num in nums)
            {
                Console.WriteLine(num);
                Console.ReadKey();
            }
        }
    }
}
