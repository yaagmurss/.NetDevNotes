using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms
{
    // Linked list is a data structure that represents a sequence of nodes
    // Nodes ==> [[Data][Link]]

    class Node // This is how we define Node Class
    {
        
        public int element;
        public Node next;
        public Node(int e, Node n) // Constructor : In order to initiliaze class node elements
        {
            element = e;
            next = n;

        }
    }
    class LinkedListClass
    {
        public Node Head;
        public Node Tail;
        public int Size;

        public void SampleMethod()
        {
            var n1 = new Node(7, null);   // [[7][null]]
            var n2 = new Node(4, null);   // [[4][null]]

            Console.WriteLine("Data of n1 Node : ", n1.element); // Returns 7
            Console.WriteLine("Link of n1 Node : ", n1.next);    // Returns null

            Console.WriteLine("Data of n2 Node : ", n1.element); // Returns 4
            Console.WriteLine("Link of n2 Node : ", n1.next);   // Returns null

            n1.next = n2; // n1 linked to n2 
        }
        public int Lenght()
        {
            return Size;
        }
        public bool isEmpty()
        {
            return Size == 0 ;
        }

        // HOW TO ADD ELEMENT IN THE LINKEDLIST
        public void AddLast(int e)
        {
            Node newest = new Node(e, null); // Creates Nodes like ==> [[e][null]]
            if (isEmpty())                   // If Node is empty than first node that we want to add is going to be HEAD
            {
                Head = newest;
            }
            else
            {
                Tail.next = newest;         // If Node is NOT empty than the node that we want to add is going to be TAIL
            }
                
            Tail = newest;                  // Tail will be the newest node
            Size = Size + 1;                // Size increase by one

        }                

        // HOW TO ADD ELEMENT BEGINNING OF THE LINKEDLIST
        public void AddFirst(int e)
        {
            var newest = new Node(e, null);
            if (isEmpty())
            {
                Head = newest;
                Tail = newest;
            }
            else
            {
                newest.next = Head;
                Head = newest;
            }
            Size =+ 1; 

        }

        // HOW TO DISPLAY ELEMENTS IN THE LINKEDLIST
        public void Display()
        {
            Node p = Head;
            while (p != null)
            {
                Console.Write(p.element + " ==> ");
                p = p.next;
            }
            Console.WriteLine();
        }

        // HOW TO INSERT ELEMENTS ANYWHERE IN THE LINKEDLIST
        public void AddAny(int e, int position)
        {
            if(position <= 0 || position >= Size)
            {
                Console.WriteLine("invalid position");
                return;
            }
            Node newest = new Node(e, null);
            Node p = Head;
            int i = 1;
            while (i < position - 1)
            {
                p = p.next;
                i =+ 1;
            }
            
        }

        // TRAVERSING NODES OF LINKED LIST

        // [[7] [4125]] ==> [[4] [4132]] ==> [[12] [4140]] ==> [[3] [NULL]]
        //    4120      ==>     4125 ==>        4132       ==>     4140
        //    HEAD                                                  TAIL

        // x = x.next ==> If we keep execute this statement, x will encounter null
        // This is how we can start from the head(that is the first node of list), move one node after until reach the tail 

        // function Display()
        //      p = head
        //      while p is not null
        //      p = p.next





    }
}
