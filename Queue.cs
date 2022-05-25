using System;
namespace Stack_code
{
    public class Queue
    {

        private int front, rear, size;
        private int []queue;

    public Queue(int s)
        {
            front = rear = 0;
            size = s;
            queue = new int[size];
        }

        public void queueEnqueue(int data)
        {
            if (rear == size)
            {
                Console.WriteLine("Queue is Full");
                return;
            }
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;

        }

        public void queueDequeue()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty.");
                return;
            }

            else
            {
                Console.WriteLine($"Dequeue item is {queue[front]}");

                if (front < size)
                    queue[front] = 0;

                front++;
            }
            return;
        }

        public void queueDisplay()
        {
            int i;
            if (front == rear)
            {
                Console.WriteLine("Queue is Empty.");
                return;
            }

            for (i = front; i < rear; i++)
            {
                Console.WriteLine("Elements of the queue {0}", queue[i]);
            }
            queueFront();
            return;
        }

        public void queueFront()
        {
            if (front == rear)
            {
                Console.WriteLine("Queue is Full.");
            }
            Console.WriteLine("Front Element is {0}", queue[front]);
            return;
        }
    }
}