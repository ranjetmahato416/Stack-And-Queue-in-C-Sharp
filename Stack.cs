using System;
namespace Stack_code
{
    public class stack
    {
       private int[] a = new int[5];
       public int l = 0;
       public void push(int item)
       {
           int f = count();
           if(f==a.Length)
           {
               Console.WriteLine("Stack is Full.");
           }
           else{
               l++;
               a[l] = item;
               Console.WriteLine($"{a[l]} is pushed onto the stack.");

           }
       }

       public void display()
       {
           bool f = isEmpty();
           if(f==true)
           {
               Console.WriteLine("Stack is Empty.");
           }
           else{
               for(int i = l; i > 0; i--)
               {
                   Console.WriteLine($"Items: {a[i]}");
               }
           }

       }

       public void pop()
       {
           bool f = isEmpty();
           if(f==true)
           {
               Console.WriteLine("Stack is Empty.");
           }
           else{
               int item  = top();
               l--;
               Console.WriteLine($"Top of the Stack {item} is Popped.");
           }

       }

       public int top()
       {
           int item;
           item = a[l];
           a[l] = default(int);
           return item;
       }
       public int count()
       {
           return l;
       }

       public bool isEmpty()
       {
           if(count()==0)
           {
               return true;
           }
           else{
               return false;
           }
       }

    }
}