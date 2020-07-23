﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Courses
    {
        [Column("CourseID")]
        public Guid Id { get; set; }

        public string CourseName { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        //public ICollection<string> collection = (ICollection<string>) Courses; 
        //----------------------------------------------------

        /*     [ForeignKey(nameof(User))]
             public Guid UserId { get; set; }
             public User User { get; set; }

             //----------------------------------------------------

             [ForeignKey(nameof(Organization))]
             public Guid OrganizationId { get; set; }

             public Organization Organization { get; set; }
        */
        //----------------------------------------------------
    }
}