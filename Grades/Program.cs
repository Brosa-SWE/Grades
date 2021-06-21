using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            GradeBook book = new GradeBook();

            book.NameChanged += new NameChangedDelegate(OnNameChanged);
 
            book.Name = "Pers Grade Book";

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);

            Console.ReadKey();

        }

        static void OnNameChanged(object Sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade Book changing name from {args.ExistingName} to {args.NewName}.");
        }


    }

 
}
