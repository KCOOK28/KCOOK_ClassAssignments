using System;

public class GradeBookTest
{
    public static void Main(String[] args)
    {

        GradeBook myGradeBook = new GradeBook("CS101 introduction to Programming", "Professor Smith" );

        myGradeBook.DisplayMessage();
        Console.Read();
    }

}