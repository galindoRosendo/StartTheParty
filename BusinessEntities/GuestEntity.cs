﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class GuestEntity : BaseEntity
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
    }
}
