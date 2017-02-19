using System;
using System.Data.Entity;
using System.Linq;
using StudentSystem.Data;
using StudentSystem.Models;
using StudentSystem.Data.Migrations;

namespace StudentSystem.ConsoleClient
{
    public class StartUp
    {
        public static void Main()
        {
            Database.SetInitializer(
                new MigrateDatabaseToLatestVersion<StudentSystemContext, Configuration>());

            var db = new StudentSystemContext();
            #region fillStudents
            //var st1 = new Student()
            //{
            //    Birthday = new DateTime(1989,07,12),
            //    Name = "Laura",
            //    PhoneNumber = "0889-444-444",
            //    RegistrationDate = new DateTime(2016,02,12)
            //};

            //var st2 = new Student()
            //{
            //    Birthday = new DateTime(1987, 12, 03),
            //    Name = "Michelle",
            //    PhoneNumber = "0879-222-444",
            //    RegistrationDate = new DateTime(2016, 02, 11)
            //};

            //var st3 = new Student()
            //{
            //    Birthday = new DateTime(1993, 04, 02),
            //    Name = "Mark",
            //    PhoneNumber = "0889-333-333",
            //    RegistrationDate = new DateTime(2016, 02, 10)
            //};

            //var st4 = new Student()
            //{
            //    Birthday = new DateTime(1994, 03, 12),
            //    Name = "Maria",
            //    PhoneNumber = "0889-123-557",
            //    RegistrationDate = new DateTime(2016, 02, 10)
            //};

            //var st5 = new Student()
            //{
            //    Birthday = new DateTime(1988, 06, 12),
            //    Name = "Sall",
            //    PhoneNumber = "0889-789-444",
            //    RegistrationDate = new DateTime(2016, 02, 10)
            //};


            //db.Students.Add(st1);
            //db.Students.Add(st2);
            //db.Students.Add(st3);
            //db.Students.Add(st4);
            //db.Students.Add(st5);

            #endregion

            #region fillCourses
            //var course1 = new Course()
            //{
            //    Name = "CSharp",
            //    Description = "building apps in .NET",
            //    StartDate = new DateTime(2016,02,22),
            //    EndDate = new DateTime(2016,04,12),
            //    Price = 240.00m
            //};

            //var course2 = new Course()
            //{
            //    Name = "Photoshop",
            //    Description = "making pictures better",
            //    StartDate = new DateTime(2016, 05, 12),
            //    EndDate = new DateTime(2016, 07, 29),
            //    Price = 240.00m
            //};

            //var course3 = new Course()
            //{
            //    Name = "Networking",
            //    Description = "building networks, OSI",
            //    StartDate = new DateTime(2016, 09, 10),
            //    EndDate = new DateTime(2016, 11, 3),
            //    Price = 100.00m 
            //};

            //var course4 = new Course()
            //{
            //    Name = "JavaScript",
            //    Description = "building apps with JS",
            //    StartDate = new DateTime(2016, 08, 10),
            //    EndDate = new DateTime(2016, 10, 12),
            //    Price = 240.00m
            ////};

            //db.Courses.Add(course1);
            //db.Courses.Add(course2);
            //db.Courses.Add(course3);
            //db.Courses.Add(course4);

            #endregion

            #region fillResources
            //var res1 = new Resources()
            //{
            //    Name = "Intro to programming",
            //    ResourceType = ResourceType.Document,
            //    URL = "",
            //    CourseId = 1
            //};

            //var res2 = new Resources()
            //{
            //    Name = "Intro to programming",
            //    ResourceType = ResourceType.Video,
            //    URL = "",
            //    CourseId = 1
            //};

            //var res3 = new Resources()
            //{
            //    Name = "Intro to programming",
            //    ResourceType = ResourceType.Presentation,
            //    URL = "",
            //    CourseId = 1
            //};

            //var res4 = new Resources()
            //{
            //    Name = "Arrays",
            //    ResourceType = ResourceType.Video,
            //    URL = "",
            //    CourseId = 1
            //};


            //var res5 = new Resources()
            //{
            //    Name = "OSI",
            //    ResourceType = ResourceType.Video,
            //    URL = "",
            //    CourseId = 3
            //};

            //var res6 = new Resources()
            //{
            //    Name = "IPv4",
            //    ResourceType = ResourceType.Presentation,
            //    URL = "",
            //    CourseId = 3
            //};

            //var res7 = new Resources()
            //{
            //    Name = "PS Intro",
            //    ResourceType = ResourceType.Document,
            //    URL = "",
            //    CourseId = 2
            //};

            //var res8 = new Resources()
            //{
            //    Name = "Layers",
            //    ResourceType = ResourceType.Document,
            //    URL = "",
            //    CourseId = 2
            //};

            //db.Resourceses.Add(res1);
            //db.Resourceses.Add(res2);
            //db.Resourceses.Add(res3);
            //db.Resourceses.Add(res4);
            //db.Resourceses.Add(res5);
            //db.Resourceses.Add(res6);
            //db.Resourceses.Add(res7);
            //db.Resourceses.Add(res8);
            #endregion

            var count = db.Courses.Count();
            db.SaveChanges();

        }
    }
}
