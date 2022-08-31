using System;
using System.Collections.Generic;

namespace StacksAndQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //----------------------------------------------------------Stack -> last in first out

            Stack<int> stack = new Stack<int>();
            //add
            stack.Push(1);
            stack.Push(5);
            stack.Push(153);
            stack.Push(5225);
            stack.Push(76575);
            stack.Push(5435);
            stack.Push(8969);
            stack.Push(36443);
            stack.Push(98769);

            //see
            Console.WriteLine("top value is: {0}", stack.Peek());
            //remove
            if (stack.Count > 0)
            {
                stack.Pop();
            }
            else
            {
                Console.WriteLine("stack empty");
            }
            //
            Console.WriteLine("top value is: {0}", stack.Peek());

            //reversing the array
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Stack<int> newStack = new Stack<int>();
            foreach (int number in numbers)
            {
                newStack.Push(number);
            }
            int[] reversedNumbers = new int[9];
            int counter = 0;
            foreach (int number in newStack)
            {
                reversedNumbers[counter] = number;
                counter++;
            }

            foreach (int number in reversedNumbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\n");

            //----------------------------------------------------------Queue firs in first out

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(4);
            queue.Enqueue(53);
            queue.Enqueue(23);
            queue.Enqueue(13);
            // remove
            int removedItem = queue.Dequeue();
            //display
            Console.WriteLine(queue.Peek() + " removed item was {0}", removedItem);

            //------------------------------------------------------------

            Queue<Order> ordersQueue = new Queue<Order>();

            foreach (Order o in RecieveOrderFromBranch1())
            {
                ordersQueue.Enqueue(o);
            }

            foreach (Order o in RecieveOrderFromBranch2())
            {
                ordersQueue.Enqueue(o);
            }

            while (ordersQueue.Count > 0)
            {
                Order processedOrder = ordersQueue.Dequeue();
                processedOrder.ProcessOrder();
            }
        }
        //this method will create an array of orders and return in
        static Order[] RecieveOrderFromBranch1()
        {
            Order[] orders = new Order[]
            {
                    new Order(1,5),
                    new Order(2,4),
                    new Order(5,10),
            };
            return orders;
        }
        static Order[] RecieveOrderFromBranch2()
        {
            Order[] orders = new Order[]
            {
                    new Order(3,5),
                    new Order(4,4),
                    new Order(6,10),
            };
            return orders;
        }

    }
}
