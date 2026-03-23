namespace SRPDemo
{
    public class Student
    {
        public required string Name { get; set; }
        public Dictionary<string, double> CoursesAndGrades = new Dictionary<string, double>();

        public void EnrollCourse(string courseName)
        {
            CoursesAndGrades[courseName] = 0; // default grade
        }

        public void AssignGrade(string courseName, double grade)
        {
            if (CoursesAndGrades.ContainsKey(courseName))
            {
                CoursesAndGrades[courseName] = grade;
            }
        }
    }
}