﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Web.Models
{
    public class AddOrderViewModel
    {
        [Required]
        public int UserId { get; set; }
    }
}
