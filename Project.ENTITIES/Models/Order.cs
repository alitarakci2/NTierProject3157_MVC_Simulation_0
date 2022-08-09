using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ENTITIES.Models
{
    public class Order:BaseEntity
    {
        public string ShippedAdress { get; set; }
        public int AppUserID { get; set; }
        public int ShipperID { get; set; }


        //relational Properties

        public virtual AppUser AppUser { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

        public virtual Shipper Shippers { get; set; }
    }
}
