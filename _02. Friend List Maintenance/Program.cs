using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Friend_List_Maintenance {
    class Program {
        static void Main(string[] args) {
            List<string> friends = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            int blacklisted = 0;
            int lost = 0;

            while (input != "Report") {
                string[] command = input.Split(' ');
                string name;
                int index;

                switch (command[0]) {
                    case "Blacklist":
                        name = command[1];

                        if (friends.Contains(name)) {
                            friends[friends.IndexOf(name)] = "Blacklisted";
                            Console.WriteLine($"{name} was blacklisted.");
                            blacklisted++;
                        } else {
                            Console.WriteLine($"{name} was not found.");
                        }
                        break;

                    case "Error":
                        index = Convert.ToInt32(command[1]);

                        if (index >= 0 && index < friends.Count) {
                            name = friends[index];

                            if (name != "Lost" && name != "Blacklisted") {
                                friends[index] = "Lost";
                                Console.WriteLine($"{name} was lost due to an error.");
                                lost++;
                            }
                        }
                        break;

                    case "Change":
                        index = Convert.ToInt32(command[1]);
                        name = command[2];

                        if (index >= 0 && index < friends.Count) {
                            string currName = friends[index];
                            friends[index] = name;
                            Console.WriteLine($"{currName} changed his username to {name}.");
                        }
                        break;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Blacklisted names: {blacklisted}");
            Console.WriteLine($"Lost names: {lost}");
            Console.WriteLine(string.Join(' ', friends));
        }
    }
}