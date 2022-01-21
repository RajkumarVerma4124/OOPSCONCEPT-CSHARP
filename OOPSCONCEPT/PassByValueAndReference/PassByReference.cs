using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSCONCEPT.PassByValueAndReference
{
	public class Student
	{
		public string StudentName { get; set; }
	}

	public class PassByReference
	{
		public static void ChangeReferenceType(Student std2)
		{
			std2.StudentName = "Steve";
		}

		public static void AddStudentName()
		{
            Student std1 = new Student
            {
                StudentName = "Bill"
            };

            ChangeReferenceType(std1);

			Console.WriteLine(std1.StudentName);
		}
	}
}
