using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace GradeBook.GradeBooks
{
   public class RankedGradeBook : BaseGradeBook
    {
        //again updating isWaighted
        public RankedGradeBook(string name, bool isWaighted) : base(name, isWaighted)
        {
            Type = GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if(Students.Count < 5)
            {
                throw new InvalidCastException("There are less than 5 students");
            }
            // casting as int because we want to use it as a index 
            var percent_20 = (int)Math.Ceiling(Students.Count * 0.2);
            // desending order in grades using list
            // order by average grade
            // do not select whole object -- 
            // we could have done that with loop
            var grades = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();
                
            if(grades[percent_20-1] <= averageGrade)
            {
                return 'A';
                
            }
            //drop 2 grades
            else if (grades[(percent_20*2)-1 ] <=averageGrade)
            {
                return 'B';
            }
            else if (grades[(percent_20 * 3) - 1] <= averageGrade)
            {
                return 'C';
            }
            else if (grades[(percent_20 * 4) - 1] <= averageGrade)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
           // deleted the base 
        }

        public override void CalculateStatistics()
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                // escape the method if there are less then 5 students 
                return;
            }
            // 
            base.CalculateStatistics();
        }
        public override void CalculateStudentStatistics(string name)
        {
            if(Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");
                return;
            }
            base.CalculateStudentStatistics(name);
        }
    }
}
