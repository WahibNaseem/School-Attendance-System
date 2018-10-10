using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KhssData.DomainModels.Attendance
{
    public class StudentClass: BaseClass
    {
        [Key]
        public int StudentClassId { get; set; }        
        public bool IsActive { get; set; }

        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
        public int ClassId { get; set; }
        public virtual Class Class { get; set; }
        public int SectionId { get; set; }
        public virtual Section Section { get; set; }

        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
