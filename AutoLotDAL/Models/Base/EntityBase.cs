﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AutoLotDAL.Models.Base
{
   public class EntityBase
    {
            [Key]
            public int Id { get; set; } 
    }
}
