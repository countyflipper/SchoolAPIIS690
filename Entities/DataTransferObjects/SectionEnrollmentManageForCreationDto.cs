using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities.DataTransferObjects
{
    public class SectionEnrollmentManageForCreationDto
    {
        [Column("SectionEnrollID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "SectionEnrollManage name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public string SectionID { get; set; }

        public string UserID { get; set; }
    }
}
