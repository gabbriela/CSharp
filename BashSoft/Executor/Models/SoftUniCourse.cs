using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Executor.Contracts;
using Executor.Exceptions;

namespace Executor.Models
{
    public class SoftUniCourse : Course
    {
        public const int NumberOfTasksOnExam = 5;
        public const int MaxScoreOnExamTask = 100;

        private string name;
        private Dictionary<string, Student> studentsByName;

        public SoftUniCourse(string name)
        {
            this.Name = name;
            this.studentsByName = new Dictionary<string, Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidStringException();
                }

                this.name = value;
            }
        }

        public Dictionary<string, Student> StudentsByName
        {
            get
            {
                return this.studentsByName;
            }
        }

        public void EnrollStudent(SoftUniStudent student)
        {
            if (this.studentsByName.ContainsKey(student.UserName))
            {
                throw new DuplicateEntryInStructureException(student.UserName, this.Name);
            }

            this.studentsByName.Add(student.UserName, student);
        }

        public string getName()
        {
            throw new NotImplementedException();
        }

        string Course.Name()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Student> GetStudentByName()
        {
            throw new NotImplementedException();
        }

        public void EnrollStudent(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
