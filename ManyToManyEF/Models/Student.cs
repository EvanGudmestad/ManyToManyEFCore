namespace ManyToManyEF.Models
{
    public class Student
    {

        public Student()
        {
            Courses = new List<Course>(); //Initialize the list
        }
        public int StudentId { get; set; }
        public string Name { get; set; }

        public string FinancialAidStatus { get; set; }

        //Skip Navigation Property
        public List<Course> Courses { get; set; }
    }
}
