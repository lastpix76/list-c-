using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liost
{

    class Program
    {
        public class CreateList
        {  
            public class Node<T>
            {
                public T data;
                public Node<T> next;

                public Node(T value)
                {
                    data = value;
                    next = null;
                }
            }

            public class RemoveDuplicate<T>
            {
                public Node<T> head = null;
                public Node<T> tail = null;

                public void addNode(T data)
                { 
                    Node<T> newNode = new Node<T>(data);
 
                    if (head == null)
                    {  
                        head = newNode;
                        tail = newNode;
                    }
                    else
                    { 
                        tail.next = newNode;  
                        tail = newNode;
                    }
                }

                public void removeDuplicate()
                {  
                    Node<T> current = head, index = null, temp = null;

                    if (head == null)
                    {
                        return;
                    }
                    else
                    {
                        while (current != null)
                        { 
                            temp = current; 
                            index = current.next;

                            while (index != null)
                            { 
                                if (current.data.Equals(index.data))
                                { 
                                    temp.next = index.next;
                                }
                                else
                                {
                                    temp = index;
                                }
                                index = index.next;
                            }
                            current = current.next;
                        }
                    }
                }

                public void display()
                {  
                    Node<T> current = head;
                    if (head == null)
                    {
                        Console.WriteLine("List is empty");
                        return;
                    }
                    while (current != null)
                    {
                        Console.Write(current.data + " ");
                        current = current.next;
                    }
                    Console.WriteLine();
                }
            }

            public static void Main()
            {
                RemoveDuplicate<int> sList = new RemoveDuplicate<int>();
 
                sList.addNode(1);
                sList.addNode(2);
                sList.addNode(3);
                sList.addNode(2);
                sList.addNode(2);
                sList.addNode(4);
                sList.addNode(1);

                Console.WriteLine("Originals list: ");
                sList.display();

                sList.removeDuplicate();

                Console.WriteLine("List after removing duplicates: ");
                sList.display();
            }
        }

    }
}
