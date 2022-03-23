using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Programs_Day_16_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UC3_StackDataStructure stackDS = new UC3_StackDataStructure();
            //stackDS.StackDataStructure();


            //UC4_QueueDataStructure queueDS = new UC4_QueueDataStructure();
            //queueDS.QueueDataStructure();

            UC7_BinaryTree binaryTree = new UC7_BinaryTree();

            binaryTree.Add(6);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(8);
            binaryTree.Add(3);
            binaryTree.Add(6);

            binaryTree.TravarsePreorder(binaryTree.Root);

            Console.ReadLine();
        }
    }
}
