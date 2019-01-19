using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0727128
{
    class Program
    {

        static void Main(string[] args)
        {
            StudentInformation _Mary = new StudentInformation("Mary", 3.8, 20);
            StudentInformation _John = new StudentInformation("John", 2.8, 15);
            StudentInformation _Cena = new StudentInformation("Cena", 3.4, 20);
            StudentInformation _Mark = new StudentInformation("Mark", 3.2, 10);
            StudentInformation _Abhi = new StudentInformation("Abhi", 3.2, 10);

            //create a collection of Studentinformation Records
            var StudentList = new List<StudentInformation>();
            StudentList.Add(_Mary);
            StudentList.Add(_John);
            StudentList.Add(_Cena);
            StudentList.Add(_Mark);
            StudentList.Add(_Abhi);

            foreach (var student in StudentList )
            {
                Console.WriteLine(student.Name);
            }
                Console.ReadLine();
        }

    }
    class StudentInformation
    {

            public string Name;
            public double GPA;
            public int Attendance;

            public StudentInformation(string aName, double bGPA, int cAttendance)
            {
                Name = aName;
                GPA = bGPA;
                Attendance = cAttendance;
            }
           
    }
}    

                     
                 
