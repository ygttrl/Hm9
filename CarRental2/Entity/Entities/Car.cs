﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
    public class Car :IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public DateTime ModelYear { get; set; }        
        public decimal DailyPrice { get; set; }       
        public string Description { get; set; }
    }
}
