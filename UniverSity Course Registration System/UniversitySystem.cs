using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Course_Registration_System
{
    // =========================
    // University System Class
    // =========================
    public class UniversitySystem
    {
        public Dictionary<string, Course> AvailableCourses { get; private set; }
        public Dictionary<string, Student> Students { get; private set; }

        public UniversitySystem()
        {
            AvailableCourses = new Dictionary<string, Course>();
            Students = new Dictionary<string, Student>();
        }

        public void AddCourse(string code, string name, int credits, int maxCapacity = 50, List<string> prerequisites = null)
        {
            // TODO:
            // 1. Throw ArgumentException if course code exists
            // 2. Create Course object
            // 3. Add to AvailableCourses
            bool hasCourse = AvailableCourses.Any(course => course.Key == code);
            if (hasCourse)
            {
                throw new ArgumentException();
            }
            else
            {
                AvailableCourses.Add(code,new Course(code,name,credits,maxCapacity,prerequisites));
            }
            return;
            throw new NotImplementedException();
        }

        public void AddStudent(string id, string name, string major, int maxCredits = 18, List<string> completedCourses = null)
        {
            // TODO:
            // 1. Throw ArgumentException if student ID exists
            // 2. Create Student object
            // 3. Add to Students dictionary
            bool hasStudent = Students.Any(student => student.Key == id);
            if (hasStudent)
            {
                throw new ArgumentException();
            }
            else
            {
                Students.Add(id,new Student(id,name,major,maxCredits,completedCourses));
            }
            return;
            throw new NotImplementedException();
        }

        public bool RegisterStudentForCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student and course existence
            // 2. Call student.AddCourse(course)
            // 3. Display meaningful messages
            Course course = AvailableCourses.FirstOrDefault(course => course.Key == courseCode ).Value;
            Student student = Students.FirstOrDefault(student => student.Key==studentId).Value;
            if( student!=null && course!=null)
            {
                student.AddCourse(course);
                Console.WriteLine("Course added to the student");
                return true;

            }
            Console.WriteLine("Prerequisites not met");
            return false;
            throw new NotImplementedException();
        }

        public bool DropStudentFromCourse(string studentId, string courseCode)
        {
            // TODO:
            // 1. Validate student existence
            // 2. Call student.DropCourse(courseCode)

            Course course = AvailableCourses.FirstOrDefault(course => course.Key == courseCode ).Value;
            Student student = Students.FirstOrDefault(student => student.Key==studentId).Value;

            if(course!=null && student != null)
            {
                student.DropCourse(courseCode);
                return true;
            }
            return false;
            throw new NotImplementedException();
        }

        public void DisplayAllCourses()
        {
            // TODO:
            // Display course code, name, credits, enrollment info
            foreach(KeyValuePair<string,Course> course in AvailableCourses)
            {
                Console.WriteLine($"Code: {course.Value.CourseCode}, Name: {course.Value.CourseName}, Credits: {course.Value.Credits}, MaxCapacity: {course.Value.MaxCapacity}");
            }
            return;
            throw new NotImplementedException();
        }

        public void DisplayStudentSchedule(string studentId)
        {
            // TODO:
            // Validate student existence
            // Call student.DisplaySchedule()
            Student student = Students.FirstOrDefault(student => student.Key==studentId).Value;

            if (student != null)
            {
                student.DisplaySchedule();
                return;
            }
            return;

            throw new NotImplementedException();
        }

        public void DisplaySystemSummary()
        {
            // TODO:
            // Display total students, total courses, average enrollment
            int totalCourses = AvailableCourses.Count();
            int totalEnrollments=0;
            foreach(KeyValuePair<string,Course> course in AvailableCourses)
            {
                string enrollmentInfo = course.Value.GetEnrollmentInfo();
                string[] currentEnrollment = enrollmentInfo.Split("/");
                totalEnrollments+=int.Parse(currentEnrollment[0]);
            }
            double average;
            if (totalCourses == 0)
            {
                average=0;
            }
            else{
                average =(double)totalEnrollments/ (double)totalCourses;
            }
            Console.WriteLine($"Total students: {Students.Count}, Total courses: {AvailableCourses.Count}, Average Enrollment: {average}");
            return;
            throw new NotImplementedException();
        }
    }
}
