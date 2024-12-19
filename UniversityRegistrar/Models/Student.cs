using System.Collections.Generic;
using System;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    public string Name { get; set; }
    public DateTime DateEnrolled { get; set; }
    public List<Course> Courses { get; set; }
    public List<CourseStudent> JoinEntities { get; }
  }
}