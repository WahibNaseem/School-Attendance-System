using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KhssData.DomainModels.Attendance
{
    public class Class:BaseClass
    {
        [Key]
        [Column(Order = 1)]
        public int ClassId { get; set; }
        [Column (Order = 0)]
        public string ClassName { get; set; }

        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
