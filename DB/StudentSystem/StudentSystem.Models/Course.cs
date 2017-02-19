using System;
using System.Collections.Generic;

namespace StudentSystem.Models
{
    public class Course
    {
        private ICollection<Student> students;

        private ICollection<Resources> resourceses;

        private ICollection<Homework> homeworks;

        public Course()
        {
            this.students = new HashSet<Student>();
            this.resourceses = new HashSet<Resources>(); 
            this.homeworks = new HashSet<Homework>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Price { get; set; }

        public virtual ICollection<Student> Students
        {
            get { return this.students; }
            set { this.students = value; }
        }

        public virtual ICollection<Resources> Resourceses
        {
            get { return this.resourceses; }
            set { this.resourceses = value; }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get { return this.homeworks; }
            set { this.homeworks = value; }
        }
    }
}
