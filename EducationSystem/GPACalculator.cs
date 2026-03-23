namespace SRPDemo
{
    public class GPACalculator
    {
        public double CalculateGPA(Student student)
        {
            // Basic GPA calculation logic
            return student.CoursesAndGrades.Values.Average();
        }
    }
}