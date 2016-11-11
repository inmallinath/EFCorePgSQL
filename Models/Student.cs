    using System;
    using System.Collections.Generic;
    namespace EFCorePGSQL.Models {
      public class Student {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public DateTime DateOfBirth { get; set; }
        public static List<Student> GetSampleStudents()   {
          List<Student> students = new List<Student>() {
            new Student {
              FirstName = "Ann",
              LastName = "Lee",
              Major = "Medicine",
              DateOfBirth = Convert.ToDateTime("2004/09/09")
            },
            new Student
            {
              FirstName = "Bob",
              LastName = "Doe",
              Major = "Engineering",
              DateOfBirth = Convert.ToDateTime("2005/09/09")
            },
            new Student {
              FirstName = "Sue",
              LastName = "Douglas",
              Major = "Pharmacy",
              DateOfBirth = Convert.ToDateTime("2006/01/01")
            },
            new Student {
              FirstName = "Tom",
              LastName = "Brown",
              Major = "Business",
              DateOfBirth = Convert.ToDateTime("2000/09/09")
            },
            new Student {
              FirstName = "Joe",
              LastName = "Mason",
              Major = "Health",
              DateOfBirth = Convert.ToDateTime("2001/01/01")
            }
          };
          return students;
        }
      }
    }