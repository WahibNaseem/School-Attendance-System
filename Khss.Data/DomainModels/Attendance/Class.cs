using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KhssData.DomainModels.Attendance
{
    public class Class:BaseClass
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
