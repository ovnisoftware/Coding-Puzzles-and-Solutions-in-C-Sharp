using System;
using System.Collections; //Necessary for Stack class
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPuzzles
{   
    //Create a queue with two stacks
    //The queue will holds string elements
    //A stack is LIFO (Last in, First out)
    //A queue is FIFO (First in, First out)
    public class Two_Stack_Queue
    {
        //Declare two stacks
        //Stack1 will contain all the elements
        Stack stack1 = new Stack();

        //Stack2 will act as a temporary container of elements when an element needs to be dequeued
        Stack stack2 = new Stack();

        //Adds a string to the queue
        public void Enqueue(string queueThis)
        {
            stack1.Push(queueThis);
        }

        public string Dequeue()
        {
            string returnString = "";
            if (stack1.Count != 0)
            {
                //Store the count of the stack as a variable, if you use 'stack1.Count' directly
                //in the for loop the, the loop will not loop the necessary number of times
                int count = stack1.Count;
                for (int i = 0; i < count; i++)
                    stack2.Push((string)stack1.Pop());
                
                returnString = (string)stack2.Pop();

                if (stack2.Count != 0)
                {
                    //Store the count of the stack as a variable, if you use 'stack1.Count' directly
                    //in the for loop the, the loop will not loop the necessary number of times
                    int count2 = stack2.Count;
                    for (int i = 0; i < count2; i++)
                        stack1.Push((string)stack2.Pop());
                }
            }
            else
                //Will let you know if you try to pop an empty stack
                returnString = "The queue is empty";
            return returnString;
        }
        ////copy this to Program.cs to test
        //Two_Stack_Queue TSQueue = new Two_Stack_Queue();
        //TSQueue.Enqueue("Element 1");
        //TSQueue.Enqueue("Element 2");
        //TSQueue.Enqueue("Element 3");
        //Console.WriteLine(TSQueue.Dequeue());
        //Console.WriteLine(TSQueue.Dequeue());
        //Console.WriteLine(TSQueue.Dequeue());
        //Console.WriteLine(TSQueue.Dequeue());
        ////Output should be:
        ////Element 1
        ////Element 2
        ////Element 3
        ////The queue is empty
    }
}