using System;
using System.Collections.Generic;


namespace Lab7_2a
{

 


        internal class Program
        {



            static void Main(string[] args)
            {
                // Creates the Queue
                // The data items are strings. The second type parameter (an int) indicates the priority
                PriorityQueue<string, int> games = new PriorityQueue<string, int>();

            // Add messages with different priorities to the queue
            games.Enqueue("Zelda", 1);
            games.Enqueue("Supermario", 3);
            games.Enqueue("Finalfantasy", 1);
            games.Enqueue("Madden", 2);
            games.Enqueue("Contra", 4);

            // Retreive the messages in priority and queue order
            while (games.TryDequeue(out string item, out int priority))
            {
                Console.WriteLine($"Dequeued Item: {item} Priority was: {priority}");

            }
            


                   }

            
        }
    } 

