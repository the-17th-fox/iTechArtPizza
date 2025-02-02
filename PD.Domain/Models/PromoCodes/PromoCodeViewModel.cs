﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PD.Domain.Models
{
    public class PromoCodeViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float DiscountAmount { get; set; }
        public DateTime ExpirationDate { get; set; }
        public List<ShortOrderViewModel> Orders { get; set; }
    }
}
