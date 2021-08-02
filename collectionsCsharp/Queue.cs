using System;
using System.Collections.Generic;
using System.Text;

namespace collectionsCsharp
{
    class Queue
    {
        public static void QUeue()
        {
            var QU = new Queue<int>();
            QU.Enqueue(1);
            QU.Enqueue(2);
            QU.Enqueue(3);
            QU.Enqueue(4); 
            QU.Enqueue(5);
            foreach(var num in QU)
            {
                Console.WriteLine("this is what i found in the queue , this number called " + num);
            }
           Console.WriteLine( QU.Dequeue());
            Console.WriteLine(QU.Peek());
            Console.WriteLine(QU.Contains(2));
            bool b = QU.Count < 0;
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
