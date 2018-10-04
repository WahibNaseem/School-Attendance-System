using System.ComponentModel.DataAnnotations;

namespace KhssData.DomainModels.Attendance
{
    public class StudentClass: BaseClass
    {
        [Key]
        public int StudentClassId { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public int SectionId { get; set; }
        public bool IsActive { get; set; }
    }
}
