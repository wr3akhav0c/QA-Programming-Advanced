namespace _05._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            int countStudents = int.Parse(Console.ReadLine());

            for (int count = 0; count < countStudents; count++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                //проверка дали студентът съществува
                if (!studentsGrades.ContainsKey(studentName))
                {
                    //този студент го срещаме за 1ви път
                    studentsGrades.Add(studentName, new List<double>());
                    studentsGrades[studentName].Add(grade);
                }
                else
                {
                    //вече има такъв студент и той си има Лист
                    studentsGrades[studentName].Add(grade);
                }
            }

            foreach (KeyValuePair<string, List<double>> entry in studentsGrades)
            {
                double averageGrade = entry.Value.Average();
                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{entry.Key} -> {averageGrade:F2}");
                }
            }
            
        }
    }
}
