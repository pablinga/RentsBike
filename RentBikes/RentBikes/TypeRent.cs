using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentBike.Models
{
    public class TypeRent
    {
        public TimeEnum time { get; set; }
        public int price { get; set; }

        public TypeRent(TimeEnum time, int price)
        {
            this.time = time;
            this.price = price;
        }
    }
}