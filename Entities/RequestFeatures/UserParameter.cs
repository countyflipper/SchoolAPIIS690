﻿using System;
using System.Collections.Generic;
using System.Text;


namespace Entities.RequestFeatures
{
    public class UserParameter : RequestParameters
    {
        public UserParameter()
        {
            OrderBy = "UserName";
        }
        public uint MinAge { get; set; }
        public uint MaxAge { get; set; } = int.MaxValue;

        public bool ValidAgeRange => MaxAge > MinAge;

        public string SearchTerm { get; set; }

        public string UserName { get; set; }
    }
}
