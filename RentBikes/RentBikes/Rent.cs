using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RentBike.Models
{
    public class Rent
    {
        public TypeRent typeRent { get; set; }
        public double amountTime { get; set; }
        public double totalPriceRent
        {
            get
            {
                return amountTime * this.typeRent.price;
            }
        }

        public Rent(TypeRent typeRent, double amountTime)
        {
            this.typeRent = typeRent;
            this.amountTime = amountTime;
        }
    }
}
