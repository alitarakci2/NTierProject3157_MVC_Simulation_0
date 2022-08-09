using NTierProject3157.ConsumerDTO;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NTierProject3157.VMClasses
{
    public class OrderVM
    {
        public Order Order { get; set; }
        public List<Order> Orders { get; set; }
        public PaymentDTO PaymentDTO { get; set; }






    }
}