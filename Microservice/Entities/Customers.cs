using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Customers: BaseClass
    {
        public Customers()
        {
            this.orders = new HashSet<Orders>();
        }

        [Key]
        public override int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public override DateTime CreatedAt { get; set; }
        public override DateTime UpdatedAt { get; set; }
        //------------------------------------------
        public virtual ICollection<Orders> orders { get; set; }

    }
}
