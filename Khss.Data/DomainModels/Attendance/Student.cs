using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KhssData.DomainModels.Attendance
{  
    public class Student: BaseClass
    {
        [Key]
        [Column(Order = 0)]
        public int StudentId { get; set; }
        [Column(Order = 1)]
        public string FirstName { get; set; }
        [Column(Order = 2)]
        public string LastName { get; set; }
        [Column(Order = 3)]
        public string Phone { get; set; }
        [Column(Order = 4)]
        public string Address { get; set; }

        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
