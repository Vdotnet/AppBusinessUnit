﻿using DVTManagementSystem.Models.ModelValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DVTManagementSystem.Models
{
    [MetadataType(typeof(UserTypeMetadata))]
    public class UserType
    {

        public int UserTypeId { get; set; }
        public string UserRole { get; set; }
        public virtual  ICollection<UserProfile> UserProfile { get; set; }

    }
}