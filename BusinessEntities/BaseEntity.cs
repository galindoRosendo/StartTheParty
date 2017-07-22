using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime RegisteredDate { get; set; }
        public int IdRegisterUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int IdModigiedUser { get; set; }
    }
}
