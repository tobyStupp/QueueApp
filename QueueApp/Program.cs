using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace QueueApp
{
    class Program
    {
        static Queue<int> MakeQueue (int len = 8)
        {
            Queue<int> q = new Queue<int>();
            Random rnd = new Random();

            for (int i=0; i< len; i++)
            {
                q.Insert(rnd.Next(50) + 1);
            }
            return q;

        }
        static Queue<int> Copy (Queue<int> q)
        {
            Queue<int> temp = new Queue<int>();
            Queue<int> copy = new Queue<int>();
            while (!q.IsEmpty())
                temp.Insert(q.Remove());
            while (!temp.IsEmpty())
            {
                q.Insert(temp.Head());
                copy.Insert(temp.Remove());
            }
            return copy;
        }
        static bool  Mystery (int num)
        {
            if (num < 10)
                return false;
            if (num % 10 == (num / 10) % 10)
                return true;
            return Mystery(num / 10);
        }
        static Queue <int> Sod (Stack<int> stack)
        {
            if (stack.IsEmpty())
                return new Queue<int>();
            int x = stack.Pop();
            Queue<int> q = Sod(stack);
            if (Mystery(x))
                q.Insert(x);
            else
                stack.Push(x);
            return q; 
        }
        static void Print (Queue<int> q)
        {
            Queue<int> c = Copy(q);
            Console.Write("[");
            if (!c.IsEmpty())
                Console.Write(c.Remove());
            while (!c.IsEmpty())
            {
                Console.Write(",{0}", c.Remove());
            }
            Console.WriteLine("]");
             
        }
        static int Count (Queue<int> q)
        {

            // Returns the amount of elements in q
            throw new NotImplementedException();
        }
        static int Remove (Queue<int> q, int x)
         {
            //returns how many time x appears in q and removes it
            throw new NotImplementedException();

        }
        static bool Exists (Queue<int> q, int x)
        {
            // returns true if the value x exists in q else it returns false
            throw new NotImplementedException(); 
        }
        static void RemoveDoubles (Queue<int> q)
        {
            // removes every repeats of existing numbers in the queue
            throw new NotImplementedException();
        }
        static void AddSorted (Queue<int> q, int x)
        {
            // adds new value in sorted queue
            throw new NotImplementedException();
        }
        static Queue<int> Intersect (Queue<int>q1, Queue<int> q2)
        {
            // returns a queue with all the values appearing in q1 and q2 and removes accordingly
            throw new NotImplementedException();
        }
        static int UpDownSeries (Node<int> p)
        {
            Node<int> prevUp = p;
            Node<int> prevDown;
            Node<int> currentUP;
            Node<int> currentDown;
            int count = 1;
            if (p != null && p.GetNext() != null)
            {
                prevDown = p.GetNext();
                count++;
            }
            else
                return count;
           while (prevDown.GetNext()!=null)
            {
                currentUP = prevDown.GetNext();
                if (prevUp.GetValue() > currentUP.GetValue())
                    return count;
                count++;
                if (currentUP.GetNext() == null)
                    prevDown = currentUP;
                else
                { 
                    currentDown = currentUP.GetNext();
                    if (prevDown.GetValue() < currentDown.GetValue())
                        return count;
                    count++;
                    prevUp = currentUP;
                    prevDown = currentDown;
                }
            }
            return count;
        }
        static bool Contains (BinNode<int> t1, BinNode<int> t2)
        {
            if (t2 == null)
                return true;
            if (t1 == null)
                return false;
            if (t1.GetValue() != t2.GetValue())
                return false;
            return Contains(t1.GetLeft(), t2.GetLeft()) && Contains(t1.GetRight(), t2.GetRight());
        }
        public static Queue<int> QD (Queue<int> q)
        {
            Stack<int> s = new Stack<int>();
            Queue<int> q1 = new Queue<int>();
            while (!q.IsEmpty())
            {
                s.Push(q.Remove());
                q1.Insert(q.Remove());
            }
            Queue<int> result = new Queue<int>();
            while (!s.IsEmpty())
                result.Insert(s.Pop());
            while (!q1.IsEmpty())
                result.Insert(q1.Remove());
            return result;
        }
        public static Queue<int> BuildQueue (int[] ar)
        {
            Queue<int> q = new Queue<int>();
            foreach (int x  in ar)
            {
                q.Insert(x);
                q.Insert(x);
            }
            return q;
        }
        public static void PrintStack(Stack<int> stack)
        {
            Stack<int> temp = new Stack<int>();
            while (!stack.IsEmpty())
            {
                Console.Write("{0,6}", stack.Top());
                temp.Push(stack.Pop());
            }
            while (!temp.IsEmpty())
                stack.Push(temp.Pop());
        }
        static void Main(string[] args)
        {
            //int[] ar = { 5, 7, 3, 4, 1 };
            //Queue<int> q = BuildQueue(ar);
            //Print(q);
            //q = QD(q);
            //Print(q);
            //Stack<int> stack = new Stack<int>();
            //stack.Push(123);
            //stack.Push(1443);
            //stack.Push(4211);
            //stack.Push(122);
            //stack.Push(38481);
            //PrintStack(stack);
            //Console.ReadKey();
            //Console.WriteLine();
            //Queue<int> q = Sod(stack);

            //PrintStack(stack);
            //Console.WriteLine();
            //Print(q);
            //Console.WriteLine();
            //Node<int> p = new Node<int>(1);
            //p = new Node<int>(10, p);
            //p = new Node<int>(2, p);
            //p = new Node<int>(8, p);
            //p = new Node<int>(3, p);
            //p = new Node<int>(1, p);
            //p = new Node<int>(5, p);
            //p = new Node<int>(3, p);
            //Console.WriteLine(UpDownSeries(p));
            BinNode<int> t = new BinNode<int>(new BinNode<int>(3), 1, new BinNode<int>(new BinNode<int>(6), 3, new BinNode<int>(2)));
            BinNode<int> t1 = new BinNode<int>(new BinNode<int>(3), 1, new BinNode<int>(null, 3, new BinNode<int>(5)));
            if (Contains(t, t1))
                Console.WriteLine("Works");
            else
                Console.WriteLine("Shit");

            Console.ReadKey();


        }
    }
}
