using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BracketValidation
{
    public class Node
    {
        public char Data;
        public Node Next;

        public Node(char data)
        {
            Data = data;
            Next = null;
        }
    }

    public class BracketValidator
    {
        private Node top;

        public BracketValidator()
        {
            top = null;
        }

        public void Push(char data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public char Pop()
        {
            if (top == null) return '\0';
            char data = top.Data;
            top = top.Next;
            return data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public bool ValidasiEkspresi(string ekspresi)
        {
            foreach (char ch in ekspresi)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    Push(ch);
                }
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    char last = Pop();
                    if ((ch == ')' && last != '(') ||
                        (ch == '}' && last != '{') ||
                        (ch == ']' && last != '['))
                    {
                        return false;
                    }
                }
            }
            return IsEmpty();
        }
    }
}
