using System.ComponentModel.DataAnnotations;

namespace ManyToManyEF.Models
{
    public class Course
    {

        public Course()
        {
            Students = new List<Student>(); //Initialize the list
        }


        //Primary key and identity
        public int CourseId { get; set; }

        [Required]
        public string Title { get; set; }

        
        //Skip navigation property
        public List<Student> Students { get; set; }
        
    }
}
