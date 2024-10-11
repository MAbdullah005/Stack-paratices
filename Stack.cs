using System;
using System.Text;
namespace Linklistapplication
{
    public class Stack_build
    {
        const int size = 100;
        int index1 = size / 2;
        int[] stack = new int[size];
        int index = 0;
        public void push(int num)
        {
            if (index > index1)
            {
                Console.WriteLine("stack 1 is full"); return;
            }
            stack[index++] = num;
        }
        public void push1(int num)
        {
            if (index1 > stack.Length)
            {
                Console.WriteLine("stack 2 is full ");
            }
            stack[index1++] = num;
        }
        public int pop1()
        {
            if (!isempty1())
            {
                return stack[--index];
            }
            Console.WriteLine("stack 1 is empty");
            return -1;
        }
        public int pop2()
        {
            if (isempty2())
            {
                Console.WriteLine("stack 2 is empty"); return -1;
            }
            return stack[--index1];
        }
        public int peek1()
        {
            if (isempty1())
            {
                Console.WriteLine("stack 1 is empty"); return -1;
            }
            return stack[index - 1];
        }
        public int peek2()
        {
            if (isempty2())
            {
                Console.WriteLine("stack 2 is empty"); return -1;
            }
            return stack[index1];
        }
        public bool isempty1()
        {
            return index == 0;
        }
        public bool isempty2()
        {
            return index1 == size / 2;
        }
        public void minstack()
        {

        }
        public override string ToString()
        {
            return stack.ToString()!;
        }
    }
    public class Stack
    {
        public string reverse(string a)
        {
            StringBuilder b = new StringBuilder();
            Stack<char> name = new Stack<char>();
            foreach (var aa in a)
            {
                name.Push(aa);
            }
            while (name.Count > 0)
            {
                b.Append(name.Pop());
            }
            return b.ToString();
        }
        public bool balncedstring(string a)
        {
            Stack<char> par = new Stack<char>();
            Stack<char> squr = new Stack<char>();
            Stack<char> big = new Stack<char>();
            Stack<char> ang = new Stack<char>();
            for (int count = 0; count < a.Length; count++)
            {
                if (a[count] == '(')
                {
                    par.Push(a[count]);
                }
                else if (a[count] == ')')
                {
                    expection_case(par, "()");
                    par.Pop();
                }
                else if (a[count] == '[')
                {
                    squr.Push(a[count]);
                }
                else if (a[count] == ']')
                {
                    expection_case(squr, "[]");
                    squr.Pop();
                }
                else if (a[count] == '{')
                {
                    big.Push(a[count]);
                }
                else if (a[count] == '}')
                {
                    expection_case(big, "{}");
                    big.Pop();

                }
                else if (a[count] == '<')
                {
                    ang.Push(a[count]);
                }
                else if (a[count] == '>')
                {
                    expection_case(ang, "<>");
                    ang.Pop();
                }

            }
            return par.Count == 0 && ang.Count == 0 && big.Count == 0 && squr.Count == 0;
        }
        private void expection_case(Stack<char> par, string sigh)
        {
            if (par.Count == 0)
            {
                throw new Exception("expection in " + sigh + " bracket");
            }
        }
    }
    public class Program
    {
        static void Main()
        {

            Stack<int> ints = new Stack<int>();
            ints.Push(1);
            ints.Push(2);
            ints.Push(3);
            Console.WriteLine("min " + ints.Min());
            Console.WriteLine(ints.Pop());
            Console.WriteLine(ints.Pop());
            Console.WriteLine(ints.Pop());
            Stack_build stack_Build = new Stack_build();
            stack_Build.push(1);
            stack_Build.push(2);
            stack_Build.push(3);
            stack_Build.push1(4);
            stack_Build.push1(5);
            stack_Build.push1(6);
            Console.WriteLine(stack_Build.pop1());
            Console.WriteLine(stack_Build.pop1());
            Console.WriteLine(stack_Build.pop1());
            Console.WriteLine(stack_Build.pop2());
            Console.WriteLine(stack_Build.pop2());
            Console.WriteLine(stack_Build.pop2());
            Console.WriteLine("stack 2 peek " + stack_Build.peek2());
            Console.WriteLine("stack 1 peek " + stack_Build.peek1());

        }
    }
}