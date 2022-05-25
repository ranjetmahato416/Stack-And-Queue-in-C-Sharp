// See https://aka.ms/new-console-template for more information
using System;
namespace Stack_code
{
    class Program
    {
        public static void Main()

        {


            StackImplementation();
            QueueExample();
        }

        public static void StackImplementation()
        {
            stack s = new stack();
            
            var res = "Y";
            do{
                Console.WriteLine("Choice \n1. PUSH\n2.POP\n3.Display\n4.Exit.");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the data to Push.");
                        int data= Convert.ToInt32(Console.ReadLine());
                        s.push(data);
                        break;
                    case 2:
                        s.pop();
                        break;
                    case 3: s.display();
                            break;
                    case 4: return;
                    default:
                        System.Console.WriteLine("Invalid Choice.");
                        break;
                }
    


            } while ( res.ToUpper() == "Y");
            



        }

        public static void QueueExample()
        {
            Console.WriteLine("Enter the size of the queue.");
            int sizeOfqueue = Convert.ToInt32(Console.ReadLine());
            Queue q = new Queue(sizeOfqueue);
            var res = "Y";
            do{
                Console.WriteLine("choice\n1.EnQueue\n2. DeQueue\n3. Display Items\n 4. Exit.");
                var choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1: Console.WriteLine("Enter data to add in the Queue.");
                            int data = Convert.ToInt32(Console.ReadLine());
                            q.queueEnqueue(data);
                            break;
                    case 2: q.queueDequeue();
                            break;
                    case 3: q.queueDisplay();
                            break;
                    case 4: return;
                    default: Console.WriteLine("Invalid Choice!");
                            return;
                }
            }while(res.ToUpper() == "Y");
            

        }

    }


}
