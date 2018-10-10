using System;
using System.ComponentModel.DataAnnotations;

namespace KhssData.DomainModels.Attendance
{
    public class Attendance : BaseClass
    {
        [Key]
        public int AttendanceId { get; set; }        
        public DateTime AttendanceDate { get; set; }
        public char AttendanceType { get; set; }
        public string Description { get; set; }

        public int StudentClassId { get; set; }
        public virtual StudentClass StudentClass { get; set; }

    }
}
