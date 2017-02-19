using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Executor.Contracts
{
    public interface Student
    {
        String getName();

        Dictionary<string, Course> GetCoursesByName();
        
        void EnrollInCourse(Course course);
        void SetMarkOnCourse(string courseName, int[] scores);
        string GetMarkForCourse(string courseName);
    }
}
