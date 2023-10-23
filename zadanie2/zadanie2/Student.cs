using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    public class Student
    {
        public string name, surname, id;
        public List<int> grades = new List<int>();
        private List<DateOnly> Attendance = new List<DateOnly>();
        private List<bool> AttendanceValue = new List<bool>();
        
        public void AddAttendance(DateOnly date, bool present)
        {
            Attendance.Add(date);
            AttendanceValue.Add(present);
        }

        public void DeleteAttendance(DateOnly date)
        {
            AttendanceValue.RemoveAt(Attendance.IndexOf(date));
            Attendance.Remove(date);
        }

        /*
         * dodawanie ocen: Student.grades.Add(int)
         */

        public string Dane
        {
            get
            {
                double average = 0;
                for (int i = 0; i < grades.Count; i++)
                {
                    average += grades[i];
                }
                average /= grades.Count;

                double attendance = 0;
                for(int i = 0; i < AttendanceValue.Count; i++)
                {
                    if (AttendanceValue[i])
                    {
                        attendance++;
                    }
                }
                attendance /= AttendanceValue.Count;
                attendance *= 100;


                return $"{name} {surname} {id} {attendance}% {average}";
            }
        }
        public Student(string name, string surname, string id)
        {
            this.name = name;
            this.surname = surname;
            this.id = id;
        }
    }
}
