using System;
namespace Homework2
{
	class LinkedList<T> : IEnumerable<T>
	{
		public Node head;
		public class Node
		{
			public Node Next;
			public T Data;

			public void Add(T data)
			{
				if (head == null)
					head = node;
				else
					tail!.Next = node;
				tail = node;

				count++;
			}
		}
	}
}