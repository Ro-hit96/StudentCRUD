using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public double Per { get; set; }
        public string Department { get; set; }

    }
    public class GetStudent
    {
        private List<Student> Studentlist;
        private List<Student> studentList;

        public GetStudent()
        {
            studentList = new List<Student>()
            {
                new Student {RollNo=001,Name="Sakshi",Per=80.33,Department="Error Solveing"},
                new Student { RollNo = 002, Name = "Vinayak", Per = 50,Department="Timepass" },
                new Student { RollNo=003,Name="Anata",Per=60,Department="Electric"}
            };
        }
        public List<Student> GetStudentList()
        {
           return studentList;
        }

        public Student GetStudentbyRollNo(int rollNo)
        {
            Student student = new Student();
            foreach (Student s2 in studentList)
            {
                if(s2.RollNo == rollNo)
                {
                    student = s2;
                }
            }
            return student;
        }
        public void AddStudent(Student s)
        {
            studentList.Add(s);
        }

        public void UpdateStudent(Student p)
        {
            foreach (Student s2 in studentList)
            {
                if (s2.RollNo == p.RollNo)
                {
                    s2.Name= p.Name;
                    s2.Per= p.Per;
                    s2.Department= p.Department;
                    break;
                }
            }
            Console.WriteLine("Updated Data Saved");
        }
        public void DeleteStudent(int rollNo)
        {
            foreach (Student s in studentList)
            {
                if (s.RollNo == rollNo)
                {
                    studentList.Remove(s);
                    break;
                }
            }
        }

        
    }
}
