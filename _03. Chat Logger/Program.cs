using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Chat_Logger {
    class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();
            List<string> output = new List<string>();

            while (input != "end") {
                List<string> command = input.Split(' ').ToList();

                switch (command[0]) {
                    case "Chat":
                        output.Add(command[1]);
                        break;

                    case "Delete":
                        output.Remove(command[1]);
                        break;

                    case "Edit":
                        if (output.Contains(command[1]))
                            output[output.IndexOf(command[1])] = command[2];
                        break;

                    case "Pin":
                        if (output.Remove(command[1])) {
                            output.Add(command[1]);
                        }
                        break;

                    case "Spam":
                        command.Remove("Spam");
                        output.AddRange(command);
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join("\n", output));
        }
    }
}