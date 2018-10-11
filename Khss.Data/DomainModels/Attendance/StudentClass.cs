using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KhssData.DomainModels.Attendance
{
    public class StudentClass: BaseClass
    {
        [Key]
        [Column(Order = 0)]
        public int StudentClassId { get; set; }
        [Column(Order = 1)]
        public bool IsActive { get; set; }

        [ForeignKey("Student")]
        [Column(Order = 2)]
        public int StudentRefId { get; set; }
        public virtual Student Student { get; set; }
        [ForeignKey("Class")]
        [Column(Order = 3)]
        public int ClassRefId { get; set; }
        public virtual Class Class { get; set; }
        [ForeignKey("Section")]
        [Column(Order = 4)]
        public int SectionRefId { get; set; }
        public virtual Section Section { get; set; }

        [ForeignKey("StudentClassRefId"   )]
        public virtual ICollection<Attendance> Attendances { get; set; }
    }
}
