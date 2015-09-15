using System;

public class GradeBook
{
   public string CourseName{get; set; }
   public string InstructorName { get; set; }

   public GradeBook(string cName, string iName)
   {
       CourseName = cName;
       InstructorName = iName;
   }
    public void   DisplayMessage()
    {
        Console.WriteLine(" Welcome to Gradebook\n{0}!", CourseName);
        Console.WriteLine("This course is presented by : \n{0} ", InstructorName);
    }

  
}

