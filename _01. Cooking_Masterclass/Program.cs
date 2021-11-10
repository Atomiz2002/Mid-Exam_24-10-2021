using System;

namespace Mid_Exam_24_10_2021 {
    class Program {
        static void Main(string[] args) {
            double budget = Convert.ToDouble(Console.ReadLine());
            int students = Convert.ToInt32(Console.ReadLine());
            double flour = Convert.ToDouble(Console.ReadLine());
            double egg = Convert.ToDouble(Console.ReadLine());
            double apron = Convert.ToDouble(Console.ReadLine());

            int free = students / 5;
            double eggs = egg * 10 * students;
            double aprons = apron * Math.Ceiling(students * 1.20);

            double cost = flour * students - free * flour + eggs + aprons;

            if (cost > budget) {
                Console.WriteLine($"{(cost - budget):F2}$ more needed.");
            } else {
                Console.WriteLine($"Items purchased for {cost:F2}$.");
            }
        }
    }
}