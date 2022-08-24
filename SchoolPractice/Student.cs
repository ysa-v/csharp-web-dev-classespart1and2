using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public string GetGradeLevel(int credits)
        {
            if (credits > 30)
            {
                return 'freshman';
            }
            else if (credits > 60)
            {
                return 'sophomore';
            }
            else if (credits > 90)
            {
                return 'junior';
            }
            else
            {
                return 'senior';
            }
        }

        public void AddGrade(int credits, double grade)
        {
            double totalQualityScore = Gpa * NumberOfCredits;

            Gpa = totalQualityScore + grade / NumberOfCredits + credits;
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != GetType())
            {
                return false;
            }

            Student studentObj = obj as Student;
            return StudentId == studentObj.StudentId;
        }
    }
}
