using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public abstract class BaseClass
    {
        public abstract DateTime CreatedAt { get; set; }
        public abstract DateTime UpdatedAt { get; set; }
        public abstract int Id { get; set; }
    }
}
