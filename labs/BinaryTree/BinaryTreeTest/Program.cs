using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BinaryTree;

namespace BinaryTreeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree<int> tree1 = new Tree<int>(10);
            tree1.Insert(5);
            tree1.Insert(11);
            tree1.Insert(5);
            tree1.Insert(-12);
            tree1.Insert(15);
            tree1.Insert(0);
            tree1.Insert(14);
            tree1.Insert(-8);
            tree1.Insert(10);
            tree1.Insert(8);
            tree1.Insert(8);
            string sortedData = tree1.WalkTree();
            Console.WriteLine($"Sorted data is: {sortedData}");
            Console.WriteLine("======================================================================");
            Tree<string> tree2 = new Tree<string>("Hello");
            tree2.Insert("World");
            tree2.Insert("How");
            tree2.Insert("Are");
            tree2.Insert("You");
            tree2.Insert("Today");
            tree2.Insert("I");
            tree2.Insert("Hope");
            tree2.Insert("You");
            tree2.Insert("Are");
            tree2.Insert("Feeling");
            tree2.Insert("Well");
            tree2.Insert("!");
            sortedData = tree2.WalkTree();
            Console.WriteLine($"Sorted data is: {sortedData}");
            Console.WriteLine("=======================================================================================");
            Tree<char> tree3 = new Tree<char>('S');
            tree3.Insert('T');
            tree3.Insert('e');
            tree3.Insert('v');
            tree3.Insert('e');
            tree3.Insert('n');
            tree3.Insert(' ');
            tree3.Insert('F');
            tree3.Insert('a');
            tree3.Insert('i');
            tree3.Insert('r');
            tree3.Insert('c');
            tree3.Insert('h');
            tree3.Insert('i');
            tree3.Insert('l');
            tree3.Insert('d');
            sortedData = tree3.WalkTree();
            Console.WriteLine($"Sorted data is :{sortedData}");

        }
    }
}
