using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;

namespace UniversityRegistrar.Models
{
  public class Student
  {
    public int StudentId { get; set; }
    [Required(ErrorMessage = "You can't attend our school if we don't know your name!")]
    public string Name { get; set; }

    [DataType(DataType.Date, ErrorMessage="Date only")]    
    [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
    public DateTime Enrollment { get; set; }
    public List<CourseStudent> JoinEntities {get;}
  }
}