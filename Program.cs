using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int no = 0;

            GetStudent crud = new GetStudent();
            do
            {

                Console.WriteLine("1.Student List");
                Console.WriteLine("2.Get Student by Id");
                Console.WriteLine("3.Add New Student");
                Console.WriteLine("4.Update Student");
                Console.WriteLine("5.Delet Sudent");
                Console.WriteLine("Enter Your Openion");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        List<Student> list = crud.GetStudentList();
                        Console.WriteLine("RollNo\tName\t Percentage\tDepartment");
                        foreach (Student s in list)
                        {
                            Console.WriteLine($"{s.RollNo}     {s.Name}       {s.Per}         {s.Department}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter the Roll No you want to Display");
                        int rollno = Convert.ToInt32(Console.ReadLine());
                        Student s1 = crud.GetStudentbyRollNo(rollno);
                        Console.WriteLine("RollNo\tName\t Percentage\tDepartment");
                        Console.WriteLine($"{s1.RollNo}     {s1.Name}       {s1.Per}         {s1.Department}");

                        break;

                    case 3:
                        Student s2 = new Student();
                        Console.WriteLine("Enter The roll no of the Student");
                        s2.RollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter The Student Name");
                        s2.Name = Console.ReadLine();
                        Console.WriteLine("Enter The Percentage");
                        s2.Per = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter Department");
                        s2.Department = Console.ReadLine();
                        crud.AddStudent(s2);
                        break;

                    case 4:
                        Student s3 = new Student();
                        Console.WriteLine("Enter the Rollno");
                        s3.RollNo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the Name");
                        s3.Name = Console.ReadLine();
                        Console.WriteLine("Enter the Persentage");
                        s3.Per = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the Department");
                        s3.Department = Convert.ToString(Console.ReadLine());
                        crud.UpdateStudent(s3);
                        break;

                        break;
                    case 5:
                        Console.WriteLine("Enter Roll No that you want to Delete");
                        int RollNo = Convert.ToInt32(Console.ReadLine());
                        crud.DeleteStudent(RollNo);
                        Console.WriteLine($"{RollNo} Record Deleted Sucessfully");
                        break;
                }
                Console.WriteLine("Press One for Continue");
                no = Convert.ToInt32(Console.ReadLine());

            } while (no == 1);
       } 
    }
}
