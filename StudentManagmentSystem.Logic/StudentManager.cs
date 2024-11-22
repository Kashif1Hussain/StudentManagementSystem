using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagmentSystem.Logic
{
    public class StudentManager
    {
        private List<Student> students = new List<Student>();
        
        public void Add(string rollNumber, string fname, string lname)
        {
           Student student = new Student();
            student.RollNumber = rollNumber;
            student.FirstName = fname;
            student.LastName = lname;
            students.Add(student);
        }

        public List<Student> GetAllStudent()
        {
            return students;
        }

        public Student Search(string rollNumber)
        {
            foreach (Student student in students)
            {
                if(student.RollNumber == rollNumber)
                {
                    return student;
                }
            }
            return null;
        }

        public void Delete(string rollNumber)
        {
            Student student = Search(rollNumber);
            if (student != null)
            {
                students.Remove(student);
            }
        }

        public void Update(Student updated)
        {
            Student student = Search(updated.RollNumber);
            if (student != null)
            {
                student.FirstName = updated.FirstName;
                student.LastName = updated.LastName;
                student.PhoneNumber = updated.PhoneNumber;
                student.Email = updated.Email;
            }
        }

    }
}
