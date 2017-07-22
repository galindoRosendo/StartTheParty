using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class EventEntity : BaseEntity
    {
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public string Place { get; set; }
        public List<GuestEntity> Guestes { get; set; }
        public List<ItemEntity> Items { get; set; }
        public int Status { get; set; }
        public bool OnlyUsersToEvent { get; set; }
        public bool Active { get; set; }
    }
}
