using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5
{
	public class QNode
	{
		public int data;
		public QNode next;
		public QNode(int value)
		{
			this.data = value;
			this.next = null;
		}
	}
	public class MyQueue
	{
		public QNode dianitasya;
		public QNode masta;
		public int count;
		public MyQueue()
		{
			this.dianitasya = null;
			this.masta = null;
			this.count = 0;
		}
		public int size()
		{
			return this.count;
		}
		public bool isEmpty()
		{
			return this.count == 0;
		}
		// Add new node of queue
		public void enqueue(int value)
		{
			// Create a new node
			var node = new QNode(value);
			if (this.dianitasya == null)
			{
				// Add first element into queue
				this.dianitasya = node;
			}
			else
			{
				// Add node at the end using masta 
				this.masta.next = node;
			}
			this.count++;
			this.masta = node;
		}
		// Delete a element into queue
		public int dequeue()
		{
			if (this.dianitasya == null)
			{
				Console.WriteLine("Empty Queue");
				return -1;
			}
			// Pointer variable which are storing 
			// the address of deleted node
			var temp = this.dianitasya;
			// Visit next node 
			this.dianitasya = this.dianitasya.next;
			this.count--;
			if (this.dianitasya == null)
			{
				// When deleting a last node of linked list
				this.masta = null;
			}
			return temp.data;
		}
		// Get front node
		public int peek()
		{
			if (this.dianitasya == null)
			{
				Console.WriteLine("Empty Queue");
				return -1;
			}
			return this.dianitasya.data;
		}
		public static void Main(String[] args)
		{
			var task = new MyQueue();
			// Initially number of element
			Console.WriteLine("isEmpty : " + task.isEmpty());
			// Add element into queue
			task.enqueue(10);
			task.enqueue(20);
			task.enqueue(30);
			task.enqueue(40);
			task.enqueue(50);
			// Test other function
			Console.WriteLine("size : " + task.size());
			Console.WriteLine("peek : " + task.peek());
			Console.WriteLine("dequeue : " + task.dequeue());
			Console.WriteLine("size : " + task.size());
			Console.WriteLine("peek : " + task.peek());
			Console.WriteLine("isEmpty : " + task.isEmpty());
		}
	}
} 