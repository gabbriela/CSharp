using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Executor.Repository;

namespace Executor.Contracts
{
    public interface Course
    {
        String Name();


        Dictionary<String, Student> GetStudentByName();

        void EnrollStudent(Student student);
    }
}
