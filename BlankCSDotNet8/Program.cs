namespace BlankCSDotNet8
{
    internal class Program
    {
        struct Student
        {
            public string name;
            public string ID;
            public string form;

            public Student(string namegiven, string IDgiven, string formgiven) 
            {
                name = namegiven;
                ID = IDgiven;
                form = formgiven;
            }
        }



        static void Main(string[] args)
        {
            const int Max_Student = 4;
            Student[] students = new Student[Max_Student];
            int studentCount = 0;

            string[] subjects = { "Geography", "Computer science", "Maths" };
            int maxSubjects = subjects.Length;

            int[,] grades = new int [Max_Student, maxSubjects];

            //Menu

            bool keepgoing = true;
            int choice = 0;

            while (keepgoing)
            {
                Console.WriteLine("Enter choice\n 1. Add student\n 2.Enter grades of students\n 3.View all student grades\n 4.Quit");
                Console.WriteLine("-------------------------------------------------------------");
                choice = Convert.ToInt32(Console.ReadLine());
                bool studentfound = false;

                if (choice == 1)
                {
                    Console.WriteLine("What is the students name?");
                    students[studentCount].name = Console.ReadLine();
                    Console.WriteLine("What is the students ID?");
                    students[studentCount].ID = Console.ReadLine();
                    Console.WriteLine("What is the students form?");
                    students[studentCount].form = Console.ReadLine();
                    studentCount ++;
                    
                }
                else if (choice == 2)
                {
                    Console.WriteLine("What is the students ID?");
                    for (int i = 0; i < studentCount; i++)
                    {
                        if (students[i].ID == Console.ReadLine())
                        {
                            studentfound = true;
                            for (int j = 0; j < maxSubjects; j++)
                            {
                                Console.WriteLine($"What did {students[i]} get in {subjects[j]}?");
                                grades[i, j] = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                    }
                }
                else if (choice == 3)
                {

                }
                else if (choice == 4)
                {
                    keepgoing = false;
                    Console.WriteLine("Bye");
                }
                else
                {
                    Console.WriteLine("Enter a valid response.");
                }


            } 
        }
    }
}
