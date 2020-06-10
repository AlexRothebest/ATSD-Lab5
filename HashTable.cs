using System;


namespace Lab5
{
    class HashTable
    {
        LinkedList[] Lists;
        int NumberOfItems;
        int NumberOfCollisions = 0;


        public HashTable(int NumberOfItems, int MinValue, int MaxValue)
        {
            this.Lists = new LinkedList[NumberOfItems];
            this.NumberOfItems = NumberOfItems;

            for (int i = 0; i < NumberOfItems; i++)
            {
                Lists[i] = new LinkedList();
            }

            Random rnd = new Random();
            for (int i = 0; i < NumberOfItems; i++)
            {
                int NextItem = rnd.Next(MinValue, MaxValue);
                int NextItemHashCode = HashCode(NextItem);
                if (Lists[NextItemHashCode].Count != 0)
                {
                    this.NumberOfCollisions++;
                }
                Lists[NextItemHashCode].Add(NextItem);
            }
        }


        public int HashCode(int Item)
        {
            return (Item + 14) % this.NumberOfItems;
        }


        public void Print()
        {
            Console.WriteLine("------------------------------------------------------------");
            for (int i = 0; i < this.NumberOfItems; i++)
            {
                Console.Write($"{i}: ");
                Lists[i].Print();
            }
            Console.WriteLine($"\nNumber of items: {this.NumberOfItems}");
            Console.WriteLine($"Number of collisions: {this.NumberOfCollisions}");
            Console.WriteLine("------------------------------------------------------------");
        }
    }
}