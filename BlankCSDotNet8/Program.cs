namespace BlankCSDotNet8
{
    internal class Program
    {
        struct Student
        {
            public string name;
            public int ID;
            public string form;

            public Student(string namegiven, int IDgiven, string formgiven) 
            {
                name = namegiven;
                ID = IDgiven;
                form = formgiven;
            }
        }



        static void Main(string[] args)
        {
            Console.WriteLine("What is the maximum number of students you wish to hold in the array?");
            int MAX_STUDENTS = Convert.ToInt32(Console.ReadLine());
            Student[] students = new Student[MAX_STUDENTS];
            int studentCount = 0;
            Console.WriteLine("How many subjects?");
            int maxSubjects = Convert.ToInt32(Console.ReadLine());
            string[] subjects = new string[maxSubjects];
            for (int i = 0; i < maxSubjects; i++)
            {
                Console.WriteLine("Name a subject the student takes");
                subjects[i] = Console.ReadLine();
            }
            int[,] grades =
            {
                {80, 73, 64},
                {50, 48, 89},
                {23, 62, 78},
                {89, 42, 53}
            };
            int choice = 1;
            while (choice != 4)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1 - Add a student");
                Console.WriteLine("2 - Enter grades for a student");
                Console.WriteLine("3 - View all stuent grades");
                Console.WriteLine("4 - Quit");
                if (choice == 1)
                {
                    Console.WriteLine("What is the student's name?");
                    string name = Console.ReadLine();
                    Console.WriteLine("What is the student's ID?");
                    int ID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the students's form group?");
                    string form = Console.ReadLine();
                    studentCount = studentCount + 1;
                    if (MAX_STUDENTS < studentCount)
                    {
                        Console.WriteLine("Error - Maximum students breached");
                    }
                }
                else if (choice == 2)
                {
                }
                else if (choice == 3)
                {
                }
                else if (choice == 4)
                {
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            }
        }
    }
}
