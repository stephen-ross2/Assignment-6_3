namespace Assignment_6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue to manage callers
            Queue<string> callQueue = new Queue<string>();

            // Enqueue customers into the call queue
            callQueue.Enqueue("One");
            callQueue.Enqueue("Two");
            callQueue.Enqueue("Three");
            callQueue.Enqueue("Four");

            Console.WriteLine("Call Queue (After Enqueue):");
            DisplayQueue(callQueue);

            // Dequeue a customer and process their call
            Console.WriteLine($"\nProcessing call for: {callQueue.Dequeue()}");

            Console.WriteLine("\nCall Queue (After Dequeue):");
            DisplayQueue(callQueue);

            // Peek the next customer in line without dequeuing
            Console.WriteLine($"\nNext in line: {callQueue.Peek()}");
        }

        // Method to display the queue elements
        static void DisplayQueue(Queue<string> queue)
        {
            foreach (string caller in queue)
            {
                Console.WriteLine($"Caller: {caller}");
            }
        }
    }
}
  