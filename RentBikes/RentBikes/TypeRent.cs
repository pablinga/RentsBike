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

        public TypeRent(TimeEnum time)
        {
            this.time = time;
            switch (time)
            {
                case TimeEnum.Hour:
                    this.price = 5;
                    break;
                case TimeEnum.Day:
                    this.price = 20;
                    break;
                case TimeEnum.Week:
                    this.price = 60;
                    break;
                default:
                    this.price = 0;
                    break;
            }         
        }
    }
}