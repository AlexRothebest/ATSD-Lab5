using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable HashTable1 = new HashTable(60, 0, 450);
            HashTable1.Print();

            HashTable HashTable2 = new HashTable(90, 0, 450);
            HashTable2.Print();

            Console.WriteLine("------------------------------------------------------------");

            LinkedList LinkedList1 = new LinkedList(1, 2, 5, 8, 19);
            LinkedList LinkedList2 = new LinkedList(2, 4, 7, 8, 10, 32);
            LinkedList1.Print();
            LinkedList2.Print();

            LinkedList LinkedList3 = LinkedList.SumOrderedLists(LinkedList1, LinkedList2);
            LinkedList3.Print();
        }
    }
}
