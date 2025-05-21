using System.Text.RegularExpressions;

namespace StaffRegister
{
    internal class Program
    {
        private static List<Employee> employeeList = new List<Employee>();
        static void Main(string[] args)
        {
            initialize();
            run();
            exit();
        }

        private static void initialize()
        {
            Console.WriteLine("Välkommen till personalregistret!");
            Console.WriteLine("");

            int numberOfStaff = 0;
            bool correctInput = false;

            while (!correctInput)
            {
                Console.WriteLine("Mata in hur många anställda du har som en siffra: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out numberOfStaff) && numberOfStaff > 0)
                {
                    correctInput = true;
                }
                else
                {
                    Console.WriteLine("Du skrev in i fel format, testa igen");
                    Console.WriteLine();
                }
            }



            for (int i = 0; i < numberOfStaff; i++)
            {
                Console.WriteLine("Detta är anställd nr " + (i + 1));

                string name = "";
                bool correctNameInput = false;

                while (!correctNameInput)
                {
                    Console.WriteLine("Mata in dennes namn (endast bokstäver): ");
                    name = Console.ReadLine();

                    if (Regex.IsMatch(name, @"^[a-zA-ZåäöÅÄÖ\s]+$"))
                    {
                        correctNameInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Du skrev in i fel format, testa igen");
                        Console.WriteLine();
                    }
                }

                int salary = 0;
                bool correctSalaryInput = false;

                while (!correctSalaryInput)
                {
                    Console.WriteLine();
                    Console.WriteLine("Mata in dennes lön som en siffra: ");
                    if (int.TryParse(Console.ReadLine(), out salary) && salary > 0)
                    {
                        correctSalaryInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Du skrev in i fel format, testa igen");
                        Console.WriteLine();
                    }
                }

                Employee anställd = new Employee(name, salary);
                employeeList.Add(anställd);
            }

        }
        private static void run()
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("");
                Console.WriteLine("Vad vill du göra? Skriv in motsvarande siffra: ");
                Console.WriteLine("1. Se anställda och deras lön?");
                Console.WriteLine("2. Avsluta programmet");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out int answer))
                {
                    Console.WriteLine("Du skrev in i fel format, testa igen");
                    Console.WriteLine();
                    continue;
                }

                if (answer == 1)
                {
                    Console.WriteLine();
                    if (employeeList.Count == 0)
                    {
                        Console.WriteLine("Det finns inga anställda att visa.");
                    }
                    else
                    {
                        foreach (var employee in employeeList)
                        {
                            Console.WriteLine(employee.ToString());
                        }
                    }
                }
                else if (answer == 2)
                {
                    running = false;

                }
                else
                {
                    Console.WriteLine("Du skrev in i fel format, testa igen");
                }
            }
        }

        private static void exit()
        {
            Console.WriteLine("Nu stängs personalregistret");
        }
    }
}
