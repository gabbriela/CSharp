namespace StudentSystem.Data
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext()
            : base("StudentSystemContext")
        {
        }

        public IDbSet<Student> Students { get; set; }
        public IDbSet<Course> Courses { get; set; }
        public IDbSet<Resources> Resourceses { get; set; }
        public IDbSet<Homework> Homeworks { get; set; }
        public IDbSet<License> Licenses { get; set; }
        
    }
    
}