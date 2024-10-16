using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangKhaiTan_Lab03
{
    internal class MyList
    {
        private IntNode first;
        private IntNode last;

        public IntNode First
        {
            get { return first; }
            set { first = value; }
        }
        public IntNode Last
        {
            get { return last; }
            set { last = value; }
        }
        public MyList()
        {
            first = null;
            last = null;
        }
        public bool IsEmpty()
        {
            return first == null;
        }
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty())
                first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }



        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri (0 ket thuc): ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0)
                    return;
                IntNode newNode = new IntNode(x);
                AddFirst(newNode);
            } while (true);
        }
        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }

        public IntNode SearchX(int x)
        {
            IntNode current = first;
            while (current != null)
            {
                if (current.Data == x)
                    return current;
                current = current.Next;
            }
            return null; // Không tìm thấy
        }


        public IntNode GetMax()
        {
            if (IsEmpty())
                return null;

            IntNode current = first;
            IntNode maxNode = first;
            while (current == null)
            {
                if (current.Data > maxNode.Data)
                    maxNode = current;
                current = current.Next;
            }
            return maxNode;
        }

        public IntNode GetMin()
        {
            if (IsEmpty()) return null;

            IntNode current = first;
            IntNode minNode = first;
            while (current != null)
            {
                if (current.Data < minNode.Data)
                    minNode = current;
                current = current.Next;
            }
            return minNode;
        }

        public MyList GetEvenList()
        {
            MyList eventList = new MyList();
            IntNode p = first;
            while (p != null)
            {
                if ((p.Data & 2) != 0)
                {
                    eventList.AddLast(new IntNode(p.Data));
                }
                p = p.Next;
            }
            return eventList;
        }

        private void AddLast(IntNode intNode)
        {
            throw new NotImplementedException();
        }

        public MyList GetOddList()
        {
            MyList oddList = new MyList();
            IntNode p = first;
            while (p != null)
            {
                if (p.Data % 2 != 0)
                    oddList.AddLast(new IntNode(p.Data));
                p = p.Next;
            }
            return oddList;
        }
    }
}
