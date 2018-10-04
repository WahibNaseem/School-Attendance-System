﻿using System.ComponentModel.DataAnnotations;

namespace KhssData.DomainModels.Attendance
{    
    public class Section: BaseClass
    {
        [Key]
        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public string Description { get; set; }
    }
}