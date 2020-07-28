using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class CourseSectionUpdateForDto
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get { return DateTime.Now.Date; } }

        public string UserId { get; set; }

        public string SectionID { get; set; }
    }
}
