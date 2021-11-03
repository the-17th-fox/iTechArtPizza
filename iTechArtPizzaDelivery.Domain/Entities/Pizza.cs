﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace iTechArtPizzaDelivery.Domain.Entities
{
    public class Pizza
    {
        [Key]
        public int PizzaID { get; set; }

        [BindRequired]
        public string Name { get; set; }

        public string Description { get; set; }

        //public /*Image*/ Image { get; set; }

    }
}
