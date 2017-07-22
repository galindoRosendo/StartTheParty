using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class ItemEntity : BaseEntity
    {
        public string Name { get; set; }
        public int Quanity { get; set; }
        public bool Active { get; set; }
    }
}
