using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkSQMatchingBrackets
{
    public class MatchingBrackets
    {
        private string text;
        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                this.text = value;
            }
        }
        public MatchingBrackets()
        {
            Console.Write("Please insert the calculation: ");
            this.text = Console.ReadLine();
        }
        private string TextBetweenBrackets(int p1,int p2)
        {
            return text.Substring(p1, p2 - p1 + 1);
        }
        public void GetBrackets()
        {
            Stack<int> brackets = new Stack<int>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]=='(') 
                { 
                    brackets.Push(i);
                }
                if (text[i] == ')') 
                { 
                    int i1 = brackets.Pop(); 
                    Console.WriteLine(TextBetweenBrackets(i1,i)); 
                }
            }
        }
    }
}
