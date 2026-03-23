using System;
using System.Collections.Generic;
using System.Linq;
namespace SRPDemo
{
   

   
    
    //Testing the Single Responsibility Principle
    public class Program
    {
        public static void Main()
        {
            Student alice = new() { Name = "Alice" };
            alice.EnrollCourse("Mathematics");
            alice.AssignGrade("Mathematics", 90);

            Student isa = new() { Name = "Isabel" };
            isa.EnrollCourse("Database Systems");
            isa.AssignGrade("Database Systems", 85);

            GPACalculator gpaCalc = new();
            TranscriptGenerator transcriptGen = new(gpaCalc);
            transcriptGen.PrintTranscript(alice);
            transcriptGen.PrintTranscript(isa);
            
            Console.Read();
        }
    }
}