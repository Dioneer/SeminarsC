using System;
namespace Homework2
{
	public class LinkedList<T>
	{
		public Node head;
		public class Node
		{
			public Node Next;
			public T Value;
		}
		public void AddFirst(T value)
		{
			Node node = new Node();
			node.Value = value;
			if (head != null)
			{
				node.Next = head;
			}
			head = node;
		}
		public void DeleteFirst(T value)
		{
			if (head != null)
			{
				head = head.Next;
			}
		}
		public Node contains(T value)
		{
			Node node = head;
			while (node != null)
			{
				if (node.Value.Equals(value))
					return node;
				node = node.Next;
			}
			return null;
		}

		public void Sort(Comparer<T> comparer)
		{
			Node node = head;
			while (node != null)
			{
				Node minvalueNode = node;
				Node node2 = node.Next;
				while (node2 != null)
				{
					if (comparer.Compare(minvalueNode.Value, node2.Value))
					{
						minvalueNode = node2;
					}
					node2 = node.Next;
				}

				if (minvalueNode != node)
				{
					T buf = node.Value;
					node.Value = minvalueNode.Value;
					minvalueNode.Value = buf;
				}
				node = node.Next;

			}
		}
		public void addLast(T value)
		{
			Node node = new Node();
			node.Value = value;
			if (head == null)
			{
				head = node;
			}
			else
			{
				Node LastNode = head;
				while (LastNode.Next != null)
				{
					LastNode = LastNode.Next;
				}
				LastNode.Next = node;
			}
		}
		public void removeLast(T value)
		{
			if (head == null)
				return;
			Node node = head;
			while (node.Next != null)
			{
				if (node.Next.Next == null)
				{
					node = node.Next;
					return;
				}
				node = node.Next;
			}
			head = null;
		}
		public String toString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			Node node = new Node();
			while (node != null)
			{
				stringBuilder.append(node.Value);
				stringBuilder.append('\n');
				node = node.Next;
			}
			return super.toString();
		}

		// ================================================================================
		public void Revert()
		{
			if (head != null && head.Next != null)
				Revert(head.Next, head);
		}
		private void Revert(Node currentNode, Node previous)
		{
			if (currentNode.Next == null)
			{
				head = currentNode;
			}
			else
			{
				Revert(currentNode.Next, currentNode);
			}

			currentNode.Next = previous;
			previous.Next = null;
		}
	}
}