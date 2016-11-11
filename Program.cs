using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
		
		private static void addStudents()
		{
			using (var db = new InstituteContext()) {
				db.Students.AddRange(Student.GetSampleStudents());
				var count = db.SaveChanges();
				Console.WriteLine("{0} records saved to database", count);
			}
		}
		
		private static void displayStudents() 
		{
			using (var db = new InstituteContext()) 
			{
				Console.WriteLine();
				Console.WriteLine("All students in database:");
				foreach (var s in db.Students) 
				{
					Console.WriteLine("{0}\t{1}\t{2}", s.Id, s.FirstName, s.LastName);
				}
			}
		}
    }
}
