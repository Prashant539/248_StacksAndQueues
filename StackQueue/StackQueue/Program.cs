using System;
namespace StackQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------StackQueue-------------");
            Console.WriteLine(" 1.Push  ");
            Console.WriteLine("2.Peek And Pop ");
            Console.WriteLine("Enter the option");
            Console.WriteLine("3.Queue ");
            Console.WriteLine("4.DeQueue ");
            int num = Convert.ToInt32(Console.ReadLine());
            Stack stack = new Stack();
            switch (num)
            {
                case 1:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.Display();
                    break;
                case 2:
                    stack.Push(70);
                    stack.Push(30);
                    stack.Push(56);
                    stack.IsEmpty();
                    stack.Pop();
                    stack.Peek();
                    stack.Display();
                    break;
                case 3:
                    Queue queue = new Queue();
                    queue.Enqueue(56);
                    queue.Enqueue(30);
                    queue.Enqueue(70);
                    queue.Display();
                    break;
                case 4:
                    Queue queue1 = new Queue();
                    
                    queue1.Dequeue(70);
                    queue1.Dequeue(30);
                    queue1.Dequeue(50);
                   queue1.Display();
                    break;
                default:
                    Console.WriteLine("Enter a valid option");
                    break;
            }
            Console.ReadLine();
        }
    }
}
