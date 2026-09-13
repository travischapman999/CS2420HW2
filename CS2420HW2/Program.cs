public class Program
{
	public static void Main()
	{
		LinkedList linkedList1 = new LinkedList([2, 2, 2, 1, 3, 3, 4, 4, 4, 5, 5]);
		Console.Write("List with duplicates: ");
		linkedList1.PrintList();
		linkedList1.RemoveDuplicates();
		Console.Write("List without duplicates: ");
		linkedList1.PrintList();
		LinkedList linkedList2 = new LinkedList([1, 1, 0, 0, 0, 1, 1, 1, 1]);
		Console.Write($"Binary before change to decimal: ");
		linkedList2.PrintList();
		int binaryToDecimal = linkedList2.BinaryToDecimal(linkedList2.GetHead());
		Console.WriteLine($"Decimal: {binaryToDecimal}");
		LinkedList decimalToBinary = new LinkedList();
		int number = 7;
		Console.WriteLine($"Decimal before change to binary: {number}");
		decimalToBinary.DecimalToBinary(number);
		Console.Write("Binary: ");
		decimalToBinary.PrintList();
	}
	public class Node
	{
		public int value;
		public Node next;
		public Node(int value)
		{
			this.value = value;
		}
	}
	public class LinkedList
	{
		private Node head;
		private Node tail;
		private int length;
		public LinkedList(int value)
		{
			Node newNode = new Node(value);
			head = newNode;
			tail = newNode;
			length = 1;
		}
		public LinkedList(int[] values)
		{
			foreach (int value in values)
			{
				Append(value);
			}
		}
		public LinkedList()
		{
			head = null;
			tail = null;
			length = 0;
		}
		public Node GetHead()
		{
			return head;
		}
		public Node GetTail()
		{
			return tail;
		}
		public int GetLength()
		{
			return length;
		}
		public void PrintList()
		{
			Node temp = head;
			while (temp != null)
			{
				Console.Write(temp.value);
				temp = temp.next;
			}
			Console.WriteLine();
		}
		public void Append(int value)
		{
			Node newNode = new Node(value);
			if (length == 0)
			{
				head = newNode;
				tail = newNode;
			}
			else
			{
				tail.next = newNode;
				tail = newNode;
			}
			length++;
		}
		public void Prepend(int value)
		{
			Node newNode = new Node(value);
			if (length == 0)
			{
				head = newNode;
				tail = newNode;
			}
			else
			{
				newNode.next = head;
				head = newNode;
			}
			length++;
		}
		public void RemoveDuplicates()
		{
			Node current = head;
			while (current.next != null)
			{
				if (head == null) return;
				if (length == 1) return;
				if (current.value == current.next.value)
				{
					current.next = current.next.next;
				}
				else { current = current.next; }
			}
		}
		public int BinaryToDecimal(Node head)
		{
			int decimalValue = 0;
			Node current = head;
			while (current != null)
			{
				decimalValue = decimalValue * 2 + current.value;
				current = current.next;
			}
			return decimalValue;
		}
		public LinkedList DecimalToBinary(int number)
		{
			int runningTotal = number;
			while (runningTotal >= 1)
			{
				int remainder = runningTotal % 2;
				Prepend(remainder);
				runningTotal = runningTotal / 2;
			}
			return this;
		}
	}
}