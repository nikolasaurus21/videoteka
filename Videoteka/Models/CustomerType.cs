﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Videoteka.Models
{
    public class CustomerType
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
    }
}