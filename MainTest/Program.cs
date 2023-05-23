using System;

namespace MainTest
{
    using System;

    namespace ControlTestMain
    {
        //struct Aircraft
        //{
        //    public int AircraftNumber;
        //    public string Name;
        //    public Aircraft(int aircraftNumber, string name)
        //    {
        //        AircraftNumber = aircraftNumber;
        //        Name = name;
        //    }
        //}

        //struct Node
        //{
        //    public Aircraft Data;
        //    public Node Next;
        //    public Node Previous;
        //}

        //public static class DoublyLinkedList
        //{
        //    private static Node head;
        //    private static Node tail;

        //    public static void InsertInOrder(Aircraft aircraft)
        //    {
        //        Node newNode = new Node { Data = aircraft };

        //        if (head == null) // If list is empty
        //        {
        //            head = newNode;
        //            tail = newNode;
        //        }
        //        else if (aircraft.AircraftNumber <= head.Data.AircraftNumber) // Insert at the beginning
        //        {
        //            newNode.Next = head;
        //            head.Previous = newNode;
        //            head = newNode;
        //        }
        //        else if (aircraft.AircraftNumber >= tail.Data.AircraftNumber) // Insert at the end
        //        {
        //            newNode.Previous = tail;
        //            tail.Next = newNode;
        //            tail = newNode;
        //        }
        //        else // Insert in the middle
        //        {
        //            Node current = head;

        //            while (current.Next != null && aircraft.AircraftNumber > current.Next.Data.AircraftNumber)
        //            {
        //                current = current.Next;
        //            }

        //            newNode.Next = current.Next;
        //            newNode.Previous = current;
        //            current.Next.Previous = newNode;
        //            current.Next = newNode;
        //        }
        //    }

        //    public static void DisplayList()
        //    {
        //        if (head == null)
        //        {
        //            Console.WriteLine("List is empty.");
        //            return;
        //        }

        //        Node current = head;

        //        while (current != null)
        //        {
        //            Console.WriteLine("Aircraft Number: {0}, Name: {1}", current.Data.AircraftNumber, current.Data.Name);
        //            current = current.Next;
        //        }
        //    }
        //}

        //public class Program
        //{
        //    public static void Main(string[] args)
        //    {
        //        // Inserting aircrafts
        //        DoublyLinkedList.InsertInOrder(new Aircraft(2, "Aircraft 2"));
        //        DoublyLinkedList.InsertInOrder(new Aircraft(1, "Aircraft 1"));
        //        DoublyLinkedList.InsertInOrder(new Aircraft(4, "Aircraft 4"));
        //        DoublyLinkedList.InsertInOrder(new Aircraft(3, "Aircraft 3"));
        //        DoublyLinkedList.InsertInOrder(new Aircraft(5, "Aircraft 5"));

        //        // Displaying the list
        //        DoublyLinkedList.DisplayList();
        //    }
        //}

        struct Aircraft
        {
            public int AircraftNumber;
            public string Name;
        }

        struct Node
        {
            public Aircraft Data;
            public int NextIndex;
            public int PreviousIndex;
        }

        struct DoublyLinkedList
        {
            private Node[] list;
            private int headIndex;
            private int tailIndex;
            private int freeIndex;

            public void Initialize(int capacity)
            {
                list = new Node[capacity];
                InitializeList();
            }

            private void InitializeList()
            {
                headIndex = -1;
                tailIndex = -1;
                freeIndex = 0;

                for (int i = 0; i < list.Length; i++)
                {
                    list[i].NextIndex = i + 1;
                    list[i].PreviousIndex = -1;
                }

                list[list.Length - 1].NextIndex = -1;
            }

            private int GetFreeIndex()
            {
                int newIndex = freeIndex;
                freeIndex = list[newIndex].NextIndex;
                return newIndex;
            }

            private void ReleaseIndex(int index)
            {
                list[index].NextIndex = freeIndex;
                list[index].PreviousIndex = -1;
                freeIndex = index;
            }

            public void InsertInOrder(Aircraft aircraft)
            {
                int newIndex = GetFreeIndex();
                list[newIndex].Data = aircraft;

                if (headIndex == -1) // If list is empty
                {
                    headIndex = newIndex;
                    tailIndex = newIndex;
                }
                else if (aircraft.AircraftNumber <= list[headIndex].Data.AircraftNumber) // Insert at the beginning
                {
                    list[newIndex].NextIndex = headIndex;
                    list[headIndex].PreviousIndex = newIndex;
                    headIndex = newIndex;
                }
                else if (aircraft.AircraftNumber >= list[tailIndex].Data.AircraftNumber) // Insert at the end
                {
                    list[newIndex].PreviousIndex = tailIndex;
                    list[tailIndex].NextIndex = newIndex;
                    tailIndex = newIndex;
                }
                else // Insert in the middle
                {
                    int currentIndex = headIndex;

                    while (currentIndex != -1 && aircraft.AircraftNumber > list[currentIndex].Data.AircraftNumber)
                    {
                        currentIndex = list[currentIndex].NextIndex;
                    }

                    list[newIndex].NextIndex = currentIndex;
                    list[newIndex].PreviousIndex = list[currentIndex].PreviousIndex;
                    list[currentIndex].PreviousIndex = newIndex;

                    if (list[newIndex].PreviousIndex != -1)
                    {
                        list[list[newIndex].PreviousIndex].NextIndex = newIndex;
                    }
                }
            }

            public void DisplayList()
            {
                if (headIndex == -1)
                {
                    Console.WriteLine("List is empty.");
                    return;
                }

                int currentIndex = headIndex;

                while (currentIndex != -1)
                {
                    Console.WriteLine("Aircraft Number: {0}, Name: {1}", list[currentIndex].Data.AircraftNumber, list[currentIndex].Data.Name);
                    currentIndex = list[currentIndex].NextIndex;
                }
            }
        }

        public static class Program
        {
            public static void Main(string[] args)
            {
                DoublyLinkedList aircraftList = new DoublyLinkedList();
                aircraftList.Initialize(5);

                // Inserting aircrafts
                aircraftList.InsertInOrder(new Aircraft { AircraftNumber = 2, Name = "Aircraft 2" });
                aircraftList.InsertInOrder(new Aircraft { AircraftNumber = 1, Name = "Aircraft 1" });
                aircraftList.InsertInOrder(new Aircraft { AircraftNumber = 4, Name = "Aircraft 4" });
                aircraftList.InsertInOrder(new Aircraft { AircraftNumber = 3, Name = "Aircraft 3" });
                aircraftList.InsertInOrder(new Aircraft { AircraftNumber = 5, Name = "Aircraft 5" });

                // Displaying the list
                aircraftList.DisplayList();
            }
        }
    }
}
