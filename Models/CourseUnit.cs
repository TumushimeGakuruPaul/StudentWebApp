using System.ComponentModel.DataAnnotations;

namespace StudentWebApp.Models
{
    public class CourseUnit
    {
        [Key]
        public int Id { get; set; }
        public string CourseUnitCode {  get; set; }
        public string name {  get; set; }
        public string DoneInYear { get; set; } 
    }
}
