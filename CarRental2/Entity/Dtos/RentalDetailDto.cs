﻿using Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Dtos
{
   public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }

        public int CarId { get; set; }

        public int CustomerId { get; set; }

        public int UserId { get; set; }

        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public string CompanyName { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
