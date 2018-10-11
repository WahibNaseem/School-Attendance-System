using KhssData.DomainModels.Attendance;
using System;
using System.Collections.Generic;
using System.Text;

namespace KhssViewModels.Class
{
   public class ClassIndexViewModel
    {
        /*public int ClassId { get; set; }
          public string ClassName { get; set; }*/

        public IEnumerable<KhssData.DomainModels.Attendance.Class> Classes { get; set; }       

    }
}
