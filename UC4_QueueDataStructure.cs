using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Programs_Day_16_17
{
    internal class UC4_QueueDataStructure
    {
       public void QueueDataStructure()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5000);
            queue.Enqueue(1000);
            queue.Enqueue(3000);
            queue.Enqueue(6000);
            queue.Enqueue(8000);
            queue.Enqueue(9000);

            Console.WriteLine("Total amount in Bank");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Left amount is: ");
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
