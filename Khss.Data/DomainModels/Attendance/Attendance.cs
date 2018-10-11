using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KhssData.DomainModels.Attendance
{
    public class Attendance : BaseClass
    {
        [Key]
        [Column(Order = 0)]
        public int AttendanceId { get; set; }
        [Column(Order = 1)]
        public DateTime AttendanceDate { get; set; }
        [Column(Order = 2)]
        public char AttendanceType { get; set; }
        [Column(Order = 3)]
        public string Description { get; set; }

        [Column(Order = 4)]
        public int StudentClassRefId { get; set; }
        public virtual StudentClass StudentClass { get; set; }

    }
}
