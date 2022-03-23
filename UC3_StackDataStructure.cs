using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Programs_Day_16_17
{
    internal class UC3_StackDataStructure
    {
        public void StackDataStructure()
        {
            //(5+6)∗(7+8)/(4+3)
            Stack<int> stack = new Stack<int>();
            stack.Push(5);      //5
            stack.Push(6);      //4
            stack.Push(7);     //3
            stack.Push(8);     //2
            stack.Push(4);     //1
            stack.Push(3);    //0


            Console.Write("Solve the Equation: ");
            Console.WriteLine((stack.ElementAt(5)+ stack.ElementAt(4))*( stack.ElementAt(3)+ stack.ElementAt(2))/( stack.ElementAt(1)+ stack.ElementAt(0)));
        }
    }
}
