using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KhssData.DomainModels.Attendance
{    
    public class Section: BaseClass
    {
        [Key]
        [Column(Order = 0)]
        public int SectionId { get; set; }
        [Column(Order = 1)]
        public string SectionName { get; set; }
        [Column(Order = 2)]
        public string Description { get; set; }

        public virtual ICollection<StudentClass> StudentClasses { get; set; }
    }
}
