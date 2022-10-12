using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputSongs = Console.ReadLine().Split(", ");

            Queue<string> songs = new Queue<string>(inputSongs);

            while (songs.Any())
            {
                string[] commands = Console.ReadLine().Split(" ");

                switch (commands[0])
                {
                    case "Play":
                        songs.Dequeue();
                        
                        break;
                   
                    case "Add":
                        string songToAdd = String.Join(" ", commands.Skip(1));
                        if (!songs.Contains(songToAdd))
                        {
                            songs.Enqueue(songToAdd);
                        }
                        else
                        {
                            Console.WriteLine($"{songToAdd} is already contained!");
                        }

                        break;

                    case "Show":
                        Console.WriteLine(String.Join(", ", songs));
                        
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
