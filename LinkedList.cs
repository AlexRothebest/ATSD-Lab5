using System;


namespace Lab5
{
	public class LinkedList
	{
		public Node HeadNode;
		public int Count = 0;


		public LinkedList(params int[] Values)
		{
			HeadNode = null;

			foreach (int Data in Values)
			{
				Add(Data);
			}
		}


		public void Add(int Data)
		{
			Node Temp = new Node(Data);

			if (HeadNode == null)
			{
				HeadNode = Temp;
			}
			else
			{
				Node CurrentNode = this.HeadNode;
				while (CurrentNode.Next != null)
				{
					CurrentNode = CurrentNode.Next;
				}

				CurrentNode.Next = Temp;
			}

			this.Count++;
		}


		public void Print()
		{
			if (this.HeadNode != null)
            {
				Node CurrentNode = HeadNode;
				while (CurrentNode != null)
				{
					Console.Write($"|{CurrentNode.Data}|");
					if (CurrentNode.Next != null)
                    {
						Console.Write("->");
                    }

					CurrentNode = CurrentNode.Next;
				}

				Console.WriteLine("\b\b");
            }
            else
            {
				Console.WriteLine("");
            }
		}


		public static LinkedList SumOrderedLists(LinkedList List1, LinkedList List2)
        {
			LinkedList ResultList = new LinkedList();

			Node ItemInList1 = List1.HeadNode;
			Node ItemInList2 = List2.HeadNode;

			while (ItemInList1 != null || ItemInList2 != null)
            {
				if (ItemInList1 == null || ItemInList2.Data < ItemInList1.Data)
                {
					ResultList.Add(ItemInList2.Data);
					ItemInList2 = ItemInList2.Next;
                }
                else
                {
					ResultList.Add(ItemInList1.Data);
					ItemInList1 = ItemInList1.Next;
				}
            }

			return ResultList;
        }
	}
}