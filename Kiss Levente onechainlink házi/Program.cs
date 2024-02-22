using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kiss_Levente_onechainlist_házi
{
	internal class Program
	{

		public static OneChainList head;
		internal class OneChainList
		{
			public string data;
			public OneChainList next;

			public OneChainList(string value)
			{
				data = value;
			}
		}

		static void Main(string[] args)
		{
			head = null;

			OneChainList node1 = new OneChainList("A");
			head = node1;

			OneChainList node2 = new OneChainList("B");
			node1.next = node2;

			OneChainList node3 = new OneChainList("C");
			node2.next = node3;

			Add(new OneChainList("D"));
			Remove("A");

			OneChainList item = head;

			while (item != null)
			{
				Console.WriteLine(item.data);
				item = item.next;
			}

			Console.ReadKey();
		}


		public static void Add(OneChainList newNode)
		{
			//Ellenőrzi, hogy üres e a lista
			if (head == null)
			{
				head = newNode;
			}
			else
			{
				//utolso node keresese
				OneChainList lastNode = head;
				while (lastNode.next != null)
				{
					lastNode = lastNode.next;
				}

				//uj node hozzadasa 
				lastNode.next = newNode;
			}
		}

		public static void Remove(string value)
		{

			// ellenorzo hogy el kell e tavolitani a head et
			if (head.data == value)
			{
				head = head.next;

			}

			// parameterkent atadott node keresese
			OneChainList currentNode = head;
			while (currentNode.next != null && currentNode.next.data != value)
			{
				currentNode = currentNode.next;
			}

			
			if (currentNode.next != null)
			{
				// node eltavolitas
				currentNode.next = currentNode.next.next;
			}
		}

		
	}
}
