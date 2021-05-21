using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverList
{
    public class RoverList<T> : RoverListBase<T>
    {
        // Add any variables you need here
        public int count;
        Node nextNode;
        public RoverList ()
        {

        }

        public override int Count
        {
            get
            {
                return count;
            }
        }

        public override void Add(T data)
        {
            Node newNode = new Node(data);
            if(head == null)
            {
                head = newNode;
            }
            else
            {
                //Traverses the list till it gets appended.
            }
            count++;
        }


        public override void Add(int Position, T data)
        {
            if (Position < 1 || Position > count + 1)
            {

            }
            else
            {

                // Keep looping until the pos is zero
                while (Position != 0)
                {
                    Position--;
                    if (Position == 0)
                    {

                        // adding Node at required position
                        Node temp = head;

                        // Making the new Node to point to
                        // the old Node at the same position
                        temp.Next = current;

                        // Changing the pointer of the Node previous
                        // to the old Node to point to the new Node
                        current = temp;
                    }
                    else
                        // Assign double pointer variable to point to the
                        // pointer pointing to the address of next Node
                        current = current.Next;
                }
                count++;
            }
        }

        public override void Clear()
        {
            head = null;

        }

        public override T ElementAt(int Position)
        {
            throw new NotImplementedException();
        }

        public override void ListNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data + " ,");
                current = current.Next;
            }
        }

        public override bool RemoveAt(int Position)
        {
            bool removed = false;
            if(Position == 0)
            { 
                head = head.Next;
            }
            else
            {
                head.Next = current.Next.Next;
            }
            return removed;
        }
    }
}
