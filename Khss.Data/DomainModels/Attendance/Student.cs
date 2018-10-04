using System.ComponentModel.DataAnnotations;

namespace KhssData.DomainModels.Attendance
{  
    public class Student: BaseClass
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }        
    }
}
