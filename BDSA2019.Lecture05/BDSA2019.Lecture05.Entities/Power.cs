﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BDSA2019.Lecture05.Entities
{
    public class Power
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public ICollection<SuperheroPower> Superheroes { get; set; }
    }
}
