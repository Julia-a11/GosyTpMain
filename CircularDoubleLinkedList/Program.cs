using System;

namespace CircularDoubleLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularDoubleLinkedList<string> circularList = new CircularDoubleLinkedList<string>();
            circularList.Add("Tom");
            circularList.Add("Bob");
            circularList.Add("Alice");
            circularList.Add("Sam");

            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }

            circularList.Remove("Bob");
            Console.WriteLine("\n После удаления: \n");
            foreach (var item in circularList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
